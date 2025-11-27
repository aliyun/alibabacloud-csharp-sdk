// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCResourcesModificationResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeRCResourcesModificationResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeRCResourcesModificationResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableResources")]
            [Validation(Required=false)]
            public List<DescribeRCResourcesModificationResponseBodyAvailableZonesAvailableResources> AvailableResources { get; set; }
            public class DescribeRCResourcesModificationResponseBodyAvailableZonesAvailableResources : TeaModel {
                [NameInMap("SupportedResources")]
                [Validation(Required=false)]
                public List<DescribeRCResourcesModificationResponseBodyAvailableZonesAvailableResourcesSupportedResources> SupportedResources { get; set; }
                public class DescribeRCResourcesModificationResponseBodyAvailableZonesAvailableResourcesSupportedResources : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StatusCategory")]
                    [Validation(Required=false)]
                    public string StatusCategory { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusCategory")]
            [Validation(Required=false)]
            public string StatusCategory { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
