// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateTrafficControlTaskRequest : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-26</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TimeRange</para>
        /// </summary>
        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        [NameInMap("FlinkResourceId")]
        [Validation(Required=false)]
        public string FlinkResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;status\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
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

        [NameInMap("PreExperimentIds")]
        [Validation(Required=false)]
        public string PreExperimentIds { get; set; }

        [NameInMap("ProdExperimentIds")]
        [Validation(Required=false)]
        public string ProdExperimentIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <para>[{\&quot;field\&quot;:\&quot;click\&quot;,\&quot;option\&quot;:\&quot;&lt;=\&quot;,\&quot;value\&quot;:\&quot;30\&quot;}]</para>
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
        public List<CreateTrafficControlTaskRequestTrafficControlTargets> TrafficControlTargets { get; set; }
        public class CreateTrafficControlTaskRequestTrafficControlTargets : TeaModel {
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
            /// <para>[{\&quot;field\&quot;:\&quot;status\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
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
            /// <para>target_1</para>
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
            /// <para>recall_1</para>
            /// </summary>
            [NameInMap("RecallName")]
            [Validation(Required=false)]
            public string RecallName { get; set; }

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
            /// <para>20</para>
            /// </summary>
            [NameInMap("ToleranceValue")]
            [Validation(Required=false)]
            public long? ToleranceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;gender\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;male\&quot;}]</para>
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
