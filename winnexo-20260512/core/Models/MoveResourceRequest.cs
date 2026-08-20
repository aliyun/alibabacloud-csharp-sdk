// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MoveResourceRequest : TeaModel {
        /// <summary>
        /// <para>The source directory ID, which is the personal directory where the resource currently resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceDirectoryId</para>
        /// </summary>
        [NameInMap("sourceDirectoryId")]
        [Validation(Required=false)]
        public string SourceDirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be moved.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The target directory ID, which is the personal directory to which the resource will be moved.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTargetDirectoryId</para>
        /// </summary>
        [NameInMap("targetDirectoryId")]
        [Validation(Required=false)]
        public string TargetDirectoryId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can view the tenant ID by logging on to the MaxCompute console and choosing <b>Tenant Management</b> &gt; <b>Tenant Properties</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PiPklI1iSRTm6VFFqlY9VzbgiEiE</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
