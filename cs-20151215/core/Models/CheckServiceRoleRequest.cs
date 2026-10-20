// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of service roles to check.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleRequestRoles> Roles { get; set; }
        public class CheckServiceRoleRequestRoles : Darabonba.Model {
            /// <summary>
            /// <para>Container service role name. For information about container service roles and permission scopes included in ACK, see <a href="https://help.aliyun.com/document_detail/86483.html">ACK service roles</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunCSManagedAutoScalerRole</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

