// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in a specific region, including cluster IDs.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is omitted, scheduled tasks for all clusters in your account are queried.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <remarks>
        /// <para>The order ID can contain only digits.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20951253014****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b> (default), <b>50</b>, and <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The latest start time of the task. The time is in UTC. If the task does not start by this time, it expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-28T12:30Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest start time of the task. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-28T12:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the available regions.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is omitted, scheduled tasks in all regions in your account are queried.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pending</b>: The task is waiting to be executed.</para>
        /// </description></item>
        /// <item><description><para><b>executing</b>: The task is being executed.</para>
        /// </description></item>
        /// <item><description><para><b>failure</b>: The task failed and is waiting for a retry.</para>
        /// </description></item>
        /// <item><description><para><b>finish</b>: The task is complete.</para>
        /// </description></item>
        /// <item><description><para><b>cancel</b>: The task is canceled.</para>
        /// </description></item>
        /// <item><description><para><b>expired</b>: The task has expired because it did not start within the scheduled time window.</para>
        /// </description></item>
        /// <item><description><para><b>rollback</b>: The task is being rolled back.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is omitted, scheduled tasks in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The action of the scheduled task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CreateDBNodes</b></para>
        /// </description></item>
        /// <item><description><para><b>ModifyDBNodeClass</b></para>
        /// </description></item>
        /// <item><description><para><b>UpgradeDBClusterVersion</b></para>
        /// </description></item>
        /// <item><description><para><b>ModifyDBClusterPrimaryZone</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Task details are returned only if you specify the <c>PlannedStartTime</c> parameter when you call one of the preceding API operations. Otherwise, the <c>TimerInfos</c> field in the response is empty.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is omitted, scheduled tasks of all types are queried.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateDBNodes</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

    }

}
