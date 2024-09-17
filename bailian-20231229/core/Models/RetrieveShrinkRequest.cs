// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveShrinkRequest : TeaModel {
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        [NameInMap("EnableReranking")]
        [Validation(Required=false)]
        public bool? EnableReranking { get; set; }

        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public string ImagesShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public string RerankShrink { get; set; }

        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public string RewriteShrink { get; set; }

        [NameInMap("SaveRetrieverHistory")]
        [Validation(Required=false)]
        public bool? SaveRetrieverHistory { get; set; }

        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public string SearchFiltersShrink { get; set; }

        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
