// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EventCenterQueryEventsResponseBodyData Data { get; set; }
        public class EventCenterQueryEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTable> Table { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTable : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;id&quot;:&quot;xxx&quot;,
                ///   &quot;source&quot;:&quot;acs.ecs&quot;
                /// }</para>
                /// </summary>
                [NameInMap("RowData")]
                [Validation(Required=false)]
                public Dictionary<string, object> RowData { get; set; }

            }

            [NameInMap("TimeSeries")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTimeSeries> TimeSeries { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTimeSeries : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;id&quot;:&quot;xxx&quot;,
                ///   &quot;source&quot;:&quot;acs.ecs&quot;
                /// }</para>
                /// </summary>
                [NameInMap("RowData")]
                [Validation(Required=false)]
                public Dictionary<string, object> RowData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1683561600000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter Limit is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4B6-548C-B999-XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
