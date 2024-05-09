// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterSpaceSummaryResponseBody : TeaModel {
        /// <summary>
        /// The queried storage overview information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterSpaceSummaryResponseBodyData Data { get; set; }
        public class DescribeDBClusterSpaceSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// The cold data.
            /// </summary>
            [NameInMap("ColdData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataColdData ColdData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataColdData : TeaModel {
                /// <summary>
                /// The data size of table records. Unit: bytes.
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// The data size of regular indexes. Unit: bytes.
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// The data size of other data. Unit: bytes.
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// The data size of primary key indexes. Unit: bytes.
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// The cold data size. Unit: bytes.
                /// 
                /// >  Formula: Cold data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Data size of other data.
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// The data growth.
            /// </summary>
            [NameInMap("DataGrowth")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth DataGrowth { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth : TeaModel {
                /// <summary>
                /// The data growth within the last day. Unit: bytes.
                /// 
                /// >  Formula: Data growth within the last day = Current data size - Data size one day ago.
                /// </summary>
                [NameInMap("DayGrowth")]
                [Validation(Required=false)]
                public long? DayGrowth { get; set; }

                /// <summary>
                /// The daily data growth within the last seven days. Unit: bytes.
                /// 
                /// >  Formula: Daily data growth within the last seven days = (Current data size - Data size seven days ago)/7.
                /// </summary>
                [NameInMap("WeekGrowth")]
                [Validation(Required=false)]
                public long? WeekGrowth { get; set; }

            }

            /// <summary>
            /// The hot data.
            /// </summary>
            [NameInMap("HotData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataHotData HotData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataHotData : TeaModel {
                /// <summary>
                /// The data size of table records. Unit: bytes.
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// The data size of regular indexes. Unit: bytes.
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// The data size of other data. Unit: bytes.
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// The data size of primary key indexes. Unit: bytes.
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// The hot data size. Unit: bytes.
                /// 
                /// >  Formula: Hot data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Data size of other data.
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// The total data size. Unit: bytes.
            /// 
            /// >  Formula: Total data size = Hot data size+ Cold data size.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
