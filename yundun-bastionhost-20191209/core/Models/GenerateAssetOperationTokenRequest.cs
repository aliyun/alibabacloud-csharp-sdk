// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenRequest : TeaModel {
        [NameInMap("AssetAccountId")]
        [Validation(Required=false)]
        public string AssetAccountId { get; set; }

        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        [NameInMap("AssetAccountPassword")]
        [Validation(Required=false)]
        public string AssetAccountPassword { get; set; }

        [NameInMap("AssetAccountProtocolName")]
        [Validation(Required=false)]
        public string AssetAccountProtocolName { get; set; }

        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
