// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveRequest : TeaModel {
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
        public List<string> Images { get; set; }

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
        public List<RetrieveRequestRerank> Rerank { get; set; }
        public class RetrieveRequestRerank : TeaModel {
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public List<RetrieveRequestRewrite> Rewrite { get; set; }
        public class RetrieveRequestRewrite : TeaModel {
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        [NameInMap("SaveRetrieverHistory")]
        [Validation(Required=false)]
        public bool? SaveRetrieverHistory { get; set; }

        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> SearchFilters { get; set; }

        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
