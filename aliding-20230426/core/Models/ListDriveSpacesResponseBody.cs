// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListDriveSpacesResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("spaces")]
        [Validation(Required=false)]
        public List<ListDriveSpacesResponseBodySpaces> Spaces { get; set; }
        public class ListDriveSpacesResponseBodySpaces : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("PermissionMode")]
            [Validation(Required=false)]
            public string PermissionMode { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("SpaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            [NameInMap("SpaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
