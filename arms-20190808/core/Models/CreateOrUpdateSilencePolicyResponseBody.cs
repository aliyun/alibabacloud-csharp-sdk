// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateSilencePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The silence policy.</para>
        /// </summary>
        [NameInMap("SilencePolicy")]
        [Validation(Required=false)]
        public CreateOrUpdateSilencePolicyResponseBodySilencePolicy SilencePolicy { get; set; }
        public class CreateOrUpdateSilencePolicyResponseBodySilencePolicy : TeaModel {
            /// <summary>
            /// <para>The effective type. Valid values: PERMANENT: The policy is effective permanently. CYCLE_EFFECT: The policy is effective cyclically. CUSTOM_TIME: The policy is effective during a custom time period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PERMANENT</para>
            /// </summary>
            [NameInMap("EffectiveTimeType")]
            [Validation(Required=false)]
            public string EffectiveTimeType { get; set; }

            /// <summary>
            /// <para>The ID of the silence policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>A list of matching rules.</para>
            /// </summary>
            [NameInMap("MatchingRules")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRules> MatchingRules { get; set; }
            public class CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRules : TeaModel {
                /// <summary>
                /// <para>A list of matching conditions.</para>
                /// </summary>
                [NameInMap("MatchingConditions")]
                [Validation(Required=false)]
                public List<CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                public class CreateOrUpdateSilencePolicyResponseBodySilencePolicyMatchingRulesMatchingConditions : TeaModel {
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
            /// <para>Specifies whether to enable the silence policy. Valid values: enable and disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Effective period. Valid values: DAY: daily WEEK: weekly</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEEK</para>
            /// </summary>
            [NameInMap("TimePeriod")]
            [Validation(Required=false)]
            public string TimePeriod { get; set; }

            /// <summary>
            /// <para>The time period during which the silence policy is effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{startWeek: &quot;1&quot;, startTime: &quot;00:00&quot;, endTime: &quot;11:59&quot;, endWeek:&quot;7&quot;}]</para>
            /// </summary>
            [NameInMap("TimeSlots")]
            [Validation(Required=false)]
            public string TimeSlots { get; set; }

        }

    }

}
