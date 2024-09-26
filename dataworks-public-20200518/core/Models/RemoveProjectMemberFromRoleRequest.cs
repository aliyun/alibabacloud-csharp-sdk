// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RemoveProjectMemberFromRoleRequest : TeaModel {
        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The code of the role in the DataWorks workspace. You can call the ListProjectRoles operation to query the codes of all roles in a DataWorks workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>role_project_owner: workspace owner</description></item>
        /// <item><description>role_project_admin: workspace administrator</description></item>
        /// <item><description>role_project_dev: developer</description></item>
        /// <item><description>role_project_pe: O\&amp;M engineer</description></item>
        /// <item><description>role_project_deploy: deployment expert</description></item>
        /// <item><description>role_project_guest: visitor</description></item>
        /// <item><description>role_project_security: security administrator</description></item>
        /// <item><description>role_project_tester: experiencer</description></item>
        /// <item><description>role_project_erd: model designer</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_project_guest</para>
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
