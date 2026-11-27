// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>General-purpose NAS: 31a8e4****.</description></item>
        /// <item><description>Extreme NAS: The ID must start with <c>extreme-</c>, such as extreme-0015****.</description></item>
        /// <item><description>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-00cb6fa094ca****.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
