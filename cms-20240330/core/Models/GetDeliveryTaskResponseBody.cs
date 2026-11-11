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
            /// <para>The creation time.</para>
            /// <para>The time is in the ISO 8601 standard format (YYYY-MM-DDThh:mm:ssZ) in UTC.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-24T02:08:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data source ID (Prometheus instance ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-xxxxxx</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The additional labels attached to all delivered metrics. The key is the label name and the value is the label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
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
            /// <para>The metric filter conditions used in conjunction with labelFiltersType. The key is the metric label name and the value is the match value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;<b>name</b>&quot;:&quot;up&quot;}</para>
            /// </summary>
            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public Dictionary<string, string> LabelFilters { get; set; }

            /// <summary>
            /// <para>The metric filter mode.</para>
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
            /// <para>The list of delivery destinations.</para>
            /// </summary>
            [NameInMap("sinkList")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskSinkList> SinkList { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskSinkList : TeaModel {
                /// <summary>
                /// <para>The detailed configuration of the delivery destination. The meanings of the key and value vary based on the sinkType. For more information, see the CreateDeliveryTask description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Url&quot;:&quot;<a href="https://example.com/api/v1/write%22,%22Network%22:%22PublicNetwork%22,%22AuthType%22:%22None%22%7D">https://example.com/api/v1/write&quot;,&quot;Network&quot;:&quot;PublicNetwork&quot;,&quot;AuthType&quot;:&quot;None&quot;}</a></para>
                /// </summary>
                [NameInMap("sinkConfigs")]
                [Validation(Required=false)]
                public Dictionary<string, string> SinkConfigs { get; set; }

                /// <summary>
                /// <para>The type of the delivery destination.</para>
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
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The keys of the resource group tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskTags> Tags { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskTags : TeaModel {
                /// <summary>
                /// <para>The key of the resource group tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sourcetype</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the resource group tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>production</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my delivery task</para>
            /// </summary>
            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The ID of the delivery task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8b07eeac8249866d</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-task</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>The time is in the ISO 8601 standard format (YYYY-MM-DDThh:mm:ssZ) in UTC.</para>
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
