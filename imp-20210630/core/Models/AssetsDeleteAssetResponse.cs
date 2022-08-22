// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AssetsDeleteAssetResponse : TeaModel {
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public CommonAsset Asset { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public RpcStatus Status { get; set; }

    }

}
