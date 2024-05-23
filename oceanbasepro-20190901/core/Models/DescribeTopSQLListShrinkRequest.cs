// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTopSQLListShrinkRequest : TeaModel {
        /// <summary>
        /// The number of block index cache hits.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The SQL type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The average number of logical reads of the SQL statement during the specified period of time.   
        /// The value covers the numbers of reads of different caches and the number of disk I/Os. It is an important metric for measuring the SQL filtering performance.   
        /// 
        /// > <br> A higher ratio of the number of logical reads to the number of returned rows indicates poorer filtering performance. General causes include non-standard content written by SQL statements, non-standard table indexes created, and non-standard SQL execution plans.
        /// </summary>
        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public string FilterConditionShrink { get; set; }

        /// <summary>
        /// The number of failures.
        /// </summary>
        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

        /// <summary>
        /// The queuing time, in ms.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of row cache hits.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The I/O wait time, in ms.
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        /// <summary>
        /// The number of retries.
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// SQLID.
        /// </summary>
        [NameInMap("SearchParameter")]
        [Validation(Required=false)]
        public string SearchParameter { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("SearchRule")]
        [Validation(Required=false)]
        public string SearchRule { get; set; }

        /// <summary>
        /// The number of Bloom filter cache hits.
        /// </summary>
        [NameInMap("SearchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        /// <summary>
        /// The number of rows read from the disk.
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// The list of top SQL statements.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// The maximum response time, in ms.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The average CPU time, in ms.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
