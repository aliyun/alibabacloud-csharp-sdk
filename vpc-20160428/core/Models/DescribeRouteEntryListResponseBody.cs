// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public DescribeRouteEntryListResponseBodyRouteEntrys RouteEntrys { get; set; }
        public class DescribeRouteEntryListResponseBodyRouteEntrys : TeaModel {
            [NameInMap("RouteEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry> RouteEntry { get; set; }
            public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("NextHops")]
                [Validation(Required=false)]
                public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops NextHops { get; set; }
                public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops : TeaModel {
                    [NameInMap("NextHop")]
                    [Validation(Required=false)]
                    public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop> NextHop { get; set; }
                    public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public int? Enabled { get; set; }

                        [NameInMap("NextHopId")]
                        [Validation(Required=false)]
                        public string NextHopId { get; set; }

                        [NameInMap("NextHopRegionId")]
                        [Validation(Required=false)]
                        public string NextHopRegionId { get; set; }

                        [NameInMap("NextHopRelatedInfo")]
                        [Validation(Required=false)]
                        public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo NextHopRelatedInfo { get; set; }
                        public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo : TeaModel {
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                        }

                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                [NameInMap("RouteEntryId")]
                [Validation(Required=false)]
                public string RouteEntryId { get; set; }

                [NameInMap("RouteEntryName")]
                [Validation(Required=false)]
                public string RouteEntryName { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
