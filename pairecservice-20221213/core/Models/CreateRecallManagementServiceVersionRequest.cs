// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementServiceVersionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration details.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public CreateRecallManagementServiceVersionRequestConfigs Configs { get; set; }
        public class CreateRecallManagementServiceVersionRequestConfigs : TeaModel {
            /// <summary>
            /// <para><b>The merge configuration.</b></para>
            /// </summary>
            [NameInMap("MergeConfig")]
            [Validation(Required=false)]
            public CreateRecallManagementServiceVersionRequestConfigsMergeConfig MergeConfig { get; set; }
            public class CreateRecallManagementServiceVersionRequestConfigsMergeConfig : TeaModel {
                /// <summary>
                /// <para>The extended configuration for the merge configuration to facilitate future feature expansion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <para>The filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age&gt;10</para>
                /// </summary>
                [NameInMap("FilterExpression")]
                [Validation(Required=false)]
                public string FilterExpression { get; set; }

                /// <summary>
                /// <para>The IDs of the filter tables.</para>
                /// </summary>
                [NameInMap("FilterRecallManagementTableIds")]
                [Validation(Required=false)]
                public List<string> FilterRecallManagementTableIds { get; set; }

                /// <summary>
                /// <para>The ID of the item table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ItemRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemRecallManagementTableId { get; set; }

                /// <summary>
                /// <para>The output fields of the item table.</para>
                /// </summary>
                [NameInMap("ItemTableFields")]
                [Validation(Required=false)]
                public List<string> ItemTableFields { get; set; }

                /// <summary>
                /// <para>The merge type. Valid values: <c>Weight</c>: weight. <c>Alternate</c>: alternate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weight</para>
                /// </summary>
                [NameInMap("MergeType")]
                [Validation(Required=false)]
                public string MergeType { get; set; }

                /// <summary>
                /// <para>The ID of the recall management service version configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallManagementServiceVersionConfigId")]
                [Validation(Required=false)]
                public string RecallManagementServiceVersionConfigId { get; set; }

            }

            /// <summary>
            /// <para>The list of recall configurations.</para>
            /// </summary>
            [NameInMap("RecallConfigs")]
            [Validation(Required=false)]
            public List<CreateRecallManagementServiceVersionRequestConfigsRecallConfigs> RecallConfigs { get; set; }
            public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigs : TeaModel {
                /// <summary>
                /// <para>The description of the recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is etrec recall</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para><b>The extended configuration for future feature expansion.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <para>The item conditions in array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;option&quot;:&quot;&lt;&quot;,&quot;field&quot;:&quot;category&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;10&quot;}]</para>
                /// </summary>
                [NameInMap("ItemConditionArray")]
                [Validation(Required=false)]
                public string ItemConditionArray { get; set; }

                /// <summary>
                /// <para>The item conditional expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age&gt;20</para>
                /// </summary>
                [NameInMap("ItemConditionExpression")]
                [Validation(Required=false)]
                public string ItemConditionExpression { get; set; }

                /// <summary>
                /// <para>The item vector field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item_embedding</para>
                /// </summary>
                [NameInMap("ItemVectorField")]
                [Validation(Required=false)]
                public string ItemVectorField { get; set; }

                /// <summary>
                /// <para>The ID of the item vector recall table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ItemVectorRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemVectorRecallManagementTableId { get; set; }

                /// <summary>
                /// <para>The name of the recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>etrec</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of operators.</para>
                /// </summary>
                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperators> Operators { get; set; }
                public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperators : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the Feature operator.</para>
                    /// </summary>
                    [NameInMap("FeatureConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFeatureConfig FeatureConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFeatureConfig : TeaModel {
                        /// <summary>
                        /// <para>The feature expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>category=3</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The feature name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>city</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The feature type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>string</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration of the Filter operator.</para>
                    /// </summary>
                    [NameInMap("FilterConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFilterConfig FilterConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFilterConfig : TeaModel {
                        /// <summary>
                        /// <para>The filter expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>age&gt;20</para>
                        /// </summary>
                        [NameInMap("Experession")]
                        [Validation(Required=false)]
                        public string Experession { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration of the Join operator.</para>
                    /// </summary>
                    [NameInMap("JoinConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsJoinConfig JoinConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsJoinConfig : TeaModel {
                        /// <summary>
                        /// <para><b>The Join field.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <para><b>The output fields.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("OutputFields")]
                        [Validation(Required=false)]
                        public List<string> OutputFields { get; set; }

                        /// <summary>
                        /// <para><b>The ID of the Join table.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("RecallManagementTableId")]
                        [Validation(Required=false)]
                        public string RecallManagementTableId { get; set; }

                    }

                    /// <summary>
                    /// <para>The operator type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Filter</para>
                    /// </summary>
                    [NameInMap("OperatorType")]
                    [Validation(Required=false)]
                    public string OperatorType { get; set; }

                    /// <summary>
                    /// <para>The configuration of the Trigger operator.</para>
                    /// </summary>
                    [NameInMap("TriggerConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsTriggerConfig TriggerConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsTriggerConfig : TeaModel {
                        /// <summary>
                        /// <para>The field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>user_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <para>The limit on the number of fields.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("FieldQuantityLimit")]
                        [Validation(Required=false)]
                        public int? FieldQuantityLimit { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable random sorting.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsRandSort")]
                        [Validation(Required=false)]
                        public bool? IsRandSort { get; set; }

                        /// <summary>
                        /// <para>The sort fields.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>create_time</para>
                        /// </summary>
                        [NameInMap("SortField")]
                        [Validation(Required=false)]
                        public string SortField { get; set; }

                    }

                }

                /// <summary>
                /// <para>The priority. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the recall management table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallManagementTableId")]
                [Validation(Required=false)]
                public string RecallManagementTableId { get; set; }

                /// <summary>
                /// <para>The recall type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X2I</para>
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public string RecallType { get; set; }

                /// <summary>
                /// <para>The sort fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("SortFields")]
                [Validation(Required=false)]
                public string SortFields { get; set; }

                /// <summary>
                /// <para>The user vector field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_embedding</para>
                /// </summary>
                [NameInMap("UserVectorField")]
                [Validation(Required=false)]
                public string UserVectorField { get; set; }

                /// <summary>
                /// <para>The ID of the user vector recall table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("UserVectorRecallManagementTableId")]
                [Validation(Required=false)]
                public string UserVectorRecallManagementTableId { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the source recall management service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SourceRecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string SourceRecallManagementServiceVersionId { get; set; }

    }

}
