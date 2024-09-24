// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleResponseBody : TeaModel {
        /// <summary>
        /// The check results.
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleResponseBodyRoles> Roles { get; set; }
        public class CheckServiceRoleResponseBodyRoles : TeaModel {
            /// <summary>
            /// Specifies whether the service role is granted required permissions.
            /// </summary>
            [NameInMap("granted")]
            [Validation(Required=false)]
            public bool? Granted { get; set; }

            /// <summary>
            /// The message returned if the service role is not granted required permissions.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The service role name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
