// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the job.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The configurations of the job.
            /// </summary>
            [NameInMap("JobConfigInfo")]
            [Validation(Required=false)]
            public GetJobInfoResponseBodyDataJobConfigInfo JobConfigInfo { get; set; }
            public class GetJobInfoResponseBodyDataJobConfigInfo : TeaModel {
                /// <summary>
                /// The interval at which the system retried to run the job after a job failure. Default value: 30. Unit: seconds.
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// The full path of the job interface class. This parameter is returned only for jobs whose job type is Java.
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// The script of a script job.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The description of the job.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The execution mode of the job. Valid values:
                /// 
                /// *   **Stand-alone operation**
                /// *   **Broadcast run**
                /// *   **Visual MapReduce**
                /// *   **MapReduce**
                /// *   ****
                /// *   **Shard run**
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// The full path used to upload files to Object Storage Service (OSS).
                /// 
                /// If you use a JAR package, you can upload the JAR package to this OSS path.
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// The monitoring information of the job.
                /// </summary>
                [NameInMap("JobMonitorInfo")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo JobMonitorInfo { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfo : TeaModel {
                    /// <summary>
                    /// The alert contact Information.
                    /// </summary>
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoContactInfo : TeaModel {
                        /// <summary>
                        /// The webhook URL of the DingTalk chatbot.
                        /// </summary>
                        [NameInMap("Ding")]
                        [Validation(Required=false)]
                        public string Ding { get; set; }

                        /// <summary>
                        /// The email address of the alert contact.
                        /// </summary>
                        [NameInMap("UserMail")]
                        [Validation(Required=false)]
                        public string UserMail { get; set; }

                        /// <summary>
                        /// The name of the alert contact.
                        /// </summary>
                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public string UserName { get; set; }

                        /// <summary>
                        /// The mobile phone number of the alert contact.
                        /// </summary>
                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    /// <summary>
                    /// The configurations of the alerting features and the alert thresholds.
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// Indicates whether the Failure alarm switch was turned on. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// Indicates whether the No machine alarm available switch was turned on.
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// The method used to send alerts. Only Short Message Service (SMS) is supported.
                        /// </summary>
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }

                        /// <summary>
                        /// The timeout threshold. Default value: 7200. Unit: seconds.
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// Indicates whether the Timeout alarm switch was turned on. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// Indicates whether the Timeout termination switch was turned on. The switch is turned off by default.
                        /// </summary>
                        [NameInMap("TimeoutKillEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutKillEnable { get; set; }

                    }

                }

                /// <summary>
                /// The job type.
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// The advanced configurations of the job.
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// The number of threads that were triggered by a single worker at a time. Default value: 5.
                    /// </summary>
                    [NameInMap("ConsumerSize")]
                    [Validation(Required=false)]
                    public int? ConsumerSize { get; set; }

                    /// <summary>
                    /// The number of task distribution threads. Default value: 5.
                    /// </summary>
                    [NameInMap("DispatcherSize")]
                    [Validation(Required=false)]
                    public int? DispatcherSize { get; set; }

                    /// <summary>
                    /// The number of tasks that were pulled by a parallel job at a time. Default value: 100.
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// The maximum number of tasks that can be queued. Default value: 10000.
                    /// </summary>
                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    /// <summary>
                    /// The interval at which the system retried to run the task after a task failure.
                    /// </summary>
                    [NameInMap("TaskAttemptInterval")]
                    [Validation(Required=false)]
                    public int? TaskAttemptInterval { get; set; }

                    /// <summary>
                    /// The number of retries after a task failure.
                    /// </summary>
                    [NameInMap("TaskMaxAttempt")]
                    [Validation(Required=false)]
                    public int? TaskMaxAttempt { get; set; }

                }

                /// <summary>
                /// The maximum number of retries after a job failure. This parameter was specified based on your business requirements. Default value: 0.
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// The maximum number of concurrent instances. Default value: 1. The default value indicates that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the next instance is reached.
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// The job name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The user-defined parameters that you can obtain when the job is running.
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// Indicates whether the job was enabled. Valid values:
                /// 
                /// *   **1**: The job was enabled and could be triggered.
                /// *   **0**: The job was disabled and could not be triggered.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The time configurations.
                /// </summary>
                [NameInMap("TimeConfig")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoTimeConfig TimeConfig { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoTimeConfig : TeaModel {
                    /// <summary>
                    /// Custom calendar days specified if TimeType is set to **1** (cron).
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// The time offset specified if TimeType is set to **1** (cron). Unit: seconds.
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// The time expression specified based on the value of TimeType:
                    /// 
                    /// *   If TimeType is set to **100** (api), no time expression is required.
                    /// *   If TimeType is set to **3** (fix_rate), this parameter value indicates the specific and fixed frequency. For example, if the value is 30, the system triggers a job every 30 seconds.
                    /// *   If TimeType is set to **1** (cron), this parameter value indicates the standard CRON expression used to specify the time when to schedule the job.
                    /// *   If TimeType is set to **4** (second_delay), this parameter value indicates the fixed delay after which the job is triggered. Valid values: 1 to 60. Unit: seconds.
                    /// </summary>
                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    /// <summary>
                    /// The time type. Valid values:
                    /// 
                    /// *   **1**: cron
                    /// *   **3**: fix_rate
                    /// *   **4**: second_delay
                    /// *   **5**: one_time
                    /// *   **100**: api
                    /// </summary>
                    [NameInMap("TimeType")]
                    [Validation(Required=false)]
                    public int? TimeType { get; set; }

                }

                /// <summary>
                /// The extended fields.
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

        }

        /// <summary>
        /// The error message returned only if an error occurs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the job details were obtained. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
