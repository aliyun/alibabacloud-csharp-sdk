// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of URLs and directories that can be blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public int? BlockQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs and directories that can be blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public int? BlockRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of accelerated domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DomainQuota")]
        [Validation(Required=false)]
        public int? DomainQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of ignore params that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public int? IgnoreParamsQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of ignore params that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IgnoreParamsRemain")]
        [Validation(Required=false)]
        public int? IgnoreParamsRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs that can be prefetched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PreloadQuota")]
        [Validation(Required=false)]
        public int? PreloadQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be prefetched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PreloadRemain")]
        [Validation(Required=false)]
        public int? PreloadRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of directories that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RefreshDirQuota")]
        [Validation(Required=false)]
        public int? RefreshDirQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of directories that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("RefreshDirRemain")]
        [Validation(Required=false)]
        public int? RefreshDirRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RefreshUrlQuota")]
        [Validation(Required=false)]
        public int? RefreshUrlQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RefreshUrlRemain")]
        [Validation(Required=false)]
        public int? RefreshUrlRemain { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF4F084A-2F49-4E1C-9CA0-DC85BCE7F391</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
