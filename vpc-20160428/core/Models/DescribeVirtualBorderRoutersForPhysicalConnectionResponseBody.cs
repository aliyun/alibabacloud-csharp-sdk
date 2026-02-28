// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C5AE8B3-A2D8-428D-A2FF-93A225C0821E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VirtualBorderRouterForPhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet VirtualBorderRouterForPhysicalConnectionSet { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet : TeaModel {
            [NameInMap("VirtualBorderRouterForPhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType> VirtualBorderRouterForPhysicalConnectionType { get; set; }
            public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType : TeaModel {
                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("EccId")]
                [Validation(Required=false)]
                public string EccId { get; set; }

                [NameInMap("EnableIpv6")]
                [Validation(Required=false)]
                public bool? EnableIpv6 { get; set; }

                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                [NameInMap("LocalIpv6GatewayIp")]
                [Validation(Required=false)]
                public string LocalIpv6GatewayIp { get; set; }

                [NameInMap("PConnVbrBussinessStatus")]
                [Validation(Required=false)]
                public string PConnVbrBussinessStatus { get; set; }

                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                [NameInMap("PConnVbrExpireTime")]
                [Validation(Required=false)]
                public string PConnVbrExpireTime { get; set; }

                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TerminationTime")]
                [Validation(Required=false)]
                public string TerminationTime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                [NameInMap("VbrName")]
                [Validation(Required=false)]
                public string VbrName { get; set; }

                [NameInMap("VbrOwnerUid")]
                [Validation(Required=false)]
                public long? VbrOwnerUid { get; set; }

                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

            }

        }

    }

}
