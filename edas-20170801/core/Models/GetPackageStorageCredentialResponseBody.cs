// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetPackageStorageCredentialResponseBody : TeaModel {
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public GetPackageStorageCredentialResponseBodyCredential Credential { get; set; }
        public class GetPackageStorageCredentialResponseBodyCredential : TeaModel {
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
