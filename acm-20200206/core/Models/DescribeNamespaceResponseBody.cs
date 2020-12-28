// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acm20200206.Models
{
    public class DescribeNamespaceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public DescribeNamespaceResponseBodyNamespace Namespace { get; set; }
        public class DescribeNamespaceResponseBodyNamespace : TeaModel {
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

    }

}
