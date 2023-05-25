// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserUploadFileJobResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the file upload task.
        /// </summary>
        [NameInMap("UploadFileJobDetail")]
        [Validation(Required=false)]
        public GetUserUploadFileJobResponseBodyUploadFileJobDetail UploadFileJobDetail { get; set; }
        public class GetUserUploadFileJobResponseBodyUploadFileJobDetail : TeaModel {
            /// <summary>
            /// The key of the file that is returned after the file is uploaded. You can use this key when you upload the file as an attachment in a ticket.
            /// </summary>
            [NameInMap("AttachmentKey")]
            [Validation(Required=false)]
            public string AttachmentKey { get; set; }

            /// <summary>
            /// The name of the file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The size of the file. Unit: byte.
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// The purpose of the uploaded file. Valid values:
            /// 
            /// *   **datacorrect**: The file is uploaded to change data.
            /// *   **order_info_attachment**: The file is uploaded as an attachment in a ticket.
            /// *   **big-file**: The file is uploaded to import multiple data records at a time.
            /// *   **sqlreview**: The file is uploaded for SQL review.
            /// </summary>
            [NameInMap("FileSource")]
            [Validation(Required=false)]
            public string FileSource { get; set; }

            /// <summary>
            /// The key of the file upload task.
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// The status of the file upload task. Valid values:
            /// 
            /// *   **INIT**: The file upload task was initialized.
            /// *   **PENDING**: The file upload task waited to be run.
            /// *   **BE_SCHEDULED**: The file upload task waited to be scheduled.
            /// *   **FAIL**: The file upload task failed.
            /// *   **SUCCESS**: The file upload task was successful.
            /// *   **RUNNING**: The file upload task was being run.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The information about the status of the file upload task.
            /// </summary>
            [NameInMap("JobStatusDesc")]
            [Validation(Required=false)]
            public string JobStatusDesc { get; set; }

            /// <summary>
            /// The information about the Object Storage Service (OSS) bucket from which the file is uploaded.
            /// 
            /// > This parameter is returned if the value of **UploadType** is **OSS**.
            /// </summary>
            [NameInMap("UploadOSSParam")]
            [Validation(Required=false)]
            public GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam UploadOSSParam { get; set; }
            public class GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam : TeaModel {
                /// <summary>
                /// The name of the OSS bucket.
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The name of the OSS object.
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

            }

            /// <summary>
            /// The method used to upload the file. Valid values:
            /// 
            /// *   **URL**
            /// *   **OSS**
            /// </summary>
            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

            /// <summary>
            /// The URL of the file.
            /// 
            /// > This parameter is returned if the value of **UploadType** is **URL**.
            /// </summary>
            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            /// <summary>
            /// The size of the uploaded file. Unit: byte.
            /// </summary>
            [NameInMap("UploadedSize")]
            [Validation(Required=false)]
            public long? UploadedSize { get; set; }

        }

    }

}
