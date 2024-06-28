// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitRequest : TeaModel {
        /// <summary>
        /// The user ID of the cost center owner.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page. A maximum of 300 entries can be returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the parent cost center. A value of -1 indicates the root cost center.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParentUnitId")]
        [Validation(Required=false)]
        public long? ParentUnitId { get; set; }

    }

}
