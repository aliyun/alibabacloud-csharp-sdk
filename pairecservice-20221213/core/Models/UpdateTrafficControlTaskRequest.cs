// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskRequest : TeaModel {
        /// <summary>
        /// <para>The behavior table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BehaviorTableMetaId")]
        [Validation(Required=false)]
        public string BehaviorTableMetaId { get; set; }

        /// <summary>
        /// <para>The control granularity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("ControlGranularity")]
        [Validation(Required=false)]
        public string ControlGranularity { get; set; }

        /// <summary>
        /// <para>The control logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Guaranteed</para>
        /// </summary>
        [NameInMap("ControlLogic")]
        [Validation(Required=false)]
        public string ControlLogic { get; set; }

        /// <summary>
        /// <para>The control type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Percent</para>
        /// </summary>
        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        /// <summary>
        /// <para>The description of the traffic control plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of effective scene IDs.</para>
        /// </summary>
        [NameInMap("EffectiveSceneIds")]
        [Validation(Required=false)]
        public List<int?> EffectiveSceneIds { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-25</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution time. Valid values: <c>Permanent</c> (runs indefinitely) and <c>TimeRange</c> (runs within a specified period). If you select <c>TimeRange</c>, you must also specify <c>StartTime</c> and <c>EndTime</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// <para>The Flink resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resource-xxx</para>
        /// </summary>
        [NameInMap("FlinkResourceId")]
        [Validation(Required=false)]
        public string FlinkResourceId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-1324***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The item conditions, specified in an array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <para>The item conditions, specified as an expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status=1</para>
        /// </summary>
        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        /// <summary>
        /// <para>The item condition type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        /// <summary>
        /// <para>The item table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ItemTableMetaId")]
        [Validation(Required=false)]
        public string ItemTableMetaId { get; set; }

        /// <summary>
        /// <para>The name of the traffic control plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A comma-separated list of pre-release experiment IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3,4</para>
        /// </summary>
        [NameInMap("PreExperimentIds")]
        [Validation(Required=false)]
        public string PreExperimentIds { get; set; }

        /// <summary>
        /// <para>A comma-separated list of production experiment IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ProdExperimentIds")]
        [Validation(Required=false)]
        public string ProdExperimentIds { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The engine service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>A list of associated engine service IDs.</para>
        /// </summary>
        [NameInMap("ServiceIds")]
        [Validation(Required=false)]
        public List<int?> ServiceIds { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-25</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The conditions for behavior statistics, specified in an array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click=exposure</para>
        /// </summary>
        [NameInMap("StatisBaeaviorConditionArray")]
        [Validation(Required=false)]
        public string StatisBaeaviorConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for behavior statistics, specified in an array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click=exposure</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionArray")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for behavior statistics, specified as an expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click=30</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionExpress")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionExpress { get; set; }

        /// <summary>
        /// <para>The condition type for behavior statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionType")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionType { get; set; }

        /// <summary>
        /// <para>A list of traffic control targets.</para>
        /// </summary>
        [NameInMap("TrafficControlTargets")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskRequestTrafficControlTargets> TrafficControlTargets { get; set; }
        public class UpdateTrafficControlTaskRequestTrafficControlTargets : TeaModel {
            /// <summary>
            /// <para>The end time of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:02:57.487556956+08:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event for the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exposure</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The item conditions, specified in an array format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
            /// </summary>
            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            /// <summary>
            /// <para>The item conditions, specified as an expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age&gt;20</para>
            /// </summary>
            [NameInMap("ItemConditionExpress")]
            [Validation(Required=false)]
            public string ItemConditionExpress { get; set; }

            /// <summary>
            /// <para>The item condition type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Array</para>
            /// </summary>
            [NameInMap("ItemConditionType")]
            [Validation(Required=false)]
            public string ItemConditionType { get; set; }

            /// <summary>
            /// <para>The name of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a new item recall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NewProductRegulation")]
            [Validation(Required=false)]
            public bool? NewProductRegulation { get; set; }

            /// <summary>
            /// <para>The recall policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hot_recall</para>
            /// </summary>
            [NameInMap("RecallName")]
            [Validation(Required=false)]
            public string RecallName { get; set; }

            /// <summary>
            /// <para>The start time of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-10T09:16:03.893+08:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatisPeriod")]
            [Validation(Required=false)]
            public string StatisPeriod { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tolerance range for the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ToleranceValue")]
            [Validation(Required=false)]
            public long? ToleranceValue { get; set; }

            /// <summary>
            /// <para>The value of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// <para>The conditions for the target user group, specified in an array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;gender&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;male&quot;}]</para>
        /// </summary>
        [NameInMap("UserConditionArray")]
        [Validation(Required=false)]
        public string UserConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for the target user group, specified as an expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>age&lt;=30&amp;&amp;(3&lt;=level&lt;=6)&amp;&amp;gender=male</para>
        /// </summary>
        [NameInMap("UserConditionExpress")]
        [Validation(Required=false)]
        public string UserConditionExpress { get; set; }

        /// <summary>
        /// <para>The condition type for the target user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("UserConditionType")]
        [Validation(Required=false)]
        public string UserConditionType { get; set; }

        /// <summary>
        /// <para>The user table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UserTableMetaId")]
        [Validation(Required=false)]
        public string UserTableMetaId { get; set; }

    }

}
