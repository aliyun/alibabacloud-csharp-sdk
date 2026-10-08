// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RebuildDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID in the dedicated cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID. You can call DescribeDedicatedHostGroups to query the dedicated cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4nxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the secondary instance is to be rebuilt.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the secondary instance is preferentially rebuilt on the original host. If the original host does not have sufficient space, the system selects a host that does not contain the primary instance. If no host with sufficient space is found, an insufficient space error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bpxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The type of secondary instance to rebuild. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FOLLOWER</b>: secondary node.</description></item>
        /// <item><description><b>LOG</b>: log node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FOLLOWER</para>
        /// </summary>
        [NameInMap("RebuildNodeType")]
        [Validation(Required=false)]
        public string RebuildNodeType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the region ID.</para>
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
