// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDetailResponseBody : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyLocalVpc : TeaModel {
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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

        [NameInMap("PeerVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallDetailResponseBodyPeerVpc PeerVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyPeerVpc : TeaModel {
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList : TeaModel {
                public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
