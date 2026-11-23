// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterAccessWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the whitelist group. Default value: <b>empty</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the whitelist group to be modified.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the whitelist in the default group is modified.</para>
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
        /// <para>The modification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the original whitelist.</description></item>
        /// <item><description><b>Append</b>: appends the specified IP addresses to the original whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the original whitelist.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the Cover mode is used by default.</para>
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
        /// <para>The IP whitelist. Two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address: For example, 192.168.0.1 allows this IP address to access the ApsaraDB for ClickHouse cluster.</description></item>
        /// <item><description>CIDR block: For example, 192.168.0.0/24 allows IP addresses from 192.168.0.1 to 192.168.0.255 to access the ApsaraDB for ClickHouse cluster.<remarks>
        /// <list type="bullet">
        /// <item><description>Do not enter 0.0.0.0.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>Set the value to 127.0.0.1 to deny access from all IP addresses.</description></item>
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
