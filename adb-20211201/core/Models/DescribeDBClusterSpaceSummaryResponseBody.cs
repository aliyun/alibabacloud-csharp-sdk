// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterSpaceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
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
                /// <para>The data volume of table records. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The data volume of regular indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <para>The volume of other data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <para>The data volume of primary key indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <para>The total cold data volume. Unit: bytes.</para>
                /// <remarks>
                /// <para>Calculation formula: Total cold data volume = Table record data volume + Regular index data volume + Primary key index data volume + Others.</para>
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
                /// <para>The data growth in the past day. Unit: bytes.</para>
                /// <remarks>
                /// <para>Calculation formula: Data growth in the past day = Current total data volume - Total data volume 1 day ago.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DayGrowth")]
                [Validation(Required=false)]
                public long? DayGrowth { get; set; }

                /// <summary>
                /// <para>The average daily data growth over the past 7 days. Unit: bytes.</para>
                /// <remarks>
                /// <para>Calculation formula: Average daily data growth over the past 7 days = (Current total data volume - Total data volume 7 days ago) / 7.</para>
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
                /// <para>The data volume of table records. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The data volume of regular indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <para>The volume of other data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <para>The data volume of primary key indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <para>The total hot data volume. Unit: bytes.</para>
                /// <remarks>
                /// <para>Calculation formula: Total hot data volume = Table record data volume + Regular index data volume + Primary key index data volume + Others.</para>
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
            /// <para>The total data volume. Unit: bytes.</para>
            /// <remarks>
            /// <para>Calculation formula: Total data volume = Total hot data volume + Total cold data volume.</para>
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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
