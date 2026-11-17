// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeObjectRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token for the creation request. Keep the original request unchanged when retrying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create-document-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Only Content.Document is supported. It includes Text and ContentFormat (MARKDOWN or TEXT).</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateKnowledgeObjectRequestContent Content { get; set; }
        public class CreateKnowledgeObjectRequestContent : TeaModel {
            /// <summary>
            /// <para>This operation returns only the document content.</para>
            /// </summary>
            [NameInMap("Document")]
            [Validation(Required=false)]
            public CreateKnowledgeObjectRequestContentDocument Document { get; set; }
            public class CreateKnowledgeObjectRequestContentDocument : TeaModel {
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
            /// <para>This operation does not accept this branch. Use a build task to import YAML for new semantic models.</para>
            /// </summary>
            [NameInMap("SemanticModel")]
            [Validation(Required=false)]
            public CreateKnowledgeObjectRequestContentSemanticModel SemanticModel { get; set; }
            public class CreateKnowledgeObjectRequestContentSemanticModel : TeaModel {
                /// <summary>
                /// <para>The logical datasets included in the model. If no public datasets exist, this is an empty array.</para>
                /// </summary>
                [NameInMap("Datasets")]
                [Validation(Required=false)]
                public List<CreateKnowledgeObjectRequestContentSemanticModelDatasets> Datasets { get; set; }
                public class CreateKnowledgeObjectRequestContentSemanticModelDatasets : TeaModel {
                    /// <summary>
                    /// <para>The document description.</para>
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
                    public List<CreateKnowledgeObjectRequestContentSemanticModelDatasetsFields> Fields { get; set; }
                    public class CreateKnowledgeObjectRequestContentSemanticModelDatasetsFields : TeaModel {
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
                        /// <para>The document description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sales metrics and policy document</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The document name. Existing objects are not overwritten based on the name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Business description</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The document name. Existing objects are not overwritten based on the name.</para>
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
                public List<CreateKnowledgeObjectRequestContentSemanticModelMetrics> Metrics { get; set; }
                public class CreateKnowledgeObjectRequestContentSemanticModelMetrics : TeaModel {
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
                    /// <para>The document description.</para>
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
                    public CreateKnowledgeObjectRequestContentSemanticModelMetricsExpression Expression { get; set; }
                    public class CreateKnowledgeObjectRequestContentSemanticModelMetricsExpression : TeaModel {
                        /// <summary>
                        /// <para>The expressions of the same metric in different SQL dialects. At least one item is required. The same dialect is not repeated.</para>
                        /// </summary>
                        [NameInMap("Dialects")]
                        [Validation(Required=false)]
                        public List<CreateKnowledgeObjectRequestContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                        public class CreateKnowledgeObjectRequestContentSemanticModelMetricsExpressionDialects : TeaModel {
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
                    /// <para>The document name. Existing objects are not overwritten based on the name.</para>
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
                public List<CreateKnowledgeObjectRequestContentSemanticModelRelationships> Relationships { get; set; }
                public class CreateKnowledgeObjectRequestContentSemanticModelRelationships : TeaModel {
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
                    public List<CreateKnowledgeObjectRequestContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                    public class CreateKnowledgeObjectRequestContentSemanticModelRelationshipsJoinKeys : TeaModel {
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
                    /// <para>The document name. Existing objects are not overwritten based on the name.</para>
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
        /// <para>The document description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy document</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the target knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The document name. Existing objects are not overwritten based on the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business description</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the object. For this operation, the value is fixed to DOCUMENT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCUMENT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the completed PUT upload session for this knowledge base. This parameter is mutually exclusive with Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abd</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
