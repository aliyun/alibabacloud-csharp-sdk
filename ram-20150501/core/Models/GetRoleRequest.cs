// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetRoleRequest : TeaModel {
        /// <summary>
        /// The name of the RAM role.
        /// 
        /// The name must be 1 to 64 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
