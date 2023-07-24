// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshQuotaResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of URLs that can be blocked.
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be blocked on the current day.
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

        /// <summary>
        /// The maximum number of directories that can be refreshed on the current day.
        /// </summary>
        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        /// <summary>
        /// The remaining number of directories that can be refreshed on the current day.
        /// </summary>
        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public string IgnoreParamsQuota { get; set; }

        [NameInMap("IgnoreParamsRemain")]
        [Validation(Required=false)]
        public string IgnoreParamsRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs that can be prefetched on the current day.
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be prefetched on the current day.
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs or directories that can be refreshed by using regular expressions on the current day.
        /// </summary>
        [NameInMap("RegexQuota")]
        [Validation(Required=false)]
        public string RegexQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs or directories that can be refreshed by using regular expressions on the current day.
        /// </summary>
        [NameInMap("RegexRemain")]
        [Validation(Required=false)]
        public string RegexRemain { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum number of URLs that can be refreshed on the current day.
        /// </summary>
        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be refreshed on the current day.
        /// </summary>
        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

    }

}
