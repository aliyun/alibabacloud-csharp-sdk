// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetTokenResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the token.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTokenResponseBodyData Data { get; set; }
        public class GetTokenResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID that is used to access OSS.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret used to access OSS.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The OSS bucket that is used to store the architecture image.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// The OSS endpoint.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The token that is used to access the Object Storage Service (OSS) bucket that stores the architecture image.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// The OSS bucket that is used to save data snapshots.
            /// </summary>
            [NameInMap("SnapshotBucket")]
            [Validation(Required=false)]
            public string SnapshotBucket { get; set; }

        }

        /// <summary>
        /// The returned message.
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

    }

}
