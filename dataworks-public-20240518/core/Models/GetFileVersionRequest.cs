// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file. You can obtain the ID of the desired file by calling <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The version of the file to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FileVersion")]
        [Validation(Required=false)]
        public int? FileVersion { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can click the wrench icon in the upper-right corner of the page to go to the Workspace Management page and view it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000011</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed at the top of the Data Development page when you switch workspaces.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to identify the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
