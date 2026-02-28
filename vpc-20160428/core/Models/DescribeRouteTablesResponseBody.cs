// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC668356-BCB4-42FD-9BC3-FA2B2E04B634</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public DescribeRouteTablesResponseBodyRouteTables RouteTables { get; set; }
        public class DescribeRouteTablesResponseBodyRouteTables : TeaModel {
            [NameInMap("RouteTable")]
            [Validation(Required=false)]
            public List<DescribeRouteTablesResponseBodyRouteTablesRouteTable> RouteTable { get; set; }
            public class DescribeRouteTablesResponseBodyRouteTablesRouteTable : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RouteEntrys")]
                [Validation(Required=false)]
                public DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrys RouteEntrys { get; set; }
                public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrys : TeaModel {
                    [NameInMap("RouteEntry")]
                    [Validation(Required=false)]
                    public List<DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntry> RouteEntry { get; set; }
                    public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntry : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        [NameInMap("NextHops")]
                        [Validation(Required=false)]
                        public DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHops NextHops { get; set; }
                        public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHops : TeaModel {
                            [NameInMap("NextHop")]
                            [Validation(Required=false)]
                            public List<DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHopsNextHop> NextHop { get; set; }
                            public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHopsNextHop : TeaModel {
                                [NameInMap("Enabled")]
                                [Validation(Required=false)]
                                public int? Enabled { get; set; }

                                [NameInMap("NextHopId")]
                                [Validation(Required=false)]
                                public string NextHopId { get; set; }

                                [NameInMap("NextHopType")]
                                [Validation(Required=false)]
                                public string NextHopType { get; set; }

                                [NameInMap("Weight")]
                                [Validation(Required=false)]
                                public int? Weight { get; set; }

                            }

                        }

                        [NameInMap("RouteEntryId")]
                        [Validation(Required=false)]
                        public string RouteEntryId { get; set; }

                        [NameInMap("RouteEntryName")]
                        [Validation(Required=false)]
                        public string RouteEntryName { get; set; }

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

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeRouteTablesResponseBodyRouteTablesRouteTableVSwitchIds VSwitchIds { get; set; }
                public class DescribeRouteTablesResponseBodyRouteTablesRouteTableVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
