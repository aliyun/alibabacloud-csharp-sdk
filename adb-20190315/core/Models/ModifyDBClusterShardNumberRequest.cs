// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBClusterShardNumberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> API to query the IDs of all AnalyticDB for MySQL clusters in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1xxxxxxxx47</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends a check request to verify prerequisites and the validity of the specified number of shards. The number of shards is <b>not</b> modified.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a standard request. After the request passes the check, the system triggers a backend task to modify the number of shards for the cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IsRollback")]
        [Validation(Required=false)]
        public bool? IsRollback { get; set; }

        /// <summary>
        /// <para>The new number of shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("NewShardNumber")]
        [Validation(Required=false)]
        public long? NewShardNumber { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> API to query the most recent list of regions.</para>
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

        /// <summary>
        /// <para>The scheduled time to apply the modification. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-09T22:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>Specifies when to modify the number of shards. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Immediate</b>: The modification takes effect immediately. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>MaintainTime</b>: The modification takes effect during the cluster\&quot;s maintenance window. You can call the ModifyDBInstanceMaintainTime API to change the maintenance window.</para>
        /// </description></item>
        /// <item><description><para><b>ScheduleTime</b>: The modification takes effect at a specified time. If you set this parameter to ScheduleTime, you must also specify the <b>SwitchTime</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public long? SwitchTimeMode { get; set; }

    }

}
