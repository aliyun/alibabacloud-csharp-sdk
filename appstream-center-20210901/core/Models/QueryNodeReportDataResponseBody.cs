// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryNodeReportDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The description of the request processing result. If the request is successful, success is usually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number corresponding to the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page used in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of node report data.</para>
        /// </summary>
        [NameInMap("ReportDataModel")]
        [Validation(Required=false)]
        public List<QueryNodeReportDataResponseBodyReportDataModel> ReportDataModel { get; set; }
        public class QueryNodeReportDataResponseBodyReportDataModel : TeaModel {
            /// <summary>
            /// <para>The total number of nodes for the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The number of pay-as-you-go nodes in the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("PostpaidNodeCount")]
            [Validation(Required=false)]
            public long? PostpaidNodeCount { get; set; }

            /// <summary>
            /// <para>The number of subscription nodes in the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("PrepaidNodeCount")]
            [Validation(Required=false)]
            public long? PrepaidNodeCount { get; set; }

            /// <summary>
            /// <para>The statistical time. The 1d granularity returns the time in the yyyy-MM-dd format. The 1m, 30m, and 6h granularities return the time in the yyyy-MM-dd HH:mm format. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01</para>
            /// </summary>
            [NameInMap("StatDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
