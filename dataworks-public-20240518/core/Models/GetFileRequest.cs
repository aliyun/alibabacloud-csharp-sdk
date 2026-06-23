// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file. You can invoke the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> API to query the ID of the corresponding file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the scheduling node. You can invoke the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> API to obtain the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200000001</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>You must specify either this parameter or the ProjectIdentifier parameter to identify the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, and go to the workspace configuration page to obtain the workspace name.</para>
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
