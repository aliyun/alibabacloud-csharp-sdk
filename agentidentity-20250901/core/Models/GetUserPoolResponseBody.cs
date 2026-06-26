// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserPool")]
        [Validation(Required=false)]
        public GetUserPoolResponseBodyUserPool UserPool { get; set; }
        public class GetUserPoolResponseBodyUserPool : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

    }

}
