// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GrantMemberProjectRolesRequest : TeaModel {
        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105149</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The codes of the roles in the workspace. You can call the <a href="https://help.aliyun.com/document_detail/2853930.html">ListProjectRoles</a> operation to query the codes of all roles in the workspace.</para>
        /// <para>You must configure this parameter to specify the roles that you want to assign to members in the workspace.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public List<string> RoleCodes { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://dataworks.console.aliyun.com/product/ms_menu">DataWorks console</a>, choose More &gt; Management Center in the left-side navigation pane, select the desired workspace on the Management Center page, and then click Go to Management Center. In the left-side navigation pane of the SettingCenter page, click Tenant Members and Roles. On the Tenant Members and Roles page, view the IDs of the accounts used by the members in the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123422344899</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
