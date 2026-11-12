// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeInspectionReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of inspection reports.</para>
        /// </summary>
        [NameInMap("ReportItems")]
        [Validation(Required=false)]
        public List<DescribeInspectionReportListResponseBodyReportItems> ReportItems { get; set; }
        public class DescribeInspectionReportListResponseBodyReportItems : TeaModel {
            /// <summary>
            /// <para>The ID of the inspected PolarDB cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-**************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>Indicates whether the inspection report is the latest report. The value is returned as a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Latest")]
            [Validation(Required=false)]
            public string Latest { get; set; }

            /// <summary>
            /// <para>The region ID of the inspected cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The detailed description of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No critical risks were found in this inspection</para>
            /// </summary>
            [NameInMap("ReportDescription")]
            [Validation(Required=false)]
            public string ReportDescription { get; set; }

            /// <summary>
            /// <para>The ID of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>report-001</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The score of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ReportScore")]
            [Validation(Required=false)]
            public long? ReportScore { get; set; }

            /// <summary>
            /// <para>The status of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>The summary of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance is running normally</para>
            /// </summary>
            [NameInMap("ReportSummary")]
            [Validation(Required=false)]
            public string ReportSummary { get; set; }

            /// <summary>
            /// <para>The time when the inspection report was generated. The time is in the yyyy-MM-dd HH:mm:ss format and is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05 16:00:00</para>
            /// </summary>
            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            /// <summary>
            /// <para>The number of check items categorized by inspection result level.</para>
            /// </summary>
            [NameInMap("SubItems")]
            [Validation(Required=false)]
            public List<DescribeInspectionReportListResponseBodyReportItemsSubItems> SubItems { get; set; }
            public class DescribeInspectionReportListResponseBodyReportItemsSubItems : TeaModel {
                /// <summary>
                /// <para>The number of check items at the critical level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public long? Critical { get; set; }

                /// <summary>
                /// <para>The number of check items at the info level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public long? Info { get; set; }

                /// <summary>
                /// <para>The number of normal check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Normal")]
                [Validation(Required=false)]
                public long? Normal { get; set; }

                /// <summary>
                /// <para>The number of check items at the warning level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Warning")]
                [Validation(Required=false)]
                public long? Warning { get; set; }

            }

            /// <summary>
            /// <para>The ID of the inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The score returned by the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// <para>The total number of reports that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
