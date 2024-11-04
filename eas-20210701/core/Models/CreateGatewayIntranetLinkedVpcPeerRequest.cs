// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayIntranetLinkedVpcPeerRequest : TeaModel {
        [NameInMap("PeerVpcs")]
        [Validation(Required=false)]
        public List<CreateGatewayIntranetLinkedVpcPeerRequestPeerVpcs> PeerVpcs { get; set; }
        public class CreateGatewayIntranetLinkedVpcPeerRequestPeerVpcs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-uf66uio7md****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-2zetuli9ws0qgjd******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
