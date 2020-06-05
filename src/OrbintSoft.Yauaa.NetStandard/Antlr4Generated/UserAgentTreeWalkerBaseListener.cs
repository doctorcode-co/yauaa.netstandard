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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IUserAgentTreeWalkerListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class UserAgentTreeWalkerBaseListener : IUserAgentTreeWalkerListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherBase</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherBase([NotNull] UserAgentTreeWalkerParser.MatcherBaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherBase</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherBase([NotNull] UserAgentTreeWalkerParser.MatcherBaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsNull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathIsNull([NotNull] UserAgentTreeWalkerParser.MatcherPathIsNullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsNull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcherRequire"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathIsNull([NotNull] UserAgentTreeWalkerParser.MatcherPathIsNullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherExtract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherExtract([NotNull] UserAgentTreeWalkerParser.MatcherExtractContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherExtract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherExtract([NotNull] UserAgentTreeWalkerParser.MatcherExtractContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherVariable([NotNull] UserAgentTreeWalkerParser.MatcherVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="UserAgentTreeWalkerParser.matcherVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherVariable([NotNull] UserAgentTreeWalkerParser.MatcherVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherCleanVersion</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherCleanVersion([NotNull] UserAgentTreeWalkerParser.MatcherCleanVersionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherCleanVersion</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherCleanVersion([NotNull] UserAgentTreeWalkerParser.MatcherCleanVersionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupPrefixContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupPrefixContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContainsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContainsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcatPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherConcatPrefix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPrefixContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcatPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherConcatPrefix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPrefixContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathLookup</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathLookup([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathLookup</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathLookup([NotNull] UserAgentTreeWalkerParser.MatcherPathLookupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherWordRange([NotNull] UserAgentTreeWalkerParser.MatcherWordRangeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherWordRange([NotNull] UserAgentTreeWalkerParser.MatcherWordRangeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherNormalizeBrand</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherNormalizeBrand([NotNull] UserAgentTreeWalkerParser.MatcherNormalizeBrandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherNormalizeBrand</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherNormalizeBrand([NotNull] UserAgentTreeWalkerParser.MatcherNormalizeBrandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcat</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherConcat([NotNull] UserAgentTreeWalkerParser.MatcherConcatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcat</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherConcat([NotNull] UserAgentTreeWalkerParser.MatcherConcatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherConcatPostfix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherConcatPostfix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPostfixContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherConcatPostfix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherConcatPostfix([NotNull] UserAgentTreeWalkerParser.MatcherConcatPostfixContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsInLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathIsInLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupContainsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsInLookupContains</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathIsInLookupContains([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupContainsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPathIsInLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPathIsInLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupPrefixContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPathIsInLookupPrefix</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPathIsInLookupPrefix([NotNull] UserAgentTreeWalkerParser.MatcherPathIsInLookupPrefixContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>matcherPath</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatcherPath([NotNull] UserAgentTreeWalkerParser.MatcherPathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>matcherPath</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.matcher"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatcherPath([NotNull] UserAgentTreeWalkerParser.MatcherPathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>pathFixedValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPathFixedValue([NotNull] UserAgentTreeWalkerParser.PathFixedValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>pathFixedValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPathFixedValue([NotNull] UserAgentTreeWalkerParser.PathFixedValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>pathVariable</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPathVariable([NotNull] UserAgentTreeWalkerParser.PathVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>pathVariable</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPathVariable([NotNull] UserAgentTreeWalkerParser.PathVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>pathWalk</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPathWalk([NotNull] UserAgentTreeWalkerParser.PathWalkContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>pathWalk</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.basePath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPathWalk([NotNull] UserAgentTreeWalkerParser.PathWalkContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepDown</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepDown([NotNull] UserAgentTreeWalkerParser.StepDownContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepDown</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepDown([NotNull] UserAgentTreeWalkerParser.StepDownContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepUp</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepUp([NotNull] UserAgentTreeWalkerParser.StepUpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepUp</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepUp([NotNull] UserAgentTreeWalkerParser.StepUpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepNext([NotNull] UserAgentTreeWalkerParser.StepNextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepNext([NotNull] UserAgentTreeWalkerParser.StepNextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepNext2([NotNull] UserAgentTreeWalkerParser.StepNext2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepNext2([NotNull] UserAgentTreeWalkerParser.StepNext2Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepNext3([NotNull] UserAgentTreeWalkerParser.StepNext3Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepNext3([NotNull] UserAgentTreeWalkerParser.StepNext3Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNext4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepNext4([NotNull] UserAgentTreeWalkerParser.StepNext4Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNext4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepNext4([NotNull] UserAgentTreeWalkerParser.StepNext4Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepPrev([NotNull] UserAgentTreeWalkerParser.StepPrevContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepPrev([NotNull] UserAgentTreeWalkerParser.StepPrevContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepPrev2([NotNull] UserAgentTreeWalkerParser.StepPrev2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev2</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepPrev2([NotNull] UserAgentTreeWalkerParser.StepPrev2Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepPrev3([NotNull] UserAgentTreeWalkerParser.StepPrev3Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev3</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepPrev3([NotNull] UserAgentTreeWalkerParser.StepPrev3Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepPrev4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepPrev4([NotNull] UserAgentTreeWalkerParser.StepPrev4Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepPrev4</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepPrev4([NotNull] UserAgentTreeWalkerParser.StepPrev4Context context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepEqualsValue([NotNull] UserAgentTreeWalkerParser.StepEqualsValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepEqualsValue([NotNull] UserAgentTreeWalkerParser.StepEqualsValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepNotEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepNotEqualsValue([NotNull] UserAgentTreeWalkerParser.StepNotEqualsValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepNotEqualsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepNotEqualsValue([NotNull] UserAgentTreeWalkerParser.StepNotEqualsValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepStartsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepStartsWithValue([NotNull] UserAgentTreeWalkerParser.StepStartsWithValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepStartsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepStartsWithValue([NotNull] UserAgentTreeWalkerParser.StepStartsWithValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepEndsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepEndsWithValue([NotNull] UserAgentTreeWalkerParser.StepEndsWithValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepEndsWithValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepEndsWithValue([NotNull] UserAgentTreeWalkerParser.StepEndsWithValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepContainsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepContainsValue([NotNull] UserAgentTreeWalkerParser.StepContainsValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepContainsValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepContainsValue([NotNull] UserAgentTreeWalkerParser.StepContainsValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepIsInSet</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepIsInSet([NotNull] UserAgentTreeWalkerParser.StepIsInSetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepIsInSet</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepIsInSet([NotNull] UserAgentTreeWalkerParser.StepIsInSetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepWordRange([NotNull] UserAgentTreeWalkerParser.StepWordRangeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepWordRange</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepWordRange([NotNull] UserAgentTreeWalkerParser.StepWordRangeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stepBackToFull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStepBackToFull([NotNull] UserAgentTreeWalkerParser.StepBackToFullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stepBackToFull</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStepBackToFull([NotNull] UserAgentTreeWalkerParser.StepBackToFullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeOpenStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeOpenStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeOpenStartToEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeOpenStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeOpenStartToEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeOpenStartToEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeStartToOpenEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeStartToOpenEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToOpenEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeStartToOpenEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeStartToOpenEnd([NotNull] UserAgentTreeWalkerParser.NumberRangeStartToOpenEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeSingleValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeSingleValue([NotNull] UserAgentTreeWalkerParser.NumberRangeSingleValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeSingleValue</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeSingleValue([NotNull] UserAgentTreeWalkerParser.NumberRangeSingleValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeAll</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeAll([NotNull] UserAgentTreeWalkerParser.NumberRangeAllContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeAll</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeAll([NotNull] UserAgentTreeWalkerParser.NumberRangeAllContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>numberRangeEmpty</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberRangeEmpty([NotNull] UserAgentTreeWalkerParser.NumberRangeEmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numberRangeEmpty</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.numberRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberRangeEmpty([NotNull] UserAgentTreeWalkerParser.NumberRangeEmptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWordRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.WordRangeStartToEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeStartToEnd</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWordRangeStartToEnd([NotNull] UserAgentTreeWalkerParser.WordRangeStartToEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeFirstWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWordRangeFirstWords([NotNull] UserAgentTreeWalkerParser.WordRangeFirstWordsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeFirstWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWordRangeFirstWords([NotNull] UserAgentTreeWalkerParser.WordRangeFirstWordsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeLastWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWordRangeLastWords([NotNull] UserAgentTreeWalkerParser.WordRangeLastWordsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeLastWords</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWordRangeLastWords([NotNull] UserAgentTreeWalkerParser.WordRangeLastWordsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>wordRangeSingleWord</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWordRangeSingleWord([NotNull] UserAgentTreeWalkerParser.WordRangeSingleWordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>wordRangeSingleWord</c>
	/// labeled alternative in <see cref="UserAgentTreeWalkerParser.wordRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWordRangeSingleWord([NotNull] UserAgentTreeWalkerParser.WordRangeSingleWordContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace OrbintSoft.Yauaa.Antlr4Source
