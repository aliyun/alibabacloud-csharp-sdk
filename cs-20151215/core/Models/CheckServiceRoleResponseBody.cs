// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The service role check results.</para>
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleResponseBodyRoles> Roles { get; set; }
        public class CheckServiceRoleResponseBodyRoles : Darabonba.Model {
            /// <summary>
            /// <para>Indicates whether the role has been authorized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("granted")]
            [Validation(Required=false)]
            public bool? Granted { get; set; }

            /// <summary>
            /// <para>The message returned when the role is not authorized.</para>
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

