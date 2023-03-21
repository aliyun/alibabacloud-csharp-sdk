// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the parameters that are required to upload a file.
        /// </summary>
        [NameInMap("UploadUrlList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlResponseBodyUploadUrlList> UploadUrlList { get; set; }
        public class CreateFileDetectUploadUrlResponseBodyUploadUrlList : TeaModel {
            /// <summary>
            /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The signature information.
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public CreateFileDetectUploadUrlResponseBodyUploadUrlListContext Context { get; set; }
            public class CreateFileDetectUploadUrlResponseBodyUploadUrlListContext : TeaModel {
                /// <summary>
                /// The AccessKey ID that is used to access the OSS bucket.
                /// </summary>
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                /// <summary>
                /// The key of the file that is used after the file is uploaded to the OSS bucket.
                /// </summary>
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                /// <summary>
                /// The policy that poses limits on file upload. For example, the policy can limit the size of the file.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The signature that is used to upload the file.
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

            /// <summary>
            /// The timestamp when the values of the parameters expire. Unit: milliseconds.
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            /// <summary>
            /// Indicates whether the file exists in the cloud. Valid values:
            /// 
            /// *   **true**: The file exists in the cloud. You do not need to upload the file.
            /// *   **false**: The file does not exist in the cloud. You must upload the file.
            /// </summary>
            [NameInMap("FileExist")]
            [Validation(Required=false)]
            public bool? FileExist { get; set; }

            /// <summary>
            /// The identifier of the file.
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// The internal endpoint of the URL to which the file is uploaded.
            /// </summary>
            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The public endpoint of the URL to which the file is uploaded.
            /// </summary>
            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

        }

    }

}
