// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeResourcesModificationResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeResourcesModificationResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResources AvailableResources { get; set; }
                public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResources : TeaModel {
                    [NameInMap("AvailableResource")]
                    [Validation(Required=false)]
                    public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource> AvailableResource { get; set; }
                    public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource : TeaModel {
                        [NameInMap("SupportedResources")]
                        [Validation(Required=false)]
                        public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources SupportedResources { get; set; }
                        public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources : TeaModel {
                            [NameInMap("SupportedResource")]
                            [Validation(Required=false)]
                            public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource> SupportedResource { get; set; }
                            public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource : TeaModel {
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

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

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
