// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataJobs> Jobs { get; set; }
            public class ListJobsResponseBodyDataJobs : TeaModel {
                public int? AttemptInterval { get; set; }
                public string ClassName { get; set; }
                public string Content { get; set; }
                public string Description { get; set; }
                public string ExecuteMode { get; set; }
                public string JarUrl { get; set; }
                public long? JobId { get; set; }
                public ListJobsResponseBodyDataJobsJobMonitorInfo JobMonitorInfo { get; set; }
                public class ListJobsResponseBodyDataJobsJobMonitorInfo : TeaModel {
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo : TeaModel {
                        [NameInMap("Ding")]
                        [Validation(Required=false)]
                        public string Ding { get; set; }

                        [NameInMap("UserMail")]
                        [Validation(Required=false)]
                        public string UserMail { get; set; }

                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public string UserName { get; set; }

                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig : TeaModel {
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }
                        [NameInMap("TimeoutKillEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutKillEnable { get; set; }
                    };

                }
                public ListJobsResponseBodyDataJobsMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class ListJobsResponseBodyDataJobsMapTaskXAttrs : TeaModel {
                    [NameInMap("ConsumerSize")]
                    [Validation(Required=false)]
                    public int? ConsumerSize { get; set; }

                    [NameInMap("DispatcherSize")]
                    [Validation(Required=false)]
                    public int? DispatcherSize { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    [NameInMap("TaskAttemptInterval")]
                    [Validation(Required=false)]
                    public int? TaskAttemptInterval { get; set; }

                    [NameInMap("TaskMaxAttempt")]
                    [Validation(Required=false)]
                    public int? TaskMaxAttempt { get; set; }

                }
                public int? MaxAttempt { get; set; }
                public string MaxConcurrency { get; set; }
                public string Name { get; set; }
                public string Parameters { get; set; }
                public int? Status { get; set; }
                public ListJobsResponseBodyDataJobsTimeConfig TimeConfig { get; set; }
                public class ListJobsResponseBodyDataJobsTimeConfig : TeaModel {
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    [NameInMap("TimeType")]
                    [Validation(Required=false)]
                    public int? TimeType { get; set; }

                }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
