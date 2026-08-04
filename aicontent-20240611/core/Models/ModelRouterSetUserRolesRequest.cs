// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterSetUserRolesRequest : TeaModel {
        /// <summary>
        /// <para>The department role list (required, full overwrite).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;clientId&quot;:1001,&quot;roleCode&quot;:&quot;member&quot;},{&quot;clientId&quot;:1002,&quot;roleCode&quot;:&quot;member&quot;}]</para>
        /// </summary>
        [NameInMap("departmentRoles")]
        [Validation(Required=false)]
        public List<DepartmentRoleCmd> DepartmentRoles { get; set; }

    }

}
