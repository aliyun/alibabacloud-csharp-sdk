// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RewriteConfig : TeaModel {
        [NameInMap("equalRules")]
        [Validation(Required=false)]
        public List<EqualRule> EqualRules { get; set; }

        [NameInMap("regexRules")]
        [Validation(Required=false)]
        public List<RegexRule> RegexRules { get; set; }

        [NameInMap("wildcardRules")]
        [Validation(Required=false)]
        public List<WildcardRule> WildcardRules { get; set; }

    }

}
