// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessRuleRequest : TeaModel {
        /// <summary>
        /// The name of the permission group.
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// The rule ID.
        /// </summary>
        [NameInMap("AccessRuleId")]
        [Validation(Required=false)]
        public string AccessRuleId { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid values:
        /// 
        /// *   standard (default): General-purpose NAS file system
        /// *   extreme: Extreme NAS file system
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// The IPv6 address or CIDR block of the authorized object.
        /// 
        /// You must set this parameter to an IPv6 IP address or CIDR block.
        /// 
        /// > *   Only Extreme NAS file systems that reside in the China (Hohhot) region support IPv6.
        /// >*   Only permission groups that reside in virtual private clouds (VPCs) support IPv6.
        /// >*   This parameter is unavailable if you specify the SourceCidrIp parameter.
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// The priority of the rule.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 1, which indicates the highest priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The access permissions of the authorized object on the file system.
        /// 
        /// Valid values:
        /// 
        /// *   RDWR (default): the read and write permissions
        /// *   RDONLY: the read-only permissions
        /// </summary>
        [NameInMap("RWAccessType")]
        [Validation(Required=false)]
        public string RWAccessType { get; set; }

        /// <summary>
        /// The IP address or CIDR block of the authorized object.
        /// 
        /// You must set this parameter to an IP address or CIDR block.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// The access permissions for different types of users in the authorized object.
        /// 
        /// Valid values:
        /// 
        /// *   no_squash: allows access from root users to the file system.
        /// *   root_squash: grants root users the least permissions as the nobody user.
        /// *   all_squash: grants all users the least permissions as the nobody user.
        /// 
        /// The nobody user has the least permissions in Linux and can access only the public content of the file system. This ensures the security of the file system.
        /// </summary>
        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

    }

}
