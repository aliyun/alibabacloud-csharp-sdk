// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTieredCacheRequest : TeaModel {
        /// <summary>
        /// <para>The tiered cache architecture mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>edge: The edge cache layer.</para>
        /// </description></item>
        /// <item><description><para>edge_smart: The edge cache layer and the intelligent cache layer.</para>
        /// </description></item>
        /// <item><description><para>edge_regional: The edge cache layer and the regional cache layer.</para>
        /// </description></item>
        /// <item><description><para>edge_regional_smart: The edge cache layer, the regional cache layer, and the intelligent cache layer.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edge_smart</para>
        /// </summary>
        [NameInMap("CacheArchitectureMode")]
        [Validation(Required=false)]
        public string CacheArchitectureMode { get; set; }

        /// <summary>
        /// <para>The site ID. You can get this ID by calling <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
