// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshQuotaResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of URLs that can be refreshed on the current day.
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        /// <summary>
        /// The remaining number of times that you can prefetch content to L2 points of presence (POPs) on the current day.
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be refreshed on the current day.
        /// </summary>
        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs or directories with parameters ignored that can be refreshed on the current day.
        /// </summary>
        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public string IgnoreParamsQuota { get; set; }

        /// <summary>
        /// The number of remaining URLs or directories that can be refreshed with parameters ignored on the current day.
        /// </summary>
        [NameInMap("IgnoreParamsRemain")]
        [Validation(Required=false)]
        public string IgnoreParamsRemain { get; set; }

        /// <summary>
        /// The maximum number of directories that can be refreshed on the current day.
        /// </summary>
        [NameInMap("PreloadEdgeQuota")]
        [Validation(Required=false)]
        public string PreloadEdgeQuota { get; set; }

        /// <summary>
        /// The maximum number of times that you can prefetch content to L1 POPs on the current day.
        /// </summary>
        [NameInMap("PreloadEdgeRemain")]
        [Validation(Required=false)]
        public string PreloadEdgeRemain { get; set; }

        /// <summary>
        /// The remaining number of times that you can prefetch content to L1 POPs on the current day.
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        /// <summary>
        /// The maximum number of times that you can prefetch content to L1 nodes on the current day.
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        /// <summary>
        /// The maximum number of times that you can prefetch content to L2 POPs on the current day.
        /// </summary>
        [NameInMap("RegexQuota")]
        [Validation(Required=false)]
        public string RegexQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs that can be blocked on the current day.
        /// </summary>
        [NameInMap("RegexRemain")]
        [Validation(Required=false)]
        public string RegexRemain { get; set; }

        /// <summary>
        /// The maximum number of URLs and directories that can be blocked on the current day.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The remaining number of directories that can be refreshed on the current day.
        /// </summary>
        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        /// <summary>
        /// The remaining number of URLs or directories that can be refreshed by using regular expressions on the current day.
        /// </summary>
        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

    }

}
