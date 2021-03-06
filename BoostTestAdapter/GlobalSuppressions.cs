// (C) Copyright ETAS 2015.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE_1_0.txt or copy at
// http://www.boost.org/LICENSE_1_0.txt)

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.SourceFilter.ConditionalInclusions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.Utility.VisualStudio")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.Settings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "BoostTestAdapter.Boost.Results.LogEntryTypes.LogEntryException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.BoostTestDiscoverer.#DiscoverTests(System.Collections.Generic.IEnumerable`1<System.String>,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IDiscoveryContext,Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.IMessageLogger,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestCaseDiscoverySink)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.BoostTestExecutor.#RunTests(System.Collections.Generic.IEnumerable`1<System.String>,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunContext,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IFrameworkHandle)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.BoostTestExecutor.#RunBoostTests(System.Collections.Generic.IEnumerable`1<BoostTestAdapter.Utility.TestRun>,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunContext,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IFrameworkHandle)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.SourceFilter.ConditionalInclusions.ConditionalInclusionsMachine.#Apply(BoostTestAdapter.SourceFilter.CppSourceFile,VisualStudioAdapter.Defines)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.Boost.Runner.BoostTestRunnerBase.#KillProcess(System.Diagnostics.Process,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.SourceFilter.ExpressionEvaluation.#EvaluateExpression(System.String,VisualStudioAdapter.Defines)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XML", Scope = "type", Target = "BoostTestAdapter.Boost.Results.BoostTestResultXMLOutput")]
