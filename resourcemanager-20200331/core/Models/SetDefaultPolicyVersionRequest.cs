// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SetDefaultPolicyVersionRequest : TeaModel {
        [NameInMap("PolicyName")]
        [Validation(Required=true)]
        public string PolicyName { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=true)]
        public string VersionId { get; set; }

    }

}
