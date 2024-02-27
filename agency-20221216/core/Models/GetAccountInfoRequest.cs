// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoRequest : TeaModel {
        /// <summary>
        /// Pagination, current page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Pagination, record number on each page, maximum 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Account UID of Distribution Customer. This parameter and the UserType parameter must have one filled. If this parameter is empty, then check all Distribution Customer accounts of the selected UserType.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// Distribution Customer\"s Account Type:
        /// - 1 End User
        /// - 2 Enterprise
        /// - 3 T2 Partner
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
