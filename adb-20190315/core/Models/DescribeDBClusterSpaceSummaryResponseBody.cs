// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterSpaceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried storage overview information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterSpaceSummaryResponseBodyData Data { get; set; }
        public class DescribeDBClusterSpaceSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cold data.</para>
            /// </summary>
            [NameInMap("ColdData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataColdData ColdData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataColdData : TeaModel {
                /// <summary>
                /// <para>The data size of table records. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The data size of regular indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <para>The other data size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <para>The data size of primary key indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <para>The cold data size. Unit: bytes.</para>
                /// <remarks>
                /// <para> Formula: Cold data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Other data size.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4194304</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// <para>The data growth.</para>
            /// </summary>
            [NameInMap("DataGrowth")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth DataGrowth { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataDataGrowth : TeaModel {
                /// <summary>
                /// <para>The data growth within the last day. Unit: bytes.</para>
                /// <remarks>
                /// <para> Formula: Data growth within the last day = Current data size - Data size of one day ago.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DayGrowth")]
                [Validation(Required=false)]
                public long? DayGrowth { get; set; }

                /// <summary>
                /// <para>The daily data growth within the last seven days. Unit: bytes.</para>
                /// <remarks>
                /// <para> Formula: Daily data growth within the last seven days = (Current data size - Data size of seven days ago)/7.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("WeekGrowth")]
                [Validation(Required=false)]
                public long? WeekGrowth { get; set; }

            }

            /// <summary>
            /// <para>The hot data.</para>
            /// </summary>
            [NameInMap("HotData")]
            [Validation(Required=false)]
            public DescribeDBClusterSpaceSummaryResponseBodyDataHotData HotData { get; set; }
            public class DescribeDBClusterSpaceSummaryResponseBodyDataHotData : TeaModel {
                /// <summary>
                /// <para>The data size of table records. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The data size of regular indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <para>The other data size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <para>The data size of primary key indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <para>The hot data size. Unit: bytes.</para>
                /// <remarks>
                /// <para> Formula: Hot data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Other data size.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4194304</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// <para>The total data size. Unit: bytes.</para>
            /// <remarks>
            /// <para> Formula: Total data size = Hot data size+ Cold data size.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8388608</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25B56BC7-4978-40B3-9E48-4B7067******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
