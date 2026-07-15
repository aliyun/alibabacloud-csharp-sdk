// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class AllocateDBInstanceSrvNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2ze5eb9514e31364</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of a mongos or shard node in a sharded cluster instance.</para>
        /// <remarks>
        /// <para>This parameter is not currently required.</para>
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
        /// <para>The type of SRV connection string to enable.</para>
        /// <list type="bullet">
        /// <item><description><para><c>vpc</c>: SRV connection string for the VPC.</para>
        /// </description></item>
        /// <item><description><para><c>public</c>: Public SRV connection string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default is the VPC connection string.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("SrvConnectionType")]
        [Validation(Required=false)]
        public string SrvConnectionType { get; set; }

    }

}
