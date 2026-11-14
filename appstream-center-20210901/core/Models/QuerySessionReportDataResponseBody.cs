// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QuerySessionReportDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of <c>200</c> indicates that the request is processed successfully. Other values indicate that the request fails to be processed.</para>
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
        /// <para>The description of the request processing result. Typically, <c>success</c> is returned when the request is successful.</para>
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
        /// <para>The list of session report data.</para>
        /// </summary>
        [NameInMap("ReportDataModel")]
        [Validation(Required=false)]
        public List<QuerySessionReportDataResponseBodyReportDataModel> ReportDataModel { get; set; }
        public class QuerySessionReportDataResponseBodyReportDataModel : TeaModel {
            /// <summary>
            /// <para>The number of connected sessions in the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ConnectSessionCount")]
            [Validation(Required=false)]
            public long? ConnectSessionCount { get; set; }

            /// <summary>
            /// <para>The total number of sessions corresponding to the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The statistical time. The <c>1d</c> granularity returns <c>yyyy-MM-dd</c>. The <c>1m</c>, <c>30m</c>, and <c>6h</c> granularities return <c>yyyy-MM-dd HH:mm</c>. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01</para>
            /// </summary>
            [NameInMap("StatDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// <para>The number of sessions established through streaming access in the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("StreamingSessionCount")]
            [Validation(Required=false)]
            public long? StreamingSessionCount { get; set; }

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
