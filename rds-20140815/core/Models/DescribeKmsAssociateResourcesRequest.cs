// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeKmsAssociateResourcesRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("KmsResourceId")]
        [Validation(Required=false)]
        public string KmsResourceId { get; set; }

        [NameInMap("KmsResourceRegionId")]
        [Validation(Required=false)]
        public string KmsResourceRegionId { get; set; }

        [NameInMap("KmsResourceType")]
        [Validation(Required=false)]
        public string KmsResourceType { get; set; }

        [NameInMap("KmsResourceUser")]
        [Validation(Required=false)]
        public string KmsResourceUser { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
