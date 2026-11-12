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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/185342.html">DescribeDBClusters</a> operation to view the details of all clusters under your account, including the node ID.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Nodes in Serverless (AgileServerless) clusters are not supported. Operation description: This operation does not support nodes in Serverless (AgileServerless) clusters. You can check the ServerlessType field in the DescribeDBClusters response to determine the cluster type. For Serverless clusters, use the alternative management operations.</para>
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
        /// <para>Specifies whether to execute the node restart task immediately or at a scheduled time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Executes the task at a scheduled time.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Executes the task immediately.</para>
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
        /// <para>The latest time to start the scheduled task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The end time must be at least 30 minutes later than the start time.</description></item>
        /// <item><description>If <c>PlannedStartTime</c> is specified but this parameter is not, the latest time to start the task defaults to the start time plus 30 minutes. For example, if <c>PlannedStartTime</c> is set to <c>2021-01-14T09:00:00Z</c> and this parameter is left empty, the task will start no later than <c>2021-01-14T09:30:00Z</c>.</description></item>
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
        /// <para>The earliest time to start the scheduled node restart task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time must be within the next 72 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the allowed start time ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-17T09:00:00Z</c>.</description></item>
        /// <item><description>If this parameter is left empty, the node restart task is executed immediately by default.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to view the available regions.</para>
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
