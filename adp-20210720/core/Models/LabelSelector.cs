// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class LabelSelector : TeaModel {
        [NameInMap("matchExpressions")]
        [Validation(Required=false)]
        public List<LabelSelectorMatchExpressions> MatchExpressions { get; set; }
        public class LabelSelectorMatchExpressions : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("matchLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> MatchLabels { get; set; }

    }

}
