// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallCenListResponseBodyVpcFirewalls : TeaModel {
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig : TeaModel {
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
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }
                [NameInMap("DefendCidrList")]
                [Validation(Required=false)]
                public List<string> DefendCidrList { get; set; }
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
                public long? OwnerId { get; set; }
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }
                [NameInMap("RouteMode")]
                [Validation(Required=false)]
                public string RouteMode { get; set; }
                [NameInMap("SupportManualMode")]
                [Validation(Required=false)]
                public string SupportManualMode { get; set; }
                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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

            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
