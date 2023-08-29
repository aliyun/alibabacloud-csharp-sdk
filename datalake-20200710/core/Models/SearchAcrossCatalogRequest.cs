// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SearchAcrossCatalogRequest : TeaModel {
        [NameInMap("CatalogIds")]
        [Validation(Required=false)]
        public List<string> CatalogIds { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        [NameInMap("SearchTypes")]
        [Validation(Required=false)]
        public List<string> SearchTypes { get; set; }

        [NameInMap("SortCriteria")]
        [Validation(Required=false)]
        public List<SortCriterion> SortCriteria { get; set; }

    }

}
