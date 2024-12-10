// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteGatewayIntranetLinkedVpcPeerRequest : TeaModel {
        /// <summary>
        /// <para>The VPC peer.</para>
        /// </summary>
        [NameInMap("PeerVpcs")]
        [Validation(Required=false)]
        public List<DeleteGatewayIntranetLinkedVpcPeerRequestPeerVpcs> PeerVpcs { get; set; }
        public class DeleteGatewayIntranetLinkedVpcPeerRequestPeerVpcs : TeaModel {
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
            /// <para>The ID of the VPC peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf66uio7md****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the associated VPC. To obtain the VPC ID, see <a href="https://help.aliyun.com/document_detail/2621223.html">ListGatewayIntranetLinkedVpc</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zetuli9ws0qgjd******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
