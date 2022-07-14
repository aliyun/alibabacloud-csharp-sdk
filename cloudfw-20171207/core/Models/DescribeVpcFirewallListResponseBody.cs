// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallListResponseBodyVpcFirewalls : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }
            };

            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                        public string DestinationCidr { get; set; }
                        public string NextHopInstanceId { get; set; }
                    }
                    public string RouteTableId { get; set; }
                }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }
            };

            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            [NameInMap("PeerVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc PeerVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc : TeaModel {
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList : TeaModel {
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
                        public string DestinationCidr { get; set; }
                        public string NextHopInstanceId { get; set; }
                    }
                    public string RouteTableId { get; set; }
                }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }
            };

            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
