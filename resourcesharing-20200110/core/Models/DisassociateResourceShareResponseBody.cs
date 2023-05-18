// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class DisassociateResourceShareResponseBody : TeaModel {
        /// <summary>
        /// The time when the disassociation of the entity was updated. The value of this parameter depends on the value of the AssociationType parameter:
        /// 
        /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the time when the disassociation of the resource was updated.
        /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the time when the disassociation of the principal was updated.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the entity. The value of this parameter depends on the value of the AssociationType parameter:
        /// 
        /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the ID of the resource.
        /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the ID of the resource directory, folder, or member.
        /// </summary>
        [NameInMap("ResourceShareAssociations")]
        [Validation(Required=false)]
        public List<DisassociateResourceShareResponseBodyResourceShareAssociations> ResourceShareAssociations { get; set; }
        public class DisassociateResourceShareResponseBodyResourceShareAssociations : TeaModel {
            [NameInMap("AssociationStatus")]
            [Validation(Required=false)]
            public string AssociationStatus { get; set; }

            /// <summary>
            /// The association status. Valid values:
            /// 
            /// *   Associating: The entity is being associated.
            /// *   Associated: The entity is associated.
            /// *   Failed: The entity fails to be associated.
            /// *   Disassociating: The entity is being disassociated.
            /// *   Disassociated: The entity is disassociated.
            /// 
            /// >  The system deletes the records of entities in the `Failed` or `Disassociated` state within 48 hours to 96 hours.
            /// </summary>
            [NameInMap("AssociationStatusMessage")]
            [Validation(Required=false)]
            public string AssociationStatusMessage { get; set; }

            [NameInMap("AssociationType")]
            [Validation(Required=false)]
            public string AssociationType { get; set; }

            /// <summary>
            /// The ID of the resource share.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the disassociation of the entity was performed. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the time when the resource was disassociated from the resource share.
            /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the time when the principal was disassociated from the resource share.
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// The cause of the disassociation failure.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// The association type. Valid values:
            /// 
            /// *   Resource
            /// *   Target
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// The type of the entity. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of AssociationType is Resource, the value of this parameter is the type of the resource. For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
            /// *   If the value of AssociationType is Target, the value of this parameter is Account.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// The name of the resource share.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
