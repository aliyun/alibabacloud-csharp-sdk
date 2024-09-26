// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ListUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the used amounts and upper limits of privileges and quotas that you have in the specified region. The information contains the following items:</para>
        /// <list type="bullet">
        /// <item><description>UsedCpu: the number of existing vCPUs.</description></item>
        /// <item><description>MaxCpu: the upper limit of vCPUs.</description></item>
        /// <item><description>MaxImageCacheCount: the upper limit of manually created image caches.</description></item>
        /// <item><description>UsedImageCacheCount: the number of existing image caches that are manually created.</description></item>
        /// <item><description>MaxAutoImageCacheCount: the upper limit of automatically created image caches.</description></item>
        /// <item><description>UsedAutoImageCacheCount: the number of existing image caches that are automatically created.</description></item>
        /// <item><description>MaxDataCacheCount: the upper limit of DataCaches.</description></item>
        /// <item><description>UsedDataCacheCount: the number of existing DataCaches.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UsedCpu&quot;: 11,&quot;MaxCpu&quot;: 1000,&quot;MaxImageCacheCount&quot;: 50,&quot;UsedImageCacheCount&quot;: 0}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89164E78-FC82-4684-BE97-DCDD85D26546</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
