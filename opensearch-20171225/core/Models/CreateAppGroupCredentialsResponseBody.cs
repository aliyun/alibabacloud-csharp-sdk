// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppGroupCredentialsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAppGroupCredentialsResponseBodyResult Result { get; set; }
        public class CreateAppGroupCredentialsResponseBodyResult : TeaModel {
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
