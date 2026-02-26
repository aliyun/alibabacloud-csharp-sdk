// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogReportListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogReportListResponseBodyItems Items { get; set; }
        public class DescribeSQLLogReportListResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeSQLLogReportListResponseBodyItemsItem> Item { get; set; }
            public class DescribeSQLLogReportListResponseBodyItemsItem : TeaModel {
                [NameInMap("LatencyTopNItems")]
                [Validation(Required=false)]
                public DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems LatencyTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems : TeaModel {
                    [NameInMap("LatencyTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem> LatencyTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem : TeaModel {
                        [NameInMap("AvgLatency")]
                        [Validation(Required=false)]
                        public long? AvgLatency { get; set; }

                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

                [NameInMap("QPSTopNItems")]
                [Validation(Required=false)]
                public DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems QPSTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems : TeaModel {
                    [NameInMap("QPSTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem> QPSTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem : TeaModel {
                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                    }

                }

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
