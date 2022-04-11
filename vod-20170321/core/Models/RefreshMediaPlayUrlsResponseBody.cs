// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsResponseBody : TeaModel {
        /// <summary>
        /// 没有多应用权限的视频ID
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public string ForbiddenMediaIds { get; set; }

        /// <summary>
        /// 刷新预热任务ID
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

        /// <summary>
        /// 不存在的媒资ID
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public string NonExistMediaIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
