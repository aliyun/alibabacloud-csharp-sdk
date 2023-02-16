// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
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
                /// The interval at which the system retries to run the job after a job failure. Unit: seconds. Default value: 30.
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
                /// *   **standalone**
                /// *   **broadcast**
                /// *   **parallel**
                /// *   **grid**
                /// *   **batch**
                /// *   **shard**
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// The full path that is used to upload files to Object Storage Service (OSS).
                /// 
                /// If you use a JAR package, you can upload the JAR package to this OSS path.
                /// </summary>
                [NameInMap("JarUrl")]
                [Validation(Required=false)]
                public string JarUrl { get; set; }

                /// <summary>
                /// The ID of the job.
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
                    /// The contact Information.
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
                        /// The email address of the user.
                        /// </summary>
                        [NameInMap("UserMail")]
                        [Validation(Required=false)]
                        public string UserMail { get; set; }

                        /// <summary>
                        /// The name of the user.
                        /// </summary>
                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public string UserName { get; set; }

                        /// <summary>
                        /// The mobile number of the user.
                        /// </summary>
                        [NameInMap("UserPhone")]
                        [Validation(Required=false)]
                        public string UserPhone { get; set; }

                    }

                    /// <summary>
                    /// The configurations of the alerting feature and alert thresholds.
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class GetJobInfoResponseBodyDataJobConfigInfoJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// Indicates whether an alert is generated upon a failure. Valid values:
                        /// 
                        /// *   **true**: The feature is enabled.
                        /// *   **false**: The feature is disabled.
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// Indicates whether an alert is generated if no worker is available.
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// The notification method. Only Short Message Service (SMS) is supported.
                        /// </summary>
                        [NameInMap("SendChannel")]
                        [Validation(Required=false)]
                        public string SendChannel { get; set; }

                        /// <summary>
                        /// The timeout threshold. Unit: seconds. Default value: 7200.
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public long? Timeout { get; set; }

                        /// <summary>
                        /// Indicates whether an alert is generated upon a timeout. Valid values:
                        /// 
                        /// *   **true**: The feature is enabled.
                        /// *   **false**: The feature is disabled.
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// Indicates whether the job is terminated upon a timeout. By default, this feature is disabled.
                        /// </summary>
                        [NameInMap("TimeoutKillEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutKillEnable { get; set; }

                    }

                }

                /// <summary>
                /// The type of the job.
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// The advanced configurations of the job. The parameters are returned only if the execution mode of the job is parallel, grid, or batch.
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class GetJobInfoResponseBodyDataJobConfigInfoMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// The number of threads that are triggered by an instance. Default value: 5.
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
                    /// The number of tasks that are returned for a parallel job at a time. Default value: 100.
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
                    /// The retry interval of the task after a task failure.
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
                /// The maximum number of retries after a job failure. This parameter is specified based on your business requirements. Default value: 0.
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// The maximum number of concurrent instances. Default value: 1. A value of 1 indicates that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the next instance is reached.
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public string MaxConcurrency { get; set; }

                /// <summary>
                /// The name of the job.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The user-defined parameters. These parameters can be obtained when the job is running.
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// The status of the job. Valid values:
                /// 
                /// *   **1**: The job is enabled and can be triggered.
                /// *   **0**: The job is disabled and cannot be triggered.
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
                    /// If the TimeType parameter is set to **1** (cron), you can customize the calendar.
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// If the TimeType parameter is set to **1** (cron), you can configure the time offset. Unit: seconds.
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// The time expression. The time expression varies with the time type:
                    /// 
                    /// *   **api**: No time expression exists.
                    /// *   **fix_rate**: a specific fixed frequency. For example, a value of 30 indicates that the job is triggered every 30 seconds.
                    /// *   **cron**: a standard Cron expression.
                    /// *   **second_delay**: a fixed delay after which the job is triggered. Valid values: 1 to 60. Unit: seconds.
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
        /// The error message that is returned only when an error occurs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the job details are obtained. Valid values:
        /// 
        /// *   **true**: The job details are obtained.
        /// *   **false**: Failed to obtain the job details.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
