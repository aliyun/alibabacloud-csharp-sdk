// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchSimilarityShrinkRequest : TeaModel {
        [NameInMap("Classifications")]
        [Validation(Required=false)]
        public string ClassificationsShrink { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("NameUriList")]
        [Validation(Required=false)]
        public List<SearchSimilarityShrinkRequestNameUriList> NameUriList { get; set; }
        public class SearchSimilarityShrinkRequestNameUriList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public bool? ShowDetail { get; set; }

        [NameInMap("SimilarGroups")]
        [Validation(Required=false)]
        public string SimilarGroupsShrink { get; set; }

        [NameInMap("Sorter")]
        [Validation(Required=false)]
        public string Sorter { get; set; }

        [NameInMap("Umid")]
        [Validation(Required=false)]
        public string Umid { get; set; }

    }

}
