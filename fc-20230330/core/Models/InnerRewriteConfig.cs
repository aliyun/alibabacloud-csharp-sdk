// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InnerRewriteConfig : TeaModel {
        [NameInMap("regexRules")]
        [Validation(Required=false)]
        public List<RewriteRegexRule> RegexRules { get; set; }

    }

}
