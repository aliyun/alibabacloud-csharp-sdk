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
        /// <para>The value supports CIDR format and IPv6 format address range.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The IPv6 feature is supported only by Extreme NAS file systems in regions in the Chinese mainland, and IPv6 must be enabled for the file system.</description></item>
        /// <item><description>Only VPC networks are supported.</description></item>
        /// <item><description>IPv4 and IPv6 are mutually exclusive.</description></item>
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
        /// <para>The priority of the permission rule.</para>
        /// <para>If an authorized address matches multiple rules, the rule with the highest priority takes effect.</para>
        /// <para>Valid values: 1 to 100. The value 1 indicates the highest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The read and write permissions of the authorized address on the file system.</para>
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
        /// <para>The IP address or CIDR block of the authorized address.</para>
        /// <para>The value must be a single IP address or a CIDR block.</para>
        /// <remarks>
        /// <para>Permission groups of the classic network type support only IP addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.0/16</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The access permissions of the system user of the authorized address on the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>no_squash (default): allows access to the file system as the root user.</description></item>
        /// <item><description>root_squash: maps the root user to the nobody user when the root user accesses the file system.</description></item>
        /// <item><description>all_squash: maps all users to the nobody user regardless of the user identity.</description></item>
        /// </list>
        /// <para>The nobody user is a default user in Linux. The nobody user can access only public content on the server and has low privileges and high security. Authorization is required for the system user to access the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_squash</para>
        /// </summary>
        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

    }

}
