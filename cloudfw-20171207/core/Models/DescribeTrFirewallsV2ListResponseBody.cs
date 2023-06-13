// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2ListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("VpcTrFirewalls")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls> VpcTrFirewalls { get; set; }
        public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls : TeaModel {
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            [NameInMap("FirewallId")]
            [Validation(Required=false)]
            public string FirewallId { get; set; }

            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig : TeaModel {
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }

            }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            [NameInMap("ProtectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource ProtectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("RouteMode")]
            [Validation(Required=false)]
            public string RouteMode { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("UnprotectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource UnprotectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
