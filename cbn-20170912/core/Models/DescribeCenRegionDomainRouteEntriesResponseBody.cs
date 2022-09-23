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
                [NameInMap("AsPaths")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                [NameInMap("CenOutRouteMapRecords")]
                [Validation(Required=false)]
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

                [NameInMap("CenRouteMapRecords")]
                [Validation(Required=false)]
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

                [NameInMap("Communities")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("NextHopInstanceId")]
                [Validation(Required=false)]
                public string NextHopInstanceId { get; set; }

                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ToOtherRegionStatus")]
                [Validation(Required=false)]
                public string ToOtherRegionStatus { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
