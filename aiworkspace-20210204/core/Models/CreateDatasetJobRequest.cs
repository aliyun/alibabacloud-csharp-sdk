// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a job description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The task operation.</para>
        /// <list type="bullet">
        /// <item><description><para>SemanticIndex: semantic index</para>
        /// </description></item>
        /// <item><description><para>IntelligentTag: intelligent tagging</para>
        /// </description></item>
        /// <item><description><para>FileMetaExport: metadata export</para>
        /// </description></item>
        /// <item><description><para>FileMetaBuild: build and update metadata</para>
        /// </description></item>
        /// <item><description><para>IntelligentTagRevert: revoke intelligent tagging</para>
        /// </description></item>
        /// <item><description><para>FileMetaImport: metadata import</para>
        /// </description></item>
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
        /// <para>The task type.</para>
        /// <list type="bullet">
        /// <item><description><para>Full (default): forces the processing of all metadata. This task takes a long time to execute.</para>
        /// </description></item>
        /// <item><description><para>Increment: processes only changed or unsuccessfully processed metadata. The SemanticIndex and IntelligentTag tasks support Increment and Full. Other tasks support only Full.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;modelId\&quot;:\&quot;xxx\&quot;}</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpec { get; set; }

        /// <summary>
        /// <para>The workspace ID. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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
