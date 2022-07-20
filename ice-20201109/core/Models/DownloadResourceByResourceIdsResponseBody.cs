// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DownloadResourceByResourceIdsResponseBody : TeaModel {
        /// <summary>
        /// 过期时间
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 资源地址
        /// </summary>
        [NameInMap("ResourcePackageUrl")]
        [Validation(Required=false)]
        public string ResourcePackageUrl { get; set; }

    }

}
