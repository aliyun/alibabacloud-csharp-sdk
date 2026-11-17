// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgeObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code, which is used to determine the error type when a request fails.</para>
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
        public ListKnowledgeObjectsResponseBodyData Data { get; set; }
        public class ListKnowledgeObjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cursor for the next page. The value is null if there is no next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The knowledge objects that the caller has permission to read on the current page.</para>
            /// </summary>
            [NameInMap("Objects")]
            [Validation(Required=false)]
            public List<ListKnowledgeObjectsResponseBodyDataObjects> Objects { get; set; }
            public class ListKnowledgeObjectsResponseBodyDataObjects : TeaModel {
                /// <summary>
                /// <para>The typed content of the knowledge object. The semantic model content or document content is returned based on the Type.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListKnowledgeObjectsResponseBodyDataObjectsContent Content { get; set; }
                public class ListKnowledgeObjectsResponseBodyDataObjectsContent : TeaModel {
                    /// <summary>
                    /// <para>The document content. This field exists only when Type is set to DOCUMENT.</para>
                    /// </summary>
                    [NameInMap("Document")]
                    [Validation(Required=false)]
                    public ListKnowledgeObjectsResponseBodyDataObjectsContentDocument Document { get; set; }
                    public class ListKnowledgeObjectsResponseBodyDataObjectsContentDocument : TeaModel {
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
                    /// <para>The semantic model content. This field exists only when Type is set to SEMANTIC_MODEL.</para>
                    /// </summary>
                    [NameInMap("SemanticModel")]
                    [Validation(Required=false)]
                    public ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModel SemanticModel { get; set; }
                    public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModel : TeaModel {
                        /// <summary>
                        /// <para>The logical datasets included in the model. An empty array is returned if no public datasets are available.</para>
                        /// </summary>
                        [NameInMap("Datasets")]
                        [Validation(Required=false)]
                        public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelDatasets> Datasets { get; set; }
                        public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelDatasets : TeaModel {
                            /// <summary>
                            /// <para>The brief description of the object. This field is editable. Pass an empty string to clear the description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales metrics and policy documents</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The metadata entity ID returned by Data Map. Clients must pass this value as is and must not concatenate it.</para>
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
                            public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelDatasetsFields> Fields { get; set; }
                            public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelDatasetsFields : TeaModel {
                                /// <summary>
                                /// <para>The data type of the field. This field must be provided for publicly accessible model fields and is not inferred by the server.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>BIGINT</para>
                                /// </summary>
                                [NameInMap("DataType")]
                                [Validation(Required=false)]
                                public string DataType { get; set; }

                                /// <summary>
                                /// <para>The brief description of the object. This field is editable. Pass an empty string to clear the description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Sales metrics and policy documents</para>
                                /// </summary>
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                /// <summary>
                                /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Sales policy</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            /// <summary>
                            /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales policy</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The explicitly declared primary key field name. This field is optional. Each item must exist in the Fields of the current dataset.</para>
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
                        public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetrics> Metrics { get; set; }
                        public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetrics : TeaModel {
                            /// <summary>
                            /// <para>The name of the semantic dataset to which the metric belongs. This value must be locatable in the Datasets of the current model.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>orders</para>
                            /// </summary>
                            [NameInMap("DatasetName")]
                            [Validation(Required=false)]
                            public string DatasetName { get; set; }

                            /// <summary>
                            /// <para>The brief description of the object. This field is editable. Pass an empty string to clear the description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales metrics and policy documents</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The executable expression. It must contain at least one dialect version and is not auto-generated by the model.</para>
                            /// </summary>
                            [NameInMap("Expression")]
                            [Validation(Required=false)]
                            public ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetricsExpression Expression { get; set; }
                            public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetricsExpression : TeaModel {
                                /// <summary>
                                /// <para>The expressions of the same metric in different SQL dialects. At least one item is required. Dialects are not duplicated.</para>
                                /// </summary>
                                [NameInMap("Dialects")]
                                [Validation(Required=false)]
                                public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                                public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelMetricsExpressionDialects : TeaModel {
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
                            /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales policy</para>
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
                        /// <para>The defined relationships in the model expressed by field pairs. An empty array is returned if no relationships are available. Relationships are not inferred from graph paths.</para>
                        /// </summary>
                        [NameInMap("Relationships")]
                        [Validation(Required=false)]
                        public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelRelationships> Relationships { get; set; }
                        public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelRelationships : TeaModel {
                            /// <summary>
                            /// <para>The name of the starting semantic dataset.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>orders</para>
                            /// </summary>
                            [NameInMap("FromDataset")]
                            [Validation(Required=false)]
                            public string FromDataset { get; set; }

                            /// <summary>
                            /// <para>The equi-join pairs of fields at both ends of the relationship. For composite relationships, fields are paired one by one.</para>
                            /// </summary>
                            [NameInMap("JoinKeys")]
                            [Validation(Required=false)]
                            public List<ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                            public class ListKnowledgeObjectsResponseBodyDataObjectsContentSemanticModelRelationshipsJoinKeys : TeaModel {
                                /// <summary>
                                /// <para>The name of the field in the starting dataset that participates in the relationship. This field must be defined in the Fields of the dataset corresponding to FromDataset.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>customer_id</para>
                                /// </summary>
                                [NameInMap("FromField")]
                                [Validation(Required=false)]
                                public string FromField { get; set; }

                                /// <summary>
                                /// <para>The name of the field in the ending dataset that participates in the relationship. This field must be defined in the Fields of the dataset corresponding to ToDataset.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>id</para>
                                /// </summary>
                                [NameInMap("ToField")]
                                [Validation(Required=false)]
                                public string ToField { get; set; }

                            }

                            /// <summary>
                            /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Sales policy</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The name of the ending semantic dataset.</para>
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
                /// <para>The brief description of the object. This field is editable. Pass an empty string to clear the description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales metrics and policy documents</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download items for multi-file specification YAMLs, including file names and temporary download URLs.</para>
                /// </summary>
                [NameInMap("DownloadFiles")]
                [Validation(Required=false)]
                public List<ListKnowledgeObjectsResponseBodyDataObjectsDownloadFiles> DownloadFiles { get; set; }
                public class ListKnowledgeObjectsResponseBodyDataObjectsDownloadFiles : TeaModel {
                    /// <summary>
                    /// <para>The temporary download URL of the specification YAML file. The validity period is subject to ExpiresIn.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.invalid/short-lived-result-download">https://example.invalid/short-lived-result-download</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The original file name of the uploaded document. This field is read-only. Renaming the Name field does not change this value. This field is not returned for external documents and semantic models.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>policy.md</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The temporary download URL of the specification YAML file. The validity period is subject to ExpiresIn.</para>
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
                /// <para>The validity period of the knowledge object download URL in seconds. The current value is 300 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ExpiresIn")]
                [Validation(Required=false)]
                public int? ExpiresIn { get; set; }

                /// <summary>
                /// <para>The original file name of the uploaded document. This field is read-only. Renaming the Name field does not change this value. This field is not returned for external documents and semantic models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>policy.md</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The knowledge base to which the object belongs.</para>
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
                /// <para>The time when the current content was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1790200800000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The user-facing name of the object. This field is editable. Renaming the object does not change the KnowledgeObjectId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales policy</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the uploaded original file in bytes. This field is read-only and does not represent the length of the edited body text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

                /// <summary>
                /// <para>The array of source references. Currently, an empty array is returned.</para>
                /// </summary>
                [NameInMap("SourceReferences")]
                [Validation(Required=false)]
                public List<ListKnowledgeObjectsResponseBodyDataObjectsSourceReferences> SourceReferences { get; set; }
                public class ListKnowledgeObjectsResponseBodyDataObjectsSourceReferences : TeaModel {
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
                /// <para>The knowledge object type. The current values are SEMANTIC_MODEL and DOCUMENT. More types may be added in the future.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOCUMENT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The current version of the SEMANTIC_MODEL being read. Pass this value when updating content. The version can be edited in place.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VersionNo")]
                [Validation(Required=false)]
                public long? VersionNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The secure error message returned when a request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
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
