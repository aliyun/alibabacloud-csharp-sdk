// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetNatGatewayStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The NAT gateway configuration status information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNatGatewayStatusResponseBodyData Data { get; set; }
        public class GetNatGatewayStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inst-1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the NAT gateway is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NatGatewayConfigured")]
            [Validation(Required=false)]
            public bool? NatGatewayConfigured { get; set; }

            /// <summary>
            /// <para>The list of NAT gateway details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("NatGateways")]
            [Validation(Required=false)]
            public List<GetNatGatewayStatusResponseBodyDataNatGateways> NatGateways { get; set; }
            public class GetNatGatewayStatusResponseBodyDataNatGateways : TeaModel {
                /// <summary>
                /// <para>The NAT gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-xxx</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// <para>Indicates whether the SNAT rule is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SnatConfigured")]
                [Validation(Required=false)]
                public bool? SnatConfigured { get; set; }

                /// <summary>
                /// <para>The SNAT table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stb-xxx</para>
                /// </summary>
                [NameInMap("SnatTableId")]
                [Validation(Required=false)]
                public string SnatTableId { get; set; }

                /// <summary>
                /// <para>The status of the NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available: available</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the SNAT rule is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SnatConfigured")]
            [Validation(Required=false)]
            public bool? SnatConfigured { get; set; }

            /// <summary>
            /// <para>The status of the NAT gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>READY: The NAT gateway exists, and the zone/vSwitch CIDR selected by the current instance is covered by SNAT.</description></item>
            /// <item><description>NEED_CONFIGURE_NAT_GATEWAY: No NAT gateway exists in the VPC associated with the current instance. You need to purchase or configure a NAT gateway.</description></item>
            /// <item><description>NEED_CONFIGURE_SNAT_RULE: The NAT gateway exists, but the zone/vSwitch CIDR selected by the current instance is not fully added to SNAT. You need to add SNAT rules.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Indicates whether the selected zone/vSwitch CIDR is covered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ZoneCidrCovered")]
            [Validation(Required=false)]
            public bool? ZoneCidrCovered { get; set; }

            /// <summary>
            /// <para>The CIDR blocks and SNAT configuration status of each zone/vSwitch in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("ZoneCidrs")]
            [Validation(Required=false)]
            public List<GetNatGatewayStatusResponseBodyDataZoneCidrs> ZoneCidrs { get; set; }
            public class GetNatGatewayStatusResponseBodyDataZoneCidrs : TeaModel {
                /// <summary>
                /// <para>The CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>Indicates whether the CIDR block is covered by a SNAT rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Covered")]
                [Validation(Required=false)]
                public bool? Covered { get; set; }

                /// <summary>
                /// <para>The associated NAT gateway ID. This value is null if not configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-xxx</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// <para>The SNAT entry ID. This value is null if not configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>snat-xxx</para>
                /// </summary>
                [NameInMap("SnatEntryId")]
                [Validation(Required=false)]
                public string SnatEntryId { get; set; }

                /// <summary>
                /// <para>The SNAT source CIDR. This value is null if not configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("SnatSourceCidr")]
                [Validation(Required=false)]
                public string SnatSourceCidr { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
