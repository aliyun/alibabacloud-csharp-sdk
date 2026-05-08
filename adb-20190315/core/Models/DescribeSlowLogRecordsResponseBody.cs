// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1rqvm70uh2****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SlowLogRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord> SlowLogRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord : TeaModel {
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                [NameInMap("OutputSize")]
                [Validation(Required=false)]
                public string OutputSize { get; set; }

                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                [NameInMap("PeakMemoryUsage")]
                [Validation(Required=false)]
                public string PeakMemoryUsage { get; set; }

                [NameInMap("PlanningTime")]
                [Validation(Required=false)]
                public long? PlanningTime { get; set; }

                [NameInMap("ProcessID")]
                [Validation(Required=false)]
                public string ProcessID { get; set; }

                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public long? QueryTime { get; set; }

                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                [NameInMap("ScanSize")]
                [Validation(Required=false)]
                public string ScanSize { get; set; }

                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("WallTime")]
                [Validation(Required=false)]
                public long? WallTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7559209-7EC3-41E1-8F78-156990******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
