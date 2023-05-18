// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class DisassociateResourceShareRequest : TeaModel {
        /// <summary>
        /// The information of the entities that are associated with the resource share.
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// The ID of a shared resource.
        /// 
        /// Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.
        /// 
        /// >  Resources.N.ResourceId and Resources.N.ResourceType must be used in pairs.
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DisassociateResourceShareRequestResources> Resources { get; set; }
        public class DisassociateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// The owner of the resource share. Valid values:
            /// 
            /// *   Self: The resource share belongs to the current account. This is the default value. If you are the management account or a member of a resource directory and you want to remove resources or principals from a resource share, set this parameter to Self.
            /// *   OtherAccounts: The resource share belongs to another account. If you are not the management account or a member of a resource directory and you want to exit a resource share, set this parameter to OtherAccounts.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The ID of a principal.
            /// 
            /// Valid values of N: 1 to 5. This indicates that a maximum of five principals can be specified at a time.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}
