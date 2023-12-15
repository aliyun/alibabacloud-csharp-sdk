// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogReportListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of SQL log reports.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogReportListResponseBodyItems Items { get; set; }
        public class DescribeSQLLogReportListResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeSQLLogReportListResponseBodyItemsItem> Item { get; set; }
            public class DescribeSQLLogReportListResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// An array that consists of SQL statements executed with the highest latency.
                /// </summary>
                [NameInMap("LatencyTopNItems")]
                [Validation(Required=false)]
                public DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems LatencyTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems : TeaModel {
                    [NameInMap("LatencyTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem> LatencyTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem : TeaModel {
                        /// <summary>
                        /// The average time that is required to execute the SQL statement. Unit: milliseconds.
                        /// </summary>
                        [NameInMap("AvgLatency")]
                        [Validation(Required=false)]
                        public long? AvgLatency { get; set; }

                        /// <summary>
                        /// The number of times that the SQL statement is executed.
                        /// </summary>
                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        /// <summary>
                        /// The SQL statement.
                        /// 
                        /// >  Only the first 128 characters of the SQL statement are returned. In addition, only the SQL statements that take more than 100 ms to execute are returned.
                        /// </summary>
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

                /// <summary>
                /// An array that consists of SQL statements executed the most frequently.
                /// </summary>
                [NameInMap("QPSTopNItems")]
                [Validation(Required=false)]
                public DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems QPSTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems : TeaModel {
                    [NameInMap("QPSTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem> QPSTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem : TeaModel {
                        /// <summary>
                        /// The number of times that the SQL statement is executed.
                        /// </summary>
                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        /// <summary>
                        /// The SQL statement.
                        /// 
                        /// >  Only the first 128 characters of the SQL statement are returned. In addition, only the SQL statements that take more than 5 ms to execute are returned.
                        /// </summary>
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

                /// <summary>
                /// The time when the report was generated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ReportTime")]
                [Validation(Required=false)]
                public string ReportTime { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of SQL log reports on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
