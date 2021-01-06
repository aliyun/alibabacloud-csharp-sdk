// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetPolicyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=true)]
        public GetPolicyResponsePolicy Policy { get; set; }
        public class GetPolicyResponsePolicy : TeaModel {
            [NameInMap("PolicyType")]
            [Validation(Required=true)]
            public string PolicyType { get; set; }
            [NameInMap("UpdateDate")]
            [Validation(Required=true)]
            public string UpdateDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("AttachmentCount")]
            [Validation(Required=true)]
            public int? AttachmentCount { get; set; }
            [NameInMap("PolicyName")]
            [Validation(Required=true)]
            public string PolicyName { get; set; }
            [NameInMap("DefaultVersion")]
            [Validation(Required=true)]
            public string DefaultVersion { get; set; }
            [NameInMap("PolicyDocument")]
            [Validation(Required=true)]
            public string PolicyDocument { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
        };

    }

}
