// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRefreshQuotaResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of Object Storage Service (OSS) buckets that can be refreshed each day.
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        /// <summary>
        /// The maximum number of directories of files that can be refreshed each day.
        /// </summary>
        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        /// <summary>
        /// The remaining number of directories of files that can be refreshed on the current day.
        /// </summary>
        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs of files that can be prefetched each day.
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs of files that can be prefetched on the current day.
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum number of URLs of files that can be refreshed each day.
        /// </summary>
        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs of files that can be refreshed on the current day.
        /// </summary>
        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

        /// <summary>
        /// The remaining number of OSS buckets that can be refreshed on the current day.
        /// </summary>
        [NameInMap("blockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

    }

}
