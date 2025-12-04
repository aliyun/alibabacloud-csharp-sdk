// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2StorageUsageResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("CapacityByDiskCategory")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> CapacityByDiskCategory { get; set; }

        [NameInMap("InstanceStorageZoneMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceStorageZoneMap { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageByDiskCategory")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> UsageByDiskCategory { get; set; }

    }

}
