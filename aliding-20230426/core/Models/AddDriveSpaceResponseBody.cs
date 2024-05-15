// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddDriveSpaceResponseBody : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("permissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
