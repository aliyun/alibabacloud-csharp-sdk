// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyGroupMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// <para>The alert rule configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<ModifyGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class ModifyGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>The comparison operator that is used to compare the metric value with the threshold. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
            /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
            /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
            /// <item><description>LessThanThreshold: less than the threshold.</description></item>
            /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
            /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday.</description></item>
            /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
            /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
            /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
            /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
            /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GreaterThanOrEqualToThreshold</para>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>The time period during which the alert rule is effective. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-22:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The level of the alert. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>critical (default value): critical</description></item>
            /// <item><description>warn: warning</description></item>
            /// <item><description>info: information</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            /// <summary>
            /// <para>The time period during which the alert rule is ineffective. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23:00-23:59</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met. Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.</para>
            /// <remarks>
            /// <para> Only one alert notification is sent during a mute period even if the metric value exceeds the alert threshold during consecutive checks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// <para>The statistical aggregation method that is used to calculate the metric values. Valid values of N: 1 to 200.</para>
            /// <remarks>
            /// <para> Set the value to Average.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The alert trigger.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the resource.</para>
                /// <para>For information about how to obtain the ARN of a resource, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// <para>Format: <c>acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. Fields:</para>
                /// <list type="bullet">
                /// <item><description>{Service name abbreviation}: the abbreviation of the service name. Valid value: mns.</description></item>
                /// <item><description>{userId}: the ID of the Alibaba Cloud account.</description></item>
                /// <item><description>{regionId}: the region ID of the message queue or topic.</description></item>
                /// <item><description>{Resource type}: the type of the resource for which alerts are triggered. Valid values: <list type="bullet">
                /// <item><description><b>queues</b> </description></item>
                /// <item><description><b>topics</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description>{Resourcename}: the name of the resource. <list type="bullet">
                /// <item><description>If the resource type is set to <b>queues</b>, the resource name is the name of the message queue. </description></item>
                /// <item><description>If the resource type is set to <b>topics</b>, the resource name is the name of the topic.`</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:120886317861****:/queues/test/message</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the resource for which alerts are triggered.</para>
                /// <para>For information about how to obtain the ID of a resource for which alerts are triggered, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters of the alert callback. The parameters are in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
                /// </summary>
                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                /// <summary>
                /// <para>The level of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INFO: information</description></item>
                /// <item><description>WARN: warning</description></item>
                /// <item><description>CRITICAL: critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;INFO&quot;, &quot;WARN&quot;, &quot;CRITICAL&quot;]</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// <para>The alert threshold. Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// <para>The number of times for which the threshold can be consecutively exceeded. Valid values of N: 1 to 200. Default value: 3.</para>
            /// <remarks>
            /// <para> A metric triggers an alert only after the metric value reaches the threshold consecutively for the specified times.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public string Times { get; set; }

            /// <summary>
            /// <para>The callback URL to which a POST request is sent when an alert is triggered based on the alert rule. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6780****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the process monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92E3065F-0980-4E31-9AA0-BA6****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The logical operator used between conditional expressions that are used to match instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all</description></item>
        /// <item><description>and</description></item>
        /// <item><description>or</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
