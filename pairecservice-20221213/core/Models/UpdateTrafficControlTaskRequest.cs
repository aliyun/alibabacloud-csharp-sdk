// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskRequest : TeaModel {
        [NameInMap("BehaviorTableMetaId")]
        [Validation(Required=false)]
        public string BehaviorTableMetaId { get; set; }

        [NameInMap("ControlGranularity")]
        [Validation(Required=false)]
        public string ControlGranularity { get; set; }

        [NameInMap("ControlLogic")]
        [Validation(Required=false)]
        public string ControlLogic { get; set; }

        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        [NameInMap("FlinkResourceId")]
        [Validation(Required=false)]
        public string FlinkResourceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        [NameInMap("ItemTableMetaId")]
        [Validation(Required=false)]
        public string ItemTableMetaId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PreExperimentIds")]
        [Validation(Required=false)]
        public string PreExperimentIds { get; set; }

        [NameInMap("ProdExperimentIds")]
        [Validation(Required=false)]
        public string ProdExperimentIds { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StatisBaeaviorConditionArray")]
        [Validation(Required=false)]
        public string StatisBaeaviorConditionArray { get; set; }

        [NameInMap("StatisBehaviorConditionExpress")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionExpress { get; set; }

        [NameInMap("StatisBehaviorConditionType")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionType { get; set; }

        [NameInMap("TrafficControlTargets")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskRequestTrafficControlTargets> TrafficControlTargets { get; set; }
        public class UpdateTrafficControlTaskRequestTrafficControlTargets : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            [NameInMap("ItemConditionExpress")]
            [Validation(Required=false)]
            public string ItemConditionExpress { get; set; }

            [NameInMap("ItemConditionType")]
            [Validation(Required=false)]
            public string ItemConditionType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NewProductRegulation")]
            [Validation(Required=false)]
            public bool? NewProductRegulation { get; set; }

            [NameInMap("RecallName")]
            [Validation(Required=false)]
            public string RecallName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StatisPeriod")]
            [Validation(Required=false)]
            public string StatisPeriod { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ToleranceValue")]
            [Validation(Required=false)]
            public long? ToleranceValue { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        [NameInMap("UserConditionArray")]
        [Validation(Required=false)]
        public string UserConditionArray { get; set; }

        [NameInMap("UserConditionExpress")]
        [Validation(Required=false)]
        public string UserConditionExpress { get; set; }

        [NameInMap("UserConditionType")]
        [Validation(Required=false)]
        public string UserConditionType { get; set; }

        [NameInMap("UserTableMetaId")]
        [Validation(Required=false)]
        public string UserTableMetaId { get; set; }

    }

}
