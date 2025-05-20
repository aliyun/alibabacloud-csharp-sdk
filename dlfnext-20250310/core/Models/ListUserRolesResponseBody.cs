// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListUserRolesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>token!</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<Role> Roles { get; set; }

    }

}
