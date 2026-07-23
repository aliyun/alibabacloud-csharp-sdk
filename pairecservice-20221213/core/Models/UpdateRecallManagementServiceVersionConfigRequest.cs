// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementServiceVersionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the recall management version configuration. Valid values are <c>Recall</c> for the recall configuration and <c>Merge</c> for the merge configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recall</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The merge configuration.</para>
        /// </summary>
        [NameInMap("MergeConfig")]
        [Validation(Required=false)]
        public UpdateRecallManagementServiceVersionConfigRequestMergeConfig MergeConfig { get; set; }
        public class UpdateRecallManagementServiceVersionConfigRequestMergeConfig : TeaModel {
            /// <summary>
            /// <para>Additional configurations for the merge. Reserved for future use.</para>
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
            /// <para>age&gt;20</para>
            /// </summary>
            [NameInMap("FilterExpression")]
            [Validation(Required=false)]
            public string FilterExpression { get; set; }

            /// <summary>
            /// <para>A list of recall management table IDs to use for filtering.</para>
            /// </summary>
            [NameInMap("FilterRecallManagementTableIds")]
            [Validation(Required=false)]
            public List<string> FilterRecallManagementTableIds { get; set; }

            /// <summary>
            /// <para>The ID of the item recall management table.</para>
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
            /// <para>The merge type. Valid values: <c>Weight</c> and <c>Alternate</c>.</para>
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
            /// <para>4</para>
            /// </summary>
            [NameInMap("RecallManagementServiceVersionConfigId")]
            [Validation(Required=false)]
            public string RecallManagementServiceVersionConfigId { get; set; }

        }

        /// <summary>
        /// <para>The recall configuration.</para>
        /// </summary>
        [NameInMap("RecallConfig")]
        [Validation(Required=false)]
        public UpdateRecallManagementServiceVersionConfigRequestRecallConfig RecallConfig { get; set; }
        public class UpdateRecallManagementServiceVersionConfigRequestRecallConfig : TeaModel {
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
            /// <para>The extended configuration. Reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            /// <summary>
            /// <para>The data format of the item condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;type&quot;:&quot;equal&quot;]</para>
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
            /// <para>The ID of the item vector recall management table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>A list of operators.</para>
            /// </summary>
            [NameInMap("Operators")]
            [Validation(Required=false)]
            public List<UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperators> Operators { get; set; }
            public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperators : TeaModel {
                /// <summary>
                /// <para>The configuration for the <c>Feature</c> operator.</para>
                /// </summary>
                [NameInMap("FeatureConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig FeatureConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig : TeaModel {
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
                /// <para>The configuration for the <c>Filter</c> operator.</para>
                /// </summary>
                [NameInMap("FilterConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig FilterConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig : TeaModel {
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
                /// <para>The configuration for the <c>Join</c> operator.</para>
                /// </summary>
                [NameInMap("JoinConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig JoinConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig : TeaModel {
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
                    /// <para>The fields to return from the join.</para>
                    /// </summary>
                    [NameInMap("OutputFields")]
                    [Validation(Required=false)]
                    public List<string> OutputFields { get; set; }

                    /// <summary>
                    /// <para>The ID of the table to join.</para>
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
                /// <para>The configuration for the <c>Trigger</c> operator.</para>
                /// </summary>
                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig TriggerConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig : TeaModel {
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
                    /// <para>Specifies whether to perform a random sort.</para>
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
            /// <para>2</para>
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
            /// <para>The ID of the user vector recall management table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UserVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string UserVectorRecallManagementTableId { get; set; }

        }

    }

}
