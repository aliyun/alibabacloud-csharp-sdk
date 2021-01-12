// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLReportsResponseBody : TeaModel {
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
        public DescribeSQLReportsResponseBodyItems Items { get; set; }
        public class DescribeSQLReportsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeSQLReportsResponseBodyItemsItem> Item { get; set; }
            public class DescribeSQLReportsResponseBodyItemsItem : TeaModel {
                public string ReportTime { get; set; }
                public DescribeSQLReportsResponseBodyItemsItemLatencyTopNItems LatencyTopNItems { get; set; }
                public class DescribeSQLReportsResponseBodyItemsItemLatencyTopNItems : TeaModel {
                    [NameInMap("LatencyTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLReportsResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem> LatencyTopNItem { get; set; }
                    public class DescribeSQLReportsResponseBodyItemsItemLatencyTopNItemsLatencyTopNItem : TeaModel {
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
                public DescribeSQLReportsResponseBodyItemsItemQPSTopNItems QPSTopNItems { get; set; }
                public class DescribeSQLReportsResponseBodyItemsItemQPSTopNItems : TeaModel {
                    [NameInMap("QPSTopNItem")]
                    [Validation(Required=false)]
                    public List<DescribeSQLReportsResponseBodyItemsItemQPSTopNItemsQPSTopNItem> QPSTopNItem { get; set; }
                    public class DescribeSQLReportsResponseBodyItemsItemQPSTopNItemsQPSTopNItem : TeaModel {
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
