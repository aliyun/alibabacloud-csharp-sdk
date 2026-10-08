// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS_MySQL</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end date of the query. The end date must be later than or equal to the start date, and the interval between the start date and the end date cannot exceed 31 days. Format: <i>yyyy-MM-dd</i>Z (UTC).</para>
        /// <remarks>
        /// <para>If the end date is the same as the start date, the query starts from 08:00 on the start date and covers up to 24 hours of slow query log statistics.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-05-30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b> to <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The sorting criterion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TotalExecutionCounts</b>: sorted by total number of executions in descending order.</description></item>
        /// <item><description><b>TotalQueryTimes</b>: sorted by total execution duration in descending order.</description></item>
        /// <item><description><b>TotalLogicalReads</b>: sorted by total number of logical reads in descending order.</description></item>
        /// <item><description><b>TotalPhysicalReads</b>: sorted by total number of physical reads in descending order.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for SQL Server 2008 R2 instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TotalExecutionCounts</para>
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// <para>The start date of the query. Format: <i>yyyy-MM-dd</i>Z (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-05-01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
