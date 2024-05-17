// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// The interval of retries after a job failure. Default value: 30. Unit: seconds.
        /// </summary>
        [NameInMap("AttemptInterval")]
        [Validation(Required=false)]
        public int? AttemptInterval { get; set; }

        /// <summary>
        /// If you set TimeType to 1 (cron), you can specify calendar days.
        /// </summary>
        [NameInMap("Calendar")]
        [Validation(Required=false)]
        public string Calendar { get; set; }

        /// <summary>
        /// The full path of the job interface class.
        /// 
        /// This parameter is available only when you set JobType to java. You must enter a full path.
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// The number of threads that are triggered by a single worker at a time. Default value: 5. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("ConsumerSize")]
        [Validation(Required=false)]
        public int? ConsumerSize { get; set; }

        /// <summary>
        /// The information about the alert contact.
        /// </summary>
        [NameInMap("ContactInfo")]
        [Validation(Required=false)]
        public List<CreateJobRequestContactInfo> ContactInfo { get; set; }
        public class CreateJobRequestContactInfo : TeaModel {
            /// <summary>
            /// The webhook URL of the DingTalk chatbot.[](https://open.dingtalk.com/document/org/application-types)
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
            /// The mobile number of the alert contact.
            /// </summary>
            [NameInMap("UserPhone")]
            [Validation(Required=false)]
            public string UserPhone { get; set; }

        }

        /// <summary>
        /// The script content. This parameter is required when you set JobType to python, shell, go, or k8s.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// If you set TimeType to 1 (cron), you can specify a time offset. Unit: seconds.
        /// </summary>
        [NameInMap("DataOffset")]
        [Validation(Required=false)]
        public int? DataOffset { get; set; }

        /// <summary>
        /// The job description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of task distribution threads. Default value: 5. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("DispatcherSize")]
        [Validation(Required=false)]
        public int? DispatcherSize { get; set; }

        /// <summary>
        /// The execution mode of the job. Valid values:
        /// 
        /// *   **Stand-alone operation**
        /// *   **Broadcast run**
        /// *   **Visual MapReduce**
        /// *   **MapReduce**
        /// *   **Shard run**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecuteMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// Specifies whether to turn on Failure alarm. If the switch is turned on, an alert will be generated upon a failure. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("FailEnable")]
        [Validation(Required=false)]
        public bool? FailEnable { get; set; }

        /// <summary>
        /// The number of consecutive failures. An alert will be received if the number of consecutive failures reaches the value of this parameter.
        /// </summary>
        [NameInMap("FailTimes")]
        [Validation(Required=false)]
        public int? FailTimes { get; set; }

        /// <summary>
        /// The application ID. You can obtain the application ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The job type. Valid values:
        /// 
        /// *   java
        /// *   python
        /// *   shell
        /// *   go
        /// *   http
        /// *   xxljob
        /// *   dataworks
        /// *   k8s
        /// *   springschedule
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The maximum number of retries after a job failure. Specify this parameter based on your business requirements. Default value: 0.
        /// </summary>
        [NameInMap("MaxAttempt")]
        [Validation(Required=false)]
        public int? MaxAttempt { get; set; }

        /// <summary>
        /// The maximum number of concurrent instances. Default value: 1. The default value indicates that only one instance is allowed to run at a time. When an instance is running, another instance is not triggered even if the scheduled time for running the instance is reached.
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Specifies whether to turn on No machine alarm available. If the switch is turned on, an alert will be generated when no machine is available for running the job. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("MissWorkerEnable")]
        [Validation(Required=false)]
        public bool? MissWorkerEnable { get; set; }

        /// <summary>
        /// The job name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The namespace source. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The number of tasks that can be pulled at a time. Default value: 100. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The user-defined parameters that you can obtain when the job is running.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The maximum number of tasks that can be queued. Default value: 10000. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("QueueSize")]
        [Validation(Required=false)]
        public int? QueueSize { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The method that is used to send alerts. Only Short Message Service (SMS) is supported. Default value: sms.
        /// </summary>
        [NameInMap("SendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        /// <summary>
        /// Specifies whether to enable the job. If this parameter is set to 0, the job is disabled. If this parameter is set to 1, the job is enabled. Default value: 1.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Specifies whether to turn on Successful notice. If the switch is turned on, a notice will be sent when a job succeeds.
        /// </summary>
        [NameInMap("SuccessNoticeEnable")]
        [Validation(Required=false)]
        public bool? SuccessNoticeEnable { get; set; }

        /// <summary>
        /// The interval of retries after a task failure. Default value: 0. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("TaskAttemptInterval")]
        [Validation(Required=false)]
        public int? TaskAttemptInterval { get; set; }

        /// <summary>
        /// The number of retries after a task failure. Default value: 0. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("TaskMaxAttempt")]
        [Validation(Required=false)]
        public int? TaskMaxAttempt { get; set; }

        /// <summary>
        /// The time expression. Specify the time expression based on the value of TimeType:
        /// 
        /// *   If you set TimeType to **1** (cron), specify this parameter to a standard CRON expression.
        /// *   If you set TimeType to **100** (api), no time expression is required.
        /// *   If you set TimeType to **3** (fixed_rate), specify this parameter to a fixed frequency in seconds. For example, if you set this parameter to 30, the system triggers a job every 30 seconds.
        /// *   If you set TimeType to **4** (second_delay), specify this parameter to a fixed delay after which the job is triggered. Valid values: 1 to 60. Unit: seconds.
        /// *   If you set TimeType to **5** (one_time), specify this parameter to a specific time point at which the job is triggered. The time is in the format of yyyy-MM-dd HH:mm:ss, such as 2022-10-10 10:10:00, or a timestamp in milliseconds.
        /// </summary>
        [NameInMap("TimeExpression")]
        [Validation(Required=false)]
        public string TimeExpression { get; set; }

        /// <summary>
        /// The time type. Valid values:
        /// 
        /// *   **1**: cron
        /// *   **3**: fixed_rate
        /// *   **4**: second_delay
        /// *   **5**: one_time
        /// *   **100**: api
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

        /// <summary>
        /// The timeout threshold. Default value: 7200. Unit: seconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// Specifies whether to turn on Timeout alarm. If the switch is turned on, an alert will be generated upon a timeout. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("TimeoutEnable")]
        [Validation(Required=false)]
        public bool? TimeoutEnable { get; set; }

        /// <summary>
        /// Specifies whether to turn on Timeout termination. If the switch is turned on, the job will be terminated upon a timeout. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("TimeoutKillEnable")]
        [Validation(Required=false)]
        public bool? TimeoutKillEnable { get; set; }

        /// <summary>
        /// Time zone.
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// If you set JobType to k8s, this parameter is required. xxljob task: {"resource":"job"} shell task: {"image":"busybox","resource":"shell"}
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
