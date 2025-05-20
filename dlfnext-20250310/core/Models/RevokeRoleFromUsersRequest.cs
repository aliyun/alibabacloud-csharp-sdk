// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class RevokeRoleFromUsersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:dlf::[accountId]:role/role_name</para>
        /// </summary>
        [NameInMap("rolePrincipal")]
        [Validation(Required=false)]
        public string RolePrincipal { get; set; }

        [NameInMap("userPrincipals")]
        [Validation(Required=false)]
        public List<string> UserPrincipals { get; set; }

    }

}
