// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateAutoScalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        [NameInMap("EffectiveTimeEnd")]
        [Validation(Required=false)]
        public string EffectiveTimeEnd { get; set; }

        [NameInMap("EffectiveTimeStart")]
        [Validation(Required=false)]
        public string EffectiveTimeStart { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NodesMax")]
        [Validation(Required=false)]
        public int? NodesMax { get; set; }

        [NameInMap("NodesMin")]
        [Validation(Required=false)]
        public int? NodesMin { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScaleRuleList")]
        [Validation(Required=false)]
        public List<CreateAutoScalingConfigRequestScaleRuleList> ScaleRuleList { get; set; }
        public class CreateAutoScalingConfigRequestScaleRuleList : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ObservationWindow")]
            [Validation(Required=false)]
            public int? ObservationWindow { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("ScaleInStep")]
            [Validation(Required=false)]
            public int? ScaleInStep { get; set; }

            [NameInMap("ScaleOutStep")]
            [Validation(Required=false)]
            public int? ScaleOutStep { get; set; }

            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("TargetMetric")]
            [Validation(Required=false)]
            public string TargetMetric { get; set; }

            [NameInMap("TargetNodes")]
            [Validation(Required=false)]
            public int? TargetNodes { get; set; }

            [NameInMap("ThresholdLower")]
            [Validation(Required=false)]
            public int? ThresholdLower { get; set; }

            [NameInMap("ThresholdUpper")]
            [Validation(Required=false)]
            public int? ThresholdUpper { get; set; }

            [NameInMap("TriggerCronExpr")]
            [Validation(Required=false)]
            public string TriggerCronExpr { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public string SpecId { get; set; }

        [NameInMap("StorageCapacityMax")]
        [Validation(Required=false)]
        public long? StorageCapacityMax { get; set; }

    }

}
