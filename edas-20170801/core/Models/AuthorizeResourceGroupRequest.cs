// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AuthorizeResourceGroupRequest : TeaModel {
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
