// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSecurityProxyRequest : TeaModel {
        /// <summary>
        /// <para>The status of the NAT firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: enabled</description></item>
        /// <item><description><b>close</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>ngw-bp1okz6k7s4n4mnk5f1g3</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The routes to be switched to the NAT gateway.</para>
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
            /// <para>The next hop of the original NAT gateway.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1okz6k7s4n4mnk5f1g3</para>
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
            /// <para>The route table to which the default route of the NAT gateway belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze13wrgz7wsu9yiqeffg</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT firewall. The name must be 4 to 50 characters in length, and can contain letters, digits, and underscores (_). However, it cannot start with an underscore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-idmp-fir</para>
        /// </summary>
        [NameInMap("ProxyName")]
        [Validation(Required=false)]
        public string ProxyName { get; set; }

        /// <summary>
        /// <para>The region ID of the virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> For more information about Cloud Firewall supported regions, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
        /// <para>Specifies whether to enable the strict mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: yes</description></item>
        /// <item><description>0: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public int? StrictMode { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0xfgv74i01ph</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The mode of the vSwitch that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatic</description></item>
        /// <item><description><b>false</b>: manual</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VswitchAuto")]
        [Validation(Required=false)]
        public string VswitchAuto { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("VswitchCidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required if you set the VswitchAuto parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1sqg9wms9w9y1uxcs1x</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
