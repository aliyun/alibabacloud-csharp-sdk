// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TagSelector : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TagCondition> Conditions { get; set; }

        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

    }

}
