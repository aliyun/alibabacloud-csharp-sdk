// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyGroupMonitoringAgentProcessRequest : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<ModifyGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class ModifyGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// The level of the alert. Valid values:
            /// 
            /// *   INFO: information
            /// *   WARN: warning
            /// *   CRITICAL: critical
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// The time period during which the alert rule is effective. Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            /// <summary>
            /// The ID of the process monitoring task.
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// The logical operator used between conditional expressions that are used to match instances. Valid values:
            /// 
            /// *   all
            /// *   and
            /// *   or
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// The level of the alert. Valid values of N: 1 to 200. Valid values:
            /// 
            /// *   critical (default value): critical
            /// *   warn: warning
            /// *   info: information
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class ModifyGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the resource.
                /// 
                /// For information about how to obtain the ARN of a resource, see [DescribeMetricRuleTargets](~~121592~~).
                /// 
                /// Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
                /// 
                /// *   {Service name abbreviation}: the abbreviation of the service name. Valid value: mns.
                /// *   {userId}: the ID of the Alibaba Cloud account.
                /// *   {regionId}: the region ID of the message queue or topic.
                /// *   {Resource type}`: the type of the resource for which alerts are triggered. Valid values: - **queues** - **topics** {Resource name}: the name of the resource. - If the resource type is set to **queues**, the resource name is the name of the message queue. - If the resource type is set to **topics**, the resource name is the name of the topic.`
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The time period during which the alert rule is ineffective. Valid values of N: 1 to 200.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The alert threshold. Valid values of N: 1 to 200.
                /// </summary>
                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                /// <summary>
                /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule. Valid values of N: 1 to 200.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// The mute period during which new alerts are not sent even if the trigger conditions are met. Valid values of N: 1 to 200.
            /// 
            /// Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.
            /// 
            /// >  Only one alert notification is sent during a mute period even if the metric value exceeds the alert threshold during consecutive checks.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to **ModifyGroupMonitoringAgentProcess**.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public string Times { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The status code 200 indicates that the call was successful.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The statistical aggregation method that is used to calculate the metric values. Valid values of N: 1 to 200.
        /// 
        /// >  Set the value to Average.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The comparison operator that is used to compare the metric value with the threshold. Valid values of N: 1 to 200. Valid values:
        /// 
        /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
        /// *   GreaterThanThreshold: greater than the threshold
        /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
        /// *   LessThanThreshold: less than the threshold.
        /// *   NotEqualToThreshold: not equal to the threshold
        /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday.
        /// *   LessThanYesterday: less than the metric value at the same time yesterday
        /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
        /// *   LessThanLastWeek: less than the metric value at the same time last week
        /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
        /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
