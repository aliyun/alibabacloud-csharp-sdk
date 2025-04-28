// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetFileMetasRequest : TeaModel {
        /// <summary>
        /// <para>The metadata records to be updated for the dataset files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DatasetFileMetas")]
        [Validation(Required=false)]
        public List<DatasetFileMetaConentUpdate> DatasetFileMetas { get; set; }

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
        /// <para>The ID of the tagging job that is associated with the metadata tag of the dataset file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-hv0b1****u8taig3y</para>
        /// </summary>
        [NameInMap("TagJobId")]
        [Validation(Required=false)]
        public string TagJobId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. To obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>796**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
