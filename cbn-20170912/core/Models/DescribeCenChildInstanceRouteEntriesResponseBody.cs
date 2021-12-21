// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenChildInstanceRouteEntriesResponseBody : TeaModel {
        [NameInMap("CenRouteEntries")]
        [Validation(Required=false)]
        public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntries CenRouteEntries { get; set; }
        public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntries : TeaModel {
            [NameInMap("CenRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry> CenRouteEntry { get; set; }
            public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry : TeaModel {
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords CenRouteMapRecords { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords : TeaModel {
                    [NameInMap("CenRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord> CenRouteMapRecord { get; set; }
                    public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflicts Conflicts { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflicts : TeaModel {
                    [NameInMap("Conflict")]
                    [Validation(Required=false)]
                    public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflictsConflict> Conflict { get; set; }
                    public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflictsConflict : TeaModel {
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }
                public string DestinationCidrBlock { get; set; }
                public string NextHopInstanceId { get; set; }
                public string NextHopRegionId { get; set; }
                public string NextHopType { get; set; }
                public bool? OperationalMode { get; set; }
                public string PublishStatus { get; set; }
                public string RouteTableId { get; set; }
                public string Status { get; set; }
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
