// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of SQL log reports.</para>
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
                /// <para>An array that consists of SQL statements executed with the highest latency.</para>
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
                        /// <para>The average time that is required to execute the SQL statement. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500</para>
                        /// </summary>
                        [NameInMap("AvgLatency")]
                        [Validation(Required=false)]
                        public long? AvgLatency { get; set; }

                        /// <summary>
                        /// <para>The number of times that the SQL statement is executed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        /// <summary>
                        /// <para>The SQL statement.</para>
                        /// <remarks>
                        /// <para> Only the first 128 characters of the SQL statement are returned. In addition, only the SQL statements that take more than 100 ms to execute are returned.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM table_name;</para>
                        /// </summary>
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

                /// <summary>
                /// <para>An array that consists of SQL statements executed the most frequently.</para>
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
                        /// <para>The number of times that the SQL statement is executed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        /// <summary>
                        /// <para>The SQL statement.</para>
                        /// <remarks>
                        /// <para> Only the first 128 characters of the SQL statement are returned. In addition, only the SQL statements that take more than 5 ms to execute are returned.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM table_name;</para>
                        /// </summary>
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the report was generated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-27T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReportTime")]
                [Validation(Required=false)]
                public string ReportTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of SQL log reports on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08A3B71B-FE08-4B03-974F-CC7EA6DB1828</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
