// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSAcrNamespaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<ListAKSAcrNamespaceResponseBodyNamespaces> Namespaces { get; set; }
        public class ListAKSAcrNamespaceResponseBodyNamespaces : TeaModel {
            [NameInMap("AuthorizeType")]
            [Validation(Required=false)]
            public string AuthorizeType { get; set; }

            [NameInMap("AutoCreate")]
            [Validation(Required=false)]
            public string AutoCreate { get; set; }

            [NameInMap("DefaultVisibility")]
            [Validation(Required=false)]
            public string DefaultVisibility { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("NamespaceStatus")]
            [Validation(Required=false)]
            public string NamespaceStatus { get; set; }

        }

    }

}
