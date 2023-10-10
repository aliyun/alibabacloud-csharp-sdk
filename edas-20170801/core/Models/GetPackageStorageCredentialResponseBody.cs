// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetPackageStorageCredentialResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The STS credential.
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public GetPackageStorageCredentialResponseBodyCredential Credential { get; set; }
        public class GetPackageStorageCredentialResponseBodyCredential : TeaModel {
            /// <summary>
            /// The AccessKey ID of your account.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret of your account.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The name of the OSS bucket.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// The time when the STS credential expires. Example: 2019-11-10T07:20:19Z.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// The object key prefix in Object Storage Service (OSS).
            /// </summary>
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }

            /// <summary>
            /// The private endpoint of OSS.
            /// </summary>
            [NameInMap("OssInternalEndpoint")]
            [Validation(Required=false)]
            public string OssInternalEndpoint { get; set; }

            /// <summary>
            /// The public endpoint of OSS.
            /// </summary>
            [NameInMap("OssPublicEndpoint")]
            [Validation(Required=false)]
            public string OssPublicEndpoint { get; set; }

            /// <summary>
            /// The VPC endpoint of OSS.
            /// </summary>
            [NameInMap("OssVpcEndpoint")]
            [Validation(Required=false)]
            public string OssVpcEndpoint { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The security token issued by STS.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// The message that is returned.
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
