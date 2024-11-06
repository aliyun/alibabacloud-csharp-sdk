// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of URLs that can be blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("BlockQuota")]
        [Validation(Required=false)]
        public int? BlockQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("BlockRemain")]
        [Validation(Required=false)]
        public int? BlockRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of accelerated domains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DomainQuota")]
        [Validation(Required=false)]
        public int? DomainQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs or directories with parameters ignored that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("IgnoreParamsQuota")]
        [Validation(Required=false)]
        public int? IgnoreParamsQuota { get; set; }

        /// <summary>
        /// <para>The number of remaining URLs or directories with parameters ignored that can be refreshed.</para>
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
        /// <para>300</para>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("RefreshDirRemain")]
        [Validation(Required=false)]
        public int? RefreshDirRemain { get; set; }

        /// <summary>
        /// <para>The maximum number of URLs that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RefreshUrlQuota")]
        [Validation(Required=false)]
        public int? RefreshUrlQuota { get; set; }

        /// <summary>
        /// <para>The remaining number of URLs that can be refreshed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RefreshUrlRemain")]
        [Validation(Required=false)]
        public int? RefreshUrlRemain { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFFCDFAD-DACC-484E-9BE6-0AF3B3A0DD23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
