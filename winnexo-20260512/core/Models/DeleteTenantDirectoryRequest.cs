// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class DeleteTenantDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>删除模式：reject / recursive / move_to_root</para>
        /// 
        /// <b>Example:</b>
        /// <para>reject</para>
        /// </summary>
        [NameInMap("deleteMode")]
        [Validation(Required=false)]
        public string DeleteMode { get; set; }

        /// <summary>
        /// <para>目录唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
