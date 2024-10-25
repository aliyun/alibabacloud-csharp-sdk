// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status codes.</para>
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
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The process monitoring tasks.</para>
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
                /// <para>The alert rule configurations.</para>
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
                        /// <para>The comparison operator that is used to compare the metric value with the threshold. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                        /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                        /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                        /// <item><description>LessThanThreshold: less than the threshold</description></item>
                        /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                        /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday.</description></item>
                        /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                        /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                        /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                        /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                        /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The time period during which the alert rule is effective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00:00-23:59</para>
                        /// </summary>
                        [NameInMap("EffectiveInterval")]
                        [Validation(Required=false)]
                        public string EffectiveInterval { get; set; }

                        /// <summary>
                        /// <para>The level of the alert. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>critical</description></item>
                        /// <item><description>warn</description></item>
                        /// <item><description>Info</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>warn</para>
                        /// </summary>
                        [NameInMap("EscalationsLevel")]
                        [Validation(Required=false)]
                        public string EscalationsLevel { get; set; }

                        /// <summary>
                        /// <para>The time period during which the alert rule is ineffective.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00:00-23:59</para>
                        /// </summary>
                        [NameInMap("NoEffectiveInterval")]
                        [Validation(Required=false)]
                        public string NoEffectiveInterval { get; set; }

                        /// <summary>
                        /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.</para>
                        /// <remarks>
                        /// <para> Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>86400</para>
                        /// </summary>
                        [NameInMap("SilenceTime")]
                        [Validation(Required=false)]
                        public string SilenceTime { get; set; }

                        /// <summary>
                        /// <para>The method used to calculate metric values that trigger alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Average</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The resources for which alerts are triggered.</para>
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
                                /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Format: acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message. Example: acs:mns:cn-hangzhou:120886317861\<em>\</em>\<em>\</em>:/queues/test123/message. Fields:</para>
                                /// <list type="bullet">
                                /// <item><description><para>{Service name abbreviation}: the abbreviation of the service name. Set the value to Simple Message Queue (formerly MNS) (SMQ).</para>
                                /// </description></item>
                                /// <item><description><para>{userId}: the ID of the Alibaba Cloud account.</para>
                                /// </description></item>
                                /// <item><description><para>{regionId}: the region ID of the SMQ queue or topic.</para>
                                /// </description></item>
                                /// <item><description><para>{Resource type}: the type of the resource for which alerts are triggered. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>queues</b></description></item>
                                /// <item><description><b>topics</b></description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>{Resource name}: the resource name.</para>
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
                                /// <para>The ID of the resource for which alerts are triggered.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>123</para>
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
                                [NameInMap("JsonParmas")]
                                [Validation(Required=false)]
                                public string JsonParmas { get; set; }

                                /// <summary>
                                /// <para>The alert level. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>INFO</description></item>
                                /// <item><description>WARN</description></item>
                                /// <item><description>CRITICAL</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>CRITICAL</para>
                                /// </summary>
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The alert threshold.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        /// <summary>
                        /// <para>The number of times for which the threshold can be consecutively exceeded.</para>
                        /// <remarks>
                        /// <para> A metric triggers an alert only after the metric value reaches the threshold consecutively for the specified times.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                        /// <summary>
                        /// <para>The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                        /// </summary>
                        [NameInMap("Webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the process monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3F6150F9-45C7-43F9-9578-A58B2E72****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The matching conditions.</para>
                /// <remarks>
                /// <para> Only the instances that meet the conditional expressions are monitored by the process monitoring task.</para>
                /// </remarks>
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
                        /// <para>The matching condition. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>all (default): matches all</description></item>
                        /// <item><description>startWith: starts with a prefix</description></item>
                        /// <item><description>endWith: ends with a suffix</description></item>
                        /// <item><description>contains: contains</description></item>
                        /// <item><description>notContains: excludes</description></item>
                        /// <item><description>equals: equals</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> The matched instances are monitored by the process monitoring task.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// <para>The criteria based on which the instances are matched.</para>
                        /// <remarks>
                        /// <para> Set the value to <c>name</c>. The value name indicates that the instances are matched based on the instance name.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The keyword used to match the instance name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>portalHost</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sshd</para>
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7985D471-3FA8-4EE9-8F4B-45C19DF3D36F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
