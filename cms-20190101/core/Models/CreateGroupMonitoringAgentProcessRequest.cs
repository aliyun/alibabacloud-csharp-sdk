// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert rule configurations.</para>
        /// <para>Valid values of N: 1 to 3.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>The comparison operator for the threshold. Valid values:</para>
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
            /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
            /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GreaterThanOrEqualToThreshold</para>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>The effective period of the alert rule.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>07:00-22:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>critical: critical. This is the default value.</description></item>
            /// <item><description>warn: warning.</description></item>
            /// <item><description>info: informational.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is deprecated and no longer requires attention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-05:30</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The mute period. Unit: seconds. Minimum value: 3600, which indicates 1 hour. Default value: 86400, which indicates 1 day.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para>If the monitoring data continuously exceeds the alert rule threshold, the system sends only one alert notification within each mute period.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// <para>The statistical method for alerts.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para>Only Average is supported.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The list of alert targets.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the resource.</para>
                /// <para>For information about how to obtain the ARN of a resource, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// <para>The ARN is in the following format: <c>acs:{service abbreviation}:{regionId}:{userId}:/{resource type}/{resource name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. The parameters are described as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>{service abbreviation}: the abbreviation of the cloud service. Only Simple Message Queue (formerly MNS) is supported.</para>
                /// </description></item>
                /// <item><description><para>{userId}: the Alibaba Cloud account ID.</para>
                /// </description></item>
                /// <item><description><para>{regionId}: the region where the Simple Message Queue (formerly MNS) queue or topic resides.</para>
                /// </description></item>
                /// <item><description><para>{resource type}: the type of the resource that receives alert notifications. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>queues</b>: queue.</description></item>
                /// <item><description><b>topics</b>: topic.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>{resource name}: the name of the resource.</para>
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
                /// <para>The ID of the alert target.</para>
                /// <para>For information about how to obtain the ID of an alert target, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
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
                /// <item><description>INFO: informational.</description></item>
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
            /// <para>The alert threshold.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>Unit: count.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// <para>The number of consecutive times the alert level is triggered. Default value: 3.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para>An alert is triggered only when the alert level is reached for the specified number of consecutive times and the alert threshold is met.</para>
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
            /// <para>The webhook URL for alert callbacks.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>For information about how to obtain the application group ID, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The list of match conditional expressions.</para>
        /// <para>Valid values of N: 1 to 3.</para>
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestMatchExpress> MatchExpress { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestMatchExpress : TeaModel {
            /// <summary>
            /// <para>The match condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: matches all. This is the default value.</description></item>
            /// <item><description>startWith: matches the prefix.</description></item>
            /// <item><description>endWith: matches the suffix.</description></item>
            /// <item><description>contains: contains the specified string.</description></item>
            /// <item><description>notContains: does not contain the specified string.</description></item>
            /// <item><description>equals: exactly matches.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>startWith</para>
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// <para>The type of the match condition.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para>Only Name, which indicates the instance name, is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>name1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the matched instance.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>portalHost</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical relation for matching instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: all.</description></item>
        /// <item><description>and: AND.</description></item>
        /// <item><description>or: OR.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Process_Java</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
