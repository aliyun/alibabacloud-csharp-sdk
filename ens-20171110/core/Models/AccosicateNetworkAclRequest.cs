// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AccosicateNetworkAclRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The information about the resources with which you want to associate the network ACL.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<AccosicateNetworkAclRequestResource> Resource { get; set; }
        public class AccosicateNetworkAclRequestResource : TeaModel {
            /// <summary>
            /// The ID of the resource with which you want to associate the network ACL.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of resource with which you want to associate the network ACL. Set the value to **Network**.
            /// 
            /// ****
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
