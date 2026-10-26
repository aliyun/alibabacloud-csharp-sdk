// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateTrafficControlTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the behavior table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BehaviorTableMetaId")]
        [Validation(Required=false)]
        public string BehaviorTableMetaId { get; set; }

        /// <summary>
        /// <para>The control granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Global: global</description></item>
        /// <item><description>Single: single item</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("ControlGranularity")]
        [Validation(Required=false)]
        public string ControlGranularity { get; set; }

        /// <summary>
        /// <para>The control logic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Guaranteed: guaranteed traffic control</description></item>
        /// <item><description>Approach: approximate traffic control</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Guaranteed</para>
        /// </summary>
        [NameInMap("ControlLogic")]
        [Validation(Required=false)]
        public string ControlLogic { get; set; }

        /// <summary>
        /// <para>The control type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Percent: percentage-based control</description></item>
        /// <item><description>Quantity: quantity-based control</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Percent</para>
        /// </summary>
        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        /// <summary>
        /// <para>The description of the traffic control task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of effective scene IDs.</para>
        /// </summary>
        [NameInMap("EffectiveSceneIds")]
        [Validation(Required=false)]
        public List<int?> EffectiveSceneIds { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-26</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Permanent: The task is executed permanently.</description></item>
        /// <item><description>TimeRange: The task is executed within a specified time range. If you select this value, you must specify StartTime and EndTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TimeRange</para>
        /// </summary>
        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// <para>The ID of the Flink data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>res-***</para>
        /// </summary>
        [NameInMap("FlinkResourceId")]
        [Validation(Required=false)]
        public string FlinkResourceId { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The conditions for items in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;status\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for items in expression format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status=1</para>
        /// </summary>
        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        /// <summary>
        /// <para>The condition type for items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Array: array format</description></item>
        /// <item><description>Expression: expression format</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        /// <summary>
        /// <para>The ID of the item table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ItemTableMetaId")]
        [Validation(Required=false)]
        public string ItemTableMetaId { get; set; }

        /// <summary>
        /// <para>The name of the traffic control task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of the experiments in the pre-release environment. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("PreExperimentIds")]
        [Validation(Required=false)]
        public string PreExperimentIds { get; set; }

        /// <summary>
        /// <para>The IDs of the experiments in the production environment. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,5,6</para>
        /// </summary>
        [NameInMap("ProdExperimentIds")]
        [Validation(Required=false)]
        public string ProdExperimentIds { get; set; }

        /// <summary>
        /// <para>The scene ID. You can call the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation to obtain the scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The list of bound engine service IDs.</para>
        /// </summary>
        [NameInMap("ServiceIds")]
        [Validation(Required=false)]
        public List<int?> ServiceIds { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-25</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The conditions for statistical behaviors in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;click\&quot;,\&quot;option\&quot;:\&quot;&lt;=\&quot;,\&quot;value\&quot;:\&quot;30\&quot;}]</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionArray")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for statistical behaviors in expression format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click=30</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionExpress")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionExpress { get; set; }

        /// <summary>
        /// <para>The condition type for statistical behaviors. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Array: array format</description></item>
        /// <item><description>Expression: expression format</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("StatisBehaviorConditionType")]
        [Validation(Required=false)]
        public string StatisBehaviorConditionType { get; set; }

        /// <summary>
        /// <para>The list of traffic control targets.</para>
        /// </summary>
        [NameInMap("TrafficControlTargets")]
        [Validation(Required=false)]
        public List<CreateTrafficControlTaskRequestTrafficControlTargets> TrafficControlTargets { get; set; }
        public class CreateTrafficControlTaskRequestTrafficControlTargets : TeaModel {
            /// <summary>
            /// <para>The end time of the control target. Specify the time in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-25</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event of the control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>click</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The conditions for items in array format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;field\&quot;:\&quot;status\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
            /// </summary>
            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            /// <summary>
            /// <para>The conditions for items in expression format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>status=1</para>
            /// </summary>
            [NameInMap("ItemConditionExpress")]
            [Validation(Required=false)]
            public string ItemConditionExpress { get; set; }

            /// <summary>
            /// <para>The condition type for item control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Array: array format</description></item>
            /// <item><description>Expression: expression format</description></item>
            /// </list>
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
            /// <para>target_1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether the target is for new product regulation.</para>
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
            /// <para>recall_1</para>
            /// </summary>
            [NameInMap("RecallName")]
            [Validation(Required=false)]
            public string RecallName { get; set; }

            /// <summary>
            /// <para>The start time of the control target. Specify the time in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The statistical period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: daily</description></item>
            /// <item><description>Hour: hourly</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("StatisPeriod")]
            [Validation(Required=false)]
            public string StatisPeriod { get; set; }

            /// <summary>
            /// <para>The status of the control target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Opened: enabled</description></item>
            /// <item><description>Closed: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Opened</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tolerance range of the control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ToleranceValue")]
            [Validation(Required=false)]
            public long? ToleranceValue { get; set; }

            /// <summary>
            /// <para>The target value for control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// <para>The conditions for the target users in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;gender\&quot;,\&quot;option\&quot;:\&quot;=\&quot;,\&quot;value\&quot;:\&quot;male\&quot;}]</para>
        /// </summary>
        [NameInMap("UserConditionArray")]
        [Validation(Required=false)]
        public string UserConditionArray { get; set; }

        /// <summary>
        /// <para>The conditions for the target users in expression format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>age&lt;=30&amp;&amp;(3&lt;=level&lt;=6)&amp;&amp;gender=male</para>
        /// </summary>
        [NameInMap("UserConditionExpress")]
        [Validation(Required=false)]
        public string UserConditionExpress { get; set; }

        /// <summary>
        /// <para>The condition type for the target users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Array: array format</description></item>
        /// <item><description>Expression: expression format</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("UserConditionType")]
        [Validation(Required=false)]
        public string UserConditionType { get; set; }

        /// <summary>
        /// <para>The ID of the user table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UserTableMetaId")]
        [Validation(Required=false)]
        public string UserTableMetaId { get; set; }

    }

}
