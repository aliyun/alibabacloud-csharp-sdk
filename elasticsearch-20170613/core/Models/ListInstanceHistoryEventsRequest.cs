// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryEventsRequestBody> Body { get; set; }
        public class ListInstanceHistoryEventsRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to sort in descending order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default): Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>The field by which the results are sorted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>event_time: event creation time</description></item>
            /// <item><description>event_execute_start_time: event execution time</description></item>
            /// <item><description>event_execute_finish_time: event completion time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>event_time</para>
            /// </summary>
            [NameInMap("sortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }

        }

        /// <summary>
        /// <para>The end time for querying by event creation time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventCreateEndTime")]
        [Validation(Required=false)]
        public string EventCreateEndTime { get; set; }

        /// <summary>
        /// <para>The start time for querying by event creation time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventCreateStartTime")]
        [Validation(Required=false)]
        public string EventCreateStartTime { get; set; }

        /// <summary>
        /// <para>The lifecycle status of the event.</para>
        /// </summary>
        [NameInMap("eventCycleStatus")]
        [Validation(Required=false)]
        public List<string> EventCycleStatus { get; set; }

        /// <summary>
        /// <para>The end time for querying by event execution time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventExecuteEndTime")]
        [Validation(Required=false)]
        public string EventExecuteEndTime { get; set; }

        /// <summary>
        /// <para>The start time for querying by event execution time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventExecuteStartTime")]
        [Validation(Required=false)]
        public string EventExecuteStartTime { get; set; }

        /// <summary>
        /// <para>The end time for querying by event completion time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventFinashEndTime")]
        [Validation(Required=false)]
        public string EventFinashEndTime { get; set; }

        /// <summary>
        /// <para>The start time for querying by event completion time. Specify a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventFinashStartTime")]
        [Validation(Required=false)]
        public string EventFinashStartTime { get; set; }

        /// <summary>
        /// <para>The event level.</para>
        /// </summary>
        [NameInMap("eventLevel")]
        [Validation(Required=false)]
        public List<string> EventLevel { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public List<string> EventType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-2r42l7a740005****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the node that triggered the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.xx.xx</para>
        /// </summary>
        [NameInMap("nodeIP")]
        [Validation(Required=false)]
        public string NodeIP { get; set; }

        /// <summary>
        /// <para>The starting document offset. The value must be a non-negative integer. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of events to return. The value must be a non-negative integer. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
