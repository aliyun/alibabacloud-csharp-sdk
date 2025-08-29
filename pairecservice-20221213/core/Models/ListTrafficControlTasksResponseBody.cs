// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("TrafficControlTasks")]
        [Validation(Required=false)]
        public List<ListTrafficControlTasksResponseBodyTrafficControlTasks> TrafficControlTasks { get; set; }
        public class ListTrafficControlTasksResponseBodyTrafficControlTasks : TeaModel {
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

            [NameInMap("EffectiveSceneIds")]
            [Validation(Required=false)]
            public List<int?> EffectiveSceneIds { get; set; }

            [NameInMap("EffectiveSceneNames")]
            [Validation(Required=false)]
            public List<int?> EffectiveSceneNames { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EverPublished")]
            [Validation(Required=false)]
            public bool? EverPublished { get; set; }

            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public string ExecutionTime { get; set; }

            [NameInMap("FlinkResourceId")]
            [Validation(Required=false)]
            public string FlinkResourceId { get; set; }

            [NameInMap("FlinkResourceName")]
            [Validation(Required=false)]
            public string FlinkResourceName { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

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

            [NameInMap("PrepubStatus")]
            [Validation(Required=false)]
            public string PrepubStatus { get; set; }

            [NameInMap("ProdExperimentIds")]
            [Validation(Required=false)]
            public string ProdExperimentIds { get; set; }

            [NameInMap("ProductStatus")]
            [Validation(Required=false)]
            public string ProductStatus { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceIds")]
            [Validation(Required=false)]
            public List<string> ServiceIds { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StatisBahaviorConditionExpress")]
            [Validation(Required=false)]
            public string StatisBahaviorConditionExpress { get; set; }

            [NameInMap("StatisBehaviorConditionArray")]
            [Validation(Required=false)]
            public string StatisBehaviorConditionArray { get; set; }

            [NameInMap("StatisBehaviorConditionType")]
            [Validation(Required=false)]
            public string StatisBehaviorConditionType { get; set; }

            [NameInMap("TrafficControlTargets")]
            [Validation(Required=false)]
            public List<ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargets> TrafficControlTargets { get; set; }
            public class ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargets : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

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

                [NameInMap("SplitParts")]
                [Validation(Required=false)]
                public ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargetsSplitParts SplitParts { get; set; }
                public class ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargetsSplitParts : TeaModel {
                    [NameInMap("SetValues")]
                    [Validation(Required=false)]
                    public List<long?> SetValues { get; set; }

                    [NameInMap("TimePoints")]
                    [Validation(Required=false)]
                    public List<long?> TimePoints { get; set; }

                }

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

                [NameInMap("TrafficControlTargetId")]
                [Validation(Required=false)]
                public string TrafficControlTargetId { get; set; }

                [NameInMap("TrafficControlTaskId")]
                [Validation(Required=false)]
                public string TrafficControlTaskId { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("TrafficControlTaskId")]
            [Validation(Required=false)]
            public string TrafficControlTaskId { get; set; }

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

}
