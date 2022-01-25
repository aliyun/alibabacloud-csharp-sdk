// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            [NameInMap("JobConfigInfo")]
            [Validation(Required=false)]
            public GetJobInfoResponseBodyDataJobConfigInfo JobConfigInfo { get; set; }
            public class GetJobInfoResponseBodyDataJobConfigInfo : TeaModel {
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                [NameInMap("JobMonitorInfo")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo JobMonitorInfo { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo : TeaModel {
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo : TeaModel {
                        public string Ding { get; set; }
                        public string UserMail { get; set; }
                        public string UserName { get; set; }
                        public string UserPhone { get; set; }
                    }
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig : TeaModel {
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

                    }
                };

                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs : TeaModel {
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
                };

                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TimeConfig")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoTimeConfig TimeConfig { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoTimeConfig : TeaModel {
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
                };

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
