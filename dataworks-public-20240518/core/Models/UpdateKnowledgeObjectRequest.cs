// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeObjectRequest : TeaModel {
        /// <summary>
        /// <para>The client token. This parameter is supported only for DOCUMENT. Model updates do not guarantee exactly-once remote save notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edit-document-text-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The typed content update. Object properties are submitted as needed. Arrays are replaced in their entirety when submitted. Unspecified properties are retained.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateKnowledgeObjectRequestContent Content { get; set; }
        public class UpdateKnowledgeObjectRequestContent : TeaModel {
            /// <summary>
            /// <para>The document content. This property exists only when Type is set to DOCUMENT.</para>
            /// </summary>
            [NameInMap("Document")]
            [Validation(Required=false)]
            public UpdateKnowledgeObjectRequestContentDocument Document { get; set; }
            public class UpdateKnowledgeObjectRequestContentDocument : TeaModel {
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
            public UpdateKnowledgeObjectRequestContentSemanticModel SemanticModel { get; set; }
            public class UpdateKnowledgeObjectRequestContentSemanticModel : TeaModel {
                /// <summary>
                /// <para>The logical datasets contained in the model. This is an empty array if no public datasets are available.</para>
                /// </summary>
                [NameInMap("Datasets")]
                [Validation(Required=false)]
                public List<UpdateKnowledgeObjectRequestContentSemanticModelDatasets> Datasets { get; set; }
                public class UpdateKnowledgeObjectRequestContentSemanticModelDatasets : TeaModel {
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
                    public List<UpdateKnowledgeObjectRequestContentSemanticModelDatasetsFields> Fields { get; set; }
                    public class UpdateKnowledgeObjectRequestContentSemanticModelDatasetsFields : TeaModel {
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
                public List<UpdateKnowledgeObjectRequestContentSemanticModelMetrics> Metrics { get; set; }
                public class UpdateKnowledgeObjectRequestContentSemanticModelMetrics : TeaModel {
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
                    public UpdateKnowledgeObjectRequestContentSemanticModelMetricsExpression Expression { get; set; }
                    public class UpdateKnowledgeObjectRequestContentSemanticModelMetricsExpression : TeaModel {
                        /// <summary>
                        /// <para>The expressions for the same metric in different SQL dialects. At least one item is required. Dialects cannot be duplicated.</para>
                        /// </summary>
                        [NameInMap("Dialects")]
                        [Validation(Required=false)]
                        public List<UpdateKnowledgeObjectRequestContentSemanticModelMetricsExpressionDialects> Dialects { get; set; }
                        public class UpdateKnowledgeObjectRequestContentSemanticModelMetricsExpressionDialects : TeaModel {
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
                public List<UpdateKnowledgeObjectRequestContentSemanticModelRelationships> Relationships { get; set; }
                public class UpdateKnowledgeObjectRequestContentSemanticModelRelationships : TeaModel {
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
                    public List<UpdateKnowledgeObjectRequestContentSemanticModelRelationshipsJoinKeys> JoinKeys { get; set; }
                    public class UpdateKnowledgeObjectRequestContentSemanticModelRelationshipsJoinKeys : TeaModel {
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
        /// <para>The new description. An empty string clears the description. If this parameter is not specified, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual paid amount</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expected modification time. This parameter is supported only for DOCUMENT. It is required when modifying the body text and optional when modifying metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790200800000</para>
        /// </summary>
        [NameInMap("ExpectedModifyTime")]
        [Validation(Required=false)]
        public long? ExpectedModifyTime { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base to which the object belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The stable knowledge object ID returned by the Get or List operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obj-model-001</para>
        /// </summary>
        [NameInMap("KnowledgeObjectId")]
        [Validation(Required=false)]
        public string KnowledgeObjectId { get; set; }

        /// <summary>
        /// <para>The new name. This parameter cannot be empty. If this parameter is not specified, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The upload ID. This parameter is supported only for SEMANTIC_MODEL. It replaces the public model content with a complete YAML file and is mutually exclusive with Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abd</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// <para>The version number. This parameter is required when updating Content or UploadId for SEMANTIC_MODEL. Use the VersionNo returned by the Get operation. This is not an optimistic lock.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VersionNo")]
        [Validation(Required=false)]
        public long? VersionNo { get; set; }

    }

}
