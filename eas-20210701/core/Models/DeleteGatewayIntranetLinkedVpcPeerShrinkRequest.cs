// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteGatewayIntranetLinkedVpcPeerShrinkRequest : TeaModel {
        [NameInMap("PeerVpcs")]
        [Validation(Required=false)]
        public string PeerVpcsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-2zetuli9ws0qgjd******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
