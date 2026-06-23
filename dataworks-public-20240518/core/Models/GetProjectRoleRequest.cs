// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectRoleRequest : TeaModel {
        /// <summary>
        /// <para>The code of the workspace role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>role_project_admin: workspace administrator</para>
        /// </description></item>
        /// <item><description><para>role_project_dev: developer</para>
        /// </description></item>
        /// <item><description><para>role_project_dg_admin: data governance administrator</para>
        /// </description></item>
        /// <item><description><para>role_project_guest: guest</para>
        /// </description></item>
        /// <item><description><para>role_project_security: security administrator</para>
        /// </description></item>
        /// <item><description><para>role_project_deploy: deployer</para>
        /// </description></item>
        /// <item><description><para>role_project_owner: workspace owner</para>
        /// </description></item>
        /// <item><description><para>role_project_data_analyst: data analyst</para>
        /// </description></item>
        /// <item><description><para>role_project_pe: O\&amp;M engineer</para>
        /// </description></item>
        /// <item><description><para>role_project_erd: model designer</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_project_guest</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
