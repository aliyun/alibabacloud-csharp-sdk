// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRuleRequest : TeaModel {
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
        /// <para>The alert contact groups. Separate multiple alert contact groups with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// <para>The period of time during which the alert rule is effective. Valid values: 00:00 to 23:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-23:59</para>
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// <para>The subject of the alert notification email.</para>
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
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
        /// <para> The value 0 indicates that the reported custom monitoring data does not belong to an application group.</para>
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
        /// <item><description>CRITICAL</description></item>
        /// <item><description>WARN</description></item>
        /// <item><description>INFO</description></item>
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
        /// <para> For more information about how to obtain the metric name, see <a href="https://help.aliyun.com/document_detail/115005.html">DescribeCustomMetricList</a>.</para>
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
        /// <para>The cycle that is used to aggregate custom monitoring data. Unit: seconds Set the value to an integral multiple of 60. The original reporting cycle of custom monitoring data is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The custom monitoring data to which the alert rule applies. The value includes the application group ID to which the custom monitoring data belongs and the dimension to which the metric belongs.</para>
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
        /// <para> You can specify an existing ID to modify the corresponding alert rule or specify a new ID to create an alert rule.</para>
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
        /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400, which is equivalent to one day.</para>
        /// <remarks>
        /// <para> Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The method used to calculate the metric value based on which alerts are triggered.</para>
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
        /// <para>The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
