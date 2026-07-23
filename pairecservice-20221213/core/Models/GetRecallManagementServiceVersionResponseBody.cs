// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementServiceVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration details.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public GetRecallManagementServiceVersionResponseBodyConfigs Configs { get; set; }
        public class GetRecallManagementServiceVersionResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The merge configuration.</para>
            /// </summary>
            [NameInMap("MergeConfig")]
            [Validation(Required=false)]
            public GetRecallManagementServiceVersionResponseBodyConfigsMergeConfig MergeConfig { get; set; }
            public class GetRecallManagementServiceVersionResponseBodyConfigsMergeConfig : TeaModel {
                /// <summary>
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <para>The filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age&gt;20</para>
                /// </summary>
                [NameInMap("FilterExpression")]
                [Validation(Required=false)]
                public string FilterExpression { get; set; }

                /// <summary>
                /// <para>The identifiers of the tables to filter.</para>
                /// </summary>
                [NameInMap("FilterRecallManagementTableIds")]
                [Validation(Required=false)]
                public List<string> FilterRecallManagementTableIds { get; set; }

                /// <summary>
                /// <para>The identifier of the item table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ItemRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemRecallManagementTableId { get; set; }

                /// <summary>
                /// <para>The output fields from the item table.</para>
                /// </summary>
                [NameInMap("ItemTableFields")]
                [Validation(Required=false)]
                public List<string> ItemTableFields { get; set; }

                /// <summary>
                /// <para>The merge type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weight</para>
                /// </summary>
                [NameInMap("MergeType")]
                [Validation(Required=false)]
                public string MergeType { get; set; }

                /// <summary>
                /// <para>The identifier of the recall service version configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallManagementServiceVersionConfigId")]
                [Validation(Required=false)]
                public string RecallManagementServiceVersionConfigId { get; set; }

            }

            /// <summary>
            /// <para>The recall service version configurations.</para>
            /// </summary>
            [NameInMap("RecallConfigs")]
            [Validation(Required=false)]
            public List<GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigs> RecallConfigs { get; set; }
            public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigs : TeaModel {
                /// <summary>
                /// <para>The recall description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is etrec recall</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <para>The item conditions, specified as a string in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;option&quot;:&quot;&lt;&quot;,&quot;field&quot;:&quot;category&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;10&quot;}]</para>
                /// </summary>
                [NameInMap("ItemConditionArray")]
                [Validation(Required=false)]
                public string ItemConditionArray { get; set; }

                /// <summary>
                /// <para>The item condition expression.</para>
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
                /// <para>The identifier of the item vector recall table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ItemVectorRecallManagementTableId")]
                [Validation(Required=false)]
                public string ItemVectorRecallManagementTableId { get; set; }

                /// <summary>
                /// <para>The recall name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>etrec</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of operators to apply.</para>
                /// </summary>
                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperators> Operators { get; set; }
                public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperators : TeaModel {
                    /// <summary>
                    /// <para>The configuration for the Feature operator.</para>
                    /// </summary>
                    [NameInMap("FeatureConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFeatureConfig FeatureConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFeatureConfig : TeaModel {
                        /// <summary>
                        /// <para>The feature expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>city = \&quot;hangzhou\&quot;</para>
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
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration for the Filter operator.</para>
                    /// </summary>
                    [NameInMap("FilterConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFilterConfig FilterConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFilterConfig : TeaModel {
                        /// <summary>
                        /// <para>The filter expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>age &gt; 10</para>
                        /// </summary>
                        [NameInMap("Experession")]
                        [Validation(Required=false)]
                        public string Experession { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration for the Join operator.</para>
                    /// </summary>
                    [NameInMap("JoinConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsJoinConfig JoinConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsJoinConfig : TeaModel {
                        /// <summary>
                        /// <para>The join field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        /// <summary>
                        /// <para>The fields to return.</para>
                        /// </summary>
                        [NameInMap("OutputFields")]
                        [Validation(Required=false)]
                        public List<string> OutputFields { get; set; }

                        /// <summary>
                        /// <para>The identifier of the join table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
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
                    /// <para>The configuration for the Trigger operator.</para>
                    /// </summary>
                    [NameInMap("TriggerConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsTriggerConfig TriggerConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsTriggerConfig : TeaModel {
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
                        /// <para>The maximum number of fields.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("FieldQuantityLimit")]
                        [Validation(Required=false)]
                        public int? FieldQuantityLimit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether to perform a random sort.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsRandSort")]
                        [Validation(Required=false)]
                        public bool? IsRandSort { get; set; }

                        /// <summary>
                        /// <para>The sort field.</para>
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
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The identifier of the recall service version configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RecallManagementServiceVersionConfigId")]
                [Validation(Required=false)]
                public string RecallManagementServiceVersionConfigId { get; set; }

                /// <summary>
                /// <para>The identifier of the recall management table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
                /// <para>The identifier of the user vector recall table.</para>
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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the current version is effective.</para>
        /// </summary>
        [NameInMap("IsEffective")]
        [Validation(Required=false)]
        public bool? IsEffective { get; set; }

        /// <summary>
        /// <para>The name of the recall service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The identifier of the recall service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string RecallManagementServiceVersionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E15A1443-7917-5BE0-AE70-25538ECF398D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
