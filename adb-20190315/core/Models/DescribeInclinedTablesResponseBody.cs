// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeInclinedTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeInclinedTablesResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeInclinedTablesResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The message of the detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There are a total of 10 tables with an excessive number of primary keys.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excessive primary key fields</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The queried tables.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInclinedTablesResponseBodyItems Items { get; set; }
        public class DescribeInclinedTablesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The queried table.</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeInclinedTablesResponseBodyItemsTable> Table { get; set; }
            public class DescribeInclinedTablesResponseBodyItemsTable : TeaModel {
                /// <summary>
                /// <para>Indicates whether data is skewed in the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsIncline")]
                [Validation(Required=false)]
                public string IsIncline { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ff</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of rows in the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2565</para>
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adm_analyze</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>The number of rows in the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2416527</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>The percentage of the table size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("SpaceRatio")]
                [Validation(Required=false)]
                public double? SpaceRatio { get; set; }

                /// <summary>
                /// <para>The total data size of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

                /// <summary>
                /// <para>The column type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>executor</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
