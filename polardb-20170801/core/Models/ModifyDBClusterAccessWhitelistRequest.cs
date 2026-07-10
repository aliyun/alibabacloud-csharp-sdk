// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAccessWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP whitelist group. If this parameter is set to <b>hidden</b>, the group is not displayed in the console.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>IP whitelist groups that are already displayed in the console cannot be hidden.</description></item>
        /// <item><description>This parameter takes effect only when <b>WhiteListType</b> is set to <b>IP</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group. The name must be 2 to 120 characters in length and can contain lowercase letters and digits. The name must start with a letter and end with a letter or digit.</para>
        /// <list type="bullet">
        /// <item><description>If the specified whitelist group name does not exist, a new whitelist group is created.</description></item>
        /// <item><description>If the specified whitelist group name already exists, the whitelist group is modified.</description></item>
        /// <item><description>If this parameter is not specified, the default group is modified.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of 50 IP whitelist groups are supported for a cluster.</description></item>
        /// <item><description>This parameter takes effect only when <b>WhiteListType</b> is set to <b>IP</b>.</description></item>
        /// </list>
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
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The method used to modify the IP whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the original IP whitelist (default value).</description></item>
        /// <item><description><b>Append</b>: appends IP addresses to the whitelist.</description></item>
        /// <item><description><b>Delete</b>: removes IP addresses from the whitelist.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PfsInstanceId")]
        [Validation(Required=false)]
        public string PfsInstanceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group IDs. Separate multiple security group IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of 3 security groups are supported for a cluster.</description></item>
        /// <item><description>This parameter takes effect only when <b>WhiteListType</b> is set to <b>SecurityGroup</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-*********</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public string SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The IP addresses or CIDR blocks in the IP whitelist group. A maximum of 1,000 IP addresses or CIDR blocks can be added to all IP whitelist groups. Separate multiple IP addresses with commas (,). The following two formats are supported: </para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 10.23.12.24.</description></item>
        /// <item><description>CIDR format, such as 10.23.12.24/24, where 24 indicates the prefix length of the CIDR block. The prefix length ranges from 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.12.24</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// <para>The type of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IP</b>: IP whitelist group.</description></item>
        /// <item><description><b>SecurityGroup</b>: security group.</description></item>
        /// </list>
        /// <para>Default value: <b>IP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public string WhiteListType { get; set; }

    }

}
