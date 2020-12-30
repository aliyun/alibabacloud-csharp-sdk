// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
                public bool? IsDefault { get; set; }
                public long? AvailableIpAddressCount { get; set; }
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
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable RouteTable { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable : TeaModel {
                    [NameInMap("RouteTableType")]
                    [Validation(Required=false)]
                    public string RouteTableType { get; set; }

                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }
                public string NetworkAclId { get; set; }
                public long? OwnerId { get; set; }
                public string VSwitchId { get; set; }
                public string CidrBlock { get; set; }
                public string Description { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string Ipv6CidrBlock { get; set; }
                public string VSwitchName { get; set; }
            }
        };

    }

}
