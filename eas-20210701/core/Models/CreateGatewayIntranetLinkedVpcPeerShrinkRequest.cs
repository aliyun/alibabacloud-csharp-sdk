// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayIntranetLinkedVpcPeerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of VPC peers.</para>
        /// </summary>
        [NameInMap("PeerVpcs")]
        [Validation(Required=false)]
        public string PeerVpcsShrink { get; set; }

        /// <summary>
        /// <para>The VPC ID. To obtain the VPC ID, see <a href="https://help.aliyun.com/document_detail/2621223.html">ListGatewayIntranetLinkedVpc</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zetuli9ws0qgjd******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
