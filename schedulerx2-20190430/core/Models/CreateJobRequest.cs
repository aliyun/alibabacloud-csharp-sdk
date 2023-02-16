// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// The interval at which the system attempts to rerun a job. Default value: 30. Unit: seconds.
        /// </summary>
        [NameInMap("AttemptInterval")]
        [Validation(Required=false)]
        public int? AttemptInterval { get; set; }

        /// <summary>
        /// When the Time type parameter is set to cron, you can specify a custom calendar.
        /// </summary>
        [NameInMap("Calendar")]
        [Validation(Required=false)]
        public string Calendar { get; set; }

        /// <summary>
        /// The full path of the job interface class.
        /// 
        /// This field is available only when you select a java job. In this case, you must enter a full path.
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
        /// The information of the job contact.
        /// </summary>
        [NameInMap("ContactInfo")]
        [Validation(Required=false)]
        public List<CreateJobRequestContactInfo> ContactInfo { get; set; }
        public class CreateJobRequestContactInfo : TeaModel {
            /// <summary>
            /// The webhook URL of the DingTalk chatbot. For more information, see [DingTalk development documentation](https://open.dingtalk.com/document/org/application-types).
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
        /// The script code content that is required when you set the job type to **python**, **shell**, or **go**.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// When the Time type parameter is set to cron, you can specify a time offset. Unit: seconds.
        /// </summary>
        [NameInMap("DataOffset")]
        [Validation(Required=false)]
        public int? DataOffset { get; set; }

        /// <summary>
        /// The description of the job.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Default value: 5. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("DispatcherSize")]
        [Validation(Required=false)]
        public int? DispatcherSize { get; set; }

        /// <summary>
        /// The execution mode of the job. The following execution modes are supported:
        /// 
        /// *   **standalone**: The job runs in standalone mode.
        /// *   **broadcast**: The job runs in broadcast mode.
        /// *   **parallel**: The job runs in parallel computing mode.
        /// *   **grid**: The job runs in memory grid mode.
        /// *   **batch**: The job runs in grid computing mode.
        /// *   **sharding**: The job runs in sharding mode.
        /// </summary>
        [NameInMap("ExecuteMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// Specifies whether to turn on Failure alarm. Valid values:
        /// 
        /// *   **true**: Turn on Failure alarm.
        /// *   **false**: Turn off Failure alarm.
        /// </summary>
        [NameInMap("FailEnable")]
        [Validation(Required=false)]
        public bool? FailEnable { get; set; }

        [NameInMap("FailTimes")]
        [Validation(Required=false)]
        public int? FailTimes { get; set; }

        /// <summary>
        /// The ID of the application. You can obtain the application ID on the Application Management page in Distributed Task Scheduling Platform.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The type of the job. The following job types are supported:
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
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The maximum number of attempts that the system can make when an error occurs on a job. You can specify this parameter based on your business requirements. Default value: 0.
        /// </summary>
        [NameInMap("MaxAttempt")]
        [Validation(Required=false)]
        public int? MaxAttempt { get; set; }

        /// <summary>
        /// The maximum number of instances that the system can run at the same time. Default value: 1. When you set this parameter to 1, if the current job does not end, the system will not run the next job even if the runtime is reached.
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Specifies whether to turn on No machine alarm available.
        /// 
        /// *   **true**: Turn on No machine alarm available.
        /// *   **false**: Turn off No machine alarm available.
        /// </summary>
        [NameInMap("MissWorkerEnable")]
        [Validation(Required=false)]
        public bool? MissWorkerEnable { get; set; }

        /// <summary>
        /// The name of the job.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the namespace. You can obtain the ID of the namespace on the Namespace page in Distributed Task Scheduling Platform.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The number of subtasks that can be pulled at a time. Default value: 100. This parameter is an advanced configuration item of MapReduce job.
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
        /// The maximum number of subtask queues that you can cache. Default value: 10000. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("QueueSize")]
        [Validation(Required=false)]
        public int? QueueSize { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The channel for sending alerts. Only SMS messages are supported. Set the value to sms.
        /// </summary>
        [NameInMap("SendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        /// <summary>
        /// 0: disabled. 1: enabled. Default value: 1.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SuccessNoticeEnable")]
        [Validation(Required=false)]
        public bool? SuccessNoticeEnable { get; set; }

        /// <summary>
        /// The interval at which the system can rerun the subtask when the subtask fails. Default value: 0. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("TaskAttemptInterval")]
        [Validation(Required=false)]
        public int? TaskAttemptInterval { get; set; }

        /// <summary>
        /// The number of retries that the system can perform when the subtask fails. Default value: 0. This parameter is an advanced configuration item of the MapReduce job.
        /// </summary>
        [NameInMap("TaskMaxAttempt")]
        [Validation(Required=false)]
        public int? TaskMaxAttempt { get; set; }

        /// <summary>
        /// The time expression. You can set the time expression according to the selected time type.
        /// 
        /// *   **cron**: Specify a standard Cron expression. You can verify the expression online after you specify the expression.
        /// *   **api**: No time expression is available.
        /// *   **fixed_rate**: Specify a fixed frequency value. Unit: seconds. For example, if you set this parameter to 30, the system triggers a job every 30 seconds.
        /// *   **second_delay**: Specify a delay after which you can run a job. You can specify a value from 1 to 60. Unit: seconds.
        /// *   **one_time**: Specify a time in the format of yyyy-MM-dd HH:mm:ss or specify a timestamp in milliseconds. Example: 2022-10-10 10:10:00.
        /// </summary>
        [NameInMap("TimeExpression")]
        [Validation(Required=false)]
        public string TimeExpression { get; set; }

        /// <summary>
        /// The type of time. The following time types are supported:
        /// 
        /// *   **cron**: 1
        /// *   **fixed_rate**: 3
        /// *   **second_delay**: 4
        /// *   **one_time**: 5
        /// *   **api**: 100
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
        /// Specifies whether to turn on Timeout alarm. Valid values:
        /// 
        /// *   **true**: Turn on Timeout alarm.
        /// *   **false**: Turn off Timeout alarm.
        /// </summary>
        [NameInMap("TimeoutEnable")]
        [Validation(Required=false)]
        public bool? TimeoutEnable { get; set; }

        /// <summary>
        /// Specifies whether to turn on Timeout termination. Valid values:
        /// 
        /// *   **true**: Turn on Timeout termination.
        /// *   **false**: Turn off Timeout termination.
        /// </summary>
        [NameInMap("TimeoutKillEnable")]
        [Validation(Required=false)]
        public bool? TimeoutKillEnable { get; set; }

        /// <summary>
        /// If the Task type parameter is set to k8s, this parameter is required. xxljob task: {"resource":"job"} shell task: {"image":"busybox","resource":"shell"}
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
