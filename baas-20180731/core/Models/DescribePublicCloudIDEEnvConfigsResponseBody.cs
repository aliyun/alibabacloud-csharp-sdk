// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribePublicCloudIDEEnvConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribePublicCloudIDEEnvConfigsResponseBodyResult> Result { get; set; }
        public class DescribePublicCloudIDEEnvConfigsResponseBodyResult : TeaModel {
            [NameInMap("Bizid")]
            [Validation(Required=false)]
            public string Bizid { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TrialAccount")]
            [Validation(Required=false)]
            public string TrialAccount { get; set; }

            [NameInMap("TrialAccountPrivateKey")]
            [Validation(Required=false)]
            public string TrialAccountPrivateKey { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
