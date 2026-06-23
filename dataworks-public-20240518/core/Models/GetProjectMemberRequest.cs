// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataWorks Workspace. You can sign in to the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks Console</a> and go to the Workspace Management page to obtain the Workspace ID.</para>
        /// <para>This parameter is used to identify the DataWorks workspace that you want to access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88757</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the user. To find the ID, sign in to the <a href="https://dataworks.console.aliyun.com/product/ms_menu">DataWorks Console</a>, go to the Management Center, select the target Workspace, and open the Tenant Members and Roles page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123422****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
