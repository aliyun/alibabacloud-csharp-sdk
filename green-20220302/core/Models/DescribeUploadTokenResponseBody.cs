// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUploadTokenResponseBodyData Data { get; set; }
        public class DescribeUploadTokenResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The bucket name.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The time when the file sharing link expires.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public int? Expiration { get; set; }

            /// <summary>
            /// The file prefix.
            /// </summary>
            [NameInMap("FileNamePrefix")]
            [Validation(Required=false)]
            public string FileNamePrefix { get; set; }

            /// <summary>
            /// the oss intranet point.
            /// </summary>
            [NameInMap("OssInternalEndPoint")]
            [Validation(Required=false)]
            public string OssInternalEndPoint { get; set; }

            /// <summary>
            /// the oss internet point.
            /// </summary>
            [NameInMap("OssInternetEndPoint")]
            [Validation(Required=false)]
            public string OssInternetEndPoint { get; set; }

            /// <summary>
            /// The security token.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
