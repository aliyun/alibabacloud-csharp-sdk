// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAccessWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP address whitelist group. If you set this parameter to \<c>hidden\\</c>, the whitelist group is not visible in the console.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot hide an IP address whitelist group that is already visible in the console.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
        /// </description></item>
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
        /// <para>The name of the IP address whitelist group. The name must be 2 to 120 characters in length. It must consist of lowercase letters and digits. The name must start with a letter and end with a letter or a digit.</para>
        /// <list type="bullet">
        /// <item><description><para>If the specified whitelist group name does not exist, a new whitelist group is created.</para>
        /// </description></item>
        /// <item><description><para>If the specified whitelist group name already exists, the whitelist group is modified.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the \<c>default\\</c> group is modified.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>A cluster can have up to 50 IP address whitelist groups.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
        /// </description></item>
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
        /// <para>The method used to modify the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b>: Overwrites the original IP address whitelist. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>Append</b>: Appends IP addresses to the whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>Delete</b>: Deletes IP addresses from the whitelist.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
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
        /// <para>The security group ID. Separate multiple security group IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>A cluster can be associated with up to three security groups.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only when <b>WhiteListType</b> is set to <b>SecurityGroup</b>.</para>
        /// </description></item>
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
        /// <para>The IP addresses or CIDR blocks in the IP address whitelist group. All IP address whitelist groups can contain a total of 1,000 IP addresses or CIDR blocks. Separate multiple IP addresses with commas (,). The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>IP address format. For example: 10.23.12.24.</para>
        /// </description></item>
        /// <item><description><para>CIDR format. For example: 10.23.12.24/24. The number 24 indicates the prefix length of the IP address. The prefix length can range from 1 to 32.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when <b>WhiteListType</b> is set to <b>IP</b>.</para>
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
        /// <item><description><para><b>IP</b>: IP address whitelist group.</para>
        /// </description></item>
        /// <item><description><para><b>SecurityGroup</b>: Security group.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>IP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public string WhiteListType { get; set; }

    }

}
