// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAccessWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The attributes of the IP whitelist group. Set this parameter to <b>hidden</b> to hide the IP whitelist group in the console.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The IP whitelist group that has appeared in the console cannot be hidden.</description></item>
        /// <item><description>This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</description></item>
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
        /// <para>The name of the IP whitelist group. The group name must be 2 to 120 characters in length and consists of lowercase letters and digits. It must start with a letter, and end with a letter or a digit.</para>
        /// <list type="bullet">
        /// <item><description>If the specified whitelist group name does not exist, the whitelist group is created.</description></item>
        /// <item><description>If the specified whitelist group name exists, the whitelist group is modified.</description></item>
        /// <item><description>If you do not specify this parameter, the default group is modified.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can create a maximum of 50 IP whitelist groups for a cluster.</para>
        /// </description></item>
        /// <item><description><para>This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>Cover</b> (default): overwrites the original IP whitelist.</description></item>
        /// <item><description><b>Append</b>: appends IP addresses to the original whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes IP addresses.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</para>
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
        /// <para>The ID of the security group. Separate multiple security groups with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can add a maximum of three security groups to a cluster.</description></item>
        /// <item><description>This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>SecurityGroup</b>.</description></item>
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
        /// <para>The IP addresses or Classless Inter-Domain Routing (CIDR) blocks in the IP whitelist group. You can add 1,000 IP addresses or CIDR blocks to all the IP whitelist groups. Separate multiple IP addresses with commas (,). The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses. Example: 10.23.12.24.</description></item>
        /// <item><description>CIDR blocks. Example: 10.23.12.24/24. 24 indicates the length of the prefix of the CIDR block. The length is the range of 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</para>
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
