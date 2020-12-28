// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acm20200206.Models
{
    public class DescribeNamespacesWithCreateResponseBody : TeaModel {
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<DescribeNamespacesWithCreateResponseBodyNamespaces> Namespaces { get; set; }
        public class DescribeNamespacesWithCreateResponseBodyNamespaces : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("ConfigCount")]
            [Validation(Required=false)]
            public int? ConfigCount { get; set; }

            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
