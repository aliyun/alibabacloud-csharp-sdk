// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetDeliveryTaskResponseBody : TeaModel {
        [NameInMap("deliveryTask")]
        [Validation(Required=false)]
        public GetDeliveryTaskResponseBodyDeliveryTask DeliveryTask { get; set; }
        public class GetDeliveryTaskResponseBodyDeliveryTask : TeaModel {
            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-24T02:08:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rw-xxxxxx</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("externalLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExternalLabels { get; set; }

            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo ExtraInfo { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskExtraInfo : TeaModel {
                [NameInMap("taskNameList")]
                [Validation(Required=false)]
                public List<string> TaskNameList { get; set; }

            }

            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public Dictionary<string, string> LabelFilters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("labelFiltersType")]
            [Validation(Required=false)]
            public string LabelFiltersType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-chengdu</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("sinkList")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskSinkList> SinkList { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskSinkList : TeaModel {
                [NameInMap("sinkConfigs")]
                [Validation(Required=false)]
                public Dictionary<string, string> SinkConfigs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prometheus</para>
                /// </summary>
                [NameInMap("sinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending2Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetDeliveryTaskResponseBodyDeliveryTaskTags> Tags { get; set; }
            public class GetDeliveryTaskResponseBodyDeliveryTaskTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sourcetype</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>production</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my delivery task</para>
            /// </summary>
            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8b07eeac8249866d</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-task</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
