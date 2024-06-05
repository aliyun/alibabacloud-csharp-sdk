// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ApplyAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the automatic snapshot policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// The IDs of advanced Extreme NAS file systems.
        /// 
        /// You can specify a maximum of 100 file system IDs at a time. If you want to apply an automatic snapshot policy to multiple file systems, separate the file system IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemIds")]
        [Validation(Required=false)]
        public string FileSystemIds { get; set; }

    }

}
