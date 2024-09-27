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
            /// <para>Specifies whether the service role is granted required permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("granted")]
            [Validation(Required=false)]
            public bool? Granted { get; set; }

            /// <summary>
            /// <para>The message returned if the service role is not granted required permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The role does not exist: AliyunCSManagedAutoScalerRole</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The service role name.</para>
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
