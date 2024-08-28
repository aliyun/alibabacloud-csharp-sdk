// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataRequest : TeaModel {
        /// <summary>
        /// The name of the collection.
        /// 
        /// >  You can call the [ListCollections](https://help.aliyun.com/document_detail/2401503.html) operation to query a list of collections.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// The content that is used for full-text search. If you leave this parameter empty, only vector search is used. If you do not leave this parameter empty, two-way retrieval based on vector search and full-text search is used.
        /// 
        /// >  You must specify at least one of the Content and Vector parameters.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
        /// The metadata fields to be returned. Separate multiple fields with commas (,). This parameter is empty by default.
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// Specifies whether to return vector data. Valid values:
        /// 
        /// *   **true**: returns vector data.
        /// *   **false**: does not return vector data. In full-text search scenarios, set this parameter to false.
        /// </summary>
        [NameInMap("IncludeValues")]
        [Validation(Required=false)]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// The similarity algorithm for search. Valid values:
        /// 
        /// *   **l2**: Euclidean distance.
        /// *   **ip**: inner product distance.
        /// *   **cosine**: cosine similarity.
        /// 
        /// >  If you leave this parameter empty, the l2, ip, or cosine algorithm that is specified when you create an index is used.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// >  You can call the [ListNamespaces](https://help.aliyun.com/document_detail/2401502.html) operation to query a list of namespaces.
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

        /// <summary>
        /// The starting point for paginated queries. This parameter is empty by default. This parameter does not support two-way retrieval scenarios.
        /// 
        /// The value must be greater than or equal to 0. If you do not leave this parameter empty, the Total parameter is returned to indicate the total number of matched entries. You must specify this parameter and the TopK parameter in pairs. For example, to paginate 20 chunks at a time for a total of 45 chunks whose chunk_id values are 0 to 44, three requests are involved:
        /// 
        /// *   First request: Set the Offset value to 0 and the TopK value to 20. The chunks whose chunk_id values are 0 to 19 are returned.
        /// *   Second request: Set the Offset value to 20 and the TopK value to 20. The chunks whose chunk_id values are 20 to 39 are returned.
        /// *   Third request: Set the Offset value to 30 and the TopK value to 20. The chunks whose chunk_id values are 40 to 44 are returned.
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The fields by which to sort the results. This parameter is empty by default. This parameter does not support two-way retrieval scenarios.
        /// 
        /// You must specify the default fields in the metadata or the table, such as id. You can specify the following number of fields:
        /// 
        /// *   One field, such as chunk_id.
        /// *   Multiple fields that are sorted in ascending order and separated by commas (,), such as block_id and chunk_id.
        /// *   Multiple fields that are sorted in descending order and separated by commas (,), such as block_id DESC, chunk_id DESC.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RelationalTableFilter")]
        [Validation(Required=false)]
        public QueryCollectionDataRequestRelationalTableFilter RelationalTableFilter { get; set; }
        public class QueryCollectionDataRequestRelationalTableFilter : TeaModel {
            [NameInMap("CollectionMetadataField")]
            [Validation(Required=false)]
            public string CollectionMetadataField { get; set; }

            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("TableField")]
            [Validation(Required=false)]
            public string TableField { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// The vector data. The length of the value must be the same as that of the Dimension parameter in the [CreateCollection](https://help.aliyun.com/document_detail/2401497.html) operation.
        /// 
        /// >  If you leave this parameter empty, only full-text search results are returned.
        /// </summary>
        [NameInMap("Vector")]
        [Validation(Required=false)]
        public List<double?> Vector { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
