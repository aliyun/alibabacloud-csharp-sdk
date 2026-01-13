// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementServiceVersionConfigRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MergeConfig")]
        [Validation(Required=false)]
        public UpdateRecallManagementServiceVersionConfigRequestMergeConfig MergeConfig { get; set; }
        public class UpdateRecallManagementServiceVersionConfigRequestMergeConfig : TeaModel {
            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            [NameInMap("FilterExpression")]
            [Validation(Required=false)]
            public string FilterExpression { get; set; }

            [NameInMap("FilterRecallManagementTableIds")]
            [Validation(Required=false)]
            public List<string> FilterRecallManagementTableIds { get; set; }

            [NameInMap("ItemRecallManagementTableId")]
            [Validation(Required=false)]
            public string ItemRecallManagementTableId { get; set; }

            [NameInMap("ItemTableFields")]
            [Validation(Required=false)]
            public List<string> ItemTableFields { get; set; }

            [NameInMap("MergeType")]
            [Validation(Required=false)]
            public string MergeType { get; set; }

            [NameInMap("RecallManagementServiceVersionConfigId")]
            [Validation(Required=false)]
            public string RecallManagementServiceVersionConfigId { get; set; }

        }

        [NameInMap("RecallConfig")]
        [Validation(Required=false)]
        public UpdateRecallManagementServiceVersionConfigRequestRecallConfig RecallConfig { get; set; }
        public class UpdateRecallManagementServiceVersionConfigRequestRecallConfig : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            [NameInMap("ItemVectorField")]
            [Validation(Required=false)]
            public string ItemVectorField { get; set; }

            [NameInMap("ItemVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string ItemVectorRecallManagementTableId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operators")]
            [Validation(Required=false)]
            public List<UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperators> Operators { get; set; }
            public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperators : TeaModel {
                [NameInMap("FeatureConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig FeatureConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFeatureConfig : TeaModel {
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
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig FilterConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsFilterConfig : TeaModel {
                    [NameInMap("Experession")]
                    [Validation(Required=false)]
                    public string Experession { get; set; }

                }

                [NameInMap("JoinConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig JoinConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsJoinConfig : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("OutputFields")]
                    [Validation(Required=false)]
                    public string OutputFields { get; set; }

                    [NameInMap("RecallManagementTableId")]
                    [Validation(Required=false)]
                    public string RecallManagementTableId { get; set; }

                }

                [NameInMap("OperatorsType")]
                [Validation(Required=false)]
                public string OperatorsType { get; set; }

                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig TriggerConfig { get; set; }
                public class UpdateRecallManagementServiceVersionConfigRequestRecallConfigOperatorsTriggerConfig : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("FieldQuantityLimit")]
                    [Validation(Required=false)]
                    public string FieldQuantityLimit { get; set; }

                    [NameInMap("IsRandSort")]
                    [Validation(Required=false)]
                    public string IsRandSort { get; set; }

                    [NameInMap("SortField")]
                    [Validation(Required=false)]
                    public string SortField { get; set; }

                }

            }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("RecallManagementTableId")]
            [Validation(Required=false)]
            public string RecallManagementTableId { get; set; }

            [NameInMap("RecallType")]
            [Validation(Required=false)]
            public string RecallType { get; set; }

            [NameInMap("UserVectorField")]
            [Validation(Required=false)]
            public string UserVectorField { get; set; }

            [NameInMap("UserVectorRecallManagementTableId")]
            [Validation(Required=false)]
            public string UserVectorRecallManagementTableId { get; set; }

        }

    }

}
