// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The job templates.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The job templates.
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataApplications> Applications { get; set; }
            public class ListJobsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// The number of running instances.
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// The description of the job template.
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                /// <summary>
                /// The ID of the job template.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the job template.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The time when the job was last completed.
                /// </summary>
                [NameInMap("CompletionTime")]
                [Validation(Required=false)]
                public long? CompletionTime { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The number of instances that failed to run.
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// Indicates whether the latest change order was executed. Valid values:
                /// 
                /// *   **0**: The latest change order failed to be executed.
                /// *   **1**: The latest change order was executed.
                /// </summary>
                [NameInMap("LastChangeorderState")]
                [Validation(Required=false)]
                public string LastChangeorderState { get; set; }

                /// <summary>
                /// The running status of the latest job. Valid values:
                /// 
                /// *   **0**: The job is not executed.
                /// *   **1**: The job was executed.
                /// *   **2**: The job failed to be executed.
                /// *   **3**: The job is being executed.
                /// </summary>
                [NameInMap("LastJobState")]
                [Validation(Required=false)]
                public string LastJobState { get; set; }

                /// <summary>
                /// The time when the job was last started.
                /// </summary>
                [NameInMap("LastStartTime")]
                [Validation(Required=false)]
                public long? LastStartTime { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The namespace ID.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of instances that were successfully run.
                /// </summary>
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

                /// <summary>
                /// Indicates whether the job template is suspended.
                /// </summary>
                [NameInMap("Suspend")]
                [Validation(Required=false)]
                public bool? Suspend { get; set; }

                /// <summary>
                /// The tag of the job template.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListJobsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListJobsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public string TriggerConfig { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of job templates.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, **ErrorCode** is not returned.
        /// *   If the call fails, **ErrorCode** is returned. For more information, see the "**Error codes**" section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the applications were obtained. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of job templates.
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
