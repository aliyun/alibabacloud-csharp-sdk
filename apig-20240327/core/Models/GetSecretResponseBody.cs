// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetSecretResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSecretResponseBodyData Data { get; set; }
        public class GetSecretResponseBodyData : TeaModel {
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("gatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            [NameInMap("kmsConfig")]
            [Validation(Required=false)]
            public KMSConfig KmsConfig { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("referenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            [NameInMap("secretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            [NameInMap("secretSource")]
            [Validation(Required=false)]
            public string SecretSource { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
