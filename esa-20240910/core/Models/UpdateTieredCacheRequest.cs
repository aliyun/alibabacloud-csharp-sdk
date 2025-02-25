// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTieredCacheRequest : TeaModel {
        /// <summary>
        /// <para>Multi-level cache architecture mode. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>edge: Edge cache layer.</description></item>
        /// <item><description>edge_smart: Edge cache layer + intelligent cache layer.</description></item>
        /// <item><description>edge_regional: Edge cache layer + regional cache layer.</description></item>
        /// <item><description>edge_regional_smart: Edge cache layer + regional cache layer + intelligent cache layer.</description></item>
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
        /// <para>Site ID, which can be obtained by calling <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a>.</para>
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
