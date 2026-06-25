// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteWorkspaceRolesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the roles to delete.</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public List<string> RoleIds { get; set; }

    }

}
