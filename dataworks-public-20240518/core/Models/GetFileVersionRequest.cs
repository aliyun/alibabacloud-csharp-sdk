// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file. You can call <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> to query the file ID.</para>
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
        /// <para>The ID of the DataWorks workspace. You can click the small wrench icon in the upper-right corner of the page to go to the storage management page and view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000011</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed at the top of the DataStudio page for switching workspaces.</para>
        /// <para>You must set either this parameter or ProjectId to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
