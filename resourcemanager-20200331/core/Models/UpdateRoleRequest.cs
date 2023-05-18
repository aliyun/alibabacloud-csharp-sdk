// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateRoleRequest : TeaModel {
        /// <summary>
        /// The document of the policy that specifies the trusted entity to assume the RAM role.
        /// </summary>
        [NameInMap("NewAssumeRolePolicyDocument")]
        [Validation(Required=false)]
        public string NewAssumeRolePolicyDocument { get; set; }

        /// <summary>
        /// The description of the RAM role.
        /// 
        /// The description must be 1 to 1,024 characters in length.
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// The maximum session duration of the RAM role.
        /// 
        /// Unit: seconds. Valid values: 3600 to 43200. Default value: 3600.
        /// 
        /// If you do not specify this parameter, the default value is used.
        /// </summary>
        [NameInMap("NewMaxSessionDuration")]
        [Validation(Required=false)]
        public long? NewMaxSessionDuration { get; set; }

        /// <summary>
        /// The name of the RAM role.
        /// 
        /// The name must be 1 to 64 characters in length and can contain letters, digits, periods (.),and hyphens (-).
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
