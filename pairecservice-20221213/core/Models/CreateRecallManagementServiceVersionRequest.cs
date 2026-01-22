// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementServiceVersionRequest : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public CreateRecallManagementServiceVersionRequestConfigs Configs { get; set; }
        public class CreateRecallManagementServiceVersionRequestConfigs : TeaModel {
            [NameInMap("MergeConfig")]
            [Validation(Required=false)]
            public CreateRecallManagementServiceVersionRequestConfigsMergeConfig MergeConfig { get; set; }
            public class CreateRecallManagementServiceVersionRequestConfigsMergeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>age&gt;10</para>
                /// </summary>
                [NameInMap("FilterExpression")]
                [Validation(Required=false)]
                public string FilterExpression { get; set; }

                [NameInMap("FilterRecallManagementTableIds")]
                [Validation(Required=false)]
                public List<string> FilterRecallManagementTableIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ItemRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemRecallManagementTableId { get; set; }

                [NameInMap("ItemTableFields")]
                [Validation(Required=false)]
                public List<string> ItemTableFields { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Weight</para>
                /// </summary>
                [NameInMap("MergeType")]
                [Validation(Required=false)]
                public string MergeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallManagementServiceVersionConfigId")]
                [Validation(Required=false)]
                public string RecallManagementServiceVersionConfigId { get; set; }

            }

            [NameInMap("RecallConfigs")]
            [Validation(Required=false)]
            public List<CreateRecallManagementServiceVersionRequestConfigsRecallConfigs> RecallConfigs { get; set; }
            public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>this is etrec recall</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;option&quot;:&quot;&lt;&quot;,&quot;field&quot;:&quot;category&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;10&quot;}]</para>
                /// </summary>
                [NameInMap("ItemConditionArray")]
                [Validation(Required=false)]
                public string ItemConditionArray { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>age&gt;10</para>
                /// </summary>
                [NameInMap("ItemConditionExpression")]
                [Validation(Required=false)]
                public string ItemConditionExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>item_embedding</para>
                /// </summary>
                [NameInMap("ItemVectorField")]
                [Validation(Required=false)]
                public string ItemVectorField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ItemVectorRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemVectorRecallManagementTableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>etrec</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperators> Operators { get; set; }
                public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperators : TeaModel {
                    [NameInMap("FeatureConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFeatureConfig FeatureConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFeatureConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>category=3</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>city</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>string</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("FilterConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFilterConfig FilterConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsFilterConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>age&gt;20</para>
                        /// </summary>
                        [NameInMap("Experession")]
                        [Validation(Required=false)]
                        public string Experession { get; set; }

                    }

                    [NameInMap("JoinConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsJoinConfig JoinConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsJoinConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("OutputFields")]
                        [Validation(Required=false)]
                        public List<string> OutputFields { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("RecallManagementTableId")]
                        [Validation(Required=false)]
                        public string RecallManagementTableId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Filter</para>
                    /// </summary>
                    [NameInMap("OperatorType")]
                    [Validation(Required=false)]
                    public string OperatorType { get; set; }

                    [NameInMap("TriggerConfig")]
                    [Validation(Required=false)]
                    public CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsTriggerConfig TriggerConfig { get; set; }
                    public class CreateRecallManagementServiceVersionRequestConfigsRecallConfigsOperatorsTriggerConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>user_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("FieldQuantityLimit")]
                        [Validation(Required=false)]
                        public string FieldQuantityLimit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsRandSort")]
                        [Validation(Required=false)]
                        public string IsRandSort { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>create_time</para>
                        /// </summary>
                        [NameInMap("SortField")]
                        [Validation(Required=false)]
                        public string SortField { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallManagementTableId")]
                [Validation(Required=false)]
                public string RecallManagementTableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>X2I</para>
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public string RecallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_embedding</para>
                /// </summary>
                [NameInMap("UserVectorField")]
                [Validation(Required=false)]
                public string UserVectorField { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("UserVectorRecallManagementTableId")]
                [Validation(Required=false)]
                public string UserVectorRecallManagementTableId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SourceRecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string SourceRecallManagementServiceVersionId { get; set; }

    }

}
