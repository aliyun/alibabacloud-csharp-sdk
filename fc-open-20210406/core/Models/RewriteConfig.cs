// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class RewriteConfig : TeaModel {
        [NameInMap("equalRules")]
        [Validation(Required=false)]
        public List<RewriteConfigEqualRules> EqualRules { get; set; }
        public class RewriteConfigEqualRules : TeaModel {
            [NameInMap("match")]
            [Validation(Required=false)]
            public string Match { get; set; }

            [NameInMap("replacement")]
            [Validation(Required=false)]
            public string Replacement { get; set; }

        }

        [NameInMap("regexRules")]
        [Validation(Required=false)]
        public List<RewriteConfigRegexRules> RegexRules { get; set; }
        public class RewriteConfigRegexRules : TeaModel {
            [NameInMap("match")]
            [Validation(Required=false)]
            public string Match { get; set; }

            [NameInMap("replacement")]
            [Validation(Required=false)]
            public string Replacement { get; set; }

        }

        [NameInMap("wildcardRules")]
        [Validation(Required=false)]
        public List<RewriteConfigWildcardRules> WildcardRules { get; set; }
        public class RewriteConfigWildcardRules : TeaModel {
            [NameInMap("match")]
            [Validation(Required=false)]
            public string Match { get; set; }

            [NameInMap("replacement")]
            [Validation(Required=false)]
            public string Replacement { get; set; }

        }

    }

}
