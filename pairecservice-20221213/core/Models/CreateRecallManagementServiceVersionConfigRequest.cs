// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementServiceVersionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration type for the recall management version, which can be <c>Recall</c> for a recall config or <c>Merge</c> for a merge config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recall</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai-teest-1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Merge configuration.</para>
        /// </summary>
        [NameInMap("MergeConfig")]
        [Validation(Required=false)]
        public CreateRecallManagementServiceVersionConfigRequestMergeConfig MergeConfig { get; set; }
        public class CreateRecallManagementServiceVersionConfigRequestMergeConfig : TeaModel {
            /// <summary>
            /// <para>Additional configurations for the merge configuration are provided to facilitate future feature extensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            /// <summary>
            /// <para>Filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age&gt;20</para>
            /// </summary>
            [NameInMap("FilterExpression")]
            [Validation(Required=false)]
            public string FilterExpression { get; set; }

            /// <summary>
            /// <para>Filter table ID.</para>
            /// </summary>
            [NameInMap("FilterRecallManagementTableIds")]
            [Validation(Required=false)]
            public List<string> FilterRecallManagementTableIds { get; set; }

            /// <summary>
            /// <para>Item table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ItemRecallManagementTableId")]
            [Validation(Required=false)]
            public string ItemRecallManagementTableId { get; set; }

            /// <summary>
            /// <para>Item table output fields.</para>
            /// </summary>
            [NameInMap("ItemTableFields")]
            [Validation(Required=false)]
            public List<string> ItemTableFields { get; set; }

            /// <summary>
            /// <para>Merge type. Enumerated values: <c>Weight</c> and <c>Alternate</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weight</para>
            /// </summary>
            [NameInMap("MergeType")]
            [Validation(Required=false)]
            public string MergeType { get; set; }

            /// <summary>
            /// <para>recall management service version configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecallManagementServiceVersionConfigId")]
            [Validation(Required=false)]
            public string RecallManagementServiceVersionConfigId { get; set; }

        }

        /// <summary>
        /// <para>Recall configuration.</para>
        /// </summary>
        [NameInMap("RecallConfig")]
        [Validation(Required=false)]
        public CreateRecallManagementServiceVersionConfigRequestRecallConfig RecallConfig { get; set; }
        public class CreateRecallManagementServiceVersionConfigRequestRecallConfig : TeaModel {
            /// <summary>
            /// <para>Recall description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is etrec recall</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Additional configuration for future feature expansion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            /// <summary>
            /// <para>Item condition, setting array-formatted conditions</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;option&quot;:&quot;&lt;&quot;,&quot;field&quot;:&quot;category&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;10&quot;}]</para>
            /// </summary>
            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            /// <summary>
            /// <para>Item condition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age&gt;20</para>
            /// </summary>
            [NameInMap("ItemConditionExpression")]
            [Validation(Required=false)]
            public string ItemConditionExpression { get; set; }

            /// <summary>
            /// <para>Item vector field.</para>
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
            /// <para>5</para>
            /// </summary>
            [NameInMap("ItemVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string ItemVectorRecallManagementTableId { get; set; }

            /// <summary>
            /// <para>Recall name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>etrec</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operator list.</para>
            /// </summary>
            [NameInMap("Operators")]
            [Validation(Required=false)]
            public List<CreateRecallManagementServiceVersionConfigRequestRecallConfigOperators> Operators { get; set; }
            public class CreateRecallManagementServiceVersionConfigRequestRecallConfigOperators : TeaModel {
                /// <summary>
                /// <para><b>Feature operator configuration.</b></para>
                /// </summary>
                [NameInMap("FeatureConfig")]
                [Validation(Required=false)]
                public CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig FeatureConfig { get; set; }
                public class CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig : TeaModel {
                    /// <summary>
                    /// <para><b>Feature expression.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>category=3</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para><b>Feature name.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>city</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para><b>Feature type.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Filter operator configuration.</para>
                /// </summary>
                [NameInMap("FilterConfig")]
                [Validation(Required=false)]
                public CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig FilterConfig { get; set; }
                public class CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig : TeaModel {
                    /// <summary>
                    /// <para>Filter expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>age&gt;20</para>
                    /// </summary>
                    [NameInMap("Experession")]
                    [Validation(Required=false)]
                    public string Experession { get; set; }

                }

                /// <summary>
                /// <para><b>Join operator configuration.</b></para>
                /// </summary>
                [NameInMap("JoinConfig")]
                [Validation(Required=false)]
                public CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig JoinConfig { get; set; }
                public class CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig : TeaModel {
                    /// <summary>
                    /// <para>Join field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>item_id</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>Return field.</para>
                    /// </summary>
                    [NameInMap("OutputFields")]
                    [Validation(Required=false)]
                    public List<string> OutputFields { get; set; }

                    /// <summary>
                    /// <para>Join table ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("RecallManagementTableId")]
                    [Validation(Required=false)]
                    public string RecallManagementTableId { get; set; }

                }

                /// <summary>
                /// <para>Operator type. Enumeration value: FilterFeatureTriggerFeature</para>
                /// 
                /// <b>Example:</b>
                /// <para>Filter</para>
                /// </summary>
                [NameInMap("OperatorType")]
                [Validation(Required=false)]
                public string OperatorType { get; set; }

                /// <summary>
                /// <para>Trigger operator configuration.</para>
                /// </summary>
                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig TriggerConfig { get; set; }
                public class CreateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_id</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>Number of fields limit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("FieldQuantityLimit")]
                    [Validation(Required=false)]
                    public int? FieldQuantityLimit { get; set; }

                    /// <summary>
                    /// <para>Whether to sort randomly.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsRandSort")]
                    [Validation(Required=false)]
                    public bool? IsRandSort { get; set; }

                    /// <summary>
                    /// <para>Sort field.</para>
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
            /// <para>Priority. The smaller the number, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>Recall management table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RecallManagementTableId")]
            [Validation(Required=false)]
            public string RecallManagementTableId { get; set; }

            /// <summary>
            /// <para>Recall type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>X2I</para>
            /// </summary>
            [NameInMap("RecallType")]
            [Validation(Required=false)]
            public string RecallType { get; set; }

            /// <summary>
            /// <para>Sort field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("SortFields")]
            [Validation(Required=false)]
            public string SortFields { get; set; }

            /// <summary>
            /// <para>User vector field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_embedding</para>
            /// </summary>
            [NameInMap("UserVectorField")]
            [Validation(Required=false)]
            public string UserVectorField { get; set; }

            /// <summary>
            /// <para>User vector recall table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UserVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string UserVectorRecallManagementTableId { get; set; }

        }

    }

}
