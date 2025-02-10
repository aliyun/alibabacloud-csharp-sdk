// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetTieredCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The tiered cache architecture mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>edge: edge tiered cache.</description></item>
        /// <item><description>edge_smart: edge tiered cache + smart tiered cache.</description></item>
        /// <item><description>edge_regional: edge tiered cache + regional tiered cache.</description></item>
        /// <item><description>edge_regional_smart: edge tiered cache + regional tiered cache + smart tiered cache.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>edge</para>
        /// </summary>
        [NameInMap("CacheArchitectureMode")]
        [Validation(Required=false)]
        public string CacheArchitectureMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
