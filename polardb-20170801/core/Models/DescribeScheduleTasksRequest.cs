// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The description of the cluster.</para>
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
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the information of all PolarDB clusters that are deployed in a specific region, such as the cluster IDs.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, all scheduled tasks on your clusters are queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// <remarks>
        /// <para> The order ID can contain only digits.</para>
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
        /// <para>The page number of the page to return. Set this parameter to an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The latest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-28T12:30Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-28T12:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the region information of all clusters in a specific account.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, scheduled tasks on your clusters that are deployed in all regions are queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The state of the tasks that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pending</b>: The tasks are pending execution.</description></item>
        /// <item><description><b>executing</b>: The tasks are being executed.</description></item>
        /// <item><description><b>failure</b>: The tasks failed and need to be run again.</description></item>
        /// <item><description><b>finish</b>: The tasks are complete.</description></item>
        /// <item><description><b>cancel</b>: The tasks are canceled.</description></item>
        /// <item><description><b>expired</b>: The tasks are expired. The tasks are not started within the time periods that are specified to start the tasks.</description></item>
        /// <item><description><b>rollback</b>: The tasks are being rolled back.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, all scheduled tasks in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of scheduled tasks that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateDBNodes</b></description></item>
        /// <item><description><b>ModifyDBNodeClass</b></description></item>
        /// <item><description><b>UpgradeDBClusterVersion</b></description></item>
        /// <item><description><b>ModifyDBClusterPrimaryZone</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <c>PlannedStartTime</c> parameter when you call the four preceding operations, the details of each task are returned. Otherwise, an empty string is returned for the <c>TimerInfos</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, all types of scheduled tasks on you clusters are queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateDBNodes</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

    }

}
