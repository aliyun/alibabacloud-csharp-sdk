// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ReleasePublicNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The public endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SRV</b></description></item>
        /// <item><description><b>Normal</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only when you want to release an SRV endpoint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SRV</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> If you set this parameter to the ID of a sharded cluster instance, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp2235****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the mongos, shard, or Configserver node in the sharded cluster instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is valid only if you set the <b>DBInstanceId</b> parameter to the ID of a sharded cluster instance.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to view the ID of the mongos, shard, or Configserver node.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp2235****</para>
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
