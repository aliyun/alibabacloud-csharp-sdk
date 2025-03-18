// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleRequest : TeaModel {
        /// <summary>
        /// <para>The service roles that you want to check.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleRequestRoles> Roles { get; set; }
        public class CheckServiceRoleRequestRoles : TeaModel {
            /// <summary>
            /// <para>The name of the service role. For more information about ACK roles, see <a href="https://help.aliyun.com/document_detail/86483.html">ACK roles</a>.</para>
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
