// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class AllocateDBInstanceSrvNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2ze5eb9514e31364</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Mongos or shard node in a sharded cluster instance.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1b7bb3bbe****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the SRV address to apply for. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc</b>: VPC SRV address.</description></item>
        /// <item><description><b>public</b>: Public SRV address.<remarks>
        /// <para>The default is the private SRV address.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("SrvConnectionType")]
        [Validation(Required=false)]
        public string SrvConnectionType { get; set; }

    }

}
