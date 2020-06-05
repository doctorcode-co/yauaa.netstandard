//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Antlr4Source\UserAgentTreeWalker.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OrbintSoft.Yauaa.Antlr4Source {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="UserAgentTreeWalkerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IUserAgentTreeWalkerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherBase</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherBase([NotNull] UserAgentTreeWalkerParser.MatcherBaseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherBase</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherBase([NotNull] UserAgentTreeWalkerParser.MatcherBaseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsNull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathIsNull([NotNull] UserAgentTreeWalkerParser.MatcherPathIsNullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsNull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathIsNull([NotNull] UserAgentTreeWalkerParser.MatcherPathIsNullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherExtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherExtract([NotNull] UserAgentTreeWalkerParser.MatcherExtractContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherExtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherExtract([NotNull] UserAgentTreeWalkerParser.MatcherExtractContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherVariable([NotNull] UserAgentTreeWalkerParser.MatcherVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherVariable([NotNull] UserAgentTreeWalkerParser.MatcherVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherCleanVersion</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherCleanVersion([NotNull] UserAgentTreeWalkerParser.MatcherCleanVersionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherCleanVersion</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherCleanVersion([NotNull] UserAgentTreeWalkerParser.MatcherCleanVersionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupPrefixContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupPrefixContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContainsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContainsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcatPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherConcatPrefix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPrefixContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcatPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherConcatPrefix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPrefixContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookup</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathLookup([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookup</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathLookup([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherWordRange([NotNull] UserAgentTreeWalkerParser.MatcherWordRangeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherWordRange([NotNull] UserAgentTreeWalkerParser.MatcherWordRangeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherNormalizeBrand</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherNormalizeBrand([NotNull] UserAgentTreeWalkerParser.MatcherNormalizeBrandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherNormalizeBrand</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherNormalizeBrand([NotNull] UserAgentTreeWalkerParser.MatcherNormalizeBrandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcat</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherConcat([NotNull] UserAgentTreeWalkerParser.MatcherConcatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcat</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherConcat([NotNull] UserAgentTreeWalkerParser.MatcherConcatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcatPostfix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherConcatPostfix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPostfixContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcatPostfix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherConcatPostfix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPostfixContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsInLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathIsInLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupContainsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsInLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathIsInLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupContainsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsInLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPathIsInLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupPrefixContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsInLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPathIsInLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupPrefixContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPath</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatcherPath([NotNull] UserAgentTreeWalkerParser.MatcherPathContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPath</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatcherPath([NotNull] UserAgentTreeWalkerParser.MatcherPathContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>pathFixedValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPathFixedValue([NotNull] UserAgentTreeWalkerParser.PathFixedValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pathFixedValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPathFixedValue([NotNull] UserAgentTreeWalkerParser.PathFixedValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>pathVariable</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPathVariable([NotNull] UserAgentTreeWalkerParser.PathVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pathVariable</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPathVariable([NotNull] UserAgentTreeWalkerParser.PathVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>pathWalk</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPathWalk([NotNull] UserAgentTreeWalkerParser.PathWalkContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pathWalk</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPathWalk([NotNull] UserAgentTreeWalkerParser.PathWalkContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepDown</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepDown([NotNull] UserAgentTreeWalkerParser.StepDownContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepDown</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepDown([NotNull] UserAgentTreeWalkerParser.StepDownContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepUp</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepUp([NotNull] UserAgentTreeWalkerParser.StepUpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepUp</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepUp([NotNull] UserAgentTreeWalkerParser.StepUpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepNext([NotNull] UserAgentTreeWalkerParser.StepNextContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepNext([NotNull] UserAgentTreeWalkerParser.StepNextContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepNext2([NotNull] UserAgentTreeWalkerParser.StepNext2Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepNext2([NotNull] UserAgentTreeWalkerParser.StepNext2Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepNext3([NotNull] UserAgentTreeWalkerParser.StepNext3Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepNext3([NotNull] UserAgentTreeWalkerParser.StepNext3Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepNext4([NotNull] UserAgentTreeWalkerParser.StepNext4Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepNext4([NotNull] UserAgentTreeWalkerParser.StepNext4Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepPrev([NotNull] UserAgentTreeWalkerParser.StepPrevContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepPrev([NotNull] UserAgentTreeWalkerParser.StepPrevContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepPrev2([NotNull] UserAgentTreeWalkerParser.StepPrev2Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepPrev2([NotNull] UserAgentTreeWalkerParser.StepPrev2Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepPrev3([NotNull] UserAgentTreeWalkerParser.StepPrev3Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepPrev3([NotNull] UserAgentTreeWalkerParser.StepPrev3Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepPrev4([NotNull] UserAgentTreeWalkerParser.StepPrev4Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepPrev4([NotNull] UserAgentTreeWalkerParser.StepPrev4Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepEqualsValue([NotNull] UserAgentTreeWalkerParser.StepEqualsValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepEqualsValue([NotNull] UserAgentTreeWalkerParser.StepEqualsValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNotEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepNotEqualsValue([NotNull] UserAgentTreeWalkerParser.StepNotEqualsValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNotEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepNotEqualsValue([NotNull] UserAgentTreeWalkerParser.StepNotEqualsValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepStartsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepStartsWithValue([NotNull] UserAgentTreeWalkerParser.StepStartsWithValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepStartsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepStartsWithValue([NotNull] UserAgentTreeWalkerParser.StepStartsWithValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepEndsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepEndsWithValue([NotNull] UserAgentTreeWalkerParser.StepEndsWithValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepEndsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepEndsWithValue([NotNull] UserAgentTreeWalkerParser.StepEndsWithValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepContainsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepContainsValue([NotNull] UserAgentTreeWalkerParser.StepContainsValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepContainsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepContainsValue([NotNull] UserAgentTreeWalkerParser.StepContainsValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepIsInSet</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepIsInSet([NotNull] UserAgentTreeWalkerParser.StepIsInSetContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepIsInSet</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepIsInSet([NotNull] UserAgentTreeWalkerParser.StepIsInSetContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepWordRange([NotNull] UserAgentTreeWalkerParser.StepWordRangeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepWordRange([NotNull] UserAgentTreeWalkerParser.StepWordRangeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stepBackToFull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStepBackToFull([NotNull] UserAgentTreeWalkerParser.StepBackToFullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stepBackToFull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStepBackToFull([NotNull] UserAgentTreeWalkerParser.StepBackToFullContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToEndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToEndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeOpenStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeOpenStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeOpenStartToEndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeOpenStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeOpenStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeOpenStartToEndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeStartToOpenEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeStartToOpenEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToOpenEndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeStartToOpenEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeStartToOpenEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToOpenEndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeSingleValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeSingleValue([NotNull] UserAgentTreeWalkerParser.NumberRangeSingleValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeSingleValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeSingleValue([NotNull] UserAgentTreeWalkerParser.NumberRangeSingleValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeAll</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeAll([NotNull] UserAgentTreeWalkerParser.NumberRangeAllContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeAll</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeAll([NotNull] UserAgentTreeWalkerParser.NumberRangeAllContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeEmpty</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberRangeEmpty([NotNull] UserAgentTreeWalkerParser.NumberRangeEmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeEmpty</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberRangeEmpty([NotNull] UserAgentTreeWalkerParser.NumberRangeEmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWordRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.WordRangeStartToEndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWordRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.WordRangeStartToEndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeFirstWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWordRangeFirstWords([NotNull] UserAgentTreeWalkerParser.WordRangeFirstWordsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeFirstWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWordRangeFirstWords([NotNull] UserAgentTreeWalkerParser.WordRangeFirstWordsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeLastWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWordRangeLastWords([NotNull] UserAgentTreeWalkerParser.WordRangeLastWordsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeLastWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWordRangeLastWords([NotNull] UserAgentTreeWalkerParser.WordRangeLastWordsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeSingleWord</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWordRangeSingleWord([NotNull] UserAgentTreeWalkerParser.WordRangeSingleWordContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeSingleWord</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWordRangeSingleWord([NotNull] UserAgentTreeWalkerParser.WordRangeSingleWordContext context);
}
} // namespace OrbintSoft.Yauaa.Antlr4Source
