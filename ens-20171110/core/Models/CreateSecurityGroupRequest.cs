// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The description of the security group. The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the security group. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-). By default, this parameter is empty.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
