// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterSpaceSummaryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterSpaceSummaryResponseBodyData Data { get; set; }
        public class DescribeDBClusterSpaceSummaryResponseBodyData : TeaModel {
            [NameInMap("ColdData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataColdData ColdData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataColdData : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            [NameInMap("DataGrowth")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth DataGrowth { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth : TeaModel {
                [NameInMap("DayGrowth")]
                [Validation(Required=false)]
                public long? DayGrowth { get; set; }

                [NameInMap("WeekGrowth")]
                [Validation(Required=false)]
                public long? WeekGrowth { get; set; }

            }

            [NameInMap("HotData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataHotData HotData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataHotData : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
