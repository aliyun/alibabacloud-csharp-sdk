// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetBusinessRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business flow. You can call the <a href="https://help.aliyun.com/document_detail/173945.html">ListBusiness</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000111</para>
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace ID. You must specify either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace for the API operation. You can also call the ListProjects operation to query the workspace ID under the current tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace name. You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

    }

}
