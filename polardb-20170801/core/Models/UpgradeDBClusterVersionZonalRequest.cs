// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradeDBClusterVersionZonalRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value on the client side. The value must be unique across different requests and is case-sensitive. It can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB on ENS cluster. Only cluster IDs returned by the DescribeDBClustersZonal operation are supported. Before you call this operation, you must create an edge cluster by using ENS infrastructure. Standard PolarDB cluster IDs are not supported. Note: Only edge cluster IDs returned by DescribeDBClustersZonal are accepted, and the edge cluster must be created based on ENS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately execute or schedule the kernel version upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Scheduled execution.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Immediate execution.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to specify this parameter when you invoke this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The latest time must be at least 30 minutes later than the start time.</description></item>
        /// <item><description>If you specify <c>PlannedStartTime</c> but do not specify this parameter, the latest time to start the task defaults to 30 minutes after the start time. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts at <c>2021-01-14T09:30:00Z</c> at the latest.</description></item>
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
        /// <para>The earliest time to start the scheduled Milvus version upgrade task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the allowed start time ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If you leave this parameter empty, the Milvus version upgrade task is immediately executed by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The version code of the target database engine version. You can obtain the value from the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230707</para>
        /// </summary>
        [NameInMap("TargetDBRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetDBRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The version code of the target PolarProxy version. You can obtain the value from the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240702</para>
        /// </summary>
        [NameInMap("TargetProxyRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetProxyRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The kernel version upgrade label. Set the value to <b>INNOVATE</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to upgrades from PolarDB for MySQL 8.0.1 to PolarDB for MySQL 8.0.2.</description></item>
        /// <item><description>If you specify this parameter, you must set <c>UpgradePolicy</c> to <b>COLD</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>INNOVATE</para>
        /// </summary>
        [NameInMap("UpgradeLabel")]
        [Validation(Required=false)]
        public string UpgradeLabel { get; set; }

        /// <summary>
        /// <para>The kernel version upgrade policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HOT</b>: Hot upgrade.</para>
        /// </description></item>
        /// <item><description><para><b>COLD</b>: Cold upgrade. Only PolarDB for MySQL 8.0 Cluster Edition supports this upgrade method.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOT</para>
        /// </summary>
        [NameInMap("UpgradePolicy")]
        [Validation(Required=false)]
        public string UpgradePolicy { get; set; }

        /// <summary>
        /// <para>The upgrade type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PROXY</b>: Upgrades only PolarProxy.</para>
        /// </description></item>
        /// <item><description><para><b>DB</b>: Upgrades only the database engine.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b> (default): Upgrades both PolarProxy and the database engine.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROXY</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
