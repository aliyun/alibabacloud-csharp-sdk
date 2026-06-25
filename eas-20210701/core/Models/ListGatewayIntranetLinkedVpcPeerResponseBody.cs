// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayIntranetLinkedVpcPeerResponseBody : TeaModel {
        /// <summary>
        /// <para>The private gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>A list of peer VPCs.</para>
        /// </summary>
        [NameInMap("PeerVpcList")]
        [Validation(Required=false)]
        public List<ListGatewayIntranetLinkedVpcPeerResponseBodyPeerVpcList> PeerVpcList { get; set; }
        public class ListGatewayIntranetLinkedVpcPeerResponseBodyPeerVpcList : TeaModel {
            /// <summary>
            /// <para>A list of peer VPC IDs.</para>
            /// </summary>
            [NameInMap("PeerVpcs")]
            [Validation(Required=false)]
            public List<ListGatewayIntranetLinkedVpcPeerResponseBodyPeerVpcListPeerVpcs> PeerVpcs { get; set; }
            public class ListGatewayIntranetLinkedVpcPeerResponseBodyPeerVpcListPeerVpcs : TeaModel {
                /// <summary>
                /// <para>The region where the peer VPC is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the peer VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf66uio7md****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zetuli9ws0qgjd******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
