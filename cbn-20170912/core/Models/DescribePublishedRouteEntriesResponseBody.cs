// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribePublishedRouteEntriesResponseBody : TeaModel {
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

        [NameInMap("PublishedRouteEntries")]
        [Validation(Required=false)]
        public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries PublishedRouteEntries { get; set; }
        public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries : TeaModel {
            [NameInMap("PublishedRouteEntry")]
            [Validation(Required=false)]
            public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry> PublishedRouteEntry { get; set; }
            public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry : TeaModel {
                [NameInMap("ChildInstanceRouteTableId")]
                [Validation(Required=false)]
                public string ChildInstanceRouteTableId { get; set; }

                [NameInMap("Conflicts")]
                [Validation(Required=false)]
                public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts Conflicts { get; set; }
                public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts : TeaModel {
                    [NameInMap("Conflict")]
                    [Validation(Required=false)]
                    public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict> Conflict { get; set; }
                    public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict : TeaModel {
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

                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF1A7B2A-677F-4F71-96EA-6002B329F437</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
