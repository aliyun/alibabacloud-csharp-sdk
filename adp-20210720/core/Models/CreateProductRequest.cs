// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateProductRequest : TeaModel {
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("foundationVersionUID")]
        [Validation(Required=false)]
        public string FoundationVersionUID { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

        [NameInMap("withoutProductVersion")]
        [Validation(Required=false)]
        public bool? WithoutProductVersion { get; set; }

    }

}
