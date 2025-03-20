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
        /// <item><description>edge: edge tiered cache.</description></item>
        /// <item><description>edge_smart: edge tiered cache + smart tiered cache.</description></item>
        /// <item><description>edge_regional: edge tiered cache + regional tiered cache.</description></item>
        /// <item><description>edge_regional_smart: edge tiered cache + regional tiered cache + smart tiered cache.</description></item>
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
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
