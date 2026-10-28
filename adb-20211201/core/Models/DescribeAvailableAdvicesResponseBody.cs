// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAvailableAdvicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableAdvicesResponseBodyItems> Items { get; set; }
        public class DescribeAvailableAdvicesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the suggestion was generated, in the yyyyMMdd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20221124</para>
            /// </summary>
            [NameInMap("AdviceDate")]
            [Validation(Required=false)]
            public string AdviceDate { get; set; }

            /// <summary>
            /// <para>The suggestion ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcd04135-0925-4aed-a5a7-e7d92cb1****</para>
            /// </summary>
            [NameInMap("AdviceId")]
            [Validation(Required=false)]
            public string AdviceId { get; set; }

            /// <summary>
            /// <para>The type of the suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INDEX</b>: Index optimization.</description></item>
            /// <item><description><b>TIERING</b>: Hot and cold data optimization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INDEX</para>
            /// </summary>
            [NameInMap("AdviceType")]
            [Validation(Required=false)]
            public string AdviceType { get; set; }

            /// <summary>
            /// <para>The benefit of the suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Saves 0.4 GB of storage space</para>
            /// </summary>
            [NameInMap("Benefit")]
            [Validation(Required=false)]
            public string Benefit { get; set; }

            /// <summary>
            /// <para>The index fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>message</para>
            /// </summary>
            [NameInMap("IndexFields")]
            [Validation(Required=false)]
            public string IndexFields { get; set; }

            /// <summary>
            /// <para>The page number. Valid values: greater than 0 and up to the maximum value of the Integer data type. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>30</b> (default)</description></item>
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>100</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The reason for generating optimization suggestions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not used for 15 days, and the historical usage probability is less than 1%</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The SQL statement to apply the suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alter table <c>schema1</c>.<c>table1</c> drop key col1_1_idx</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of returned results. Valid values: greater than or equal to 0 and up to the maximum value of the Integer data type. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10192</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The page number. Valid values: greater than 0 and up to the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96A55627-28E9-5E47-B8F6-D786BE551349</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The concatenated string of the database name and table name.</para>
        /// </summary>
        [NameInMap("SchemaTableNames")]
        [Validation(Required=false)]
        public List<string> SchemaTableNames { get; set; }

        /// <summary>
        /// <para>The total number of returned results. Valid values: greater than or equal to 0 and up to the maximum value of the Integer data type. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10192</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
