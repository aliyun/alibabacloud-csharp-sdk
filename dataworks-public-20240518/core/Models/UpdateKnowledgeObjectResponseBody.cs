// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeObjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. You can use this code to determine the error type when the request fails.</para>
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
        public UpdateKnowledgeObjectResponseBodyData Data { get; set; }
        public class UpdateKnowledgeObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current valid typed knowledge content. The document or semantic model structure is returned based on the type.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public UpdateKnowledgeObjectResponseBodyDataContent Content { get; set; }
            public class UpdateKnowledgeObjectResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The document content. This property exists only when Type is set to DOCUMENT.</para>
                /// </summary>
                [NameInMap("Document")]
                [Validation(Required=false)]
                public UpdateKnowledgeObjectResponseBodyDataContentDocument Document { get; set; }
                public class UpdateKnowledgeObjectResponseBodyDataContentDocument : TeaModel {
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
                    /// <para>Updated full body text</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The semantic model content. This property exists only when Type is set to SEMANTIC_MODEL.</para>
                /// </summary>
                [NameInMap("SemanticModel")]
                [Validation(Required=false)]
                public UpdateKnowledgeObjectResponseBodyDataContentSemanticModel SemanticModel { get; set; }
                public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModel : TeaModel {
                    /// <summary>
                    /// <para>The logical datasets included in the model. An empty array is returned if no public datasets are available.</para>
                    /// </summary>
                    [NameInMap("Datasets")]
                    [Validation(Required=false)]
                    public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelDatasets> Datasets { get; set; }
                    public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelDatasets : TeaModel {
                        /// <summary>
                        /// <para>The business description of the dataset. This parameter is optional.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Actual paid amount</para>
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
                        /// <para>The defined and publicly available fields of the dataset. This is an empty array if no field definitions are provided.</para>
                        /// </summary>
                        [NameInMap("Fields")]
                        [Validation(Required=false)]
                        public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields> Fields { get; set; }
                        public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields : TeaModel {
                            /// <summary>
                            /// <para>The data type of the field. This parameter is required for publicly available model fields and is not inferred by the server.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DECIMAL</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <para>The business description of the field. This parameter is optional.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Actual paid amount</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The name of the field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>pay_amount</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the dataset within the model, used for relationship positioning within the model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The explicitly declared primary key field name. This parameter is optional. Each item must exist in the Fields of this dataset.</para>
                        /// </summary>
                        [NameInMap("PrimaryKey")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The executable metrics in the model. This is an empty array if no metrics are available. Metrics with only candidate formulas are not included.</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetrics> Metrics { get; set; }
                    public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetrics : TeaModel {
                        /// <summary>
                        /// <para>The name of the associated SemanticDataset. This must be locatable within the Datasets of this model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("DatasetName")]
                        [Validation(Required=false)]
                        public string DatasetName { get; set; }

                        /// <summary>
                        /// <para>The description of the metric calculation logic. This parameter is optional.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Actual paid amount minus refund amount</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The executable expression. This must include at least one dialect version and is not auto-generated by the model.</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression Expression { get; set; }
                        public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression : TeaModel {
                            /// <summary>
                            /// <para>The expressions for the same metric in different SQL dialects. At least one item is required. Dialects cannot be duplicated.</para>
                            /// </summary>
                            [NameInMap("Dialects")]
                            [Validation(Required=false)]
                            public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                            public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects : TeaModel {
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
                                /// <para>SUM(pay_amount - refund_amount)</para>
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
                        /// <para>Net sales</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The explicitly declared unit of the metric. This parameter is optional and is not returned if no reliable source is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                    }

                    /// <summary>
                    /// <para>The defined relationships in the model expressed by field pairs. This is an empty array if no relationships are available. Relationships are not inferred from graph paths.</para>
                    /// </summary>
                    [NameInMap("Relationships")]
                    [Validation(Required=false)]
                    public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelRelationships> Relationships { get; set; }
                    public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelRelationships : TeaModel {
                        /// <summary>
                        /// <para>The name of the source SemanticDataset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("FromDataset")]
                        [Validation(Required=false)]
                        public string FromDataset { get; set; }

                        /// <summary>
                        /// <para>The equi-join key pairs for the fields at both ends. At least one item is required. Composite joins are listed item by item.</para>
                        /// </summary>
                        [NameInMap("JoinKeys")]
                        [Validation(Required=false)]
                        public List<UpdateKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                        public class UpdateKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys : TeaModel {
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
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The name of the target SemanticDataset.</para>
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
            /// <para>The time when the object was first created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200800000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the knowledge object. This field is editable. Pass an empty string to clear the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Actual paid amount</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The complete specification shards for multi-file models. Each item includes FileName and DownloadUrl. This field is optional.</para>
            /// </summary>
            [NameInMap("DownloadFiles")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeObjectResponseBodyDataDownloadFiles> DownloadFiles { get; set; }
            public class UpdateKnowledgeObjectResponseBodyDataDownloadFiles : TeaModel {
                /// <summary>
                /// <para>The temporary download URL for the single-file YAML specification. This field is optional.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.invalid/short-lived-result-download">https://example.invalid/short-lived-result-download</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The original file name of the uploaded document. This field is read-only. Renaming the object does not change this value. This field is not returned for external documents and semantic models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>policy.md</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>The temporary download URL for the single-file YAML specification. This field is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.invalid/short-lived-result-download">https://example.invalid/short-lived-result-download</a></para>
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
            /// <para>The validity period of the download URL, in seconds. This field is optional.</para>
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
            /// <para>The ID of the associated knowledge base.</para>
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
            /// <para>obj-model-001</para>
            /// </summary>
            [NameInMap("KnowledgeObjectId")]
            [Validation(Required=false)]
            public string KnowledgeObjectId { get; set; }

            /// <summary>
            /// <para>The time when the object was last modified, in milliseconds. This value is used for conditional updates of DOCUMENT content. This field does not indicate that optimistic locking updates are supported for semantic models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1791789000000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The user-facing name of the knowledge object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>orders</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The size of the original uploaded file in bytes. This field is read-only and does not represent the length of the edited content.</para>
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
            public List<UpdateKnowledgeObjectResponseBodyDataSourceReferences> SourceReferences { get; set; }
            public class UpdateKnowledgeObjectResponseBodyDataSourceReferences : TeaModel {
                /// <summary>
                /// <para>The source ID of the registered KnowledgeSource in the current knowledge base. This field exists only when the type is KNOWLEDGE_SOURCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src-001</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The category of the source reference. The structure retains KNOWLEDGE_SOURCE. The SourceReferences array is currently empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SEMANTIC_MODEL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The knowledge object type. The current values are SEMANTIC_MODEL and DOCUMENT. More types may be added in the future.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEMANTIC_MODEL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the model that is saved and read in the current operation.</para>
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
