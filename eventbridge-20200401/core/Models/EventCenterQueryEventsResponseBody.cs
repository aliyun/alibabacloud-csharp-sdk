// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values: Success: Successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EventCenterQueryEventsResponseBodyData Data { get; set; }
        public class EventCenterQueryEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of records returned for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that indicates the read position returned by the current call. An empty value indicates that all data has been read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The query results for the table query type.</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTable> Table { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTable : TeaModel {
                /// <summary>
                /// <para>The entries in the query results, represented as key-value pairs.</para>
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
            /// <para>The query results for the timeseries query type.</para>
            /// </summary>
            [NameInMap("TimeSeries")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTimeSeries> TimeSeries { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTimeSeries : TeaModel {
                /// <summary>
                /// <para>The entries in the query results, represented as key-value pairs.</para>
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
                /// <para>The timestamp used for display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683561600000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The total number of data entries that meet the request conditions. This parameter is optional and is not returned by default.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4B6-548C-B999-XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values: true: Successful. false: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
