// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetFileMetasRequest : TeaModel {
        /// <summary>
        /// <para>A list of file metadata content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DatasetFileMetas")]
        [Validation(Required=false)]
        public List<DatasetFileMetaContentCreate> DatasetFileMetas { get; set; }

        /// <summary>
        /// <para>The name of the dataset version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the dataset is located. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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
