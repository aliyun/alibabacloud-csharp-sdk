// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListExportZookeeperDataResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListExportZookeeperDataResponseBodyData> Data { get; set; }
        public class ListExportZookeeperDataResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the task.
            /// </summary>
            [NameInMap("ContentMap")]
            [Validation(Required=false)]
            public string ContentMap { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The type of the object that is exported. Valid values:
            /// 
            /// *   transactionLog: transaction logs
            /// *   snapshot: snapshots
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// The extension information that is in the JSON format. The extension information facilitates addition of parameters.
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the associated task at the underlying layer. This parameter is used only to troubleshoot failures.
            /// </summary>
            [NameInMap("KubeoneTaskIds")]
            [Validation(Required=false)]
            public string KubeoneTaskIds { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   CREATE: The task is being created.
            /// *   RUNNING: The task is being executed.
            /// *   FINISH: The task is completed.
            /// *   FAILED: The task failed.
            /// *   EXPIRE: The task has expired.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the task was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the \*\*%s\*\* variable in the **ErrMessage** parameter.
        /// 
        /// > If the return value of the **ErrMessage** parameter is **The Value of Input Parameter %s is not valid** and the return value of the **DynamicMessage** parameter is **DtsJobId**, the specified **DtsJobId** parameter is invalid.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
