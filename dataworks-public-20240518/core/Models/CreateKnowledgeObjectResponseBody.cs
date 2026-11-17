// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeObjectResponseBody : TeaModel {
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
        public CreateKnowledgeObjectResponseBodyData Data { get; set; }
        public class CreateKnowledgeObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current valid typed knowledge content. Returns the document or semantic model structure based on the Type.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public CreateKnowledgeObjectResponseBodyDataContent Content { get; set; }
            public class CreateKnowledgeObjectResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>This operation returns only the document content.</para>
                /// </summary>
                [NameInMap("Document")]
                [Validation(Required=false)]
                public CreateKnowledgeObjectResponseBodyDataContentDocument Document { get; set; }
                public class CreateKnowledgeObjectResponseBodyDataContentDocument : TeaModel {
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
                /// <para>The semantic model. This field exists only when Type is set to SEMANTIC_MODEL.</para>
                /// </summary>
                [NameInMap("SemanticModel")]
                [Validation(Required=false)]
                public CreateKnowledgeObjectResponseBodyDataContentSemanticModel SemanticModel { get; set; }
                public class CreateKnowledgeObjectResponseBodyDataContentSemanticModel : TeaModel {
                    /// <summary>
                    /// <para>The logical datasets included in the model. An empty array is returned if no public datasets are available.</para>
                    /// </summary>
                    [NameInMap("Datasets")]
                    [Validation(Required=false)]
                    public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelDatasets> Datasets { get; set; }
                    public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelDatasets : TeaModel {
                        /// <summary>
                        /// <para>The description. This field is editable. Pass an empty string to clear the description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sales metrics and policy document</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The metadata entity ID returned by Data Map. The client passes this ID as-is without concatenating it.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>maxcompute-table:::project_name:schema_name:table_name</para>
                        /// </summary>
                        [NameInMap("EntityId")]
                        [Validation(Required=false)]
                        public string EntityId { get; set; }

                        /// <summary>
                        /// <para>The defined and publicly available fields of the dataset. If no field definitions are provided, this is an empty array.</para>
                        /// </summary>
                        [NameInMap("Fields")]
                        [Validation(Required=false)]
                        public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields> Fields { get; set; }
                        public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelDatasetsFields : TeaModel {
                            /// <summary>
                            /// <para>The data type of the field. This must be provided for publicly available model fields and is not guessed by the server.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BIGINT</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <para>The description. This field is editable. Pass an empty string to clear the description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales metrics and policy document</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The user-facing name. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Business description</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The user-facing name. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Business description</para>
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
                    /// <para>The executable metrics in the model. If no metrics exist, this is an empty array. Metrics with only candidate formulas are not included.</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetrics> Metrics { get; set; }
                    public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetrics : TeaModel {
                        /// <summary>
                        /// <para>The SemanticDataset.Name to which the metric belongs. It must be locatable in the Datasets of this model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("DatasetName")]
                        [Validation(Required=false)]
                        public string DatasetName { get; set; }

                        /// <summary>
                        /// <para>The description. This field is editable. Pass an empty string to clear the description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sales metrics and policy document</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The executable expression. It must include at least one dialect version and is not auto-completed by the model.</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression Expression { get; set; }
                        public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpression : TeaModel {
                            /// <summary>
                            /// <para>The expressions of the same metric in different SQL dialects. At least one item is required. The same dialect is not repeated.</para>
                            /// </summary>
                            [NameInMap("Dialects")]
                            [Validation(Required=false)]
                            public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                            public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelMetricsExpressionDialects : TeaModel {
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
                                /// <para>The non-empty calculation expression in the specified dialect. It is not a complete query statement.</para>
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
                        /// <para>The user-facing name. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Business description</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The explicitly declared unit of the metric. This parameter is optional. It is not returned when no reliable source is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                    }

                    /// <summary>
                    /// <para>The defined relationships in the model expressed by field pairs. If no relationships exist, this is an empty array. Relationships are not guessed from graph paths.</para>
                    /// </summary>
                    [NameInMap("Relationships")]
                    [Validation(Required=false)]
                    public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelRelationships> Relationships { get; set; }
                    public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelRelationships : TeaModel {
                        /// <summary>
                        /// <para>The SemanticDataset.Name of the starting point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>orders</para>
                        /// </summary>
                        [NameInMap("FromDataset")]
                        [Validation(Required=false)]
                        public string FromDataset { get; set; }

                        /// <summary>
                        /// <para>The equi-join pairs of fields at both ends of the relationship. For composite relationships, fields are paired item by item.</para>
                        /// </summary>
                        [NameInMap("JoinKeys")]
                        [Validation(Required=false)]
                        public List<CreateKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                        public class CreateKnowledgeObjectResponseBodyDataContentSemanticModelRelationshipsJoinKeys : TeaModel {
                            /// <summary>
                            /// <para>The name of the field in the starting dataset that participates in the relationship. It must be defined in the Fields of the dataset corresponding to FromDataset.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>customer_id</para>
                            /// </summary>
                            [NameInMap("FromField")]
                            [Validation(Required=false)]
                            public string FromField { get; set; }

                            /// <summary>
                            /// <para>The name of the field in the ending dataset that participates in the relationship. It must be defined in the Fields of the dataset corresponding to ToDataset.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("ToField")]
                            [Validation(Required=false)]
                            public string ToField { get; set; }

                        }

                        /// <summary>
                        /// <para>The user-facing name. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Business description</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The SemanticDataset.Name of the ending point.</para>
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
            /// <para>The description. This field is editable. Pass an empty string to clear the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales metrics and policy document</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The download items for multi-file specification YAMLs, including file names and temporary download URLs.</para>
            /// </summary>
            [NameInMap("DownloadFiles")]
            [Validation(Required=false)]
            public List<CreateKnowledgeObjectResponseBodyDataDownloadFiles> DownloadFiles { get; set; }
            public class CreateKnowledgeObjectResponseBodyDataDownloadFiles : TeaModel {
                /// <summary>
                /// <para>The temporary download URL for the specification YAML file. The validity period is specified by ExpiresIn.</para>
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
                /// <para>Business_Description.pdf</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>The temporary download URL for the original uploaded file of the DOCUMENT or the current specification YAML of the SEMANTIC_MODEL returned by GetKnowledgeObject. This is not a persistent property.</para>
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
            /// <para>The validity period of the download URL, in seconds. This field is returned together with DownloadUrl.</para>
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
            /// <para>Business_Description.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base to which the object belongs.</para>
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
            /// <para>obj-document-001</para>
            /// </summary>
            [NameInMap("KnowledgeObjectId")]
            [Validation(Required=false)]
            public string KnowledgeObjectId { get; set; }

            /// <summary>
            /// <para>The time when the object was last modified, in milliseconds. This value is used for conditional updates of the DOCUMENT body. This field does not indicate that optimistic locking updates are supported for semantic models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200800000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The user-facing name. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business description</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The size of the uploaded original file in bytes. This field is read-only and does not represent the length of the edited body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("SizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>The array of source references. Currently, an empty array is returned.</para>
            /// </summary>
            [NameInMap("SourceReferences")]
            [Validation(Required=false)]
            public List<CreateKnowledgeObjectResponseBodyDataSourceReferences> SourceReferences { get; set; }
            public class CreateKnowledgeObjectResponseBodyDataSourceReferences : TeaModel {
                /// <summary>
                /// <para>The source ID. This field exists only when the type is KNOWLEDGE_SOURCE. It represents the SourceId of the KnowledgeSource registered in the current knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src-001</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The category of the source reference. The structure retains KNOWLEDGE_SOURCE. Currently, SourceReferences is an empty array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOCUMENT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The object type. The value is fixed to DOCUMENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOCUMENT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The current version of the SEMANTIC_MODEL being read. Pass this value when updating the content to edit the version in place.</para>
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
