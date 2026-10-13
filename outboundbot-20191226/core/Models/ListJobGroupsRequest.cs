// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to asynchronously obtain the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncQuery")]
        [Validation(Required=false)]
        public bool? AsyncQuery { get; set; }

        /// <summary>
        /// <para>The end time to filter job groups by creation time. Use a UNIX timestamp in milliseconds.</para>
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
        /// <para>The filter condition. Filters by job status. You can specify multiple statuses separated by commas. The logical OR operator is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Draft</b>: Draft.</description></item>
        /// <item><description><b>Scheduling</b>: Scheduling.</description></item>
        /// <item><description><b>Executing</b>: Executing.</description></item>
        /// <item><description><b>Completed</b>: Completed.</description></item>
        /// <item><description><b>Paused</b>: Paused.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Cancelled</b>: Cancelled.</description></item>
        /// <item><description><b>Initializing</b>: Initializing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("JobGroupStatusFilter")]
        [Validation(Required=false)]
        public string JobGroupStatusFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether to query tasks with a valid minimum concurrency guarantee.</para>
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
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Interview</para>
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>The start time to filter job groups by creation time. Use a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578965079000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
