// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ListRoleUsersRequest : TeaModel {
        /// <summary>
        /// NextPageToken
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// PageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// use name pattern filter
        /// </summary>
        [NameInMap("UserNamePattern")]
        [Validation(Required=false)]
        public string UserNamePattern { get; set; }

    }

}
