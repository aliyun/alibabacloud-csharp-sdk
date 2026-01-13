// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementServiceVersionConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Recall</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

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

        [NameInMap("MergeConfig")]
        [Validation(Required=false)]
        public GetRecallManagementServiceVersionConfigResponseBodyMergeConfig MergeConfig { get; set; }
        public class GetRecallManagementServiceVersionConfigResponseBodyMergeConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;:&quot;&quot;}</para>
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

        [NameInMap("RecallConfig")]
        [Validation(Required=false)]
        public GetRecallManagementServiceVersionConfigResponseBodyRecallConfig RecallConfig { get; set; }
        public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>this is etrec recall</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;:&quot;&quot;}</para>
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
            /// <para>2</para>
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
            public List<GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperators> Operators { get; set; }
            public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperators : TeaModel {
                [NameInMap("FeatureConfig")]
                [Validation(Required=false)]
                public GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsFeatureConfig FeatureConfig { get; set; }
                public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsFeatureConfig : TeaModel {
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("FilterConfig")]
                [Validation(Required=false)]
                public GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsFilterConfig FilterConfig { get; set; }
                public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsFilterConfig : TeaModel {
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                }

                [NameInMap("JoinConfig")]
                [Validation(Required=false)]
                public GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsJoinConfig JoinConfig { get; set; }
                public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsJoinConfig : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("OutputFields")]
                    [Validation(Required=false)]
                    public List<string> OutputFields { get; set; }

                    [NameInMap("RecallManagementTableId")]
                    [Validation(Required=false)]
                    public string RecallManagementTableId { get; set; }

                }

                [NameInMap("OperatorType")]
                [Validation(Required=false)]
                public string OperatorType { get; set; }

                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsTriggerConfig TriggerConfig { get; set; }
                public class GetRecallManagementServiceVersionConfigResponseBodyRecallConfigOperatorsTriggerConfig : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("FieldQuantityLimit")]
                    [Validation(Required=false)]
                    public int? FieldQuantityLimit { get; set; }

                    [NameInMap("IsRandSort")]
                    [Validation(Required=false)]
                    public bool? IsRandSort { get; set; }

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
            /// <para>3</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string UserVectorRecallManagementTableId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecallManagementServiceId")]
        [Validation(Required=false)]
        public string RecallManagementServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersionConfigId")]
        [Validation(Required=false)]
        public string RecallManagementServiceVersionConfigId { get; set; }

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
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
