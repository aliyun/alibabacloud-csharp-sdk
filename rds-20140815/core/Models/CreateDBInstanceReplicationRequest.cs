// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceReplicationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the replication channel, used to identify the replication link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>replication-channel-001</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>The instance ID. You can obtain it by invoking DescribeDBInstances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890abcdef</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>The host address of the master database, which can be an IP address or a domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("MasterHost")]
        [Validation(Required=false)]
        public string MasterHost { get; set; }

        /// <summary>
        /// <para>The password of the master database, used to authenticate the replication user. It must be Base64-encoded in advance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U2VjdXJlUGFzczEyMyE=</para>
        /// </summary>
        [NameInMap("MasterPassword")]
        [Validation(Required=false)]
        public string MasterPassword { get; set; }

        /// <summary>
        /// <para>The port number of the master database, typically 3306 for MySQL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("MasterPort")]
        [Validation(Required=false)]
        public int? MasterPort { get; set; }

        /// <summary>
        /// <para>The username of the master database, used to establish the replication connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repl_user</para>
        /// </summary>
        [NameInMap("MasterUser")]
        [Validation(Required=false)]
        public string MasterUser { get; set; }

        /// <summary>
        /// <para>阿里云账号ID，用于指定资源的所有者</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the Region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
