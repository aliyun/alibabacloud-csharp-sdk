// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyGroupMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<ModifyGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class ModifyGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>The comparison operator for the threshold of the Critical alert level. The value of N can be 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>GreaterThanOrEqualToThreshold: greater than or equal to</para>
            /// </description></item>
            /// <item><description><para>GreaterThanThreshold: greater than</para>
            /// </description></item>
            /// <item><description><para>LessThanOrEqualToThreshold: less than or equal to</para>
            /// </description></item>
            /// <item><description><para>LessThanThreshold: less than</para>
            /// </description></item>
            /// <item><description><para>NotEqualToThreshold: not equal to</para>
            /// </description></item>
            /// <item><description><para>GreaterThanYesterday: greater than the value at the same time yesterday</para>
            /// </description></item>
            /// <item><description><para>LessThanYesterday: less than the value at the same time yesterday</para>
            /// </description></item>
            /// <item><description><para>GreaterThanLastWeek: greater than the value at the same time last week</para>
            /// </description></item>
            /// <item><description><para>LessThanLastWeek: less than the value at the same time last week</para>
            /// </description></item>
            /// <item><description><para>GreaterThanLastPeriod: greater than the value in the last monitoring cycle</para>
            /// </description></item>
            /// <item><description><para>LessThanLastPeriod: less than the value in the last monitoring cycle</para>
            /// </description></item>
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
            /// <para>The time period when the alert rule is effective. The value of N can be 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-22:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The alert level. The value of N can be 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>critical (default): critical</para>
            /// </description></item>
            /// <item><description><para>warn: warning</para>
            /// </description></item>
            /// <item><description><para>info: information</para>
            /// </description></item>
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
            /// <para>This parameter is deprecated. You can ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-05:30</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The mute period. The value of N can be 1 to 200.</para>
            /// <para>Unit: seconds. Minimum value: 3600. Default value: 86400.</para>
            /// <remarks>
            /// <para>If monitoring data continuously exceeds the alert threshold, an alert notification is sent only once during each mute period.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// <para>The statistical method for alerts. The value of N can be 1 to 200.</para>
            /// <remarks>
            /// <para>Only Average is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>None.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the resource.</para>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// <para>The ARN of a resource is in the following format: <c>acs:{product-abbreviation}:{regionId}:{userId}:/{resource-type}/{resource-name}/message</c>. For example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. The parameters are described as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>{product-abbreviation}: Currently, only Simple Message Queue (formerly MNS) is supported.</para>
                /// </description></item>
                /// <item><description><para>{userId}: The ID of your Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para>{regionId}: The region where the Simple Message Queue (formerly MNS) queue or subject is located.</para>
                /// </description></item>
                /// <item><description><para>{resource-type}: The type of the resource that receives alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>queues</b>: a queue.</para>
                /// </description></item>
                /// <item><description><para><b>topics</b>: a subject.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>{resource-name}: The name of the resource.</para>
                /// <list type="bullet">
                /// <item><description><para>If the resource type is <b>queues</b>, the resource name is the queue name.</para>
                /// </description></item>
                /// <item><description><para>If the resource type is <b>topics</b>, the resource name is the subject name.</para>
                /// </description></item>
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
                /// <para>The ID of the alert-triggered target.</para>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The JSON-formatted parameters for the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
                /// </summary>
                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                /// <summary>
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>INFO: information</para>
                /// </description></item>
                /// <item><description><para>WARN: warning</para>
                /// </description></item>
                /// <item><description><para>CRITICAL: critical</para>
                /// </description></item>
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
            /// <para>The alert threshold. The value of N can be 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// <para>The number of consecutive times that the alert level is reached. The value of N can be 1 to 200. Default value: 3.</para>
            /// <remarks>
            /// <para>An alert is triggered only when the alert level is reached the specified number of consecutive times and the threshold is met.</para>
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
            /// <para>The callback URL. A POST request is sent to this URL when an alert is triggered. The value of N can be 1 to 200.</para>
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
        /// <para>The ID of the process monitoring job for the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92E3065F-0980-4E31-9AA0-BA6****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. You can ignore it.</para>
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
