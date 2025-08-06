// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAppPolicyResponseBody : TeaModel {
        [NameInMap("AppPolicy")]
        [Validation(Required=false)]
        public CreateAppPolicyResponseBodyAppPolicy AppPolicy { get; set; }
        public class CreateAppPolicyResponseBodyAppPolicy : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            [NameInMap("PolicyValue")]
            [Validation(Required=false)]
            public string PolicyValue { get; set; }

            [NameInMap("Products")]
            [Validation(Required=false)]
            public string Products { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
