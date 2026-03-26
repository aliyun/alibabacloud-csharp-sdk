// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetShareRelationship : TeaModel {
        [NameInMap("AllowedMountAccessLevels")]
        [Validation(Required=false)]
        public List<string> AllowedMountAccessLevels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T12:23:58Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSecureMode")]
        [Validation(Required=false)]
        public bool? IsSecureMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-08-26T12:23:58Z</para>
        /// </summary>
        [NameInMap("SharedAt")]
        [Validation(Required=false)]
        public string SharedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>148***************115</para>
        /// </summary>
        [NameInMap("SourceTenantId")]
        [Validation(Required=false)]
        public string SourceTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>33**19</para>
        /// </summary>
        [NameInMap("SourceWorkspaceId")]
        [Validation(Required=false)]
        public string SourceWorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>153***************249</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42**2</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
