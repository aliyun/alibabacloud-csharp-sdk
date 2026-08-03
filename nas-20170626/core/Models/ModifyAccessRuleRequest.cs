// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessRuleRequest : TeaModel {
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
        /// <para>The ID of the permission rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccessRuleId")]
        [Validation(Required=false)]
        public string AccessRuleId { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS.</description></item>
        /// <item><description>extreme: Extreme NAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block.</para>
        /// <para>IPv6 addresses and CIDR blocks are supported.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only Extreme NAS file systems in the China (Hohhot) region support IPv6 CIDR blocks.</description></item>
        /// <item><description>Only VPCs are supported.</description></item>
        /// <item><description>IPv4 and IPv6 are mutually exclusive. You cannot convert between the two types.</description></item>
        /// <item><description>You must specify either SourceCidrIp or Ipv6SourceCidrIp. You cannot leave both parameters empty, and you cannot specify both parameters at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fe80::3d4a:80fd:f05d:****</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The priority of the permission rule.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 1 (highest priority).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The read and write permission that the authorized object has on the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RDWR (default): read and write.</description></item>
        /// <item><description>RDONLY: read-only.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDWR</para>
        /// </summary>
        [NameInMap("RWAccessType")]
        [Validation(Required=false)]
        public string RWAccessType { get; set; }

        /// <summary>
        /// <para>The IP address or CIDR block.</para>
        /// <para>The value must be a single IP address or a CIDR block.</para>
        /// <remarks>
        /// <para>You must specify either SourceCidrIp or Ipv6SourceCidrIp. You cannot leave both parameters empty, and you cannot specify both parameters at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.0.**.**</c></para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The access permissions that the system user of the authorization object has on the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>no_squash: allows access to the file system as the root user.</description></item>
        /// <item><description>root_squash: maps the root user to the nobody user when the root user accesses the file system.</description></item>
        /// <item><description>all_squash: maps all users to the nobody user regardless of the user identity used to access the file system.</description></item>
        /// </list>
        /// <para>The nobody user is a default user in Linux. This user can access only public content on the server and has low privileges and high security.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all_squash</para>
        /// </summary>
        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

    }

}
