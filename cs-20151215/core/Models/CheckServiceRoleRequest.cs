// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleRequest : TeaModel {
        /// <summary>
        /// The service roles that you want to check.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleRequestRoles> Roles { get; set; }
        public class CheckServiceRoleRequestRoles : TeaModel {
            /// <summary>
            /// The service role name.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
