// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ListRolesRequest : TeaModel {
        /// <summary>
        /// Next PageToken
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RoleNamePattern")]
        [Validation(Required=false)]
        public string RoleNamePattern { get; set; }

    }

}
