// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshVodObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the refresh task. Multiple IDs are separated by commas (,). Refresh tasks are merged based on the following rules:
        /// 
        /// If the tasks are set for the same accelerated domain name, submitted within the same second, and refresh content based on URLs instead of directories, the tasks IDs are merged into the same task ID (RefreshTaskId). If the number of these tasks exceeds 2,000, every 2,000 tasks IDs are merged into the same task ID (RefreshTaskId).
        /// </summary>
        [NameInMap("RefreshTaskId")]
        [Validation(Required=false)]
        public string RefreshTaskId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
