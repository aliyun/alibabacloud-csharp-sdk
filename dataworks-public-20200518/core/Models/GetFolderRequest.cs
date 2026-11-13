// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFolderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the folder. You must specify either this parameter or FolderPath. You can call the <a href="https://help.aliyun.com/document_detail/173955.html">ListFolders</a> operation to obtain the folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The path of the folder. You must specify either this parameter or FolderId. You can call the <a href="https://help.aliyun.com/document_detail/173955.html">ListFolders</a> operation to obtain the folder path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/my_first_business_process/MaxCompute/ods_layer</para>
        /// </summary>
        [NameInMap("FolderPath")]
        [Validation(Required=false)]
        public string FolderPath { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace ID. You must specify either this parameter or ProjectIdentifier to determine the DataWorks workspace for the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000011</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace name. You must specify either this parameter or ProjectId to determine the DataWorks workspace for the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
