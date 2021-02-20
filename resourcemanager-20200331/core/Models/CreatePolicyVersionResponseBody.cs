// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreatePolicyVersionResponseBody : TeaModel {
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public CreatePolicyVersionResponseBodyPolicyVersion PolicyVersion { get; set; }
        public class CreatePolicyVersionResponseBodyPolicyVersion : TeaModel {
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
