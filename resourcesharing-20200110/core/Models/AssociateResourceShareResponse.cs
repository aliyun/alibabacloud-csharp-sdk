// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AssociateResourceShareResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceShareAssociations")]
        [Validation(Required=true)]
        public List<AssociateResourceShareResponseResourceShareAssociations> ResourceShareAssociations { get; set; }
        public class AssociateResourceShareResponseResourceShareAssociations : TeaModel {
            [NameInMap("ResourceShareId")]
            [Validation(Required=true)]
            public string ResourceShareId { get; set; }

            [NameInMap("ResourceShareName")]
            [Validation(Required=true)]
            public string ResourceShareName { get; set; }

            [NameInMap("AssociationType")]
            [Validation(Required=true)]
            public string AssociationType { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=true)]
            public string EntityId { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=true)]
            public string EntityType { get; set; }

            [NameInMap("AssociationStatus")]
            [Validation(Required=true)]
            public string AssociationStatus { get; set; }

            [NameInMap("AssociationStatusMessage")]
            [Validation(Required=true)]
            public string AssociationStatusMessage { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

        }

    }

}
