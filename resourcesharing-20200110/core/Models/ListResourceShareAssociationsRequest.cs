// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareAssociationsRequest : TeaModel {
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
        /// The association type. Valid values:
        /// 
        /// *   Resource
        /// *   Target
        /// </summary>
        [NameInMap("AssociationType")]
        [Validation(Required=false)]
        public string AssociationType { get; set; }

        /// <summary>
        /// The maximum number of entries to return for a single request.
        /// 
        /// Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The `token` that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// 
        /// >  This parameter is unavailable if you set the `AssociationType` parameter to `Target`.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// The ID of the principal.
        /// 
        /// >  This parameter is unavailable if you set the `AssociationType` parameter to `Resource`.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
