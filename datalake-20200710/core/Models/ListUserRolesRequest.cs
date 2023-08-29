// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ListUserRolesRequest : TeaModel {
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// PageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrincipalArn")]
        [Validation(Required=false)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// role name pattern filter
        /// </summary>
        [NameInMap("RoleNamePattern")]
        [Validation(Required=false)]
        public string RoleNamePattern { get; set; }

    }

}
