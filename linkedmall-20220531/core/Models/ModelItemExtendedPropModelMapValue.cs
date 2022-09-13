/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ModelItemExtendedPropModelMapValue : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ValueStart")]
        [Validation(Required=false)]
        public string ValueStart { get; set; }

        [NameInMap("ValueEnd")]
        [Validation(Required=false)]
        public string ValueEnd { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("ChildProps")]
        [Validation(Required=false)]
        public Dictionary<string, object> ChildProps { get; set; }

    }

}
