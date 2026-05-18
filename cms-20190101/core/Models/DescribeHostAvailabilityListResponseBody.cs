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

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public DescribeHostAvailabilityListResponseBodyTaskList TaskList { get; set; }
        public class DescribeHostAvailabilityListResponseBodyTaskList : TeaModel {
            [NameInMap("NodeTaskConfig")]
            [Validation(Required=false)]
            public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig> NodeTaskConfig { get; set; }
            public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig AlertConfig { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public int? EndTime { get; set; }

                    [NameInMap("EscalationList")]
                    [Validation(Required=false)]
                    public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList EscalationList { get; set; }
                    public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList : TeaModel {
                        [NameInMap("escalationList")]
                        [Validation(Required=false)]
                        public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList> EscalationList { get; set; }
                        public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList : TeaModel {
                            [NameInMap("Aggregate")]
                            [Validation(Required=false)]
                            public string Aggregate { get; set; }

                            [NameInMap("MetricName")]
                            [Validation(Required=false)]
                            public string MetricName { get; set; }

                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public string Operator { get; set; }

                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public string Times { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public int? NotifyType { get; set; }

                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

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

                    [NameInMap("WebHook")]
                    [Validation(Required=false)]
                    public string WebHook { get; set; }

                }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances Instances { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<string> Instance { get; set; }

                }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskOption")]
                [Validation(Required=false)]
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption TaskOption { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption : TeaModel {
                    [NameInMap("HttpKeyword")]
                    [Validation(Required=false)]
                    public string HttpKeyword { get; set; }

                    [NameInMap("HttpMethod")]
                    [Validation(Required=false)]
                    public string HttpMethod { get; set; }

                    [NameInMap("HttpNegative")]
                    [Validation(Required=false)]
                    public bool? HttpNegative { get; set; }

                    [NameInMap("HttpPostContent")]
                    [Validation(Required=false)]
                    public string HttpPostContent { get; set; }

                    [NameInMap("HttpResponseCharset")]
                    [Validation(Required=false)]
                    public string HttpResponseCharset { get; set; }

                    [NameInMap("HttpURI")]
                    [Validation(Required=false)]
                    public string HttpURI { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("TelnetOrPingHost")]
                    [Validation(Required=false)]
                    public string TelnetOrPingHost { get; set; }

                }

                [NameInMap("TaskScope")]
                [Validation(Required=false)]
                public string TaskScope { get; set; }

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
