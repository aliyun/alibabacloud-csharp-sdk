// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Sample ID of a General-purpose NAS file system: 31a8e4\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of Extreme NAS file systems must start with <c>extreme-</c>, for example, extreme-0015\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of Cloud Parallel File Storage (CPFS) file systems must start with <c>cpfs-</c>, for example, cpfs-00cb6fa094ca\<em>\</em>\<em>\</em>.</description></item>
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
