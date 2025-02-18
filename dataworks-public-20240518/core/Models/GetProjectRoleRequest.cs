// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectRoleRequest : TeaModel {
        /// <summary>
        /// <para>The code of the role in the DataWorks workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>role_project_admin: workspace administrator</description></item>
        /// <item><description>role_project_dev: developer</description></item>
        /// <item><description>role_project_dg_admin: data governance administrator</description></item>
        /// <item><description>role_project_guest: visitor</description></item>
        /// <item><description>role_project_security: security administrator</description></item>
        /// <item><description>role_project_deploy: deployer</description></item>
        /// <item><description>role_project_owner: workspace owner</description></item>
        /// <item><description>role_project_data_analyst: data analyst</description></item>
        /// <item><description>role_project_pe: O\&amp;M engineer</description></item>
        /// <item><description>role_project_erd: model designer</description></item>
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
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
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
