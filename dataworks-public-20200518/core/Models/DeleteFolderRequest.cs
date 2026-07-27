// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteFolderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the folder. For more information about how to obtain the folder ID, see <a href="https://help.aliyun.com/document_detail/173955.html">ListFolders</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2eb6f9****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. To obtain the workspace ID, log on to the DataWorks console and go to the Workspace Management page. You must set this parameter or ProjectIdentifier to specify the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. To obtain the workspace name, log on to the DataWorks console and go to the Workspace Management page. You must set this parameter or ProjectId to specify the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
