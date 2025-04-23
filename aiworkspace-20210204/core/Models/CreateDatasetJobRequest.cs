// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetJobRequest : TeaModel {
        /// <summary>
        /// <para>The dataset version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The job action.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SemanticIndex</description></item>
        /// <item><description>IntelligentTag</description></item>
        /// <item><description>FileMetaExport</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SemanticIndex</para>
        /// </summary>
        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <para>The job mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Full: full mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        /// <summary>
        /// <para>The job configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;modelId\&quot;:\&quot;xxx\&quot;}</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpec { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
