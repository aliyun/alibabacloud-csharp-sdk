// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDeliveryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of delivery tasks.</para>
        /// </summary>
        [NameInMap("deliveryTasks")]
        [Validation(Required=false)]
        public List<ListDeliveryTasksResponseBodyDeliveryTasks> DeliveryTasks { get; set; }
        public class ListDeliveryTasksResponseBodyDeliveryTasks : TeaModel {
            /// <summary>
            /// <para>The time when the delivery task was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-22T09:02:01Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Prometheus instance that serves as the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-5f2b4c7e66342s</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>A key-value map of additional labels to attach to all delivered metrics.</para>
            /// </summary>
            [NameInMap("externalLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExternalLabels { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public ListDeliveryTasksResponseBodyDeliveryTasksExtraInfo ExtraInfo { get; set; }
            public class ListDeliveryTasksResponseBodyDeliveryTasksExtraInfo : TeaModel {
                /// <summary>
                /// <para>A list of EventBridge tasks.</para>
                /// </summary>
                [NameInMap("taskNameList")]
                [Validation(Required=false)]
                public List<string> TaskNameList { get; set; }

            }

            /// <summary>
            /// <para>A key-value map of metric label filters. These filters are used with <c>labelFiltersType</c> to determine which metrics to deliver.</para>
            /// </summary>
            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public Dictionary<string, string> LabelFilters { get; set; }

            /// <summary>
            /// <para>The filtering mode for metric labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("labelFiltersType")]
            [Validation(Required=false)]
            public string LabelFiltersType { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3gn5i6bigbi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>A list of sinks.</para>
            /// </summary>
            [NameInMap("sinkList")]
            [Validation(Required=false)]
            public List<ListDeliveryTasksResponseBodyDeliveryTasksSinkList> SinkList { get; set; }
            public class ListDeliveryTasksResponseBodyDeliveryTasksSinkList : TeaModel {
                /// <summary>
                /// <para>Detailed configuration for the sink. The available key-value pairs depend on the specified <c>sinkType</c>.</para>
                /// </summary>
                [NameInMap("sinkConfigs")]
                [Validation(Required=false)]
                public Dictionary<string, string> SinkConfigs { get; set; }

                /// <summary>
                /// <para>The type of the sink.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("sinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

            }

            /// <summary>
            /// <para>The current status of the delivery task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The resource tags attached to the task.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListDeliveryTasksResponseBodyDeliveryTasksTags> Tags { get; set; }
            public class ListDeliveryTasksResponseBodyDeliveryTasksTags : TeaModel {
                /// <summary>
                /// <para>The key of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the delivery task.</para>
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
            /// <para>db21f8a126d96953</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the delivery task.</para>
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
            /// <para>2026-01-22T09:02:01Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. If this parameter is not returned, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D7DF334-B2F2-5453-AD51-A27B337E3191</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
