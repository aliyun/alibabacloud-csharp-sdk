// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of URLs that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of times that you can prefetch content to L2 points of presence (POPs) on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs or directories with parameters ignored that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public string IgnoreParamsQuota { get; set; }

        /// <summary>
        /// <para>The number of remaining URLs or directories that can be refreshed with parameters ignored on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IgnoreParamsRemain")]
        [Validation(Required=false)]
        public string IgnoreParamsRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of directories that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PreloadEdgeQuota")]
        [Validation(Required=false)]
        public string PreloadEdgeQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of times that you can prefetch content to L1 POPs on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PreloadEdgeRemain")]
        [Validation(Required=false)]
        public string PreloadEdgeRemain { get; set; }

        /// <summary>
        /// <para>The remaining number of times that you can prefetch content to L1 POPs on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of times that you can prefetch content to L1 nodes on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of times that you can prefetch content to L2 POPs on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RegexQuota")]
        [Validation(Required=false)]
        public string RegexQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be blocked on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RegexRemain")]
        [Validation(Required=false)]
        public string RegexRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs and directories that can be blocked on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42E0554B-80F4-4921-AED6-ACFB22CAAAD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The remaining number of directories that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs or directories that can be refreshed by using regular expressions on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1996</para>
        /// </summary>
        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

    }

}
