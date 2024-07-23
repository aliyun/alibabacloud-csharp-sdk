// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesByPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesByPerformanceResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesByPerformanceResponseBodyItems : TeaModel {
            [NameInMap("DBInstancePerformance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance> DBInstancePerformance { get; set; }
            public class DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance : TeaModel {
                /// <summary>
                /// <para>The CPU utilization of the instance in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.70</para>
                /// </summary>
                [NameInMap("CPUUsage")]
                [Validation(Required=false)]
                public string CPUUsage { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DatabaseTest</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The disk usage of the instance in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14.56</para>
                /// </summary>
                [NameInMap("DiskUsage")]
                [Validation(Required=false)]
                public string DiskUsage { get; set; }

                /// <summary>
                /// <para>The IOPS usage of the instance in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.15</para>
                /// </summary>
                [NameInMap("IOPSUsage")]
                [Validation(Required=false)]
                public string IOPSUsage { get; set; }

                /// <summary>
                /// <para>The number of sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.10</para>
                /// </summary>
                [NameInMap("SessionUsage")]
                [Validation(Required=false)]
                public string SessionUsage { get; set; }

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
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23907437-79B9-411A-9EE6-75A8F0F1C619</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
