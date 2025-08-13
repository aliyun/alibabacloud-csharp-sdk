// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRecommendTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRecommendTaskDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRecommendTaskDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Event code</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>Event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险</para>
            /// </summary>
            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>Comparison indicators</para>
            /// </summary>
            [NameInMap("expectVelocities")]
            [Validation(Required=false)]
            public List<string> ExpectVelocities { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Number of normal samples</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("normalSize")]
            [Validation(Required=false)]
            public long? NormalSize { get; set; }

            /// <summary>
            /// <para>Recommended strategy list</para>
            /// </summary>
            [NameInMap("recommendRuleDTOs")]
            [Validation(Required=false)]
            public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOs> RecommendRuleDTOs { get; set; }
            public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOs : TeaModel {
                /// <summary>
                /// <para>Calculation path</para>
                /// 
                /// <b>Example:</b>
                /// <para>1&amp;2</para>
                /// </summary>
                [NameInMap("computeExpression")]
                [Validation(Required=false)]
                public string ComputeExpression { get; set; }

                /// <summary>
                /// <para>Number of hit samples</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("hitSample")]
                [Validation(Required=false)]
                public long? HitSample { get; set; }

                /// <summary>
                /// <para>Primary key ID of the rule</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Number of unhit samples</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("notHitSample")]
                [Validation(Required=false)]
                public long? NotHitSample { get; set; }

                /// <summary>
                /// <para>List of candidate rules</para>
                /// </summary>
                [NameInMap("recommendRules")]
                [Validation(Required=false)]
                public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOsRecommendRules> RecommendRules { get; set; }
                public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOsRecommendRules : TeaModel {
                    /// <summary>
                    /// <para>Left variable</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>age</para>
                    /// </summary>
                    [NameInMap("left")]
                    [Validation(Required=false)]
                    public string Left { get; set; }

                    /// <summary>
                    /// <para>Operator</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>equals</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>Right variable</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("right")]
                    [Validation(Required=false)]
                    public string Right { get; set; }

                }

                /// <summary>
                /// <para>Strategy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>102224</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>Rule name</para>
                /// 
                /// <b>Example:</b>
                /// <para>营销风险识别评分_高风险_拒绝_副本</para>
                /// </summary>
                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Status</para>
                /// 
                /// <b>Example:</b>
                /// <para>NO_RULE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>List of indicators in JSON string format</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;key&quot;:&quot;dxkkLw8fe18&quot;,&quot;value&quot;:&quot;2&quot;}]</para>
                /// </summary>
                [NameInMap("velocities")]
                [Validation(Required=false)]
                public string Velocities { get; set; }

            }

            /// <summary>
            /// <para>Selected variable list</para>
            /// </summary>
            [NameInMap("recommendVariableDTOs")]
            [Validation(Required=false)]
            public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendVariableDTOs> RecommendVariableDTOs { get; set; }
            public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendVariableDTOs : TeaModel {
                /// <summary>
                /// <para>Primary key ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>234</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>手机号</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Number of risk samples</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("riskSize")]
            [Validation(Required=false)]
            public long? RiskSize { get; set; }

            /// <summary>
            /// <para>Sample name</para>
            /// 
            /// <b>Example:</b>
            /// <para>白样本</para>
            /// </summary>
            [NameInMap("sampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            /// <summary>
            /// <para>Sample scenario</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_abuse_detection</para>
            /// </summary>
            [NameInMap("sampleScene")]
            [Validation(Required=false)]
            public string SampleScene { get; set; }

            /// <summary>
            /// <para>Sample scenario name</para>
            /// 
            /// <b>Example:</b>
            /// <para>防虚假账号</para>
            /// </summary>
            [NameInMap("sampleSceneName")]
            [Validation(Required=false)]
            public string SampleSceneName { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>887</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>Task name</para>
            /// 
            /// <b>Example:</b>
            /// <para>策略推荐任务</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>Task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
