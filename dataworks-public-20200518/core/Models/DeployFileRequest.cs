// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeployFileRequest : TeaModel {
        /// <summary>
        /// <para>Description of this deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First release task</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the file. You can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to obtain this ID. You only need to specify this parameter or the <c>NodeId</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000022</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the task in the scheduling system for the file to be deployed. You only need to specify either this parameter or the <c>FileId</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000001</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log in to the DataWorks console and go to the workspace configuration page to obtain the workspace ID. You must set either this parameter or the ProjectIdentifier parameter to specify the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace name. You must set either this parameter or the <c>ProjectId</c> parameter to specify the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
