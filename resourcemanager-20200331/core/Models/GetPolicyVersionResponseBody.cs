// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetPolicyVersionResponseBody : TeaModel {
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public GetPolicyVersionResponseBodyPolicyVersion PolicyVersion { get; set; }
        public class GetPolicyVersionResponseBodyPolicyVersion : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
