// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ReleaseNodePrivateNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The type of the public endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SRV</b></description></item>
        /// <item><description><b>Normal</b><remarks>
        /// <para>This parameter is valid only when the endpoint to be released is an SRV endpoint.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SRV</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The ID of the sharded cluster instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1a7009eb24****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the internal endpoint for the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC.</description></item>
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/62135.html">DescribeShardingNetworkAddress</a> operation to query the network type of the internal endpoint for the node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the shard or Configserver node.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to query the ID of the shard or Configserver node.
        /// Notice: When you release an SRV endpoint, enter the instance ID here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp128a003436****</para>
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

    }

}
