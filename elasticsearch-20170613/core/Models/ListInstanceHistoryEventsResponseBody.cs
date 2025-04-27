// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceHistoryEventsResponseBodyHeaders Headers { get; set; }
        public class ListInstanceHistoryEventsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("X-Total-Failed")]
            [Validation(Required=false)]
            public long? XTotalFailed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("X-Total-Success")]
            [Validation(Required=false)]
            public long? XTotalSuccess { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D1A6830A-F59B-4E05-BFAC-9496C21DBBA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryEventsResponseBodyResult> Result { get; set; }
        public class ListInstanceHistoryEventsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-2ze8s9cjdf2cv969****</para>
            /// </summary>
            [NameInMap("ecsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-07T00:00:00Z</para>
            /// </summary>
            [NameInMap("eventCreateTime")]
            [Validation(Required=false)]
            public string EventCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXECUTED</para>
            /// </summary>
            [NameInMap("eventCycleStatus")]
            [Validation(Required=false)]
            public string EventCycleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-07T00:00:00Z</para>
            /// </summary>
            [NameInMap("eventExecuteTime")]
            [Validation(Required=false)]
            public string EventExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-07T00:00:00Z</para>
            /// </summary>
            [NameInMap("eventFinashTime")]
            [Validation(Required=false)]
            public string EventFinashTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("eventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS:AUTO_RESTART</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

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
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
