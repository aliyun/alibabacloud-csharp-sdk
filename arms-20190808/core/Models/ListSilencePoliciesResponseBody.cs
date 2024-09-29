// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSilencePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned pages.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListSilencePoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListSilencePoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The queried silence policies.</para>
            /// </summary>
            [NameInMap("SilencePolicies")]
            [Validation(Required=false)]
            public List<ListSilencePoliciesResponseBodyPageBeanSilencePolicies> SilencePolicies { get; set; }
            public class ListSilencePoliciesResponseBodyPageBeanSilencePolicies : TeaModel {
                [NameInMap("EffectiveTimeType")]
                [Validation(Required=false)]
                public string EffectiveTimeType { get; set; }

                /// <summary>
                /// <para>The ID of the silence policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The matching rules.</para>
                /// </summary>
                [NameInMap("MatchingRules")]
                [Validation(Required=false)]
                public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules> MatchingRules { get; set; }
                public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRules : TeaModel {
                    /// <summary>
                    /// <para>The matching conditions.</para>
                    /// </summary>
                    [NameInMap("MatchingConditions")]
                    [Validation(Required=false)]
                    public List<ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                    public class ListSilencePoliciesResponseBodyPageBeanSilencePoliciesMatchingRulesMatchingConditions : TeaModel {
                        /// <summary>
                        /// <para>The key of the matching condition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>altertname</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The logical operator of the matching condition. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>eq</c>: equal to</description></item>
                        /// <item><description><c>neq</c>: not equal to</description></item>
                        /// <item><description><c>in</c>: contains</description></item>
                        /// <item><description><c>nin</c>: does not contain</description></item>
                        /// <item><description><c>re</c>: regular expression match</description></item>
                        /// <item><description><c>nre</c>: regular expression mismatch</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eq</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The value of the matching condition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the silence policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>silencepolicy_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the silence policy is enabled. Valid values: enable and disable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("TimePeriod")]
                [Validation(Required=false)]
                public string TimePeriod { get; set; }

                [NameInMap("TimeSlots")]
                [Validation(Required=false)]
                public string TimeSlots { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The number of silence policies that were returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
