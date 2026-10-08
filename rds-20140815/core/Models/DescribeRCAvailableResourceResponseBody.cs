// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeRCAvailableResourceResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeRCAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableResources")]
            [Validation(Required=false)]
            public List<DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResources> AvailableResources { get; set; }
            public class DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResources : TeaModel {
                [NameInMap("SupportedResources")]
                [Validation(Required=false)]
                public List<DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources> SupportedResources { get; set; }
                public class DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    [NameInMap("QuotaStatus")]
                    [Validation(Required=false)]
                    public string QuotaStatus { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StatusCategory")]
                    [Validation(Required=false)]
                    public string StatusCategory { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

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
