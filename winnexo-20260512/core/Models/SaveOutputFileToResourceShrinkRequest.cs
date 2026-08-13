// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveOutputFileToResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>目标个人目录 ID；不传则自动解析用户默认目录。</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>itemIds</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("itemIds")]
        [Validation(Required=false)]
        public string ItemIdsShrink { get; set; }

        /// <summary>
        /// <para>保存方式：link=链接（1:1 幂等，编辑产出会同步资源） / copy=复制（不限次，快照）</para>
        /// 
        /// <b>Example:</b>
        /// <para>link</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
