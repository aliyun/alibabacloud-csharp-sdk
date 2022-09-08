// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenDetailResponseBody : TeaModel {
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyLocalVpc : TeaModel {
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            [NameInMap("DefendCidrList")]
            [Validation(Required=false)]
            public List<string> DefendCidrList { get; set; }

            [NameInMap("EniList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList> EniList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList : TeaModel {
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                [NameInMap("EniPrivateIpAddress")]
                [Validation(Required=false)]
                public string EniPrivateIpAddress { get; set; }

            }

            [NameInMap("ManualVSwitchId")]
            [Validation(Required=false)]
            public string ManualVSwitchId { get; set; }

            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            [NameInMap("NetworkInstanceName")]
            [Validation(Required=false)]
            public string NetworkInstanceName { get; set; }

            [NameInMap("NetworkInstanceType")]
            [Validation(Required=false)]
            public string NetworkInstanceType { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("RouteMode")]
            [Validation(Required=false)]
            public string RouteMode { get; set; }

            [NameInMap("SupportManualMode")]
            [Validation(Required=false)]
            public string SupportManualMode { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("TransitRouterType")]
            [Validation(Required=false)]
            public string TransitRouterType { get; set; }

            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                    [NameInMap("DestinationCidr")]
                    [Validation(Required=false)]
                    public string DestinationCidr { get; set; }

                    [NameInMap("NextHopInstanceId")]
                    [Validation(Required=false)]
                    public string NextHopInstanceId { get; set; }

                }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

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
