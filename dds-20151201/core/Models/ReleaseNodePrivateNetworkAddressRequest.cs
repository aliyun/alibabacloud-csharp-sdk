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
        /// <item><description><para><b>SRV</b></para>
        /// </description></item>
        /// <item><description><para><b>Normal</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the endpoint to be released is an SRV endpoint.</para>
        /// </remarks>
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
        /// <item><description><para><b>VPC</b>: virtual private cloud.</para>
        /// </description></item>
        /// <item><description><para><b>Classic</b>: classic network.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/62135.html">DescribeShardingNetworkAddress</a> API to query the network type of the internal endpoint for the node.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> API to query the ID of the shard or Configserver node.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>When you release an SRV address, enter the instance ID for this parameter.</para>
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
