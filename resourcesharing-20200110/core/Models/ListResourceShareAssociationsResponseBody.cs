// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareAssociationsResponseBody : TeaModel {
        /// <summary>
        /// The `token` that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the entities.
        /// </summary>
        [NameInMap("ResourceShareAssociations")]
        [Validation(Required=false)]
        public List<ListResourceShareAssociationsResponseBodyResourceShareAssociations> ResourceShareAssociations { get; set; }
        public class ListResourceShareAssociationsResponseBodyResourceShareAssociations : TeaModel {
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
            [NameInMap("AssociationStatus")]
            [Validation(Required=false)]
            public string AssociationStatus { get; set; }

            /// <summary>
            /// The cause of the association failure.
            /// </summary>
            [NameInMap("AssociationStatusMessage")]
            [Validation(Required=false)]
            public string AssociationStatusMessage { get; set; }

            /// <summary>
            /// The association type. Valid values:
            /// 
            /// *   Resource
            /// *   Target
            /// </summary>
            [NameInMap("AssociationType")]
            [Validation(Required=false)]
            public string AssociationType { get; set; }

            /// <summary>
            /// The time when the association of the entity was created. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the time when the shared resource was associated with or disassociated from the resource share.
            /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the time when the principal was associated with or disassociated from the resource share.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the entity. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the ID of the shared resource.
            /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the ID of the principal.
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// The type of the entity. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of AssociationType is Resource, the value of this parameter is the type of the resource. For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
            /// *   If the value of AssociationType is Target, the value of this parameter is `Account`.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// Indicates whether the principal is outside the resource directory. Valid values:
            /// 
            /// *   true: The principal is outside the resource directory.
            /// *   false: The principal is in the resource directory.
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public bool? External { get; set; }

            /// <summary>
            /// The ID of the resource share.
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// The name of the resource share.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// The time when the association of the entity was updated. The value of this parameter depends on the value of the AssociationType parameter:
            /// 
            /// *   If the value of `AssociationType` is `Resource`, the value of this parameter is the time when the association of the shared resource was updated.
            /// *   If the value of `AssociationType` is `Target`, the value of this parameter is the time when the association of the principal was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
