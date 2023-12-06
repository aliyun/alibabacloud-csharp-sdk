// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListFoundationReferenceComponentsRequest : TeaModel {
        [NameInMap("foundationReferenceUID")]
        [Validation(Required=false)]
        public string FoundationReferenceUID { get; set; }

        [NameInMap("foundationVersionUID")]
        [Validation(Required=false)]
        public string FoundationVersionUID { get; set; }

        [NameInMap("onlyEnabled")]
        [Validation(Required=false)]
        public bool? OnlyEnabled { get; set; }

        [NameInMap("parentComponentReferenceUID")]
        [Validation(Required=false)]
        public string ParentComponentReferenceUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
