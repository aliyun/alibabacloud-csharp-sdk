// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AAA45F6-0798-5461-9360-81D133823CE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of elements in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The list of traffic control tasks.</para>
        /// </summary>
        [NameInMap("TrafficControlTasks")]
        [Validation(Required=false)]
        public List<ListTrafficControlTasksResponseBodyTrafficControlTasks> TrafficControlTasks { get; set; }
        public class ListTrafficControlTasksResponseBodyTrafficControlTasks : TeaModel {
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
            /// <para>The description of the traffic control.</para>
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
            /// <para>The list of effective scenes.</para>
            /// </summary>
            [NameInMap("EffectiveSceneNameList")]
            [Validation(Required=false)]
            public List<string> EffectiveSceneNameList { get; set; }

            /// <summary>
            /// <para>The list of effective scene names.</para>
            /// </summary>
            [NameInMap("EffectiveSceneNames")]
            [Validation(Required=false)]
            public List<int?> EffectiveSceneNames { get; set; }

            /// <summary>
            /// <para>The end time. The time is in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-25</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the task has been published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EverPublished")]
            [Validation(Required=false)]
            public bool? EverPublished { get; set; }

            /// <summary>
            /// <para>The execution time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Permanent: Executes permanently.</description></item>
            /// <item><description>TimeRange: Executes within a specified time range. If you select this value, you must specify the StartTime and EndTime parameters.</description></item>
            /// </list>
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
            /// <para>The Flink resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flink_test</para>
            /// </summary>
            [NameInMap("FlinkResourceName")]
            [Validation(Required=false)]
            public string FlinkResourceName { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the ISO 8601 format and uses Z to indicate the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25T06:04:28.441Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The update time. The time is in the ISO 8601 format and uses Z to indicate the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25T06:04:28.441Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The array-formatted conditions for items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
            /// </summary>
            [NameInMap("ItemConditionArray")]
            [Validation(Required=false)]
            public string ItemConditionArray { get; set; }

            /// <summary>
            /// <para>The expression-formatted conditions for items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>status=1</para>
            /// </summary>
            [NameInMap("ItemConditionExpress")]
            [Validation(Required=false)]
            public string ItemConditionExpress { get; set; }

            /// <summary>
            /// <para>The condition type for items.</para>
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
            /// <para>The name of the traffic control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of pre-release experiment IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("PreExperimentIds")]
            [Validation(Required=false)]
            public string PreExperimentIds { get; set; }

            /// <summary>
            /// <para>The status in the pre-release environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runnning</para>
            /// </summary>
            [NameInMap("PrepubStatus")]
            [Validation(Required=false)]
            public string PrepubStatus { get; set; }

            /// <summary>
            /// <para>The list of production experiments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6,7</para>
            /// </summary>
            [NameInMap("ProdExperimentIds")]
            [Validation(Required=false)]
            public string ProdExperimentIds { get; set; }

            /// <summary>
            /// <para>The status in the production environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runnning</para>
            /// </summary>
            [NameInMap("ProductStatus")]
            [Validation(Required=false)]
            public string ProductStatus { get; set; }

            /// <summary>
            /// <para>The scene ID. You can obtain this ID by calling the ListScenes operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scene name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>home_feed</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The list of service IDs.</para>
            /// </summary>
            [NameInMap("ServiceIdList")]
            [Validation(Required=false)]
            public List<int?> ServiceIdList { get; set; }

            /// <summary>
            /// <para>The list of bound engine service IDs.</para>
            /// </summary>
            [NameInMap("ServiceIds")]
            [Validation(Required=false)]
            public List<string> ServiceIds { get; set; }

            /// <summary>
            /// <para>The start time. The time is in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The expression-formatted conditions for behavior statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event=click</para>
            /// </summary>
            [NameInMap("StatisBahaviorConditionExpress")]
            [Validation(Required=false)]
            public string StatisBahaviorConditionExpress { get; set; }

            /// <summary>
            /// <para>The array-formatted conditions for behavior statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;click&quot;,&quot;option&quot;:&quot;&lt;=&quot;,&quot;value&quot;:&quot;30&quot;}]</para>
            /// </summary>
            [NameInMap("StatisBehaviorConditionArray")]
            [Validation(Required=false)]
            public string StatisBehaviorConditionArray { get; set; }

            /// <summary>
            /// <para>The behavior expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event=exposure</para>
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
            /// <para>The list of traffic control targets.</para>
            /// </summary>
            [NameInMap("TrafficControlTargets")]
            [Validation(Required=false)]
            public List<ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargets> TrafficControlTargets { get; set; }
            public class ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargets : TeaModel {
                /// <summary>
                /// <para>The end time. The time is in the YYYY-MM-DD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-25</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The event for the traffic control target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>click</para>
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// <para>The creation time. The time is in the ISO 8601 format and includes the time zone offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-03T15:08:10.58+08:00</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The update time. The time is in the ISO 8601 format and includes the time zone offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-21T16:26:58.57+08:00</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The array-formatted conditions for items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("ItemConditionArray")]
                [Validation(Required=false)]
                public string ItemConditionArray { get; set; }

                /// <summary>
                /// <para>The expression-formatted conditions for items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status=1</para>
                /// </summary>
                [NameInMap("ItemConditionExpress")]
                [Validation(Required=false)]
                public string ItemConditionExpress { get; set; }

                /// <summary>
                /// <para>The condition type for items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Array</para>
                /// </summary>
                [NameInMap("ItemConditionType")]
                [Validation(Required=false)]
                public string ItemConditionType { get; set; }

                /// <summary>
                /// <para>The traffic control target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the recall applies to new items.</para>
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
                /// <para>recall-1</para>
                /// </summary>
                [NameInMap("RecallName")]
                [Validation(Required=false)]
                public string RecallName { get; set; }

                /// <summary>
                /// <para>The details of the split points.</para>
                /// </summary>
                [NameInMap("SplitParts")]
                [Validation(Required=false)]
                public ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargetsSplitParts SplitParts { get; set; }
                public class ListTrafficControlTasksResponseBodyTrafficControlTasksTrafficControlTargetsSplitParts : TeaModel {
                    /// <summary>
                    /// <para>The list of target value split points.</para>
                    /// </summary>
                    [NameInMap("SetValues")]
                    [Validation(Required=false)]
                    public List<long?> SetValues { get; set; }

                    /// <summary>
                    /// <para>The list of time split points.</para>
                    /// </summary>
                    [NameInMap("TimePoints")]
                    [Validation(Required=false)]
                    public List<long?> TimePoints { get; set; }

                }

                /// <summary>
                /// <para>The start time. The time is in the YYYY-MM-DD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-25</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Daily</para>
                /// </summary>
                [NameInMap("StatisPeriod")]
                [Validation(Required=false)]
                public string StatisPeriod { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Opened</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tolerance range of the traffic control target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ToleranceValue")]
                [Validation(Required=false)]
                public long? ToleranceValue { get; set; }

                /// <summary>
                /// <para>The ID of the traffic control target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TrafficControlTargetId")]
                [Validation(Required=false)]
                public string TrafficControlTargetId { get; set; }

                /// <summary>
                /// <para>The ID of the traffic control task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TrafficControlTaskId")]
                [Validation(Required=false)]
                public string TrafficControlTaskId { get; set; }

                /// <summary>
                /// <para>The target value for traffic control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the traffic control task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTaskId")]
            [Validation(Required=false)]
            public string TrafficControlTaskId { get; set; }

            /// <summary>
            /// <para>The array-formatted conditions for the target user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;gender&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;male&quot;}]</para>
            /// </summary>
            [NameInMap("UserConditionArray")]
            [Validation(Required=false)]
            public string UserConditionArray { get; set; }

            /// <summary>
            /// <para>The expression-formatted conditions for the target user group.</para>
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

}
