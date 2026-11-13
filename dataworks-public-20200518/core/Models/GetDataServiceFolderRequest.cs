// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderRequest : TeaModel {
        /// <summary>
        /// <para>The folder ID.</para>
        /// <para>You can obtain this ID from the FolderPagingResult.Folders[].FolderId parameter in the response of the ListDataServiceFolders operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public long? FolderId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>You can obtain this ID from the PageResult.ProjectList[].ProjectId parameter in the response of the ListProjects operation.</para>
        /// <para>Before calling ListProjects to obtain the workspace ID, ensure that your account has the required DataWorks edition and the necessary permissions. The sample ID is for format demonstration only.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The tenant ID. To obtain the tenant ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the current username in the upper-right corner, and choose Menu &gt; User Info.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10003</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
