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
        /// <item><description><para><b>open</b>: on</para>
        /// </description></item>
        /// <item><description><para><b>close</b>: off</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the NAT Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1okz6k7******</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The list of routes of the NAT Gateway that you want to switch.</para>
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
            /// <para>The next hop of the original NAT Gateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1okz6******</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The network type of the next hop. Set the value to NatGateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NatGateway</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The route table that contains the default route of the NAT Gateway.</para>
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
        /// <para>The name of the NAT firewall. The name must be 4 to 50 characters in length. It can contain letters, digits, Chinese characters, and underscores (<em>). The name cannot start with an underscore (</em>).</para>
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
        /// <para>For more information about the regions where Cloud Firewall is available, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
        /// <item><description><para>1: enables strict mode</para>
        /// </description></item>
        /// <item><description><para>0: disables strict mode</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public int? StrictMode { get; set; }

        /// <summary>
        /// <para>The ID of the VPC instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the automatic vSwitch selection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatic mode</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: manual mode</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VswitchAuto")]
        [Validation(Required=false)]
        public string VswitchAuto { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch. This parameter is required if you use the automatic vSwitch selection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("VswitchCidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required if you use the manual vSwitch selection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1sqg9w******</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
