// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster. You can call the DescribeDedicatedHostGroups operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4nxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The time when the migration is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The migration is performed immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The migration is performed during the maintenance window.</description></item>
        /// <item><description><b>Specified</b>: The migration is performed at a specified time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
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
        /// <para>The specified time when the migration is performed. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>EffectiveTime</b> is set to <b>Specified</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the destination host to which the primary instance is migrated. You can call the DescribeDedicatedHosts operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bpxxxxxxx1</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the destination host to which the secondary instance is migrated. You can call the DescribeDedicatedHosts operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bpxxxxxxx2</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneIdForFollower")]
        [Validation(Required=false)]
        public string ZoneIdForFollower { get; set; }

        /// <summary>
        /// <para>The zone ID of the logger node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneIdForLog")]
        [Validation(Required=false)]
        public string ZoneIdForLog { get; set; }

    }

}
