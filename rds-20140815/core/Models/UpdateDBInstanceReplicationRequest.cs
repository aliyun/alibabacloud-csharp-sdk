// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpdateDBInstanceReplicationRequest : TeaModel {
        /// <summary>
        /// <para>复制通道名称，用于标识复制链路</para>
        /// 
        /// <b>Example:</b>
        /// <para>replication-channel-001</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>目标RDS实例ID，复制链路将在此实例上更新</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890abcdef</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>主数据库主机地址，支持IP或域名，仅在需要更新时提供</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("MasterHost")]
        [Validation(Required=false)]
        public string MasterHost { get; set; }

        /// <summary>
        /// <para>主数据库密码，用于验证复制用户，需要提前经过Base64编码，仅在需要更新时提供</para>
        /// 
        /// <b>Example:</b>
        /// <para>U2VjdXJlUGFzczEyMyE=</para>
        /// </summary>
        [NameInMap("MasterPassword")]
        [Validation(Required=false)]
        public string MasterPassword { get; set; }

        /// <summary>
        /// <para>主数据库端口号，通常为3306（MySQL）或5432（PostgreSQL），仅在需要更新时提供</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("MasterPort")]
        [Validation(Required=false)]
        public int? MasterPort { get; set; }

        /// <summary>
        /// <para>主数据库用户名，用于建立复制连接，仅在需要更新时提供</para>
        /// 
        /// <b>Example:</b>
        /// <para>repl_user</para>
        /// </summary>
        [NameInMap("MasterUser")]
        [Validation(Required=false)]
        public string MasterUser { get; set; }

        /// <summary>
        /// <para>操作类型，指定对复制链路执行的操作</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

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
        /// <para>地域ID，表示RDS实例所在的地域</para>
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
