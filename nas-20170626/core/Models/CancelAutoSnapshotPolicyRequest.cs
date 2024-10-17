// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of file systems.</para>
        /// <para>You can specify a maximum of 100 file system IDs. If you want to remove automatic snapshot policies from multiple file systems, separate the file system IDs with commas (,).</para>
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
