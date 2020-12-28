// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourceResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("StatusCategory")]
            [Validation(Required=false)]
            public string StatusCategory { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("AvailableResources")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableResources> AvailableResources { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableResources : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("SupportedResources")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources> SupportedResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("StatusCategory")]
                    [Validation(Required=false)]
                    public string StatusCategory { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

            }

        }

    }

}
