// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksStatRequest : TeaModel {
        /// <summary>
        /// <para>Minimum task execution time, used to filter tasks with execution time greater than this value, in seconds. Default 0, meaning no limit</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>Query start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-08T07:04:17Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public long? ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Succeed</b></description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Cancelling</b></description></item>
        /// <item><description><b>Canceled</b></description></item>
        /// <item><description><b>Waiting</b></description></item>
        /// </list>
        /// <para>Separate multiple states with commas (,). This parameter is empty by default, which indicates that tasks in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1564657730</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>Maximum task execution time, used to filter tasks with execution time not less than this value, in seconds. Default 0, meaning no limit</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>Represents tasks whose start time is before this time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-24T10:01:37Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
