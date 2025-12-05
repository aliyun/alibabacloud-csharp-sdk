// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListPtsReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, an empty string is returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the returned page. The page number starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of reports returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The reports.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<ListPtsReportsResponseBodyReports> Reports { get; set; }
        public class ListPtsReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The timestamp when the stress testing starts. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637157073000</para>
            /// </summary>
            [NameInMap("ActualStartTime")]
            [Validation(Required=false)]
            public long? ActualStartTime { get; set; }

            /// <summary>
            /// <para>The stress testing duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10分钟</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7RLPM3Y2</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The report name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <para>The consumed Virtual User Minutes (VUM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E4LR80-15P1-555A-9ZZF-B736AZO5E5ID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of reports returned based on the condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
