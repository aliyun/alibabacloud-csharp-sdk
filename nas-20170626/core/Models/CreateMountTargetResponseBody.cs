// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateMountTargetResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        [NameInMap("MountTargetExtra")]
        [Validation(Required=false)]
        public CreateMountTargetResponseBodyMountTargetExtra MountTargetExtra { get; set; }
        public class CreateMountTargetResponseBodyMountTargetExtra : TeaModel {
            [NameInMap("DualStackMountTargetDomain")]
            [Validation(Required=false)]
            public string DualStackMountTargetDomain { get; set; }
        };

    }

}
