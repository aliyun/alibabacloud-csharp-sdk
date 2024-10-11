// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRefreshQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of Object Storage Service (OSS) buckets that can be refreshed each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public string BlockQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of directories of files that can be refreshed each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DirQuota")]
        [Validation(Required=false)]
        public string DirQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of directories of files that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("DirRemain")]
        [Validation(Required=false)]
        public string DirRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs of files that can be prefetched each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public string PreloadQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs of files that can be prefetched on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public string PreloadRemain { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42E0554B-80F4-4921-****-ACFB22CAAAD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs of files that can be refreshed each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("UrlQuota")]
        [Validation(Required=false)]
        public string UrlQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs of files that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1996</para>
        /// </summary>
        [NameInMap("UrlRemain")]
        [Validation(Required=false)]
        public string UrlRemain { get; set; }

        /// <summary>
        /// <para>The remaining number of OSS buckets that can be refreshed on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("blockRemain")]
        [Validation(Required=false)]
        public string BlockRemain { get; set; }

    }

}
