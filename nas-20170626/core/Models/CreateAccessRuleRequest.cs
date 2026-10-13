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
        /// <para>CIDR blocks and IPv6 address ranges are supported.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>IPv6 is supported only by Extreme NAS file systems in regions in the Chinese mainland, and IPv6 must be enabled for the file system.</description></item>
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
        /// <item><description>RDWR (default): Read and write.</description></item>
        /// <item><description>RDONLY: Read-only.</description></item>
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
        /// <para>The authorization of the system user of the authorized address on the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>no_squash (default): Allows access to the file system as the root user.</description></item>
        /// <item><description>root_squash: Maps the root user to the nobody user when the file system is accessed as the root user.</description></item>
        /// <item><description>all_squash: Maps all users to the nobody user regardless of the user identity used to access the file system.</description></item>
        /// </list>
        /// <para>The nobody user is the default user in Linux. The nobody user can access only public content on the server and has low privileges and high security.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_squash</para>
        /// </summary>
        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

    }

}
