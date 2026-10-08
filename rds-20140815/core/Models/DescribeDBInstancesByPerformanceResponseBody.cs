// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesByPerformanceResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesByPerformanceResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesByPerformanceResponseBodyItems : TeaModel {
            [NameInMap("DBInstancePerformance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance> DBInstancePerformance { get; set; }
            public class DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance : TeaModel {
                [NameInMap("CPUUsage")]
                [Validation(Required=false)]
                public string CPUUsage { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DiskUsage")]
                [Validation(Required=false)]
                public string DiskUsage { get; set; }

                [NameInMap("IOPSUsage")]
                [Validation(Required=false)]
                public string IOPSUsage { get; set; }

                [NameInMap("SessionUsage")]
                [Validation(Required=false)]
                public string SessionUsage { get; set; }

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
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23907437-79B9-411A-9EE6-75A8F0F1C619</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned by the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
