// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ExportPptArtifactRequest : TeaModel {
        /// <summary>
        /// <para>Indicates if the exported artifact is editable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Edit")]
        [Validation(Required=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// <para>The export file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppt</para>
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The ID of the PPT artifact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("PptArtifactId")]
        [Validation(Required=false)]
        public long? PptArtifactId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>Indicates if the exported file is compressed into a ZIP package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Zip")]
        [Validation(Required=false)]
        public bool? Zip { get; set; }

    }

}
