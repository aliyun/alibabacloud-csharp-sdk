// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateMountTargetResponseBody : TeaModel {
        /// <summary>
        /// The IPv4 domain name of the mount target.
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// The information about the mount target.
        /// </summary>
        [NameInMap("MountTargetExtra")]
        [Validation(Required=false)]
        public CreateMountTargetResponseBodyMountTargetExtra MountTargetExtra { get; set; }
        public class CreateMountTargetResponseBodyMountTargetExtra : TeaModel {
            /// <summary>
            /// The dual-stack (IPv4 and IPv6) domain name of the mount target.
            /// </summary>
            [NameInMap("DualStackMountTargetDomain")]
            [Validation(Required=false)]
            public string DualStackMountTargetDomain { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
