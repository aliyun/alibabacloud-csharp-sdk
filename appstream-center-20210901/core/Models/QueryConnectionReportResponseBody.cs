// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryConnectionReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. <c>200</c> indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of connection report data.</para>
        /// </summary>
        [NameInMap("ConnectionReportDataModel")]
        [Validation(Required=false)]
        public List<QueryConnectionReportResponseBodyConnectionReportDataModel> ConnectionReportDataModel { get; set; }
        public class QueryConnectionReportResponseBodyConnectionReportDataModel : TeaModel {
            /// <summary>
            /// <para>The ID of the app instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The average duration of successful connections. In the current version, the return value is in milliseconds, so parse it as milliseconds. The <c>Seconds</c> in the field name is retained for compatibility and does not indicate the unit. This value may not be returned if there are no successful connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250</para>
            /// </summary>
            [NameInMap("ConnectionAvgDurationSeconds")]
            [Validation(Required=false)]
            public double? ConnectionAvgDurationSeconds { get; set; }

            /// <summary>
            /// <para>The number of connection failures within the statistical window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ConnectionFailureCount")]
            [Validation(Required=false)]
            public long? ConnectionFailureCount { get; set; }

            /// <summary>
            /// <para>The number of successful connections within the statistical window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("ConnectionSuccessCount")]
            [Validation(Required=false)]
            public long? ConnectionSuccessCount { get; set; }

            /// <summary>
            /// <para>The connection success rate, which is calculated by dividing the number of successful connections by the sum of successful and failed connections. The value ranges from 0 to 1. Multiply the value by 100 to get the percentage. This value may not be returned if there are no connection records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.98</para>
            /// </summary>
            [NameInMap("ConnectionSuccessRate")]
            [Validation(Required=false)]
            public double? ConnectionSuccessRate { get; set; }

            /// <summary>
            /// <para>The ID of the business region to which the report data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The end time of the statistical window. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:05:00</para>
            /// </summary>
            [NameInMap("StatEndDate")]
            [Validation(Required=false)]
            public string StatEndDate { get; set; }

            /// <summary>
            /// <para>The start time of the statistical window. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:00:00</para>
            /// </summary>
            [NameInMap("StatStartDate")]
            [Validation(Required=false)]
            public string StatStartDate { get; set; }

        }

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
        /// <para>The description of the request processing result. <c>success</c> is usually returned when the request is successful.</para>
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
        /// <para>The unique identifier of the current request, which can be used to troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
