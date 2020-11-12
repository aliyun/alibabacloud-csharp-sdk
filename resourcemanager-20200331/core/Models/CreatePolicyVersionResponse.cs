// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreatePolicyVersionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PolicyVersion")]
        [Validation(Required=true)]
        public CreatePolicyVersionResponsePolicyVersion PolicyVersion { get; set; }
        public class CreatePolicyVersionResponsePolicyVersion : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=true)]
            public string VersionId { get; set; }
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=true)]
            public bool? IsDefaultVersion { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
        };

    }

}
