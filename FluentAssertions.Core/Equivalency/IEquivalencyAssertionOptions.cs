using System.Collections.Generic;

namespace FluentAssertions.Equivalency
{
    /// <summary>
    /// Provides the run-time details of the <see cref="EquivalencyAssertionOptions{TSubject}" /> class.
    /// </summary>
    public interface IEquivalencyAssertionOptions
    {
        /// <summary>
        /// Gets an ordered collection of selection rules that define what properties are included.
        /// </summary>
        IEnumerable<ISelectionRule> SelectionRules { get; }

        /// <summary>
        /// Gets an ordered collection of matching rules that determine which subject properties are matched with which
        /// expectation properties.
        /// </summary>
        IEnumerable<IMatchingRule> MatchingRules { get; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the assertion must perform a deep comparison.
        /// </summary>
        bool IsRecursive { get; }

        /// <summary>
        /// Gets a value indicating whether recursion is allowed to continue indefinitely.
        /// </summary>
        bool AllowInfiniteRecursion { get; }

        /// <summary>
        /// Gets value indicating how cyclic references should be handled. By default, it will throw an exception.
        /// </summary>
        CyclicReferenceHandling CyclicReferenceHandling { get; }

        /// <summary>
        /// Gets an ordered collection of rules that determine whether or not the order of collections is important. By default,
        /// ordering is irrelevant.
        /// </summary>
        OrderingRuleCollection OrderingRules { get; }
        
        /// <summary>
        /// Gets value indicating how the enums should be compared.
        /// </summary>
        EnumEquivalencyHandling EnumEquivalencyHandling { get; }

        /// <summary>
        /// Gets an ordered collection of Equivalency steps how a subject is comparted with the expectation.
        /// </summary>
        IEnumerable<IEquivalencyStep> UserEquivalencySteps { get; }
    }
}