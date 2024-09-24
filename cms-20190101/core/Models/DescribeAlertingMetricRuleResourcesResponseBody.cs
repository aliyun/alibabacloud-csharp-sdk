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

        /// <summary>
        /// <para>The resources that are associated with the alert rule.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeAlertingMetricRuleResourcesResponseBodyResources Resources { get; set; }
        public class DescribeAlertingMetricRuleResourcesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// <para>The dimensions based on which the resources are queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;region\&quot;:\&quot;cn-huhehaote\&quot;,\&quot;queue\&quot;:\&quot;test-0128\&quot;,\&quot;userId\&quot;:\&quot;120886317861****\&quot;}</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert rule is enabled.</description></item>
                /// <item><description>false: The alert rule is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The alert rule based on which the alert is triggered.</para>
                /// </summary>
                [NameInMap("Escalation")]
                [Validation(Required=false)]
                public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation Escalation { get; set; }
                public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource> Resource { get; set; }
                    public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource : TeaModel {
                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                        /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                        /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                        /// <item><description>LessThanThreshold: less than the threshold</description></item>
                        /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                        /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                        /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                        /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                        /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                        /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                        /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The description of the alert rule.</para>
                        /// <remarks>
                        /// <para> This parameter indicates the content of the alert rule. If the metric value meets the alert condition, an alert is triggered.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$Average&gt;=10</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The description of the multi-metric alert rule.</para>
                        /// </summary>
                        [NameInMap("ExpressionList")]
                        [Validation(Required=false)]
                        public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList ExpressionList { get; set; }
                        public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionList : TeaModel {
                            [NameInMap("ExpressionList")]
                            [Validation(Required=false)]
                            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList> ExpressionList { get; set; }
                            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResourceExpressionListExpressionList : TeaModel {
                                /// <summary>
                                /// <para>The operator that is used to compare the metric value with the threshold. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>GreaterThanOrEqualToThreshold</para>
                                /// </summary>
                                [NameInMap("ComparisonOperator")]
                                [Validation(Required=false)]
                                public string ComparisonOperator { get; set; }

                                /// <summary>
                                /// <para>The metric name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>cpu_total</para>
                                /// </summary>
                                [NameInMap("MetricName")]
                                [Validation(Required=false)]
                                public string MetricName { get; set; }

                                /// <summary>
                                /// <para>The statistical period of the metric. Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>60</para>
                                /// </summary>
                                [NameInMap("Period")]
                                [Validation(Required=false)]
                                public string Period { get; set; }

                                /// <summary>
                                /// <para>The statistical method of the alert level. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>Maximum</description></item>
                                /// <item><description>Minimum</description></item>
                                /// <item><description>Average</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Average</para>
                                /// </summary>
                                [NameInMap("Statistics")]
                                [Validation(Required=false)]
                                public string Statistics { get; set; }

                                /// <summary>
                                /// <para>The alert threshold.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>90</para>
                                /// </summary>
                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public string Threshold { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The relationship between multiple metrics. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>&amp;&amp;: If all metrics meet the alert conditions, CloudMonitor sends alert notifications.</description></item>
                        /// <item><description>||: If one of the metrics meets the alert conditions, CloudMonitor sends alert notifications.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&amp;&amp;</para>
                        /// </summary>
                        [NameInMap("ExpressionListJoin")]
                        [Validation(Required=false)]
                        public string ExpressionListJoin { get; set; }

                        /// <summary>
                        /// <para>The trigger conditions that are created by using expressions. You can use expressions to create trigger conditions in the following scenarios:</para>
                        /// <list type="bullet">
                        /// <item><description>Set an alert blacklist for specific resources. For example, if you specify <c>$instanceId != \\&quot;i-io8kfvcpp7x5****\\&quot; ``&amp;&amp;`` $Average &gt; 50</c>, no alert is triggered when the <c>average metric value</c> of the <c>i-io8kfvcpp7x5****</c> instance exceeds 50.</description></item>
                        /// <item><description>Set a special alert threshold for a specified instance in the rule. For example, if you specify <c>$Average &gt; ($instanceId == \\&quot;i-io8kfvcpp7x5****\\&quot;? 80: 50)</c>, an alert is triggered when the <c>average metric value</c> of the <c>i-io8kfvcpp7x5****</c> instance exceeds 80 or the <c>average metric value</c> of other instances exceeds 50.</description></item>
                        /// <item><description>Limit the number of instances whose metric values exceed the threshold. For example, if you specify <c>count($Average &gt; 20) &gt; 3</c>, an alert is triggered only when the <c>average metric value</c> of more than three instances exceeds 20.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$Average &gt; ($instanceId == \&quot;i-io8kfvcpp7x5****\&quot;? 80: 50)</para>
                        /// </summary>
                        [NameInMap("ExpressionRaw")]
                        [Validation(Required=false)]
                        public string ExpressionRaw { get; set; }

                        /// <summary>
                        /// <para>The severity level and notification methods of the alert. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>4: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                        /// <item><description>OK: No alert is generated.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public int? Level { get; set; }

                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>&gt;=</c></description></item>
                        /// <item><description><c>=</c></description></item>
                        /// <item><description><c>&lt;=</c></description></item>
                        /// <item><description><c>&gt;</c></description></item>
                        /// <item><description><c>&lt;</c></description></item>
                        /// <item><description><c>!=</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <remarks>
                        /// <para>=</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        /// <summary>
                        /// <para>This parameter is deprecated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mns</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// <para>The alert threshold.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// <remarks>
                /// <para> If the alert rule is associated with an application group, the ID of the application group is returned in this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>7671****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The time when the last alert was triggered for the resource based on the alert rule. The value is a timestamp.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622427900000</para>
                /// </summary>
                [NameInMap("LastAlertTime")]
                [Validation(Required=false)]
                public string LastAlertTime { get; set; }

                /// <summary>
                /// <para>The time when the alert rule was last modified. The value is a timestamp.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622827900000</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <para>The severity level and notification methods of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>4: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                /// <item><description>OK: No alert is generated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ActiveMessages</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The metric value that triggered the alert based on the alert rule. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;timestamp\&quot;:1623727500000,\&quot;Sum\&quot;:926,\&quot;value\&quot;:463,\&quot;Maximum\&quot;:463,\&quot;Minimum\&quot;:463,\&quot;Average\&quot;:463,\&quot;SampleCount\&quot;:2,\&quot;userId\&quot;:\&quot;120886317861****\&quot;,\&quot;region\&quot;:\&quot;cn-huhehaote\&quot;,\&quot;queue\&quot;:\&quot;test-0128\&quot;}</para>
                /// </summary>
                [NameInMap("MetricValues")]
                [Validation(Required=false)]
                public string MetricValues { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_mns_new</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The type of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mns</para>
                /// </summary>
                [NameInMap("ProductCategory")]
                [Validation(Required=false)]
                public string ProductCategory { get; set; }

                /// <summary>
                /// <para>The resources that are monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId=120886317861****,region=cn-huhehaote,queue=test-0128</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RetryTimes")]
                [Validation(Required=false)]
                public string RetryTimes { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>putNewAlarm_user_7e78d765-0e3e-4671-ba6d-7ce39108****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123456789</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The time when the resource was associated with the alert rule. The value is a timestamp.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622427900000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The method used to calculate the metric values that trigger alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
