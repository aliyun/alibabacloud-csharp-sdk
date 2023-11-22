// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByAILabelRequest : TeaModel {
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("MultimodalSearchType")]
        [Validation(Required=false)]
        public string MultimodalSearchType { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SpecificSearch")]
        [Validation(Required=false)]
        public bool? SpecificSearch { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
