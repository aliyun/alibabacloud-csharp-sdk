// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveGroupOutputFileToGroupResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target personal directory. If not specified, the user\&quot;s default directory is automatically resolved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The project group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleGroupId</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>itemIds</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;item-1&quot;,&quot;item-2&quot;]</para>
        /// </summary>
        [NameInMap("itemIds")]
        [Validation(Required=false)]
        public string ItemIdsShrink { get; set; }

        /// <summary>
        /// <para>The save mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>link: creates a link (1:1 idempotent, editing the output synchronizes the resource).</description></item>
        /// <item><description>copy: creates a copy (unlimited times, snapshot).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>link</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass this value explicitly by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
