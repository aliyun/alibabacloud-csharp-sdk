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
                [NameInMap("AsPaths")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                [NameInMap("CenRouteMapRecords")]
                [Validation(Required=false)]
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

                [NameInMap("Communities")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }

                [NameInMap("Conflicts")]
                [Validation(Required=false)]
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

                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17A57456-EF48-419D-9AE6-9B03D9996018</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
