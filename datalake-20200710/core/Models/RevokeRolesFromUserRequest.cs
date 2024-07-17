// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class RevokeRolesFromUserRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public List<string> RoleNames { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public Principal User { get; set; }

    }

}
