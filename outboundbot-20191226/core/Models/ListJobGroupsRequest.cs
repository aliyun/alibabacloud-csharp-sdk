// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve the query results asynchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncQuery")]
        [Validation(Required=false)]
        public bool? AsyncQuery { get; set; }

        /// <summary>
        /// <para>The end of the time range for the query, based on the creation time of the job group. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579965079000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filters results by job status. To specify multiple statuses, separate them with commas. The statuses are combined with a logical OR. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Draft</b>: The job group is a draft.</para>
        /// </description></item>
        /// <item><description><para><b>Scheduling</b>: The job group is being scheduled.</para>
        /// </description></item>
        /// <item><description><para><b>Executing</b>: The job group is executing.</para>
        /// </description></item>
        /// <item><description><para><b>Completed</b>: The job group has completed.</para>
        /// </description></item>
        /// <item><description><para><b>Paused</b>: The job group is paused.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: The job group has failed.</para>
        /// </description></item>
        /// <item><description><para><b>Cancelled</b>: The job group is canceled.</para>
        /// </description></item>
        /// <item><description><para><b>Initializing</b>: The job group is initializing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("JobGroupStatusFilter")]
        [Validation(Required=false)]
        public string JobGroupStatusFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only job groups with minimum concurrency enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyMinConcurrencyEnabled")]
        [Validation(Required=false)]
        public bool? OnlyMinConcurrencyEnabled { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>面试</para>
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>The start of the time range for the query, based on the creation time of the job group. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578965079000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
