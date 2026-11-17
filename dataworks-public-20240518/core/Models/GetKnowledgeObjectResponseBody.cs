// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgeObjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. You can use this code to determine the error type when a request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKnowledgeObjectResponseBodyData Data { get; set; }
        public class GetKnowledgeObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current valid typed knowledge content. The structure returned is a document or semantic model based on the object type.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public GetKnowledgeObjectResponseBodyDataContent Content { get; set; }
            public class GetKnowledgeObjectResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The document content. This field is present only when the type is DOCUMENT.</para>
                /// </summary>
                [NameInMap("Document")]
                [Validation(Required=false)]
                public GetKnowledgeObjectResponseBodyDataContentDocument Document { get; set; }
                public class GetKnowledgeObjectResponseBodyDataContentDocument : TeaModel {
                    /// <summary>
                    /// <para>The content format. This field is required when Text is provided. Initially, the supported values are MARKDOWN and TEXT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MARKDOWN</para>
                    /// </summary>
                    [NameInMap("ContentFormat")]
                    [Validation(Required=false)]
                    public string ContentFormat { get; set; }

                    /// <summary>
                    /// <para>The current document body that can be provided to the caller. This field is optional. It is omitted if parsing is incomplete, access is not authorized, or the full document cannot be provided securely. A single retrieved snippet does not stand in for the entire document.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Updated full text</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The semantic model content. This field is present only when the type is SEMANTIC_MODEL.</para>
                /// </summary>
                [NameInMap("SemanticModel")]
                [Validation(Required=false)]
                public GetKnowledgeObjectResponseBodyDataContentSemanticModel SemanticModel { get; set; }
                public class GetKnowledgeObjectResponseBodyDataContentSemanticModel : TeaModel {
                    /// <summary>
                    /// <para>The logical datasets included in the model. An empty array is returned if no public datasets are available.</para>
                    /// </summary>
                    [NameInMap("Datasets")]
                    [Validation(Required=false)]
                    public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelDatasets> Datasets { get; set; }
                    public class GetKnowledgeObjectResponseBodyDataContentSemanticModelDatasets : TeaModel {
                        /// <summary>
                        /// <para>The business description of the dataset. This field is optional.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Actual payment amount</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The DataWorks Data Map table entity ID. This field is returned when a reliable association exists. If the ID is omitted for an existing dataset of the same name, the existing ID is retained. Submitted values are processed according to the semantic layer rules for saving data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>maxcompute-table:::project_name:schema_name:table_name</para>
                        /// </summary>
                        [NameInMap("EntityId")]
                        [Validation(Required=false)]
                        public string EntityId { get; set; }

                        /// <summary>
                        /// <para>The defined and publicly accessible fields of the dataset. An empty array is returned if no field definitions are provided.</para>
                        /// </summary>
                        [NameInMap("Fields")]
                        [Validation(Required=false)]
                        public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields> Fields { get; set; }
                        public class GetKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields : TeaModel {
                            /// <summary>
                            /// <para>The data type of the field. This field is required for publicly accessible model fields and is not inferred by the server.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BIGINT</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <para>The business description of the field. This field is optional.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Actual payment amount</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The name of the field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>customer_id</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the dataset within the model. This name is used to locate relationships within the model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The explicitly declared primary key field names. This field is optional. Each field must exist in the Fields array of the dataset.</para>
                        /// </summary>
                        [NameInMap("PrimaryKey")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The executable metrics in the model. An empty array is returned if no metrics are available. Metrics with only candidate formulas are not included.</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelMetrics> Metrics { get; set; }
                    public class GetKnowledgeObjectResponseBodyDataContentSemanticModelMetrics : TeaModel {
                        /// <summary>
                        /// <para>The name of the dataset to which the metric belongs. This name must match a dataset in the Datasets array of the model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("DatasetName")]
                        [Validation(Required=false)]
                        public string DatasetName { get; set; }

                        /// <summary>
                        /// <para>The definition of the metric. This field is optional.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sales order analysis model</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The executable expression. This field must contain at least one dialect version and is not auto-generated by the model.</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public GetKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression Expression { get; set; }
                        public class GetKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression : TeaModel {
                            /// <summary>
                            /// <para>The expressions of the metric in different SQL dialects. At least one item is required. Duplicate dialects are not allowed.</para>
                            /// </summary>
                            [NameInMap("Dialects")]
                            [Validation(Required=false)]
                            public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                            public class GetKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects : TeaModel {
                                /// <summary>
                                /// <para>The SQL dialect, such as MaxCompute or ANSI_SQL.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MaxCompute</para>
                                /// </summary>
                                [NameInMap("Dialect")]
                                [Validation(Required=false)]
                                public string Dialect { get; set; }

                                /// <summary>
                                /// <para>The non-empty calculation expression in the specified dialect. This is not a complete query statement.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>SUM(pay_amount)</para>
                                /// </summary>
                                [NameInMap("Sql")]
                                [Validation(Required=false)]
                                public string Sql { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The name of the metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sales amount</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The explicitly declared unit of the metric. This field is optional and is not returned if no reliable source is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                    }

                    /// <summary>
                    /// <para>The defined relationships expressed by field pairs in the model. An empty array is returned if no relationships are defined. Relationships are not inferred from graph paths.</para>
                    /// </summary>
                    [NameInMap("Relationships")]
                    [Validation(Required=false)]
                    public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelRelationships> Relationships { get; set; }
                    public class GetKnowledgeObjectResponseBodyDataContentSemanticModelRelationships : TeaModel {
                        /// <summary>
                        /// <para>The name of the source dataset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("FromDataset")]
                        [Validation(Required=false)]
                        public string FromDataset { get; set; }

                        /// <summary>
                        /// <para>The equi-join key pairs for the fields at both ends. At least one pair is required. Composite joins are listed as individual pairs.</para>
                        /// </summary>
                        [NameInMap("JoinKeys")]
                        [Validation(Required=false)]
                        public List<GetKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                        public class GetKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys : TeaModel {
                            /// <summary>
                            /// <para>The field name in FromDataset.Fields.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>customer_id</para>
                            /// </summary>
                            [NameInMap("FromField")]
                            [Validation(Required=false)]
                            public string FromField { get; set; }

                            /// <summary>
                            /// <para>The field name in ToDataset.Fields.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("ToField")]
                            [Validation(Required=false)]
                            public string ToField { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the relationship within the model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders_to_customers</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The name of the target dataset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>customers</para>
                        /// </summary>
                        [NameInMap("ToDataset")]
                        [Validation(Required=false)]
                        public string ToDataset { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The time when the object was first created. This field is not returned for existing objects whose creation time cannot be reliably determined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200800000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The brief description of the object. This field is editable. Pass an empty string to clear the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales order analysis model</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The complete shards returned for multi-file specification snapshots. Each item contains a FileName and a DownloadUrl. For single-file snapshots, use the DownloadUrl field.</para>
            /// </summary>
            [NameInMap("DownloadFiles")]
            [Validation(Required=false)]
            public List<GetKnowledgeObjectResponseBodyDataDownloadFiles> DownloadFiles { get; set; }
            public class GetKnowledgeObjectResponseBodyDataDownloadFiles : TeaModel {
                /// <summary>
                /// <para>The temporary HTTPS download URL of the shard. The validity period is specified by the ExpiresIn field.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.invalid/current-model-yaml">https://example.invalid/current-model-yaml</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The file name of the specification YAML shard. Multiple shards form the complete model and do not represent the object identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>policy.md</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>The temporary download URL of the uploaded original file for documents. For semantic models, this is the temporary download URL of the complete specification YAML for the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.invalid/current-model-yaml">https://example.invalid/current-model-yaml</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the current caller has full content editing permissions. The value is true for OWNER and ADMIN and false for VIEWER. Authorization is checked again for write operations.</para>
            /// </summary>
            [NameInMap("Editable")]
            [Validation(Required=false)]
            public bool? Editable { get; set; }

            /// <summary>
            /// <para>The validity period of the download URL, in seconds. The value is fixed at 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public int? ExpiresIn { get; set; }

            /// <summary>
            /// <para>The original file name of the uploaded document. This field is read-only. Renaming the object does not change this value. This field is not returned for external documents and semantic models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy.md</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge object. For semantic models, use the model ID from the semantic layer. For documents, use the stable ID from the local document table. Callers must treat the ID as opaque and must not use a retrieval ID in its place.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj-001</para>
            /// </summary>
            [NameInMap("KnowledgeObjectId")]
            [Validation(Required=false)]
            public string KnowledgeObjectId { get; set; }

            /// <summary>
            /// <para>The time when the object was last modified, in milliseconds. This value is used for conditional updates of the document body. This field does not indicate that the semantic model supports optimistic locking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200800000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the knowledge object ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales subject model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The size of the uploaded original file in bytes. This field is read-only and does not reflect the length of the edited text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>The array of source references. An empty array is currently returned.</para>
            /// </summary>
            [NameInMap("SourceReferences")]
            [Validation(Required=false)]
            public List<GetKnowledgeObjectResponseBodyDataSourceReferences> SourceReferences { get; set; }
            public class GetKnowledgeObjectResponseBodyDataSourceReferences : TeaModel {
                /// <summary>
                /// <para>The source ID registered in the knowledge base. This field is present only when the type is KNOWLEDGE_SOURCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src-001</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The type of the source reference. The structure reserves KNOWLEDGE_SOURCE. Currently, the SourceReferences array is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SEMANTIC_MODEL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The object type. Current valid values are SEMANTIC_MODEL and DOCUMENT. This field may be extended in the future.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEMANTIC_MODEL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the semantic model read in this request. This version is used to specify the target version for subsequent saves and is not an optimistic lock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionNo")]
            [Validation(Required=false)]
            public long? VersionNo { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
