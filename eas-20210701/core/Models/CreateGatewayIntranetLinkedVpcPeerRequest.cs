// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayIntranetLinkedVpcPeerRequest : TeaModel {
        /// <summary>
        /// <para>The list of VPC peers.</para>
        /// </summary>
        [NameInMap("PeerVpcs")]
        [Validation(Required=false)]
        public List<CreateGatewayIntranetLinkedVpcPeerRequestPeerVpcs> PeerVpcs { get; set; }
        public class CreateGatewayIntranetLinkedVpcPeerRequestPeerVpcs : TeaModel {
            /// <summary>
            /// <para>The region where the VPC peer resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the VPC peer. To obtain the VPC ID, see <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf66uio7md****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

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
