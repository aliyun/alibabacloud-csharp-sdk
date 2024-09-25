// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradeDBClusterVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run the kernel upgrade task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not required when you call the operation.</para>
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
        /// <para>The latest start time to run the task that updates the kernel version of the cluster. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter must be at least 30 minutes later than the value of PlannedStartTime.</description></item>
        /// <item><description>If you specify <c>PlannedStartTime</c> but do not specify PlannedEndTime, the latest start time of the task is <c>PlannedEndTime + 30 minutes</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and do not specify PlannedEndTime, the latest start time of the task is set to <c>2021-01-14T09:30:00Z</c>.</description></item>
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
        /// <para>The earliest start time to run the task that updates the kernel version of the cluster. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The earliest start time of the task can be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a point in time between <c>2021-01-14T09:00:00Z</c> and <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If you do not specify this parameter, the kernel update task runs immediately after you submit the request.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:00:00Z</para>
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
        /// <para>The code of the db version to which you want to upgrade the cluster. You can call the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation to query the version code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230707</para>
        /// </summary>
        [NameInMap("TargetDBRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetDBRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The code of the proxy version to which you want to upgrade the cluster. You can call the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation to query the version code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240702</para>
        /// </summary>
        [NameInMap("TargetProxyRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetProxyRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The upgrade tag. The value is fixed as <b>INNOVATE</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is applicable only when you upgrade PolarDB for MySQL 8.0.1 to PolarDB for MySQL 8.0.2.</description></item>
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
        /// <para>The engine version upgrade policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HOT</b>: hot upgrade.</description></item>
        /// <item><description><b>COLD</b>: cold upgrade. Only PolarDB for MySQL 8.0 Cluster Edition supports this upgrade method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOT</para>
        /// </summary>
        [NameInMap("UpgradePolicy")]
        [Validation(Required=false)]
        public string UpgradePolicy { get; set; }

        /// <summary>
        /// <para>The update type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PROXY</b>: specifies to upgrade PloarProxy.</description></item>
        /// <item><description><b>DB</b>: specifies to upgrade the kernel version.</description></item>
        /// <item><description><b>ALL</b>: specifies to upgrade both PloarProxy and kernel version.</description></item>
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
