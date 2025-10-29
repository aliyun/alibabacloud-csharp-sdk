// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFolderRequest : TeaModel {
        /// <summary>
        /// <para>The folder ID. Either this parameter or FolderPath must be specified. You can call the <a href="https://help.aliyun.com/document_detail/173955.html">ListFolders</a> operation to obtain the folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The folder path. Either this parameter or FolderId must be specified. You can call the <a href="https://help.aliyun.com/document_detail/173955.html">ListFolders</a> operation to obtain the folder path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/my_first_business_process/MaxCompute/ods_layer</para>
        /// </summary>
        [NameInMap("FolderPath")]
        [Validation(Required=false)]
        public string FolderPath { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can obtain the workspace ID from the workspace configuration page in the DataWorks console. Either this parameter or ProjectIdentifier must be specified to determine which DataWorks workspace this API call operates on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000011</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can obtain the workspace name from the workspace configuration page in the DataWorks console. Either this parameter or ProjectId must be specified to determine which DataWorks workspace this API call operates on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
