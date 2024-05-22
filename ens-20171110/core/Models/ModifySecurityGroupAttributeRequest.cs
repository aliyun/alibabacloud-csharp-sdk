// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifySecurityGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The description of the security group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the security group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The name of the security group. The name of a bucket must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter but cannot start with http:// or https://.
        /// *   The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
