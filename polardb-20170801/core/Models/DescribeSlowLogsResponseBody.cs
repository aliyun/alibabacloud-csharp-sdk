// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowLog")]
            [Validation(Required=false)]
            public List<DescribeSlowLogsResponseBodyItemsSQLSlowLog> SQLSlowLog { get; set; }
            public class DescribeSlowLogsResponseBodyItemsSQLSlowLog : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                [NameInMap("MaxExecutionTimeMs")]
                [Validation(Required=false)]
                public string MaxExecutionTimeMs { get; set; }

                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                [NameInMap("TotalExecutionCounts")]
                [Validation(Required=false)]
                public long? TotalExecutionCounts { get; set; }

                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public long? TotalExecutionTimes { get; set; }

                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of SQL statements that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2553A660-E4EB-4AF4-A402-8AFF70A49143</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
