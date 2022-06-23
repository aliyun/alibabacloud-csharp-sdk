// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AssetsListAssetsResponse : TeaModel {
        /// <summary>
        /// Asset列表
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<CommonAsset> Assets { get; set; }

        /// <summary>
        /// 分页Token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
