// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The check results.</para>
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleResponseBodyRoles> Roles { get; set; }
        public class CheckServiceRoleResponseBodyRoles : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service role is assigned to ACK.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The role is assigned to ACK.</description></item>
            /// <item><description>false: The role is not assigned to ACK.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("granted")]
            [Validation(Required=false)]
            public bool? Granted { get; set; }

            /// <summary>
            /// <para>The message that is displayed for a role that is not assigned to ACK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The role does not exist: AliyunCSManagedAutoScalerRole</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the service role.</para>
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
