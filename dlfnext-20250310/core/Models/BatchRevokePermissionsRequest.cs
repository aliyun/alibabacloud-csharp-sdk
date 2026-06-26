// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class BatchRevokePermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The permissions to revoke.</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<Permission> Permissions { get; set; }

    }

}
