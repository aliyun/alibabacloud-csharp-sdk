// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetFileMetasRequest : TeaModel {
        /// <summary>
        /// <para>A list of dataset file metadata to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DatasetFileMetas")]
        [Validation(Required=false)]
        public List<DatasetFileMetaConentUpdate> DatasetFileMetas { get; set; }

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
        /// <para>The ID of the tagging job for updating metadata tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-hv0b1****u8taig3y</para>
        /// </summary>
        [NameInMap("TagJobId")]
        [Validation(Required=false)]
        public string TagJobId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the dataset. For more information, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>796**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
