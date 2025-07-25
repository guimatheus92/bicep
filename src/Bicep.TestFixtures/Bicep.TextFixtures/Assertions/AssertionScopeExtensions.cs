// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicep.Core.Diagnostics;
using Bicep.Core.Extensions;
using Bicep.Core.SourceGraph;
using Bicep.Core.Text;
using Bicep.TextFixtures.Utils;
using FluentAssertions.Execution;

namespace Bicep.TextFixtures.Assertions
{
    public static class AssertionScopeExtensions
    {
        /// <summary>
        /// Prints the program syntax with line numbers and a cursor if a test fails in the given assertion scope.
        /// </summary>
        public static AssertionScope WithVisualCursor(this AssertionScope assertionScope, BicepSourceFile bicepFile, int cursor)
            => WithVisualCursor(assertionScope, bicepFile, new TextSpan(cursor, 0));

        /// <summary>
        /// Prints the program syntax with line numbers and a cursor if a test fails in the given assertion scope.
        /// </summary>
        public static AssertionScope WithVisualCursor(this AssertionScope assertionScope, BicepSourceFile bicepFile, IPositionable cursorPosition)
            => WithAnnotatedSource(
                assertionScope,
                bicepFile,
                "cursor info",
                new TestSourcePrinter.Annotation(cursorPosition.Span, "cursor").AsEnumerable());

        /// <summary>
        /// Prints the program syntax with line numbers and diagnostics if a test fails in the given assertion scope.
        /// </summary>
        public static AssertionScope WithVisualDiagnostics(this AssertionScope assertionScope, BicepSourceFile bicepFile, IEnumerable<IDiagnostic> diagnostics)
            => WithAnnotatedSource(
                assertionScope,
                bicepFile,
                "diagnostics",
                diagnostics.Select(x => new TestSourcePrinter.Annotation(x.Span, $"[{x.Code} ({x.Level})] {x.Message}")));

        /// <summary>
        /// Prints the entire program syntax with line numbers if a test fails in the given assertion scope.
        /// </summary>
        public static AssertionScope WithFullSource(this AssertionScope assertionScope, BicepSourceFile bicepFile)
        {
            assertionScope.AddReportable("source", () => TestSourcePrinter.Print(bicepFile));

            return assertionScope;
        }

        public static AssertionScope WithAnnotatedSource(AssertionScope assertionScope, BicepSourceFile bicepFile, string contextName, IEnumerable<TestSourcePrinter.Annotation> annotations)
        {
            assertionScope.AddReportable(
                contextName,
                () => TestSourcePrinter.PrintWithAnnotations(bicepFile, annotations, 1, true));

            return assertionScope;
        }

        public static AssertionScope WithAnnotatedSource(AssertionScope assertionScope, string fileText, ImmutableArray<int> lineStarts, string contextName, IEnumerable<TestSourcePrinter.Annotation> annotations)
        {
            assertionScope.AddReportable(
                contextName,
                () => TestSourcePrinter.PrintWithAnnotations(fileText, lineStarts, annotations, 1, true));

            return assertionScope;
        }
    }
}
