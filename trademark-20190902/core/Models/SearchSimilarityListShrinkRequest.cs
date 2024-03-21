// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchSimilarityListShrinkRequest : TeaModel {
        [NameInMap("Classifications")]
        [Validation(Required=false)]
        public string ClassificationsShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SimilarGroups")]
        [Validation(Required=false)]
        public string SimilarGroupsShrink { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SuccessSearchType")]
        [Validation(Required=false)]
        public string SuccessSearchType { get; set; }

        [NameInMap("Umid")]
        [Validation(Required=false)]
        public string Umid { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
