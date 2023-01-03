// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVccResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetVccResponseBodyContent Content { get; set; }
        public class GetVccResponseBodyContent : TeaModel {
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("AliyunRouterInfo")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentAliyunRouterInfo> AliyunRouterInfo { get; set; }
            public class GetVccResponseBodyContentAliyunRouterInfo : TeaModel {
                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("PcId")]
                [Validation(Required=false)]
                public string PcId { get; set; }

                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

            }

            [NameInMap("BandwidthStr")]
            [Validation(Required=false)]
            public string BandwidthStr { get; set; }

            [NameInMap("BgpCidr")]
            [Validation(Required=false)]
            public string BgpCidr { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CisRouterInfo")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentCisRouterInfo> CisRouterInfo { get; set; }
            public class GetVccResponseBodyContentCisRouterInfo : TeaModel {
                [NameInMap("CcInfos")]
                [Validation(Required=false)]
                public List<GetVccResponseBodyContentCisRouterInfoCcInfos> CcInfos { get; set; }
                public class GetVccResponseBodyContentCisRouterInfoCcInfos : TeaModel {
                    [NameInMap("CcId")]
                    [Validation(Required=false)]
                    public string CcId { get; set; }

                    [NameInMap("LocalGatewayIp")]
                    [Validation(Required=false)]
                    public string LocalGatewayIp { get; set; }

                    [NameInMap("RemoteGatewayIp")]
                    [Validation(Required=false)]
                    public string RemoteGatewayIp { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("SubnetMask")]
                    [Validation(Required=false)]
                    public string SubnetMask { get; set; }

                    /// <summary>
                    /// vlanid
                    /// </summary>
                    [NameInMap("VlanId")]
                    [Validation(Required=false)]
                    public string VlanId { get; set; }

                }

                [NameInMap("CcrId")]
                [Validation(Required=false)]
                public string CcrId { get; set; }

            }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CurrentNode")]
            [Validation(Required=false)]
            public string CurrentNode { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VccId")]
            [Validation(Required=false)]
            public string VccId { get; set; }

            [NameInMap("VccName")]
            [Validation(Required=false)]
            public string VccName { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpdBaseInfo")]
            [Validation(Required=false)]
            public GetVccResponseBodyContentVpdBaseInfo VpdBaseInfo { get; set; }
            public class GetVccResponseBodyContentVpdBaseInfo : TeaModel {
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

            }

            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
