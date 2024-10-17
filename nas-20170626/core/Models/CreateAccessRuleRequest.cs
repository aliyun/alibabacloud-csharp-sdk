// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS file system</description></item>
        /// <item><description>extreme: Extreme NAS file system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The IPv6 address or CIDR block of the authorized object.</para>
        /// <para>You must set this parameter to an IPv6 address or CIDR block.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only Extreme NAS file systems that reside in the Chinese mainland support IPv6. If you specify this parameter, you must enable IPv6 for the file system.</description></item>
        /// <item><description>Only permission groups that reside in virtual private clouds (VPCs) support IPv6.</description></item>
        /// <item><description>You cannot specify an IPv4 address and an IPv6 address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:250:6000::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The priority of the rule.</para>
        /// <para>The rule with the highest priority takes effect if multiple rules are attached to the authorized object.</para>
        /// <para>Valid values: 1 to 100. The value 1 indicates the highest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The access permissions of the authorized object on the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RDWR (default): the read and write permissions</description></item>
        /// <item><description>RDONLY: the read-only permissions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDWR</para>
        /// </summary>
        [NameInMap("RWAccessType")]
        [Validation(Required=false)]
        public string RWAccessType { get; set; }

        /// <summary>
        /// <para>The IP address or CIDR block of the authorized object.</para>
        /// <para>You must set this parameter to an IP address or CIDR block.</para>
        /// <remarks>
        /// <para>If the permission group resides in the classic network, you must set this parameter to an IP address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.0/16</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The access permissions for different types of users in the authorized object.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>no_squash (default): grants root users the permissions to access the file system.</description></item>
        /// <item><description>root_squash: grants root users the least permissions as the nobody user.</description></item>
        /// <item><description>all_squash: grants all users the least permissions as the nobody user.</description></item>
        /// </list>
        /// <para>The nobody user has the least permissions in Linux and can access only the public content of the file system. This ensures the security of the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_squash</para>
        /// </summary>
        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

    }

}
