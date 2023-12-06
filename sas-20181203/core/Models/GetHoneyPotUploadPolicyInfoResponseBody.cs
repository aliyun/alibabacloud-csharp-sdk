// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneyPotUploadPolicyInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneyPotUploadPolicyInfoResponseBodyData Data { get; set; }
        public class GetHoneyPotUploadPolicyInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The key ID that is required for the file upload.
            /// </summary>
            [NameInMap("Accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            /// <summary>
            /// The expiration time of the URL. The value is a timestamp. You can use the value to determine whether the URL expires. If the expiration time arrives, you can no longer use the URL to upload files.
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            /// <summary>
            /// The request URL during the upload.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The full path of the file in OSS. The file is uploaded by calling the OSS PostObject operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The limits that are imposed on the file upload. The limits include the file size.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The signature that is calculated based on **AccessKeySecret** and **Policy**. When you call an Object Storage Service (OSS) API operation, OSS uses the signature information to verify the POST request.
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
