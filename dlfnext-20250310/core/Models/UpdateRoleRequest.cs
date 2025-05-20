// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class UpdateRoleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>role_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>role_display_name</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:dlf::[accountId]:role/role_name</para>
        /// </summary>
        [NameInMap("rolePrincipal")]
        [Validation(Required=false)]
        public string RolePrincipal { get; set; }

    }

}
