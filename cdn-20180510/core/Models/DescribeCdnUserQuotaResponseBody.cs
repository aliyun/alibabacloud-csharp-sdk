// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of URLs and directories that can be blocked.
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public int? BlockQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs and directories that can be blocked.
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public int? BlockRemain { get; set; }

        /// <summary>
        /// The maximum number of accelerated domain names.
        /// </summary>
        [NameInMap("DomainQuota")]
        [Validation(Required=false)]
        public int? DomainQuota { get; set; }

        /// <summary>
        /// The maximum number of ignore params that can be refreshed.
        /// </summary>
        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public int? IgnoreParamsQuota { get; set; }

        /// <summary>
        /// The remaining number of ignore params that can be refreshed.
        /// </summary>
        [NameInMap("IgnoreParamsRemain")]
        [Validation(Required=false)]
        public int? IgnoreParamsRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs that can be prefetched.
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public int? PreloadQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be prefetched.
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public int? PreloadRemain { get; set; }

        /// <summary>
        /// The maximum number of directories that can be refreshed.
        /// </summary>
        [NameInMap("RefreshDirQuota")]
        [Validation(Required=false)]
        public int? RefreshDirQuota { get; set; }

        /// <summary>
        /// The remaining number of directories that can be refreshed.
        /// </summary>
        [NameInMap("RefreshDirRemain")]
        [Validation(Required=false)]
        public int? RefreshDirRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs that can be refreshed.
        /// </summary>
        [NameInMap("RefreshUrlQuota")]
        [Validation(Required=false)]
        public int? RefreshUrlQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be refreshed.
        /// </summary>
        [NameInMap("RefreshUrlRemain")]
        [Validation(Required=false)]
        public int? RefreshUrlRemain { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
