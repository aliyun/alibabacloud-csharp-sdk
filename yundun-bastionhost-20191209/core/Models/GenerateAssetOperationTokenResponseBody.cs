// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenResponseBody : TeaModel {
        [NameInMap("AssetOperationToken")]
        [Validation(Required=false)]
        public GenerateAssetOperationTokenResponseBodyAssetOperationToken AssetOperationToken { get; set; }
        public class GenerateAssetOperationTokenResponseBodyAssetOperationToken : TeaModel {
            [NameInMap("CountLeft")]
            [Validation(Required=false)]
            public long? CountLeft { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("HasCountLimit")]
            [Validation(Required=false)]
            public bool? HasCountLimit { get; set; }

            [NameInMap("MaxRenewCount")]
            [Validation(Required=false)]
            public long? MaxRenewCount { get; set; }

            [NameInMap("RenewCount")]
            [Validation(Required=false)]
            public long? RenewCount { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("TokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
