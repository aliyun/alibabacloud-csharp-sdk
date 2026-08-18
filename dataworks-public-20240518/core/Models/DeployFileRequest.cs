// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeployFileRequest : TeaModel {
        /// <summary>
        /// <para>The description of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First release task</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the file. You can call <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> to query the file ID. You need to specify only one of this parameter and the NodeId parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the node in the scheduling system that corresponds to the file to be published.</para>
        /// <para>You need to specify only one of this parameter and the FileId parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000001</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace ID. You must specify either this parameter or ProjectIdentifier to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace.</para>
        /// <para>You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace name. You must specify either this parameter or ProjectId to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
