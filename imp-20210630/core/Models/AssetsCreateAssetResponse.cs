// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AssetsCreateAssetResponse : TeaModel {
        /// <summary>
        /// 资产信息
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public CommonAsset Asset { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 响应状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public RpcStatus Status { get; set; }

    }

}
