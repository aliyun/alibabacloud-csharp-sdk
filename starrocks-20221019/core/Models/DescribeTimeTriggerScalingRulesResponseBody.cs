// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeTimeTriggerScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTimeTriggerScalingRulesResponseBodyData> Data { get; set; }
        public class DescribeTimeTriggerScalingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NodeNumber")]
            [Validation(Required=false)]
            public string NodeNumber { get; set; }

            [NameInMap("ScalingInRule")]
            [Validation(Required=false)]
            public DescribeTimeTriggerScalingRulesResponseBodyDataScalingInRule ScalingInRule { get; set; }
            public class DescribeTimeTriggerScalingRulesResponseBodyDataScalingInRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WEEKLY</para>
                /// </summary>
                [NameInMap("RecurrenceInterval")]
                [Validation(Required=false)]
                public int? RecurrenceInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<string> RecurrenceValues { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Second")]
                [Validation(Required=false)]
                public int? Second { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025</para>
                /// </summary>
                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            [NameInMap("ScalingOutRule")]
            [Validation(Required=false)]
            public DescribeTimeTriggerScalingRulesResponseBodyDataScalingOutRule ScalingOutRule { get; set; }
            public class DescribeTimeTriggerScalingRulesResponseBodyDataScalingOutRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecurrenceInterval")]
                [Validation(Required=false)]
                public int? RecurrenceInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<string> RecurrenceValues { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Second")]
                [Validation(Required=false)]
                public int? Second { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024</para>
                /// </summary>
                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>r-d1775b776110****</para>
            /// </summary>
            [NameInMap("ScalingRuleId")]
            [Validation(Required=false)]
            public string ScalingRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scale-test1</para>
            /// </summary>
            [NameInMap("ScalingRuleName")]
            [Validation(Required=false)]
            public string ScalingRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
