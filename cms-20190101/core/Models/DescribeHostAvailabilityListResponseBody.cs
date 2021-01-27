// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHostAvailabilityListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public DescribeHostAvailabilityListResponseBodyTaskList TaskList { get; set; }
        public class DescribeHostAvailabilityListResponseBodyTaskList : TeaModel {
            [NameInMap("NodeTaskConfig")]
            [Validation(Required=false)]
            public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig> NodeTaskConfig { get; set; }
            public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfig : TeaModel {
                public string TaskType { get; set; }
                public string GroupName { get; set; }
                public long? GroupId { get; set; }
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption TaskOption { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigTaskOption : TeaModel {
                    [NameInMap("HttpMethod")]
                    [Validation(Required=false)]
                    public string HttpMethod { get; set; }

                    [NameInMap("HttpURI")]
                    [Validation(Required=false)]
                    public string HttpURI { get; set; }

                    [NameInMap("TelnetOrPingHost")]
                    [Validation(Required=false)]
                    public string TelnetOrPingHost { get; set; }

                    [NameInMap("HttpResponseCharset")]
                    [Validation(Required=false)]
                    public string HttpResponseCharset { get; set; }

                    [NameInMap("HttpPostContent")]
                    [Validation(Required=false)]
                    public string HttpPostContent { get; set; }

                    [NameInMap("HttpNegative")]
                    [Validation(Required=false)]
                    public bool? HttpNegative { get; set; }

                    [NameInMap("HttpKeyword")]
                    [Validation(Required=false)]
                    public string HttpKeyword { get; set; }

                }
                public string TaskName { get; set; }
                public bool? Disabled { get; set; }
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig AlertConfig { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfig : TeaModel {
                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public int? EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public int? StartTime { get; set; }

                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public int? NotifyType { get; set; }

                    [NameInMap("EscalationList")]
                    [Validation(Required=false)]
                    public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList EscalationList { get; set; }
                    public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationList : TeaModel {
                        [NameInMap("escalationList")]
                        [Validation(Required=false)]
                        public List<DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList> EscalationList { get; set; }
                        public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigAlertConfigEscalationListEscalationList : TeaModel {
                            public string Value { get; set; }
                            public string MetricName { get; set; }
                            public string Times { get; set; }
                            public string Operator { get; set; }
                            public string Aggregate { get; set; }
                        }
                    };

                    [NameInMap("WebHook")]
                    [Validation(Required=false)]
                    public string WebHook { get; set; }

                }
                public string TaskScope { get; set; }
                public DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances Instances { get; set; }
                public class DescribeHostAvailabilityListResponseBodyTaskListNodeTaskConfigInstances : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<string> Instance { get; set; }

                }
                public long? Id { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
