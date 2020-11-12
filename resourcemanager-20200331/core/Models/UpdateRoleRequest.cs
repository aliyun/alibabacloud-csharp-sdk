// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateRoleRequest : TeaModel {
        [NameInMap("RoleName")]
        [Validation(Required=true)]
        public string RoleName { get; set; }

        [NameInMap("NewAssumeRolePolicyDocument")]
        [Validation(Required=true)]
        public string NewAssumeRolePolicyDocument { get; set; }

        [NameInMap("NewMaxSessionDuration")]
        [Validation(Required=false)]
        public long NewMaxSessionDuration { get; set; }

    }

}
