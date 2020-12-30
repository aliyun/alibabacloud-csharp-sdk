// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                public string UpdateTime { get; set; }
                public string ZoneType { get; set; }
                public string Remark { get; set; }
                public string CreateTime { get; set; }
                public int? RecordCount { get; set; }
                public string ZoneName { get; set; }
                public string ProxyPattern { get; set; }
                public long? UpdateTimestamp { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string ZoneTag { get; set; }
                public bool? IsPtr { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

    }

}
