// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
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

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public long? AvailableIpAddressCount { get; set; }

                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RouteTable")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable RouteTable { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                    [NameInMap("RouteTableType")]
                    [Validation(Required=false)]
                    public string RouteTableType { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchTags Tags { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag> Tag { get; set; }
                    public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
