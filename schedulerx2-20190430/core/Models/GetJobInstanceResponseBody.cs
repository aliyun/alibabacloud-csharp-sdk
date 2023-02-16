// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInstanceResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the job instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInstanceResponseBodyData Data { get; set; }
        public class GetJobInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the job instance.
            /// </summary>
            [NameInMap("JobInstanceDetail")]
            [Validation(Required=false)]
            public GetJobInstanceResponseBodyDataJobInstanceDetail JobInstanceDetail { get; set; }
            public class GetJobInstanceResponseBodyDataJobInstanceDetail : TeaModel {
                /// <summary>
                /// The data time.
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// The end time of the job execution.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The user who executes the job.
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// The ID of the job instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// The progress of the job instance.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The execution results of the job instance.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// The scheduled time of the job.
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// The start time of the job execution.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the job instance. Valid values:
                /// 
                /// *   **1**: The job instance is waiting for execution.
                /// *   **3**: The job instance is running.
                /// *   **4**: The job instance is successful.
                /// *   **5**: The job instance fails.
                /// *   **9**: The job instance is rejected.
                /// 
                /// Enumeration class: com.alibaba.schedulerx.common.domain.InstanceStatus
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The method that is used to specify the time when to schedule the job instance. Valid values:
                /// 
                /// *   **1**: cron
                /// *   **3**: fix_rate
                /// *   **4**: second_delay
                /// *   **100**: api
                /// 
                /// Enumeration class: com.alibaba.schedulerx.common.domain.TimeType
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// The trigger type of the job instance. Valid values:
                /// 
                /// *   **1**: The job instance is triggered at the scheduled time.
                /// *   **2**: The job instance is triggered due to data update.
                /// *   **3**: The job instance is triggered by an API call.
                /// *   **4**: The job instance is triggered because it is manually rerun.
                /// *   **5**: The job instance is triggered because the system automatically reruns the job instance upon a system exception, such as a database exception.
                /// 
                /// Enumeration class: com.alibaba.schedulerx.common.domain.TriggerType
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

                /// <summary>
                /// The endpoint of the triggered client. The value is in the IP address:Port number format.
                /// </summary>
                [NameInMap("WorkAddr")]
                [Validation(Required=false)]
                public string WorkAddr { get; set; }

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
