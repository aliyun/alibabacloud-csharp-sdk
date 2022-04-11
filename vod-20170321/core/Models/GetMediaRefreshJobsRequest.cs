// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsRequest : TeaModel {
        /// <summary>
        /// 媒资ID
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 媒资刷新预热任务ID
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

    }

}
