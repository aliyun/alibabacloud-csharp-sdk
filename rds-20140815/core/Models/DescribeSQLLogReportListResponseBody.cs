// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogReportListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogReportListResponseBodyItems Items { get; set; }
        public class DescribeSQLLogReportListResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeSQLLogReportListResponseBodyItemsItem> Item { get; set; }
            public class DescribeSQLLogReportListResponseBodyItemsItem : TeaModel {
                public string ReportTime { get; set; }
                public DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems LatencyTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItems : TeaModel {
                    [NameInMap("LatencyTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem> LatencyTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem : TeaModel {
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                        [NameInMap("AvgLatency")]
                        [Validation(Required=false)]
                        public long? AvgLatency { get; set; }

                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                    }

                }
                public DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems QPSTopNItems { get; set; }
                public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItems : TeaModel {
                    [NameInMap("QPSTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem> QPSTopNItem { get; set; }
                    public class DescribeSQLLogReportListResponseBodyItemsItemQPSTopNItemsQPSTopNItem : TeaModel {
                        [NameInMap("SQLText")]
                        [Validation(Required=false)]
                        public string SQLText { get; set; }

                        [NameInMap("SQLExecuteTimes")]
                        [Validation(Required=false)]
                        public long? SQLExecuteTimes { get; set; }

                    }

                }
            }
        };

    }

}
