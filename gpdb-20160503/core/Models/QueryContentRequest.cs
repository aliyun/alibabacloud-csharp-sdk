// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// The filter condition that is used to query data. Specify the parameter in the WHERE clause format. The parameter is an expression that returns a Boolean value of TRUE or FALSE. The parameter can contain comparison operators, such as Equal To (=), Not Equal To (<> or !=), Greater Than (>), Less Than (<), Greater Than or Equal To (>=), and Less Than or Equal To (<=), logical operators, such as AND, OR, and NOT, and keywords, such as IN, BETWEEN, and LIKE.
        /// 
        /// > 
        /// 
        /// *   For more information, see https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The two-way retrieval algorithm. This parameter is empty by default, which specifies that scores of vector search and full-text search are directly compared and sorted without additional weighting or adjustments.
        /// 
        /// Valid values:
        /// 
        /// *   RRF: The reciprocal rank fusion (RRF) algorithm uses a constant k to control the fusion effect. For more information, see the description of the HybridSearchArgs parameter.
        /// *   Weight: This algorithm uses the alpha parameter to specify the proportion of the vector search score and the full-text search score and then sorts by weight. For more information, see the description of the HybridSearchArgs parameter.
        /// *   Cascaded: This algorithm performs first full-text search and then vector search.
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// The parameters of the two-way retrieval algorithm. The following parameters are supported:
        /// 
        /// *   When HybridSearch is set to RRF, the scores are calculated by using the `1/(k+rank_i)` formula. The constant k is a positive integer that is greater than 1.
        /// 
        /// <!---->
        /// 
        ///     { 
        ///        "RRF": {
        ///         "k": 60
        ///        }
        ///     }
        /// 
        /// *   When HybridSearch is set to Weight, the scores are calculated by using the `alpha * vector_score + (1-alpha) * text_score` formula. The alpha parameter specifies the proportion of the vector search score and the full-text search score and ranges from 0 to 1. A value of 0 specifies full-text search and a value of 1 specifies vector search.
        /// 
        /// <!---->
        /// 
        ///     { 
        ///        "Weight": {
        ///         "alpha": 0.5
        ///        }
        ///     }
        /// </summary>
        [NameInMap("HybridSearchArgs")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> HybridSearchArgs { get; set; }

        /// <summary>
        /// Specifies whether to return the URL of the document. Default value: false.
        /// </summary>
        [NameInMap("IncludeFileUrl")]
        [Validation(Required=false)]
        public bool? IncludeFileUrl { get; set; }

        /// <summary>
        /// The metadata fields to be returned. Separate multiple fields with commas (,). This parameter is empty by default.
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        [NameInMap("IncludeVector")]
        [Validation(Required=false)]
        public bool? IncludeVector { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The name of the namespace. Default value: public.
        /// 
        /// >  You can call the [CreateNamespace](https://help.aliyun.com/document_detail/2401495.html) operation to create a namespace and call the [ListNamespaces](https://help.aliyun.com/document_detail/2401502.html) operation to query a list of namespaces.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The recall window. If you specify this parameter, the context of the search result is returned. Format: List\\<A, B>. Valid values: -10<=A<=0 and 0<=B<=10.
        /// 
        /// > 
        /// 
        /// *   We recommend that you specify this parameter if the source document is segmented into large numbers of pieces and you may fail to obtain the context.
        /// 
        /// *   The context of the search result is retrieved based on the recall window after the search result is reranked.
        /// </summary>
        [NameInMap("RecallWindow")]
        [Validation(Required=false)]
        public List<int?> RecallWindow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RerankFactor")]
        [Validation(Required=false)]
        public double? RerankFactor { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// Specifies whether to use full-text search to implement two-way retrieval. The default value is false, which specifies that only vector search is used.
        /// </summary>
        [NameInMap("UseFullTextRetrieval")]
        [Validation(Required=false)]
        public bool? UseFullTextRetrieval { get; set; }

    }

}
