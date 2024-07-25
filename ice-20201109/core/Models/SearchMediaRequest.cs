// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the entity.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The filter conditions. For more information about the parameter syntax, see [Media asset search protocols](https://help.aliyun.com/document_detail/2584256.html).
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The pagination identifier. The value can be up to 32 characters in length. The first time you call this operation for each new search, you do not need to specify this parameter. The value of this parameter is returned each time data records that meet the specified filter condition are found. The value is used to record the current position of queried data. Record the returned parameter value and set this parameter according to the following requirements during the next search: If you need to traverse all data that meets the filter criteria, you must set the ScrollToken parameter. If the value of the PageNo parameter exceeds 200, we recommend that you set this parameter to optimize search performance. You can only page backward. You can page a maximum of 1,000 entries in an operation.
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// The search library.
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// The sort field and order. Separate multiple parameters with commas (,).
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
