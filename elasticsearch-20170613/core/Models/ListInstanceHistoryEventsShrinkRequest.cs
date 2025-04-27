// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsShrinkRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryEventsShrinkRequestBody> Body { get; set; }
        public class ListInstanceHistoryEventsShrinkRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>event_time</para>
            /// </summary>
            [NameInMap("sortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventCreateEndTime")]
        [Validation(Required=false)]
        public string EventCreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventCreateStartTime")]
        [Validation(Required=false)]
        public string EventCreateStartTime { get; set; }

        [NameInMap("eventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatusShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventExecuteEndTime")]
        [Validation(Required=false)]
        public string EventExecuteEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventExecuteStartTime")]
        [Validation(Required=false)]
        public string EventExecuteStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventFinashEndTime")]
        [Validation(Required=false)]
        public string EventFinashEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1645596516000</para>
        /// </summary>
        [NameInMap("eventFinashStartTime")]
        [Validation(Required=false)]
        public string EventFinashStartTime { get; set; }

        [NameInMap("eventLevel")]
        [Validation(Required=false)]
        public string EventLevelShrink { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventTypeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-2r42l7a740005****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.1.xx.xx</para>
        /// </summary>
        [NameInMap("nodeIP")]
        [Validation(Required=false)]
        public string NodeIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
