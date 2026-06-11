// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery task details.</para>
        /// </summary>
        [NameInMap("deliveryTask")]
        [Validation(Required=false)]
        public GetDeliveryTaskResponseBodyDeliveryTask DeliveryTask { get; set; }
        public class GetDeliveryTaskResponseBodyDeliveryTask : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-24T02:08:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data source ID (the Prometheus instance ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxxxxx</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>A map of key-value pairs to add as external labels to all delivered metrics.</para>
            /// </summary>
            [NameInMap("externalLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExternalLabels { get; set; }

            /// <summary>
            /// <para>The extra information.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo ExtraInfo { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo : TeaModel {
                /// <summary>
                /// <para>The names of the associated EventBridge tasks.</para>
                /// </summary>
                [NameInMap("taskNameList")]
                [Validation(Required=false)]
                public List<string> TaskNameList { get; set; }

            }

            /// <summary>
            /// <para>The label filters, used with <c>labelFiltersType</c>. In each filter, the key is the metric label and the value is the value to match.</para>
            /// </summary>
            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public Dictionary<string, string> LabelFilters { get; set; }

            /// <summary>
            /// <para>The label filter type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("labelFiltersType")]
            [Validation(Required=false)]
            public string LabelFiltersType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>An array of sink configurations.</para>
            /// </summary>
            [NameInMap("sinkList")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskSinkList> SinkList { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskSinkList : TeaModel {
                /// <summary>
                /// <para>The sink configuration. The structure of this object depends on the value of <c>sinkType</c>. For details, see CreateDeliveryTask.</para>
                /// </summary>
                [NameInMap("sinkConfigs")]
                [Validation(Required=false)]
                public Dictionary<string, string> SinkConfigs { get; set; }

                /// <summary>
                /// <para>The sink type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("sinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

            }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending2Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags attached to the task.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskTags> Tags { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sourcetype</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>production</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my delivery task</para>
            /// </summary>
            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8b07eeac8249866d</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-task</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-22T11:50:48Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
