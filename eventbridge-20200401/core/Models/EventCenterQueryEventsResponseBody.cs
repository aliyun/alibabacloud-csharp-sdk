// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the API call, which can be Success or a POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EventCenterQueryEventsResponseBodyData Data { get; set; }
        public class EventCenterQueryEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The query results for the <c>table</c> query type.</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTable> Table { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTable : TeaModel {
                /// <summary>
                /// <para>A query result entry, represented as a key-value pair.</para>
                /// 
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

            /// <summary>
            /// <para>The query results for the <c>time series</c> query type.</para>
            /// </summary>
            [NameInMap("TimeSeries")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTimeSeries> TimeSeries { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTimeSeries : TeaModel {
                /// <summary>
                /// <para>A query result entry, represented as a key-value pair.</para>
                /// 
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
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683561600000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the filter conditions. This parameter is optional and is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Limit is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4B6-548C-B999-XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. <c>true</c> indicates success, and <c>false</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
