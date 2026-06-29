// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the file systems.</para>
        /// <para>You can specify up to 100 file systems in a single call. To cancel the automatic snapshot policy for multiple file systems, separate the file system IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme-233e6****,extreme-23vbp****,extreme-23vas****</para>
        /// </summary>
        [NameInMap("FileSystemIds")]
        [Validation(Required=false)]
        public string FileSystemIds { get; set; }

    }

}
