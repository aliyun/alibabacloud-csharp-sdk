// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSecurityProxyRequest : TeaModel {
        /// <summary>
        /// <para>The security protection switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: enabled</description></item>
        /// <item><description><b>close</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The zone of the firewall vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-b</para>
        /// </summary>
        [NameInMap("FwVswitchZoneId")]
        [Validation(Required=false)]
        public string FwVswitchZoneId { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1okz6k7******</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The list of routes to be switched for the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NatRouteEntryList")]
        [Validation(Required=false)]
        public List<CreateSecurityProxyRequestNatRouteEntryList> NatRouteEntryList { get; set; }
        public class CreateSecurityProxyRequestNatRouteEntryList : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the default route.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// <para>The next hop address of the original NAT gateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1okz6******</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The network type of the next hop. Valid values: NatGateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NatGateway</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The route table that contains the default route of the NAT gateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze1******</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT firewall. The name can contain uppercase and lowercase letters, Chinese characters, digits, and underscores (_). The name must be 4 to 50 characters in length and cannot start with an underscore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-firewall</para>
        /// </summary>
        [NameInMap("ProxyName")]
        [Validation(Required=false)]
        public string ProxyName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC.</para>
        /// <remarks>
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable strict mode.</para>
        /// <list type="bullet">
        /// <item><description>1: Enable strict mode.</description></item>
        /// <item><description>0: Disable strict mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public int? StrictMode { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the automatic vSwitch mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatic mode</description></item>
        /// <item><description><b>false</b>: manual mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VswitchAuto")]
        [Validation(Required=false)]
        public string VswitchAuto { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch. This parameter is required when the vSwitch is in automatic mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("VswitchCidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required when the vSwitch is in manual mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1sqg9w******</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
