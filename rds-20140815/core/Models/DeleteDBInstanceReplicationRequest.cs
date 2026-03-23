// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteDBInstanceReplicationRequest : TeaModel {
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
        /// <para>Instance ID. You can invoke DescribeDBInstances to obtain it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890abcdef</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

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
        /// <para>Region ID. You can invoke DescribeRegions to obtain it.</para>
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
