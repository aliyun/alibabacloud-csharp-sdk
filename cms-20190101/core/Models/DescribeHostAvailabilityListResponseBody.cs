// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHostAvailabilityListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A288E86-45C3-4858-9DB0-6D85B10BD92A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the availability monitoring tasks.</para>
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
                /// <para>The configurations of the alert rule.</para>
                /// </summary>
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig AlertConfig { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig : TeaModel {
                    /// <summary>
                    /// <para>The end of the time period during which the alert rule is effective. Valid values: 0 to 23.</para>
                    /// <para>For example, if the <c>AlertConfig.StartTime</c> parameter is set to 0 and the <c>AlertConfig.EndTime</c> parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.</para>
                    /// <remarks>
                    /// <para> Alert notifications are sent based on the specified threshold only if the alert rule is effective.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public int? EndTime { get; set; }

                    /// <summary>
                    /// <para>The trigger conditions of the alert rule.</para>
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
                            /// <para>The method used to calculate metric values that trigger alerts. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Value: the value of the HTTP status code</description></item>
                            /// <item><description>Average: the average HTTP response time</description></item>
                            /// <item><description>Value: the value of the Telnet status code</description></item>
                            /// <item><description>TelnetLatency: the average Telnet response time</description></item>
                            /// <item><description>Average: the average Ping packet loss rate</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Value</para>
                            /// </summary>
                            [NameInMap("Aggregate")]
                            [Validation(Required=false)]
                            public string Aggregate { get; set; }

                            /// <summary>
                            /// <para>The name of the metric. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>HttpStatus</description></item>
                            /// <item><description>HttpLatency</description></item>
                            /// <item><description>TelnetStatus</description></item>
                            /// <item><description>TelnetLatency</description></item>
                            /// <item><description>PingLostRate</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>HttpStatus</para>
                            /// </summary>
                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            /// <summary>
                            /// <para>The comparison operator that is used in the alert rule. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>&gt;</c></description></item>
                            /// <item><description><c>&gt;=</c></description></item>
                            /// <item><description><c>&lt;</c></description></item>
                            /// <item><description><c>&lt;=</c></description></item>
                            /// <item><description><c>=</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>=</para>
                            /// </summary>
                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public string Operator { get; set; }

                            /// <summary>
                            /// <para>The consecutive number of times for which the metric value is measured before an alert is triggered.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public string Times { get; set; }

                            /// <summary>
                            /// <para>The alert threshold.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>400</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The alert notification methods. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>2: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                    /// <item><description>1: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                    /// <item><description>0: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public int? NotifyType { get; set; }

                    /// <summary>
                    /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time period during which the alert rule is effective. Valid values: 0 to 23.</para>
                    /// <para>For example, if the <c>AlertConfig.StartTime</c> parameter is set to 0 and the <c>AlertConfig.EndTime</c> parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.</para>
                    /// <remarks>
                    /// <para> Alert notifications are sent based on the specified threshold only if the alert rule is effective.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public int? StartTime { get; set; }

                    /// <summary>
                    /// <para>The monitored resources.</para>
                    /// </summary>
                    [NameInMap("TargetList")]
                    [Validation(Required=false)]
                    public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetList TargetList { get; set; }
                    public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetList : TeaModel {
                        [NameInMap("Target")]
                        [Validation(Required=false)]
                        public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetListTarget> Target { get; set; }
                        public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigTargetListTarget : TeaModel {
                            /// <summary>
                            /// <para>The Alibaba Cloud Resource Name (ARN) of the function.</para>
                            /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields:</para>
                            /// <list type="bullet">
                            /// <item><description>Service: the service code</description></item>
                            /// <item><description>Region: the region ID</description></item>
                            /// <item><description>Account: the ID of the Alibaba Cloud account</description></item>
                            /// <item><description>ResourceType: the resource type</description></item>
                            /// <item><description>ResourceId: the resource ID.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>acs:mns:cn-hangzhou:17754132319*****:/queues/test/messages</para>
                            /// </summary>
                            [NameInMap("Arn")]
                            [Validation(Required=false)]
                            public string Arn { get; set; }

                            /// <summary>
                            /// <para>The ID of the resource that triggers the alert.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <para>The JSON-formatted parameters of the alert callback.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
                            /// </summary>
                            [NameInMap("JsonParams")]
                            [Validation(Required=false)]
                            public string JsonParams { get; set; }

                            /// <summary>
                            /// <para>The alert level. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>INFO</description></item>
                            /// <item><description>WARN</description></item>
                            /// <item><description>CRITICAL</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>INFO</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The callback URL.</para>
                    /// <para>CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("WebHook")]
                    [Validation(Required=false)]
                    public string WebHook { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the availability monitoring task is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The availability monitoring task is disabled.</description></item>
                /// <item><description>false: The availability monitoring task is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The name of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Group_ECS</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The ID of the availability monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ECS instances that are monitored.</para>
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
                /// <para>The name of the availability monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs_instance</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The optional parameters of the availability monitoring task.</para>
                /// </summary>
                [NameInMap("TaskOption")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption TaskOption { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption : TeaModel {
                    /// <summary>
                    /// <para>The response to the HTTP request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("HttpKeyword")]
                    [Validation(Required=false)]
                    public string HttpKeyword { get; set; }

                    /// <summary>
                    /// <para>The HTTP request method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GET</description></item>
                    /// <item><description>POST</description></item>
                    /// <item><description>HEAD</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GET</para>
                    /// </summary>
                    [NameInMap("HttpMethod")]
                    [Validation(Required=false)]
                    public string HttpMethod { get; set; }

                    /// <summary>
                    /// <para>The method to trigger an alert. The alert can be triggered based on whether the specified alert rule is included in the response body. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: If the HTTP response body includes the alert rule, an alert is triggered.</description></item>
                    /// <item><description>false: If the HTTP response does not include the alert rule, an alert is triggered.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HttpNegative")]
                    [Validation(Required=false)]
                    public bool? HttpNegative { get; set; }

                    /// <summary>
                    /// <para>The content of the HTTP POST request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>params1=paramsValue1</para>
                    /// </summary>
                    [NameInMap("HttpPostContent")]
                    [Validation(Required=false)]
                    public string HttpPostContent { get; set; }

                    /// <summary>
                    /// <para>The character set that is used in the HTTP response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UTF-8</para>
                    /// </summary>
                    [NameInMap("HttpResponseCharset")]
                    [Validation(Required=false)]
                    public string HttpResponseCharset { get; set; }

                    /// <summary>
                    /// <para>The URI that you want to monitor. If the TaskType parameter is set to HTTP, this parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("HttpURI")]
                    [Validation(Required=false)]
                    public string HttpURI { get; set; }

                    /// <summary>
                    /// <para>The interval at which detection requests are sent. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The domain name or IP address that you want to monitor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ssh.aliyun.com</para>
                    /// </summary>
                    [NameInMap("TelnetOrPingHost")]
                    [Validation(Required=false)]
                    public string TelnetOrPingHost { get; set; }

                }

                /// <summary>
                /// <para>The range of instances that are monitored by the availability monitoring task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GROUP: All ECS instances in the application group are monitored.</description></item>
                /// <item><description>GROUP_SPEC_INSTANCE: Specified ECS instances in the application group are monitored.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GROUP</para>
                /// </summary>
                [NameInMap("TaskScope")]
                [Validation(Required=false)]
                public string TaskScope { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PING</description></item>
                /// <item><description>TELNET</description></item>
                /// <item><description>HTTP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
