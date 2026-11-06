// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectMembersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the requested data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace used when you invoke this API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62136</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of workspace role codes. You can call the <a href="https://help.aliyun.com/document_detail/2853930.html">ListProjectRoles</a> operation to obtain the role codes.</para>
        /// </summary>
        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public string RoleCodesShrink { get; set; }

        /// <summary>
        /// <para>The list of DataWorks account IDs. You can log on to the <a href="https://dataworks.console.aliyun.com/product/ms_menu">DataWorks console - Administration</a>, select the workspace that you want to manage, go to the Administration page, and then go to the Tenant Members and Roles page to view the account IDs.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIdsShrink { get; set; }

    }

}
