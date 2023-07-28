// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHostAvailabilityListResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details of the availability monitoring tasks.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the availability monitoring task. Valid values:
        /// 
        /// *   PING
        /// *   TELNET
        /// *   HTTP
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public DescribeHostAvailabilityListResponseBodyTaskList TaskList { get; set; }
        public class DescribeHostAvailabilityListResponseBodyTaskList : TeaModel {
            [NameInMap("NodeTaskConfig")]
            [Validation(Required=false)]
            public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig> NodeTaskConfig { get; set; }
            public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig : TeaModel {
                /// <summary>
                /// The beginning of the time period during which the alert rule is effective. Valid values: 0 to 23.
                /// 
                /// For example, if the `AlertConfig.StartTime` parameter is set to 0 and the `AlertConfig.EndTime` parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.
                /// 
                /// >  Alert notifications are sent based on the specified threshold only if the alert rule is effective.
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig AlertConfig { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig : TeaModel {
                    /// <summary>
                    /// The alert notification methods. Valid values:
                    /// 
                    /// 0: Alert notifications are sent by using emails and DingTalk chatbots.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public int? EndTime { get; set; }

                    /// <summary>
                    /// The comparison operator that is used in the alert rule. Valid values:
                    /// 
                    /// *   `>`
                    /// *   `>=`
                    /// *   `<`
                    /// *   `<=`
                    /// *   `=`
                    /// </summary>
                    [NameInMap("EscalationList")]
                    [Validation(Required=false)]
                    public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList EscalationList { get; set; }
                    public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList : TeaModel {
                        [NameInMap("escalationList")]
                        [Validation(Required=false)]
                        public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList> EscalationList { get; set; }
                        public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList : TeaModel {
                            /// <summary>
                            /// For more information about common request parameters, see [Common parameters](~~199331~~).
                            /// </summary>
                            [NameInMap("Aggregate")]
                            [Validation(Required=false)]
                            public string Aggregate { get; set; }

                            /// <summary>
                            /// The method used to calculate metric values that trigger alerts. Valid values:
                            /// 
                            /// *   Value: the value of the HTTP status code
                            /// *   Average: the average HTTP response time
                            /// *   Value: the value of the Telnet status code
                            /// *   TelnetLatency: the average Telnet response time
                            /// *   Average: the average Ping packet loss rate
                            /// </summary>
                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            /// <summary>
                            /// This topic provides an example to show how to query all the availability monitoring tasks of your Alibaba Cloud account. The sample responses indicate that the account has one availability monitoring task named `ecs_instance`.
                            /// </summary>
                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public string Operator { get; set; }

                            /// <summary>
                            /// Queries availability monitoring tasks.
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public string Times { get; set; }

                            /// <summary>
                            /// The consecutive number of times for which the metric value is measured before an alert is triggered.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The name of the metric. Valid values:
                    /// 
                    /// *   HttpStatus: HTTP status code
                    /// *   HttpLatency: HTTP response time
                    /// *   TelnetStatus: Telnet status code
                    /// *   TelnetLatency: Telnet response time
                    /// *   PingLostRate: Ping packet loss rate
                    /// </summary>
                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public int? NotifyType { get; set; }

                    /// <summary>
                    /// The callback URL.
                    /// 
                    /// CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.
                    /// </summary>
                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

                    /// <summary>
                    /// The trigger conditions of the alert rule.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public int? StartTime { get; set; }

                    [NameInMap("TargetList")]
                    [Validation(Required=false)]
                    public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetList TargetList { get; set; }
                    public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetList : TeaModel {
                        [NameInMap("Target")]
                        [Validation(Required=false)]
                        public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetListTarget> Target { get; set; }
                        public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetListTarget : TeaModel {
                            [NameInMap("Arn")]
                            [Validation(Required=false)]
                            public string Arn { get; set; }

                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("JsonParams")]
                            [Validation(Required=false)]
                            public string JsonParams { get; set; }

                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                    }

                    /// <summary>
                    /// The alert threshold.
                    /// </summary>
                    [NameInMap("WebHook")]
                    [Validation(Required=false)]
                    public string WebHook { get; set; }

                }

                /// <summary>
                /// The ECS instances that are monitored.
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// The range of instances that are monitored by the availability monitoring task. Valid values:
                /// 
                /// *   GROUP: All ECS instances in the application group are monitored.
                /// *   GROUP_SPEC_INSTANCE: Specified ECS instances in the application group are monitored.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// Indicates whether the availability monitoring task is disabled. Valid values:
                /// 
                /// *   true: The availability monitoring task is disabled.
                /// *   false: The availability monitoring task is enabled.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The HTTP request method. Valid values:
                /// 
                /// *   GET
                /// *   POST
                /// *   HEAD
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The interval at which detection requests are sent. Unit: seconds.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances Instances { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<string> Instance { get; set; }

                }

                /// <summary>
                /// The ID of the availability monitoring task.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// The URI that you want to monitor. If the TaskType parameter is set to HTTP, this parameter is required.
                /// </summary>
                [NameInMap("TaskOption")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption TaskOption { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption : TeaModel {
                    /// <summary>
                    /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400.
                    /// </summary>
                    [NameInMap("HttpKeyword")]
                    [Validation(Required=false)]
                    public string HttpKeyword { get; set; }

                    /// <summary>
                    /// The domain name or IP address that you want to monitor.
                    /// </summary>
                    [NameInMap("HttpMethod")]
                    [Validation(Required=false)]
                    public string HttpMethod { get; set; }

                    /// <summary>
                    /// The end of the time period during which the alert rule is effective. Valid values: 0 to 23.
                    /// 
                    /// For example, if the `AlertConfig.StartTime` parameter is set to 0 and the `AlertConfig.EndTime` parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.
                    /// 
                    /// >  Alert notifications are sent based on the specified threshold only if the alert rule is effective.
                    /// </summary>
                    [NameInMap("HttpNegative")]
                    [Validation(Required=false)]
                    public bool? HttpNegative { get; set; }

                    /// <summary>
                    /// The configurations of the alert rule.
                    /// </summary>
                    [NameInMap("HttpPostContent")]
                    [Validation(Required=false)]
                    public string HttpPostContent { get; set; }

                    /// <summary>
                    /// The response to the HTTP request.
                    /// </summary>
                    [NameInMap("HttpResponseCharset")]
                    [Validation(Required=false)]
                    public string HttpResponseCharset { get; set; }

                    /// <summary>
                    /// The content of the HTTP POST request.
                    /// </summary>
                    [NameInMap("HttpURI")]
                    [Validation(Required=false)]
                    public string HttpURI { get; set; }

                    /// <summary>
                    /// The character set that is used in the HTTP response.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// The method to trigger an alert. The alert can be triggered based on whether the specified alert rule is included in the response body. Valid values:
                    /// 
                    /// *   true: If the HTTP response body includes the alert rule, an alert is triggered.
                    /// *   false: If the HTTP response does not include the alert rule, an alert is triggered.
                    /// </summary>
                    [NameInMap("TelnetOrPingHost")]
                    [Validation(Required=false)]
                    public string TelnetOrPingHost { get; set; }

                }

                /// <summary>
                /// The optional parameters of the availability monitoring task.
                /// </summary>
                [NameInMap("TaskScope")]
                [Validation(Required=false)]
                public string TaskScope { get; set; }

                /// <summary>
                /// The name of the availability monitoring task.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
