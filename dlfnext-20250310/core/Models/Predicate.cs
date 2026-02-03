// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Predicate : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<Predicate> Children { get; set; }

        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("literals")]
        [Validation(Required=false)]
        public List<object> Literals { get; set; }

        [NameInMap("transform")]
        [Validation(Required=false)]
        public Transform Transform { get; set; }

    }

}
