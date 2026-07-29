// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to change the network type from AnyTunnel to SingleTunnel. This parameter is not applicable to new instances. Keep the default value of null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("anyTunnelToSingleTunnel")]
        [Validation(Required=false)]
        public string AnyTunnelToSingleTunnel { get; set; }

        /// <summary>
        /// <para>The network types to enable. The order of the network types does not matter. For example, if an instance has the Internet, Intranet, and VPCSingleTunnel network types enabled, disable the Internet network type by specifying \<c>Intranet,VPCSingleTunnel\\</c>.</para>
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
        /// <para>The ID of the Alibaba Cloud account that owns the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1999365732646672</para>
        /// </summary>
        [NameInMap("vpcOwnerId")]
        [Validation(Required=false)]
        public string VpcOwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("vpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
