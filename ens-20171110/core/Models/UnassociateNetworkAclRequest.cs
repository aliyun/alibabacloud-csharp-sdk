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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// Resources that you want to disassociate. Valid values of **N**: 0 to 29. A maximum of 30 resources can be unbound.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<UnassociateNetworkAclRequestResource> Resource { get; set; }
        public class UnassociateNetworkAclRequestResource : TeaModel {
            /// <summary>
            /// The ID of the resource that you want to disassociate.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource that you want to disassociate. Valid values:
            /// 
            /// *   Network
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
