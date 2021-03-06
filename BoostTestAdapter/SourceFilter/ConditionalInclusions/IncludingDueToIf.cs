﻿// (C) Copyright ETAS 2015.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE_1_0.txt or copy at
// http://www.boost.org/LICENSE_1_0.txt)

using System.Globalization;

namespace BoostTestAdapter.SourceFilter.ConditionalInclusions
{
    /// <summary>
    /// Class handling the state of the Conditional inclusions machine when source is not being discarded to a positively evaluated conditional
    /// </summary>
    internal class IncludingDueToIf : IConditionalInclusionsState
    {
        private readonly ConditionalInclusionsMachine _conditionalInclusionsMachine;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conditionalInclusionsMachine">reference to the state machine</param>
        internal IncludingDueToIf(ConditionalInclusionsMachine conditionalInclusionsMachine)
        {
            _conditionalInclusionsMachine = conditionalInclusionsMachine;
        }

        #endregion Constructor

        /// <summary>
        /// Called so as to make the necessary decision making when a positively evaluated conditional has been met
        /// </summary>
        /// <param name="sourceLine">source line under analysis that may or may not be filtered</param>
        /// <param name="sourceLineType">source code type as inspected by the Inspect function in the conditional inclusions machine</param>
        /// <param name="expression">expression to be evaluated in case the source Line type is a conditional based on an expression</param>
        /// <param name="subtitutionText">substitution text in case of a define</param>
        public void Process(ref string sourceLine, SourceLineType sourceLineType, string expression, string subtitutionText)
        {
            switch (sourceLineType)
            {
                case SourceLineType.Other:
                    //Encountered source code NOT related to the conditional inclusions.
                    break;

                case SourceLineType.Elifclause:
                    //since we were in successfull if inclusion and now we met an elif we have to discard anything in the elif
                    _conditionalInclusionsMachine.UpdateCurrentState(ParserState.DiscardingDueToSuccessfullIf);
                    sourceLine = "";
                    break;

                case SourceLineType.Elseclause:
                    _conditionalInclusionsMachine.UpdateCurrentState(ParserState.DiscardingDueToSuccessfullIf);
                    sourceLine = "";
                    break;

                case SourceLineType.Endifclause:
                    _conditionalInclusionsMachine.FinishWithCurrentState();
                    sourceLine = "";
                    break;

                case SourceLineType.Ifclause:
                    switch (_conditionalInclusionsMachine.Evaluator.EvaluateExpression(expression, _conditionalInclusionsMachine.DefinesHandler))
                    {
                        case EvaluationResult.IsFalse:
                            _conditionalInclusionsMachine.AddState(ParserState.DiscardingDueToFailedIf);
                            break;

                        case EvaluationResult.IsTrue:
                            _conditionalInclusionsMachine.AddState(ParserState.IncludingDueToIf);
                            break;

                        case EvaluationResult.UnDetermined:
                            throw new SourceDiscoveryException(string.Format(CultureInfo.InvariantCulture, "Unable to evaluate expression \"{0}\"", expression));
                    }
                    sourceLine = "";
                    break;

                case SourceLineType.MultiLineDefineclause:
                    _conditionalInclusionsMachine.AddState(ParserState.DiscardingDueToMultilineDefine);
                    _conditionalInclusionsMachine.DefinesHandler.Define(expression, "");
                    sourceLine = "";
                    break;

                case SourceLineType.Defineclause:
                    _conditionalInclusionsMachine.DefinesHandler.Define(expression, subtitutionText);
                    sourceLine = "";
                    break;

                case SourceLineType.Undefineclause:
                    _conditionalInclusionsMachine.DefinesHandler.UnDefine(expression);
                    sourceLine = "";
                    break;

                case SourceLineType.Ifdefclause:
                    switch (_conditionalInclusionsMachine.DefinesHandler.IsDefined(expression))
                    {
                        case true:
                            _conditionalInclusionsMachine.AddState(ParserState.IncludingDueToIf);
                            break;

                        case false:
                            _conditionalInclusionsMachine.AddState(ParserState.DiscardingDueToFailedIf);
                            break;
                    }
                    sourceLine = "";
                    break;

                case SourceLineType.Ifndefclause:
                    switch (_conditionalInclusionsMachine.DefinesHandler.IsDefined(expression))
                    {
                        case true:
                            _conditionalInclusionsMachine.AddState(ParserState.DiscardingDueToFailedIf);
                            break;

                        case false:
                            _conditionalInclusionsMachine.AddState(ParserState.IncludingDueToIf);
                            break;
                    }
                    sourceLine = "";
                    break;
            }
        }
    }
}