// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the delivery task.</para>
        /// </summary>
        [NameInMap("deliveryTask")]
        [Validation(Required=false)]
        public GetDeliveryTaskResponseBodyDeliveryTask DeliveryTask { get; set; }
        public class GetDeliveryTaskResponseBodyDeliveryTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-24T02:08:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data source ID (Managed Service for Prometheus instance ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxxxxx</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The additional labels attached to all delivered metrics. The key is the label name, and the value is the label value.</para>
            /// </summary>
            [NameInMap("externalLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExternalLabels { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo ExtraInfo { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo : TeaModel {
                /// <summary>
                /// <para>The list of EventBridge tasks.</para>
                /// </summary>
                [NameInMap("taskNameList")]
                [Validation(Required=false)]
                public List<string> TaskNameList { get; set; }

            }

            /// <summary>
            /// <para>The metric filter conditions. Used together with labelFiltersType. The key is the metric label name, and the value is the match value.</para>
            /// </summary>
            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public Dictionary<string, string> LabelFilters { get; set; }

            /// <summary>
            /// <para>The metric filtering mode.</para>
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
            /// <para>The list of delivery targets.</para>
            /// </summary>
            [NameInMap("sinkList")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskSinkList> SinkList { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskSinkList : TeaModel {
                /// <summary>
                /// <para>The detailed configuration of the delivery target. The meaning of key/value pairs varies depending on the sinkType. For more information, see <a href="~~CreateDeliveryTask~~">CreateDeliveryTask</a>.</para>
                /// </summary>
                [NameInMap("sinkConfigs")]
                [Validation(Required=false)]
                public Dictionary<string, string> SinkConfigs { get; set; }

                /// <summary>
                /// <para>The type of the delivery target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("sinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

            }

            /// <summary>
            /// <para>The current status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending2Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
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
            /// <para>The delivery task ID.</para>
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
            /// <para>The time when the task was last updated.</para>
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
