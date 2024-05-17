// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the jobs.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The jobs and their details.
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataJobs> Jobs { get; set; }
            public class ListJobsResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// The interval at which the system retries to run the job after a job failure. Unit: seconds. Default value: 30.
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// The full path of the job interface class. This parameter is returned only for a Java job.
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// The script of the job. This parameter is returned only for a Python, Shell, or Go job.
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
                /// *   **standalone**: The job runs in standalone mode.
                /// *   **broadcast**: The job runs in broadcast mode.
                /// *   **parallel**: The job runs in parallel computing mode.
                /// *   **grid**: The job runs in memory grid mode.
                /// *   **batch**: The job runs in grid computing mode.
                /// *   **shard**: The job runs in multipart mode.
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public string ExecuteMode { get; set; }

                /// <summary>
                /// The full path to which a JAR package is uploaded in Object Storage Service (OSS).
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
                public ListJobsResponseBodyDataJobsJobMonitorInfo JobMonitorInfo { get; set; }
                public class ListJobsResponseBodyDataJobsJobMonitorInfo : TeaModel {
                    /// <summary>
                    /// The contact information.
                    /// </summary>
                    [NameInMap("ContactInfo")]
                    [Validation(Required=false)]
                    public List<ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo> ContactInfo { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoContactInfo : TeaModel {
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
                        /// The username.
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
                    /// The configurations of the alerting feature and the alert threshold.
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig MonitorConfig { get; set; }
                    public class ListJobsResponseBodyDataJobsJobMonitorInfoMonitorConfig : TeaModel {
                        /// <summary>
                        /// Indicates whether the feature of generating an alert upon a failure is enabled. Valid values:
                        /// 
                        /// *   **true**: The feature is enabled.
                        /// *   **false**: The feature is disabled.
                        /// </summary>
                        [NameInMap("FailEnable")]
                        [Validation(Required=false)]
                        public bool? FailEnable { get; set; }

                        /// <summary>
                        /// Indicates whether the feature of generating an alert when no machine is available for running the job is enabled.
                        /// </summary>
                        [NameInMap("MissWorkerEnable")]
                        [Validation(Required=false)]
                        public bool? MissWorkerEnable { get; set; }

                        /// <summary>
                        /// The method that is used to send an alert notification. Only Short Message Service (SMS) is supported.
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
                        /// Indicates whether the feature of generating an alert upon a timeout is enabled. Valid values:
                        /// 
                        /// *   **true**: The feature is enabled.
                        /// *   **false**: The feature is disabled.
                        /// </summary>
                        [NameInMap("TimeoutEnable")]
                        [Validation(Required=false)]
                        public bool? TimeoutEnable { get; set; }

                        /// <summary>
                        /// Indicates whether the feature of stopping job triggering upon a timeout is enabled. By default, the feature is disabled.
                        /// 
                        /// *   **true**: The feature is enabled.
                        /// *   **false**: The feature is disabled.
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
                /// The advanced configurations of the job. The parameters are returned only if the value of the ExecuteMode parameter is parallel, grid, or batch.
                /// </summary>
                [NameInMap("MapTaskXAttrs")]
                [Validation(Required=false)]
                public ListJobsResponseBodyDataJobsMapTaskXAttrs MapTaskXAttrs { get; set; }
                public class ListJobsResponseBodyDataJobsMapTaskXAttrs : TeaModel {
                    /// <summary>
                    /// The number of threads that are triggered by a standalone job at a time. Default value: 5.
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
                    /// The number of tasks that are pulled by a parallel job at a time. Default value: 100.
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// The maximum number of task queues that can be cached. Default value: 10000.
                    /// </summary>
                    [NameInMap("QueueSize")]
                    [Validation(Required=false)]
                    public int? QueueSize { get; set; }

                    /// <summary>
                    /// The interval at which the system retries to run the task after a task failure.
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
                /// The maximum number of instances that can concurrently run for the job. Default value: 1. A value of 1 indicates that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the instance is reached.
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
                /// Indicates whether the job is enabled. Valid values:
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
                public ListJobsResponseBodyDataJobsTimeConfig TimeConfig { get; set; }
                public class ListJobsResponseBodyDataJobsTimeConfig : TeaModel {
                    /// <summary>
                    /// If the TimeType parameter is set to cron, you can specify custom calendar days.
                    /// </summary>
                    [NameInMap("Calendar")]
                    [Validation(Required=false)]
                    public string Calendar { get; set; }

                    /// <summary>
                    /// The time offset if the TimeType parameter is set to cron. Unit: seconds.
                    /// </summary>
                    [NameInMap("DataOffset")]
                    [Validation(Required=false)]
                    public int? DataOffset { get; set; }

                    /// <summary>
                    /// The time expression. Valid values:
                    /// 
                    /// *   **api**: indicates that no time expression is used to specify the time when to schedule the job.
                    /// *   **fix_rate**: indicates that the job is triggered at a fixed frequency. For example, a value of 30 indicates that the job is triggered every 30 seconds.
                    /// *   **cron**: indicates that a standard CRON expression is used to specify the time when to schedule the job.
                    /// *   **second_delay**: indicates that the job is triggered after a fixed delay. Valid values: 1 to 60. Unit: seconds.
                    /// </summary>
                    [NameInMap("TimeExpression")]
                    [Validation(Required=false)]
                    public string TimeExpression { get; set; }

                    /// <summary>
                    /// The method that is used to specify the time when to schedule the job. Valid values:
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
        /// The error message that is returned if an error occurs.
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
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
