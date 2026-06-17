// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The latest start time must be at least 30 minutes later than the earliest start time.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time of the task is <c>PlannedStartTime + 30 minutes</c> by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task will be executed no later than <c>2021-01-14T09:30:00Z</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-18T19:20:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled task. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time can be any point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set the start time to a value in the range of <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the task is executed immediately.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-15T20:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53879cdb-9a00-428e-acaf-ff4cff******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
