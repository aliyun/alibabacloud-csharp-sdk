// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterAccessWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP address whitelist. By default, this parameter is <b>empty</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist that you want to modify.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default IP address whitelist is modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayName")]
        [Validation(Required=false)]
        public string DBClusterIPArrayName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1qx68m06981****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The method that is used to modify the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the original IP address whitelist.</description></item>
        /// <item><description><b>Append</b>: appends the specified IP addresses to the original IP address whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the original IP address whitelist.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value of Cover is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

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
        /// <para>The IP addresses in the IP address whitelist. You can specify IP addresses in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP address. For example, you can set SecurityIps to 192.168.0.1. This allows you to use this IP address to access your ApsaraDB for ClickHouse cluster.</description></item>
        /// <item><description>CIDR block. For example, you can set SecurityIps to 192.168.0.0/24. This allows you to use the IP addresses from 192.168.0.1 to 192.168.0.255 to access your ApsaraDB for ClickHouse cluster.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Do not set SecurityIps to 0.0.0.0.</para>
        /// </description></item>
        /// <item><description><para>If you set SecurityIps to 127.0.0.1, all IP addresses are blocked from accessing your ApsaraDB for ClickHouse cluster.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
