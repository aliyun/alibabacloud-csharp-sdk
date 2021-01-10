// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListExtensionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public List<ListExtensionsResponseBodyExtensions> Extensions { get; set; }
        public class ListExtensionsResponseBodyExtensions : TeaModel {
            [NameInMap("ExtensionId")]
            [Validation(Required=false)]
            public string ExtensionId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            [NameInMap("ExtensionDocumentationLink")]
            [Validation(Required=false)]
            public string ExtensionDocumentationLink { get; set; }

            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

        }

    }

}
