// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDeploymentPackageRequest : TeaModel {
        /// <summary>
        /// <para>The deployment package ID. This ID is generated when you call <a href="https://help.aliyun.com/document_detail/173944.html">SubmitFile</a> or <a href="https://help.aliyun.com/document_detail/173956.html">DeployFile</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000001</para>
        /// </summary>
        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public long? DeploymentId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID. This parameter identifies the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace. This is the identifier shown in the workspace switcher at the top of the Data Studio page.</para>
        /// <para>Either this parameter or ProjectId must be specified to determine which DataWorks workspace this API call operates on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
