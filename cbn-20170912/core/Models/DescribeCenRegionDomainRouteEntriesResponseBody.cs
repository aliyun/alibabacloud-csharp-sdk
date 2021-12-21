// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRegionDomainRouteEntriesResponseBody : TeaModel {
        [NameInMap("CenRouteEntries")]
        [Validation(Required=false)]
        public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntries CenRouteEntries { get; set; }
        public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntries : TeaModel {
            [NameInMap("CenRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry> CenRouteEntry { get; set; }
            public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry : TeaModel {
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecords CenOutRouteMapRecords { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecords : TeaModel {
                    [NameInMap("CenOutRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecordsCenOutRouteMapRecord> CenOutRouteMapRecord { get; set; }
                    public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecordsCenOutRouteMapRecord : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords CenRouteMapRecords { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords : TeaModel {
                    [NameInMap("CenRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord> CenRouteMapRecord { get; set; }
                    public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }
                public string DestinationCidrBlock { get; set; }
                public string NextHopInstanceId { get; set; }
                public string NextHopRegionId { get; set; }
                public string NextHopType { get; set; }
                public int? Preference { get; set; }
                public string Status { get; set; }
                public string ToOtherRegionStatus { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
