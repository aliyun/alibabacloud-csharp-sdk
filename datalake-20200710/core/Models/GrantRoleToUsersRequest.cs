// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GrantRoleToUsersRequest : TeaModel {
        /// <summary>
        /// RoleName
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<Principal> Users { get; set; }

    }

}
