// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveOutputFileToResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target personal folder. If not specified, the user\&quot;s default folder is automatically resolved.</para>
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
        /// <para>The save mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>link: Links the resource to the output in a 1:1 idempotent manner. Edits to the output are synchronized to the resource.</description></item>
        /// <item><description>copy: Creates a snapshot copy with no limit on the number of copies.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>link</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass it explicitly with --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
