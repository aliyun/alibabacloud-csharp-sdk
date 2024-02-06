// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnassociateNetworkAclRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL that you want to disassociate from a resource.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The information about the associated resource.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<UnassociateNetworkAclRequestResource> Resource { get; set; }
        public class UnassociateNetworkAclRequestResource : TeaModel {
            /// <summary>
            /// The ID of the resource from which you want to disassociate the network ACL.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource from which you want to disassociate the network ACL. Set the value to **Network**.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
