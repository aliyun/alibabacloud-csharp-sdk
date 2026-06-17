// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRuleRequest : TeaModel {
        /// <summary>
        /// <para>The comparison operator for the threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>&gt;=</c></para>
        /// </description></item>
        /// <item><description><para><c>=</c></para>
        /// </description></item>
        /// <item><description><para><c>&lt;=</c></para>
        /// </description></item>
        /// <item><description><para><c>&gt;</c></para>
        /// </description></item>
        /// <item><description><para><c>&lt;</c></para>
        /// </description></item>
        /// <item><description><para><c>!=</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// <para>The alert contact group. Separate multiple alert contact groups with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// <para>The effective time range of the alert rule. Valid values: 00:00-23:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-23:59</para>
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// <para>The subject of the alert email.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS instance</para>
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>The number of alert retries.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The ID of the application group to which the custom monitoring data belongs.</para>
        /// <remarks>
        /// <para>A value of 0 indicates that the reported custom monitoring data does not belong to any application group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7378****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The alert level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CRITICAL: critical.</description></item>
        /// <item><description>WARN: warning.</description></item>
        /// <item><description>INFO: information.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRITICAL</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the metric name, see <a href="https://help.aliyun.com/document_detail/115005.html">DescribeCustomMetricList</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The aggregation period of the custom monitoring data. Unit: seconds. Set the value to 60 or a multiple of 60. Default value: the original reporting period of the custom monitoring data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The custom monitoring data to which the alert rule applies. The value consists of the application group ID to which the custom monitoring data belongs and the dimensions of the metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;groupId&quot;:7378****,&quot;dimension&quot;:&quot;instanceId=i-hp3543t5e4sudb3s****&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <remarks>
        /// <para>If the alert rule ID already exists, the alert rule is modified. If the alert rule ID does not exist, an alert rule is created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyRuleId1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CpuUsage</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The mute for period. Unit: seconds. Default value: 86400 (1 day).</para>
        /// <remarks>
        /// <para>If the monitoring data continuously exceeds the alert threshold, only one alert notification is sent within each mute for period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The statistical method for alerts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The alert threshold.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        /// <summary>
        /// <para>The alert callback URL. An HTTP POST request is sent to the specified URL when an alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
