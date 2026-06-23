// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateEnhancedVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether BGP routes are automatically propagated to the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Automatic propagation is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Automatic propagation is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPropagate")]
        [Validation(Required=false)]
        public bool? AutoPropagate { get; set; }

        /// <summary>
        /// <para>The timestamp when the Enhanced VPN Gateway was created. Unit: milliseconds.<br>
        /// This value is a Unix timestamp that represents the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753580000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the Enhanced VPN Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch with which the Enhanced VPN Gateway is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0w95ql6tmr2ludkt****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>Indicates whether BGP is enabled for the Enhanced VPN Gateway. Valid values:<br></para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBgp")]
        [Validation(Required=false)]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// <para>The ENIs created for the Enhanced VPN Gateway.</para>
        /// </summary>
        [NameInMap("EniInstanceIds")]
        [Validation(Required=false)]
        public UpdateEnhancedVpnGatewayResponseBodyEniInstanceIds EniInstanceIds { get; set; }
        public class UpdateEnhancedVpnGatewayResponseBodyEniInstanceIds : TeaModel {
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public List<string> EniInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The type of the Enhanced VPN Gateway. Only <b>Enhanced.SiteToSite</b> is returned, which indicates an enhanced site-to-site VPN gateway that supports only the IPsec-VPN feature.</para>
        /// <list type="bullet">
        /// <item><description><b>Enhanced.SiteToSite</b>, an enhanced site-to-cloud VPN that supports only the IPsec feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced.SiteToSite</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The name of the Enhanced VPN Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the Enhanced VPN Gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b> (default): a public gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B457</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Enhanced VPN Gateway belongs.<br>
        /// You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the details of resource groups.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the Enhanced VPN Gateway.</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: The gateway is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>provisioning</b>: The gateway is being provisioned.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The gateway is active.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: The gateway is being updated.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The gateway is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A JSON string that indicates the features supported by the Enhanced VPN Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VpnEnableBgp&quot;: true}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The tags of the Enhanced VPN Gateway.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public UpdateEnhancedVpnGatewayResponseBodyTags Tags { get; set; }
        public class UpdateEnhancedVpnGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<UpdateEnhancedVpnGatewayResponseBodyTagsTag> Tag { get; set; }
            public class UpdateEnhancedVpnGatewayResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the vSwitch associated with the Enhanced VPN Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1y9ovl1cu9ou4tv****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the Enhanced VPN Gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoel****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the Enhanced VPN Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the Enhanced VPN Gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
