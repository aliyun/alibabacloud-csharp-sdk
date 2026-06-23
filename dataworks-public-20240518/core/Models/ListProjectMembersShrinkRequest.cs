// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectMembersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
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
        /// <para>The ID of the DataWorks workspace. To obtain this ID, log in to the <a href="https://workbench.data.aliyun.com/console">DataWorks Console</a> and go to the Workspace Management page.</para>
        /// <para>This parameter specifies the DataWorks workspace for the API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62136</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>A list of role codes for the workspace to filter the results. You can call the <a href="https://help.aliyun.com/document_detail/2853930.html">ListProjectRoles</a> operation to obtain the role codes.</para>
        /// </summary>
        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public string RoleCodesShrink { get; set; }

        /// <summary>
        /// <para>A list of DataWorks user IDs to filter the results. You can find these IDs on the <a href="https://dataworks.console.aliyun.com/product/ms_menu">Tenant Members and Roles</a> page in the Management Center.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIdsShrink { get; set; }

    }

}
