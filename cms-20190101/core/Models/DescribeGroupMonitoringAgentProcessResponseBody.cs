// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page. Default value: 1.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Default value: 10.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The process monitoring tasks created for the application group.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the process monitoring task.
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
                /// The duration of the mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.
                /// 
                /// >  Only one alert notification is sent during each mute period even if the metric value consecutively exceeds the alert threshold several times.
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
                        /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// The method used to calculate metric values that trigger alerts.
                        /// </summary>
                        [NameInMap("EffectiveInterval")]
                        [Validation(Required=false)]
                        public string EffectiveInterval { get; set; }

                        /// <summary>
                        /// The time period during which the alert rule is effective.
                        /// </summary>
                        [NameInMap("EscalationsLevel")]
                        [Validation(Required=false)]
                        public string EscalationsLevel { get; set; }

                        /// <summary>
                        /// The threshold for triggering alerts.
                        /// </summary>
                        [NameInMap("NoEffectiveInterval")]
                        [Validation(Required=false)]
                        public string NoEffectiveInterval { get; set; }

                        /// <summary>
                        /// The number of times for which the threshold can be consecutively exceeded.
                        /// 
                        /// >  A metric triggers an alert only after the metric value reaches the threshold consecutively for the specified times.
                        /// </summary>
                        [NameInMap("SilenceTime")]
                        [Validation(Required=false)]
                        public string SilenceTime { get; set; }

                        /// <summary>
                        /// Queries the process monitoring tasks for an application group.
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("TargetList")]
                        [Validation(Required=false)]
                        public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList TargetList { get; set; }
                        public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList : TeaModel {
                            [NameInMap("Target")]
                            [Validation(Required=false)]
                            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget> Target { get; set; }
                            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget : TeaModel {
                                [NameInMap("Arn")]
                                [Validation(Required=false)]
                                public string Arn { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                [NameInMap("JsonParmas")]
                                [Validation(Required=false)]
                                public string JsonParmas { get; set; }

                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                            }

                        }

                        /// <summary>
                        /// You can create a process monitoring task to monitor all or the specified Elastic Compute Service (ECS) instances in an application group and set alert rules for the process monitoring task.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// The time period during which the alert rule is ineffective.
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                        /// <summary>
                        /// The level of the alert. Valid values:
                        /// 
                        /// *   critical
                        /// *   warn
                        /// *   info
                        /// </summary>
                        [NameInMap("Webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                    }

                }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The keyword used to match the instance name.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The criteria based on which the instances are matched.
                /// 
                /// >  Set the value to `name`, indicating that the instances are matched based on instance name.
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
                        /// The comparison operator of the threshold for critical-level alerts. Valid values:
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
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// The configurations of the alert rule.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The method used to match the instances. Default value: all. Valid values:
                        /// 
                        /// *   all
                        /// *   startWith
                        /// *   endWith
                        /// *   contains
                        /// *   notContains
                        /// *   equals
                        /// 
                        /// >  The matched instances are monitored by the process monitoring task.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                /// <summary>
                /// The conditional expressions used to match the instances.
                /// 
                /// >  Only the instances that meet the conditional expressions are monitored by the process monitoring task.
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The name of the process monitoring task.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
