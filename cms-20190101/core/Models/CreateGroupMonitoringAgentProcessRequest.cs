// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// The alert rule configurations.
        /// 
        /// Valid values of N: 1 to 3.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// The operator that is used to compare the metric value with the threshold. Valid values:
            /// 
            /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
            /// *   GreaterThanThreshold: greater than the threshold
            /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
            /// *   LessThanThreshold: less than the threshold
            /// *   NotEqualToThreshold: not equal to the threshold
            /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
            /// *   LessThanYesterday: less than the metric value at the same time yesterday
            /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
            /// *   LessThanLastWeek: less than the metric value at the same time last week
            /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
            /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// The time period during which the alert rule is effective.
            /// 
            /// Valid values of N: 1 to 3.
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// The alert level. Valid values:
            /// 
            /// *   critical (default): critical
            /// *   warn: warning
            /// *   info: information
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// >  Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// The statistical method for alerts.
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// >  Set the value to Average.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// The alert triggers.
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the resource.
                /// 
                /// For information about how to obtain the ARN of a resource, see [DescribeMetricRuleTargets](https://help.aliyun.com/document_detail/121592.html).
                /// 
                /// Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
                /// 
                /// *   {Service name abbreviation}: the abbreviation of the service name. Valid value: mns.
                /// 
                /// *   {userId}: the ID of the Alibaba Cloud account.
                /// 
                /// *   {regionId}: the region ID of the message queue or topic.
                /// 
                /// *   {Resource type}: the type of the resource that triggers the alert. Valid values:
                /// 
                ///     *   **queues**
                ///     *   **topics**
                /// 
                /// *   {Resource name}: the resource name.
                /// 
                ///     *   If the resource type is **queues**, the resource name is the queue name.
                ///     *   If the resource type is **topics**, the resource name is the topic name.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The ID of the resource for which alerts are triggered.
                /// 
                /// For information about how to obtain the ID of a resource for which alerts are triggered, see [DescribeMetricRuleTargets](https://help.aliyun.com/document_detail/121592.html).
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The parameters of the alert callback. Specify the parameters in the JSON format.
                /// </summary>
                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                /// <summary>
                /// The alert level. Valid values:
                /// 
                /// *   INFO
                /// *   WARN
                /// *   CRITICAL
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// The alert threshold.
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// Unit: cores.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// The number of times for which the threshold can be consecutively exceeded. Default value: 3.
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// >  An alert is triggered only if the number of times for which the threshold can be consecutively exceeded is reached.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public string Times { get; set; }

            /// <summary>
            /// The callback URL.
            /// 
            /// Valid values of N: 1 to 3.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For more information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The expressions used to match instances.
        /// 
        /// Valid values of N: 1 to 3.
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestMatchExpress> MatchExpress { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestMatchExpress : TeaModel {
            /// <summary>
            /// The matching condition. Valid values:
            /// 
            /// *   all (default value): matches all
            /// *   startWith: starts with a prefix
            /// *   endWith: ends with a suffix
            /// *   contains: contains
            /// *   notContains: does not contain
            /// *   equals: equals
            /// 
            /// Valid values of N: 1 to 3.
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// The criteria based on which the instances are matched.
            /// 
            /// Valid values of N: 1 to 3.
            /// 
            /// > Set the value to name. The value name indicates that the instances are matched based on the instance name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The keyword used to match the instance name.
            /// 
            /// Valid values of N: 1 to 3.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The logical operator used between conditional expressions that are used to match instances. Valid values:
        /// 
        /// *   all
        /// *   and
        /// *   or
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        /// <summary>
        /// The process name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
