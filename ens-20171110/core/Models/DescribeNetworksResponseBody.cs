// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworksResponseBody : TeaModel {
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public DescribeNetworksResponseBodyNetworks Networks { get; set; }
        public class DescribeNetworksResponseBodyNetworks : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public List<DescribeNetworksResponseBodyNetworksNetwork> Network { get; set; }
            public class DescribeNetworksResponseBodyNetworksNetwork : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("GatewayRouteTableId")]
                [Validation(Required=false)]
                public string GatewayRouteTableId { get; set; }

                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                [NameInMap("NetworkName")]
                [Validation(Required=false)]
                public string NetworkName { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("RouteTableIds")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkRouteTableIds RouteTableIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }

                [NameInMap("RouterTableId")]
                [Validation(Required=false)]
                public string RouterTableId { get; set; }

                [NameInMap("SecondaryCidrBlocks")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkSecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkSecondaryCidrBlocks : TeaModel {
                    [NameInMap("SecondaryCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> SecondaryCidrBlock { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkTags Tags { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworksResponseBodyNetworksNetworkTagsTag> Tag { get; set; }
                    public class DescribeNetworksResponseBodyNetworksNetworkTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagKey { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagValue { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkVSwitchIds VSwitchIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

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
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
