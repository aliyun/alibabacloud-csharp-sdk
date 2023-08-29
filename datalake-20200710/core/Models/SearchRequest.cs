// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SearchRequest : TeaModel {
        /// <summary>
        /// catalogid
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("SortCriteria")]
        [Validation(Required=false)]
        public List<SortCriterion> SortCriteria { get; set; }

    }

}
