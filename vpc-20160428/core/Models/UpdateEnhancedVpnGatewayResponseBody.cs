// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateEnhancedVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether BGP route automatic propagation to the VPC is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Automatic propagation is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Automatic propagation is not enabled.</para>
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
        /// <para>The timestamp when the enhanced VPN gateway instance was created. Unit: milliseconds.<br>
        /// The timestamp follows the UNIX time format, which represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753580000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the enhanced VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch associated with the enhanced VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0w95ql6tmr2ludkt****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>The enabling status of the BGP feature for the enhanced VPN gateway. Valid values:<br></para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBgp")]
        [Validation(Required=false)]
        public bool? EnableBgp { get; set; }

        [NameInMap("EniInstanceIds")]
        [Validation(Required=false)]
        public UpdateEnhancedVpnGatewayResponseBodyEniInstanceIds EniInstanceIds { get; set; }
        public class UpdateEnhancedVpnGatewayResponseBodyEniInstanceIds : TeaModel {
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public List<string> EniInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enhanced.SiteToSite</b>: enhanced site-to-cloud VPN that supports only IPsec functionality.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced.SiteToSite</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The name of the enhanced VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the enhanced VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b> (default): public VPN gateway.</description></item>
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
        /// <para>The ID of the resource group to which the enhanced VPN gateway instance belongs.<br>
        /// You can call <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the enhanced VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: initializing.</description></item>
        /// <item><description><b>provisioning</b>: preparing.</description></item>
        /// <item><description><b>active</b>: normal.</description></item>
        /// <item><description><b>updating</b>: updating.</description></item>
        /// <item><description><b>deleting</b>: deleting.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of features supported by the enhanced VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VpnEnableBgp&quot;: true}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

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
        /// <para>The ID of the vSwitch associated with the enhanced VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1y9ovl1cu9ou4tv****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the enhanced VPN gateway instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoel****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the enhanced VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard.</description></item>
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
