// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementServiceVersionResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public GetRecallManagementServiceVersionResponseBodyConfigs Configs { get; set; }
        public class GetRecallManagementServiceVersionResponseBodyConfigs : TeaModel {
            [NameInMap("MergeConfig")]
            [Validation(Required=false)]
            public GetRecallManagementServiceVersionResponseBodyConfigsMergeConfig MergeConfig { get; set; }
            public class GetRecallManagementServiceVersionResponseBodyConfigsMergeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ExtendedConfig")]
                [Validation(Required=false)]
                public string ExtendedConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>age&gt;20</para>
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
            public List<GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigs> RecallConfigs { get; set; }
            public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigs : TeaModel {
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
                public List<GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperators> Operators { get; set; }
                public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperators : TeaModel {
                    [NameInMap("FeatureConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFeatureConfig FeatureConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFeatureConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>city = \&quot;hangzhou\&quot;</para>
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
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("FilterConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFilterConfig FilterConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsFilterConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>age &gt; 10</para>
                        /// </summary>
                        [NameInMap("Experession")]
                        [Validation(Required=false)]
                        public string Experession { get; set; }

                    }

                    [NameInMap("JoinConfig")]
                    [Validation(Required=false)]
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsJoinConfig JoinConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsJoinConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>item_id</para>
                        /// </summary>
                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        [NameInMap("OutputFields")]
                        [Validation(Required=false)]
                        public List<string> OutputFields { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
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
                    public GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsTriggerConfig TriggerConfig { get; set; }
                    public class GetRecallManagementServiceVersionResponseBodyConfigsRecallConfigsOperatorsTriggerConfig : TeaModel {
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
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RecallManagementServiceVersionConfigId")]
                [Validation(Required=false)]
                public string RecallManagementServiceVersionConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
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
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public string IsDefault { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string RecallManagementServiceVersionId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E15A1443-7917-5BE0-AE70-25538ECF398D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
