// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// 机构ID
        /// </summary>
        [NameInMap("organizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 单页大小，默认20
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
