// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RebuildDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance in the dedicated cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster. You can call the DescribeDedicatedHostGroups operation to obtain the dedicated cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4nxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the host on which you want to rebuild the secondary instance. If you do not specify this parameter, the system preferentially rebuilds the secondary instance on the original host. If the original host does not have sufficient storage space, the system selects a host that does not contain the primary instance. If sufficient storage space is still unavailable, an insufficient storage space error is returned.</para>
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
        /// <para>The type of the secondary instance that you want to rebuild. Valid values:</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to obtain the region ID.</para>
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
