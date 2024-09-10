// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status codes.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number. Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The process monitoring tasks.
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public DescribeGroupMonitoringAgentProcessResponseBodyProcesses Processes { get; set; }
        public class DescribeGroupMonitoringAgentProcessResponseBodyProcesses : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess> Process { get; set; }
            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess : TeaModel {
                /// <summary>
                /// The alert rule configurations.
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig AlertConfig { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig : TeaModel {
                    [NameInMap("AlertConfig")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig> AlertConfig { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig : TeaModel {
                        /// <summary>
                        /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
                        /// 
                        /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                        /// *   GreaterThanThreshold: greater than the threshold
                        /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                        /// *   LessThanThreshold: less than the threshold
                        /// *   NotEqualToThreshold: not equal to the threshold
                        /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday.
                        /// *   LessThanYesterday: less than the metric value at the same time yesterday
                        /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                        /// *   LessThanLastWeek: less than the metric value at the same time last week
                        /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                        /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// The time period during which the alert rule is effective.
                        /// </summary>
                        [NameInMap("EffectiveInterval")]
                        [Validation(Required=false)]
                        public string EffectiveInterval { get; set; }

                        /// <summary>
                        /// The level of the alert. Valid values:
                        /// 
                        /// *   critical
                        /// *   warn
                        /// *   Info
                        /// </summary>
                        [NameInMap("EscalationsLevel")]
                        [Validation(Required=false)]
                        public string EscalationsLevel { get; set; }

                        /// <summary>
                        /// The time period during which the alert rule is ineffective.
                        /// </summary>
                        [NameInMap("NoEffectiveInterval")]
                        [Validation(Required=false)]
                        public string NoEffectiveInterval { get; set; }

                        /// <summary>
                        /// The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.
                        /// 
                        /// >  Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.
                        /// </summary>
                        [NameInMap("SilenceTime")]
                        [Validation(Required=false)]
                        public string SilenceTime { get; set; }

                        /// <summary>
                        /// The method used to calculate metric values that trigger alerts.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The resource for which alerts are triggered.
                        /// </summary>
                        [NameInMap("TargetList")]
                        [Validation(Required=false)]
                        public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList TargetList { get; set; }
                        public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList : TeaModel {
                            [NameInMap("Target")]
                            [Validation(Required=false)]
                            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget> Target { get; set; }
                            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget : TeaModel {
                                /// <summary>
                                /// The Alibaba Cloud Resource Name (ARN) of the resource. Format: acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message. Example: acs:mns:cn-hangzhou:120886317861\\*\\*\\*\\*:/queues/test123/message. Fields:
                                /// 
                                /// {Service name abbreviation}: the abbreviation of the service name. Valid value: mns. {userId}: the ID of the Alibaba Cloud account. {regionId}: the region ID of the message queue or topic. {Resource type}: the type of the resource that triggers the alert. Valid values: - **queues** - **topics** - {Resource name}: the resource name. - If the resource type is set to **queues**, the resource name is the name of the message queue. - If the resource type is set to **topics**, the resource name is the name of the topic.
                                /// </summary>
                                [NameInMap("Arn")]
                                [Validation(Required=false)]
                                public string Arn { get; set; }

                                /// <summary>
                                /// The ID of the resource for which alerts are triggered.
                                /// </summary>
                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                /// <summary>
                                /// The parameters of the alert callback. The parameters are in the JSON format.
                                /// </summary>
                                [NameInMap("JsonParmas")]
                                [Validation(Required=false)]
                                public string JsonParmas { get; set; }

                                /// <summary>
                                /// The level of the alert. Valid values:
                                /// 
                                /// INFO WARN CRITICAL
                                /// </summary>
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                            }

                        }

                        /// <summary>
                        /// The alert threshold.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The number of times for which the threshold can be consecutively exceeded.
                        /// 
                        /// >  A metric triggers an alert only after the metric value reaches the threshold consecutively for the specified times.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                        /// <summary>
                        /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
                        /// </summary>
                        [NameInMap("Webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the process monitoring task.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The matching conditions.
                /// 
                /// >  Only the instances that meet the conditional expressions are monitored by the process monitoring task.
                /// </summary>
                [NameInMap("MatchExpress")]
                [Validation(Required=false)]
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress MatchExpress { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress : TeaModel {
                        /// <summary>
                        /// The matching condition. Valid values:
                        /// 
                        /// *   all (default): matches all
                        /// *   startWith: starts with a prefix
                        /// *   endWith: ends with a suffix
                        /// *   contains: contains
                        /// *   notContains: excludes
                        /// *   equals: equals
                        /// 
                        /// >  The matched instances are monitored by the process monitoring task.
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// The criteria based on which the instances are matched.
                        /// 
                        /// >  Set the value to `name`. The value name indicates that the instances are matched based on the instance name.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The keyword used to match the instance name.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

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
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
