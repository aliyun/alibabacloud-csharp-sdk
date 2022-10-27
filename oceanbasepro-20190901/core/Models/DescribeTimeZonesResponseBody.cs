// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTimeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeZones")]
        [Validation(Required=false)]
        public DescribeTimeZonesResponseBodyTimeZones TimeZones { get; set; }
        public class DescribeTimeZonesResponseBodyTimeZones : TeaModel {
            [NameInMap("Default")]
            [Validation(Required=false)]
            public string Default { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTimeZonesResponseBodyTimeZonesList> List { get; set; }
            public class DescribeTimeZonesResponseBodyTimeZonesList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

    }

}
