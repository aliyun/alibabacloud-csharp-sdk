// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertingMetricRuleResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0724011B-D9E0-4B2F-8C51-F17A894CC42C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeAlertingMetricRuleResourcesResponseBodyResources Resources { get; set; }
        public class DescribeAlertingMetricRuleResourcesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource : TeaModel {
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                [NameInMap("Escalation")]
                [Validation(Required=false)]
                public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation Escalation { get; set; }
                public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource> Resource { get; set; }
                    public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList ExpressionList { get; set; }
                        public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList : TeaModel {
                            [NameInMap("ExpressionList")]
                            [Validation(Required=false)]
                            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList> ExpressionList { get; set; }
                            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList : TeaModel {
                                [NameInMap("ComparisonOperator")]
                                [Validation(Required=false)]
                                public string ComparisonOperator { get; set; }

                                [NameInMap("MetricName")]
                                [Validation(Required=false)]
                                public string MetricName { get; set; }

                                [NameInMap("Period")]
                                [Validation(Required=false)]
                                public string Period { get; set; }

                                [NameInMap("Statistics")]
                                [Validation(Required=false)]
                                public string Statistics { get; set; }

                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public string Threshold { get; set; }

                            }

                        }

                        [NameInMap("ExpressionListJoin")]
                        [Validation(Required=false)]
                        public string ExpressionListJoin { get; set; }

                        [NameInMap("ExpressionRaw")]
                        [Validation(Required=false)]
                        public string ExpressionRaw { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public int? Level { get; set; }

                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("LastAlertTime")]
                [Validation(Required=false)]
                public string LastAlertTime { get; set; }

                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("MetricValues")]
                [Validation(Required=false)]
                public string MetricValues { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ProductCategory")]
                [Validation(Required=false)]
                public string ProductCategory { get; set; }

                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                [NameInMap("RetryTimes")]
                [Validation(Required=false)]
                public string RetryTimes { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
