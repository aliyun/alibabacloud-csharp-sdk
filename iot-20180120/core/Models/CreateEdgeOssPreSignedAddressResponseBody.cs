// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeOssPreSignedAddressResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEdgeOssPreSignedAddressResponseBodyData Data { get; set; }
        public class CreateEdgeOssPreSignedAddressResponseBodyData : TeaModel {
            /// <summary>
            /// The URL of the OSS object.
            /// </summary>
            [NameInMap("OssAddress")]
            [Validation(Required=false)]
            public string OssAddress { get; set; }

            /// <summary>
            /// The pre-signed URL of the OSS object. For more information, see [OSS documentation](~~32016~~).
            /// </summary>
            [NameInMap("OssPreSignedAddress")]
            [Validation(Required=false)]
            public string OssPreSignedAddress { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call failed.
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
        /// Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
