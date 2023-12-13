// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ListUsageResponseBody : TeaModel {
        /// <summary>
        /// The information about the used amounts and upper limits of privileges and quotas that you have in the specified region. The information contains the following items:
        /// 
        /// *   UsedCpu: the number of existing vCPUs.
        /// *   MaxCpu: the upper limit of vCPUs.
        /// *   MaxImageCacheCount: the upper limit of manually created image caches.
        /// *   UsedImageCacheCount: the number of existing image caches that are manually created.
        /// *   MaxAutoImageCacheCount: the upper limit of automatically created image caches.
        /// *   UsedAutoImageCacheCount: the number of existing image caches that are automatically created.
        /// *   MaxDataCacheCount: the upper limit of DataCaches.
        /// *   UsedDataCacheCount: the number of existing DataCaches.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
