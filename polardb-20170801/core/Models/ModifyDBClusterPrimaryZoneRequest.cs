// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterPrimaryZoneRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to query the details of all clusters in a destination region, including their cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform the zone change immediately or at a scheduled time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): The zone change is performed at the scheduled time.</para>
        /// </description></item>
        /// <item><description><para>true: The zone change is performed immediately.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        /// <summary>
        /// <para>Specifies whether to fail back to the original zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Fails back to the original zone.</para>
        /// </description></item>
        /// <item><description><para>false: Does not fail back to the original zone.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSwitchOverForDisaster")]
        [Validation(Required=false)]
        public string IsSwitchOverForDisaster { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time of the task is the value of <c>PlannedStartTime</c> plus 30 minutes by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
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
        /// <para>The earliest time to start the scheduled task to change the zone. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The start time must be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set the start time to a value from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the zone change task is performed immediately.</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the destination zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for PolarDB for Oracle and PolarDB for PostgreSQL clusters.</para>
        /// </description></item>
        /// <item><description><para>For PolarDB for MySQL clusters, this parameter is required if a vSwitch is created in the destination zone. If no vSwitch is created, the default vSwitch is used and this parameter is optional.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the new zone.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available zones.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The type of the zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Primary</b>: The primary zone.</para>
        /// </description></item>
        /// <item><description><para><b>Standby</b>: The secondary zone.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Primary</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
