// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradeDBClusterVersionZonalRequest : TeaModel {
        /// <summary>
        /// <para>A unique, case-sensitive token that you provide to ensure the idempotence of the request. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately perform or schedule the kernel upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Schedules the upgrade.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Immediately performs the upgrade.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to specify this parameter when you call this operation.</para>
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
        /// <para>The latest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time is 30 minutes after the value of <c>PlannedStartTime</c> by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
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
        /// <para>The earliest time to start the scheduled kernel upgrade. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time can be any point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a time in the range of <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the upgrade task is executed immediately.</description></item>
        /// </list>
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
        /// <para>The version code of the target DB version. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230707</para>
        /// </summary>
        [NameInMap("TargetDBRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetDBRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The version code of the target proxy version. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/2319145.html">DescribeDBClusterVersion</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240702</para>
        /// </summary>
        [NameInMap("TargetProxyRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetProxyRevisionVersionCode { get; set; }

        /// <summary>
        /// <para>The label for the kernel version upgrade. Set the value to <b>INNOVATE</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable only when you upgrade a PolarDB for MySQL 8.0.1 cluster to PolarDB for MySQL 8.0.2.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, you must set <c>UpgradePolicy</c> to <b>COLD</b>.</para>
        /// </description></item>
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
        /// <para>The upgrade policy for the kernel version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HOT</b>: hot upgrade</para>
        /// </description></item>
        /// <item><description><para><b>COLD</b>: cold upgrade. This upgrade method is supported only for PolarDB for MySQL 8.0 clusters.</para>
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
        /// <item><description><para><b>PROXY</b>: Upgrades only the database proxy (PolarProxy).</para>
        /// </description></item>
        /// <item><description><para><b>DB</b>: Upgrades only the kernel.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b> (default): Upgrades both the database proxy (PolarProxy) and the kernel.</para>
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
