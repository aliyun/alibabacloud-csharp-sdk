// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RestartDBNodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster node.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/185342.html">DescribeDBClusters</a> operation to query the details of all clusters under your account, including node IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-*************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the node immediately or at a scheduled time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The node is restarted at a scheduled time.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The node is restarted immediately.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public string FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest time must be at least 30 minutes later than the earliest time.</para>
        /// </description></item>
        /// <item><description><para>If PlannedStartTime is specified but this parameter is not, the latest start time of the task is PlannedStartTime plus 30 minutes by default. For example, if PlannedStartTime is set to <c>2021-01-14T09:00:00Z</c> and this parameter is empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled node restart. The task is executed within a specified time window. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The start time can be set to any point in time within the next 72 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the start time can be set to a value in the range from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-17T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is empty, the node is restarted immediately.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the available regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
