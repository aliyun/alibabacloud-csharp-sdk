// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSnapshotUrlsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 截图URL
        /// </summary>
        [NameInMap("SnapshotUrls")]
        [Validation(Required=false)]
        public List<string> SnapshotUrls { get; set; }

        /// <summary>
        /// 截图总数量
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// WebVTT文件URL
        /// </summary>
        [NameInMap("WebVTTUrl")]
        [Validation(Required=false)]
        public string WebVTTUrl { get; set; }

    }

}
