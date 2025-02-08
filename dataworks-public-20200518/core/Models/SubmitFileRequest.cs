// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SubmitFileRequest : TeaModel {
        /// <summary>
        /// <para>The description of the commit operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Submit a task for the first time</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The file ID. You can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to query the file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to query the ID. You must configure either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace page to obtain the workspace name. You must configure either this parameter or the ProjectId parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the pre-publish check after the file is committed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: indicates that the pre-publish check is not skipped. After the file is committed, the pre-publish check is automatically triggered. The file can be deployed only after the file passes the check.</description></item>
        /// <item><description>true: indicates that the pre-publish check is skipped. After the file is submitted, the pre-publish check process is not triggered. You can directly deploy the file.</description></item>
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
