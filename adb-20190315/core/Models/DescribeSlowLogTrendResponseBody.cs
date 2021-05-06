// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogTrendResponseBodyItems Items { get; set; }
        public class DescribeSlowLogTrendResponseBodyItems : TeaModel {
            [NameInMap("SlowLogTrendItem")]
            [Validation(Required=false)]
            public List<DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItem> SlowLogTrendItem { get; set; }
            public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItem : TeaModel {
                public string Key { get; set; }
                public string Unit { get; set; }
                public DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeries Series { get; set; }
                public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeries : TeaModel {
                    [NameInMap("SeriesItem")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeriesSeriesItem> SeriesItem { get; set; }
                    public class DescribeSlowLogTrendResponseBodyItemsSlowLogTrendItemSeriesSeriesItem : TeaModel {
                        [NameInMap("Values")]
                        [Validation(Required=false)]
                        public string Values { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
            }
        };

    }

}
