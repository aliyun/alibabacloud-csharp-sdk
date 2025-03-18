// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to change the network type from AnyTunnel to SingleTunnel. This parameter is invalid for new instances. For new instances, this parameter is set to null by default.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>others/null: The network type is not changed from AnyTunnel to SingleTunnel.</description></item>
        /// <item><description>true: The network type is changed from AnyTunnel to SingleTunnel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("anyTunnelToSingleTunnel")]
        [Validation(Required=false)]
        public string AnyTunnelToSingleTunnel { get; set; }

        /// <summary>
        /// <para>A list of network types that you want to enable. The network types are randomly ordered in the list. For example, the Internet, Intranet, and VPCSingleTunnel network types are enabled. If you want to disable the Internet type, set this parameter to Intranet,VPCSingleTunnel.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VPCSingleTunnel: virtual private cloud (VPC).</description></item>
        /// <item><description>Intranet: internal network.</description></item>
        /// <item><description>VPCAnyTunnel: compatibility requirements. This value is not supported by new instances.</description></item>
        /// <item><description>Internet: Internet.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet,VPCSingleTunnel</para>
        /// </summary>
        [NameInMap("networkTypes")]
        [Validation(Required=false)]
        public string NetworkTypes { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vccsiymtqr9aavew0vo3</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4netc3y5etlondfb5ra7</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1999365732646672</para>
        /// </summary>
        [NameInMap("vpcOwnerId")]
        [Validation(Required=false)]
        public string VpcOwnerId { get; set; }

        /// <summary>
        /// <para>The region in which the VPC resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("vpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
