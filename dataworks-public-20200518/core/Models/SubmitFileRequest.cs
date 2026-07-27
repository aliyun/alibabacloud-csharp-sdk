// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SubmitFileRequest : TeaModel {
        /// <summary>
        /// <para>The comment for the submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Submit a task for the first time</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the file. Obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks Console and go to the Workspace Configurations page to obtain the workspace ID. Specify either this parameter or <c>ProjectIdentifier</c> to identify the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the DataWorks Console and go to the Workspace Configurations page to obtain the workspace name. Specify either this parameter or <c>ProjectId</c> to identify the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the pre-deployment check after the file is submitted.</para>
        /// <list type="bullet">
        /// <item><description><para>false: Do not skip. After the file is submitted, the pre-deployment check process is automatically triggered. The file becomes deployable only after it passes the check.</para>
        /// </description></item>
        /// <item><description><para>true: Skip. The pre-deployment check process is not triggered after the file is submitted. You can proceed directly with the deployment process.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipAllDeployFileExtensions")]
        [Validation(Required=false)]
        public bool? SkipAllDeployFileExtensions { get; set; }

    }

}
