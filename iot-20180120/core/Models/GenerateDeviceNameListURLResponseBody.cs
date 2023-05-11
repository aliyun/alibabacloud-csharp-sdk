// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateDeviceNameListURLResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information returned if the call is successful. For more information, see the following parameters:
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateDeviceNameListURLResponseBodyData Data { get; set; }
        public class GenerateDeviceNameListURLResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID of the bucket owner.
            /// 
            /// The OSS bucket stores the file.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The URL of the file that is stored in OSS.
            /// 
            /// After the device list file is uploaded, this parameter is used to call the [CreateOTAStaticUpgradeJob](~~147496~~) operation to create a static update batch.
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// The endpoint of OSS.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The full path of the file in OSS. You can call the OSS PostObject operation to upload the file to OSS.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The type of the object storage. Default value: OSS.
            /// </summary>
            [NameInMap("ObjectStorage")]
            [Validation(Required=false)]
            public string ObjectStorage { get; set; }

            /// <summary>
            /// The parameter that is used by OSS to verify form fields for the request.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The signature that is calculated based on **AccessKeySecret** and **Policy**. When you call an OSS operation, OSS uses the signature information to verify the POST request.
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// The time when the URL of the file that you want to upload was generated. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
