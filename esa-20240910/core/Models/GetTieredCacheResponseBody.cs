// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetTieredCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>Multi-level cache architecture mode. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>edge: Edge cache layer.</description></item>
        /// <item><description>edge_smart: Edge cache layer + intelligent cache layer.</description></item>
        /// <item><description>edge_regional: Edge cache layer + regional cache layer.</description></item>
        /// <item><description>edge_regional_smart: Edge cache layer + regional cache layer + intelligent cache layer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>edge</para>
        /// </summary>
        [NameInMap("CacheArchitectureMode")]
        [Validation(Required=false)]
        public string CacheArchitectureMode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
