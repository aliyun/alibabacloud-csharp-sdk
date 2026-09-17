// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternCompareReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of reports on the current page. An empty array is returned if no reports match the conditions.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSqlPatternCompareReportsResponseBodyItems> Items { get; set; }
        public class DescribeSqlPatternCompareReportsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the report can be canceled. The value is true when the report is in the PENDING or RUNNING state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CancelAvailable")]
            [Validation(Required=false)]
            public bool? CancelAvailable { get; set; }

            /// <summary>
            /// <para>The end time of time range 2. The time is in the yyyy-MM-ddTHH:mmZ UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T01:00Z</para>
            /// </summary>
            [NameInMap("CompareEndTime")]
            [Validation(Required=false)]
            public string CompareEndTime { get; set; }

            /// <summary>
            /// <para>The start time of time range 2. The time is in the yyyy-MM-ddTHH:mmZ UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T00:00Z</para>
            /// </summary>
            [NameInMap("CompareStartTime")]
            [Validation(Required=false)]
            public string CompareStartTime { get; set; }

            /// <summary>
            /// <para>The time when the report was created. The time is in the yyyy-MM-ddTHH:mmZ UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T01:05Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether report details can be queried. The value is true when the report is in the SUCCESS state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DetailEnabled")]
            [Validation(Required=false)]
            public bool? DetailEnabled { get; set; }

            /// <summary>
            /// <para>The end time of time range 1. The time is in the yyyy-MM-ddTHH:mmZ UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T01:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the SQL Pattern comparison report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public long? ReportId { get; set; }

            /// <summary>
            /// <para>The report type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NEW</c>: new patterns.</description></item>
            /// <item><description><c>CHANGED</c>: patterns with increased metrics.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHANGED</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The name of the report type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Changed Pattern Comparison Report</para>
            /// </summary>
            [NameInMap("ReportTypeName")]
            [Validation(Required=false)]
            public string ReportTypeName { get; set; }

            /// <summary>
            /// <para>The sequence number in the current sorted result. The value starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowNumber")]
            [Validation(Required=false)]
            public int? RowNumber { get; set; }

            /// <summary>
            /// <para>The start time of time range 1. The time is in the yyyy-MM-ddTHH:mmZ UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The report status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PENDING</c>: waiting to be generated.</description></item>
            /// <item><description><c>RUNNING</c>: being generated.</description></item>
            /// <item><description><c>SUCCESS</c>: generated.</description></item>
            /// <item><description><c>FAILED</c>: failed to be generated.</description></item>
            /// <item><description><c>CANCELED</c>: canceled.</description></item>
            /// <item><description><c>EXPIRED</c>: expired.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The current list returns only reports in the <c>PENDING</c>, <c>RUNNING</c>, or <c>SUCCESS</c> state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of rows per page used in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6Mjo1MA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number used in this query. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page used in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1B2C3D-4E5F-6789-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of reports that match the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
