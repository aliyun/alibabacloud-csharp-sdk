// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment task. A deployment task ID is generated when you call the <a href="https://help.aliyun.com/document_detail/173944.html">SubmitFile</a> or <a href="https://help.aliyun.com/document_detail/173956.html">DeployFile</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000001</para>
        /// </summary>
        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public long? DeploymentId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can click the Workspace Manage icon in the upper-right corner of the DataStudio page to go to the Workspace Management page and view the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The GUID of the DataWorks workspace. You can view the GUID in the upper part of the DataStudio page. You can also select another GUID to switch to another workspace.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
