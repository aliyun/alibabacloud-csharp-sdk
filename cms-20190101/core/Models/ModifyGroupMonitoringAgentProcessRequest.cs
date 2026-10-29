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
            /// <para>The comparison operator for the Critical level threshold. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
            /// <item><description>GreaterThanThreshold: greater than.</description></item>
            /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
            /// <item><description>LessThanThreshold: less than.</description></item>
            /// <item><description>NotEqualToThreshold: not equal to.</description></item>
            /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
            /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
            /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
            /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
            /// <item><description>GreaterThanLastPeriod: greater than the value in the last period.</description></item>
            /// <item><description>LessThanLastPeriod: less than the value in the last period.</description></item>
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
            /// <para>The effective period of the alert rule. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-22:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>critical (default): critical.</description></item>
            /// <item><description>warn: warning.</description></item>
            /// <item><description>info: information.</description></item>
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
            /// <para>Not required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-05:30(Deprecated: true)</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The mute period. Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. Minimum value: 3600 seconds (1 hour). Default value: 86400 seconds (1 day).</para>
            /// <remarks>
            /// <para>If the monitoring data continuously exceeds the alert rule threshold, only one alert notification is sent within each mute period.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// <para>The statistical method for alerts. Valid values of N: 1 to 200.</para>
            /// <remarks>
            /// <para>Currently, only Average is supported.</para>
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
                /// <para>The resource ARN.</para>
                /// <para>For information about how to obtain the resource ARN, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// <para>The resource ARN is in the format of <c>acs:{cloud_service_abbreviation}:{regionId}:{userId}:/{resource_type}/{resource_name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. The parameters are described as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>{cloud_service_abbreviation}: Currently, only Simple Message Queue (formerly MNS) is supported.</para>
                /// </description></item>
                /// <item><description><para>{userId}: The Alibaba Cloud account ID.</para>
                /// </description></item>
                /// <item><description><para>{regionId}: The region where Simple Message Queue (formerly MNS) or the topic resides.</para>
                /// </description></item>
                /// <item><description><para>{resource_type}: The type of the resource that accepts alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>queues</b>: queue.</description></item>
                /// <item><description><b>topics</b>: topic.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>{resource_name}: The resource name.</para>
                /// <list type="bullet">
                /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
                /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
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
                /// <para>The ID of the alert trigger target.</para>
                /// <para>For information about how to obtain the alert trigger target ID, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
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
                /// <item><description>INFO: information.</description></item>
                /// <item><description>WARN: warning.</description></item>
                /// <item><description>CRITICAL: critical.</description></item>
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
            /// <para>The number of consecutive occurrences of the alert level. Valid values of N: 1 to 200. Default value: 3.</para>
            /// <remarks>
            /// <para>An alert is triggered only when the alert level consecutively occurs the specified number of times and the alert threshold is reached.</para>
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
            /// <para>The callback URL to which a POST request is sent when an alert is triggered. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6780****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the process monitoring task in the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92E3065F-0980-4E31-9AA0-BA6****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and(Deprecated: true)</para>
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
