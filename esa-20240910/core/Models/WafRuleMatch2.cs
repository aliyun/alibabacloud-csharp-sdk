// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleMatch2 : TeaModel {
        /// <summary>
        /// <para>Transforms input to lowercase to ensure case-insensitivity.</para>
        /// </summary>
        [NameInMap("ConvertToLower")]
        [Validation(Required=false)]
        public bool? ConvertToLower { get; set; }

        /// <summary>
        /// <para>The details of logical databases.</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRuleMatch2Criteria> Criteria { get; set; }
        public class WafRuleMatch2Criteria : TeaModel {
            /// <summary>
            /// <para>Transforms input to lowercase to ensure case-insensitivity.</para>
            /// </summary>
            [NameInMap("ConvertToLower")]
            [Validation(Required=false)]
            public bool? ConvertToLower { get; set; }

            /// <summary>
            /// <para>The details of logical databases.</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public List<WafRuleMatch2CriteriaCriteria> Criteria { get; set; }
            public class WafRuleMatch2CriteriaCriteria : TeaModel {
                /// <summary>
                /// <para>Transforms input to lowercase to ensure case-insensitivity.</para>
                /// </summary>
                [NameInMap("ConvertToLower")]
                [Validation(Required=false)]
                public bool? ConvertToLower { get; set; }

                /// <summary>
                /// <para>The details of logical databases.</para>
                /// </summary>
                [NameInMap("Criteria")]
                [Validation(Required=false)]
                public List<WafRuleMatch2CriteriaCriteriaCriteria> Criteria { get; set; }
                public class WafRuleMatch2CriteriaCriteriaCriteria : TeaModel {
                    /// <summary>
                    /// <para>Transforms input to lowercase to ensure case-insensitivity.</para>
                    /// </summary>
                    [NameInMap("ConvertToLower")]
                    [Validation(Required=false)]
                    public bool? ConvertToLower { get; set; }

                    /// <summary>
                    /// <para>The matching operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("MatchOperator")]
                    [Validation(Required=false)]
                    public string MatchOperator { get; set; }

                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip.src</para>
                    /// </summary>
                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>The value of the matching condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.1.1.1</para>
                    /// </summary>
                    [NameInMap("MatchValue")]
                    [Validation(Required=false)]
                    public object MatchValue { get; set; }

                    /// <summary>
                    /// <para>Converts a value or condition to its opposite.</para>
                    /// </summary>
                    [NameInMap("Negate")]
                    [Validation(Required=false)]
                    public bool? Negate { get; set; }

                }

                /// <summary>
                /// <para>The logical judgment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>and</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public string Logic { get; set; }

                /// <summary>
                /// <para>The matching operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("MatchOperator")]
                [Validation(Required=false)]
                public string MatchOperator { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip.src</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>The value of the matching condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("MatchValue")]
                [Validation(Required=false)]
                public object MatchValue { get; set; }

                /// <summary>
                /// <para>Converts a value or condition to its opposite.</para>
                /// </summary>
                [NameInMap("Negate")]
                [Validation(Required=false)]
                public bool? Negate { get; set; }

            }

            /// <summary>
            /// <para>The logical judgment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public string Logic { get; set; }

            /// <summary>
            /// <para>The matching operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eq</para>
            /// </summary>
            [NameInMap("MatchOperator")]
            [Validation(Required=false)]
            public string MatchOperator { get; set; }

            /// <summary>
            /// <para>The matching type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip.src</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The value of the matching condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("MatchValue")]
            [Validation(Required=false)]
            public object MatchValue { get; set; }

            /// <summary>
            /// <para>Converts a value or condition to its opposite.</para>
            /// </summary>
            [NameInMap("Negate")]
            [Validation(Required=false)]
            public bool? Negate { get; set; }

        }

        /// <summary>
        /// <para>The logical judgment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        /// <summary>
        /// <para>The matching operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eq</para>
        /// </summary>
        [NameInMap("MatchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The matching type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The value of the matching condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("MatchValue")]
        [Validation(Required=false)]
        public object MatchValue { get; set; }

        /// <summary>
        /// <para>Converts a value or condition to its opposite.</para>
        /// </summary>
        [NameInMap("Negate")]
        [Validation(Required=false)]
        public bool? Negate { get; set; }

    }

}
