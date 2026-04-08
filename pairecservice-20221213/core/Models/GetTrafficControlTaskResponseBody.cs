// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BehaviorTableMetaId")]
        [Validation(Required=false)]
        public string BehaviorTableMetaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("ControlGranularity")]
        [Validation(Required=false)]
        public string ControlGranularity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Guaranteed</para>
        /// </summary>
        [NameInMap("ControlLogic")]
        [Validation(Required=false)]
        public string ControlLogic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Percent</para>
        /// </summary>
        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a test task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EffectiveSceneIds")]
        [Validation(Required=false)]
        public List<int?> EffectiveSceneIds { get; set; }

        [NameInMap("EffectiveSceneNames")]
        [Validation(Required=false)]
        public List<string> EffectiveSceneNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-25</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EverPublished")]
        [Validation(Required=false)]
        public bool? EverPublished { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>resource-xxx</para>
        /// </summary>
        [NameInMap("FlinkResourceId")]
        [Validation(Required=false)]
        public string FlinkResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flink_test</para>
        /// </summary>
        [NameInMap("FlinkResourceName")]
        [Validation(Required=false)]
        public string FlinkResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-11T02:27:38.208Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-11T02:27:38.208Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>status=1</para>
        /// </summary>
        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ItemTableMetaId")]
        [Validation(Required=false)]
        public string ItemTableMetaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("PreExperimentIds")]
        [Validation(Required=false)]
        public string PreExperimentIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("PrepubStatus")]
        [Validation(Required=false)]
        public string PrepubStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4,5,6</para>
        /// </summary>
        [NameInMap("ProdExperimentIds")]
        [Validation(Required=false)]
        public string ProdExperimentIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ProductStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>scene-2</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceIds")]
        [Validation(Required=false)]
        public List<int?> ServiceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-25</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;click&quot;,&quot;option&quot;:&quot;&lt;=&quot;,&quot;value&quot;:&quot;30&quot;}]</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionArray")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>click=30</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionExpress")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionExpress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionType")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionType { get; set; }

        [NameInMap("TrafficControlTargets")]
        [Validation(Required=false)]
        public List<GetTrafficControlTaskResponseBodyTrafficControlTargets> TrafficControlTargets { get; set; }
        public class GetTrafficControlTaskResponseBodyTrafficControlTargets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-25</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>click</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-25T06:04:28.441Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-25T06:04:28.441Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
            /// </summary>
            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>status=1</para>
            /// </summary>
            [NameInMap("ItemConditionExpress")]
            [Validation(Required=false)]
            public string ItemConditionExpress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Array</para>
            /// </summary>
            [NameInMap("ItemConditionType")]
            [Validation(Required=false)]
            public string ItemConditionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>target-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NewProductRegulation")]
            [Validation(Required=false)]
            public bool? NewProductRegulation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>recall-1</para>
            /// </summary>
            [NameInMap("RecallName")]
            [Validation(Required=false)]
            public string RecallName { get; set; }

            [NameInMap("SplitParts")]
            [Validation(Required=false)]
            public GetTrafficControlTaskResponseBodyTrafficControlTargetsSplitParts SplitParts { get; set; }
            public class GetTrafficControlTaskResponseBodyTrafficControlTargetsSplitParts : TeaModel {
                [NameInMap("SetPoints")]
                [Validation(Required=false)]
                public List<int?> SetPoints { get; set; }

                [NameInMap("SetValues")]
                [Validation(Required=false)]
                public List<long?> SetValues { get; set; }

                [NameInMap("TimePoints")]
                [Validation(Required=false)]
                public List<int?> TimePoints { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-25</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("StatisPeriod")]
            [Validation(Required=false)]
            public string StatisPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Opened</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ToleranceValue")]
            [Validation(Required=false)]
            public long? ToleranceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTaskId")]
            [Validation(Required=false)]
            public string TrafficControlTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;gender&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;male&quot;}]</para>
        /// </summary>
        [NameInMap("UserConditionArray")]
        [Validation(Required=false)]
        public string UserConditionArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>age&lt;=30&amp;&amp;(3&lt;=level&lt;=6)&amp;&amp;gender=male</para>
        /// </summary>
        [NameInMap("UserConditionExpress")]
        [Validation(Required=false)]
        public string UserConditionExpress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("UserConditionType")]
        [Validation(Required=false)]
        public string UserConditionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UserTableMetaId")]
        [Validation(Required=false)]
        public string UserTableMetaId { get; set; }

    }

}
