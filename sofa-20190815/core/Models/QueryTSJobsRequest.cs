// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSJobsRequest : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public string Apps { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("ExcludedGroupId")]
        [Validation(Required=false)]
        public long? ExcludedGroupId { get; set; }

        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        [NameInMap("JobOriginZones")]
        [Validation(Required=false)]
        public string JobOriginZones { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Priorities")]
        [Validation(Required=false)]
        public string Priorities { get; set; }

        [NameInMap("TriggerTypes")]
        [Validation(Required=false)]
        public string TriggerTypes { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        [NameInMap("ZoneMode")]
        [Validation(Required=false)]
        public string ZoneMode { get; set; }

    }

}
