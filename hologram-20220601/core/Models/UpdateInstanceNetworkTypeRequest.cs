// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to convert AnyTunnel to SingleTunnel. This parameter is invalid for new instances. Set it to null by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("anyTunnelToSingleTunnel")]
        [Validation(Required=false)]
        public string AnyTunnelToSingleTunnel { get; set; }

        /// <summary>
        /// <para>The list of network types to enable. Specify a combination of existing network types. The order does not matter. For example, if the Internet, internal network, and VPCSingleTunnel network types are enabled and you want to disable the Internet network type, remove the Internet type and pass &quot;Intranet, VPCSingleTunnel&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet,VPCSingleTunnel</para>
        /// </summary>
        [NameInMap("networkTypes")]
        [Validation(Required=false)]
        public string NetworkTypes { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vccsiymtqr9aavew0vo3</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4netc3y5etlondfb5ra7</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The owner ID of the VPC, which is the Alibaba Cloud account ID.</para>
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
