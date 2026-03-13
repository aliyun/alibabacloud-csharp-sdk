// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RewriteConfig : TeaModel {
        /// <summary>
        /// <para>The exact match rules.</para>
        /// </summary>
        [NameInMap("equalRules")]
        [Validation(Required=false)]
        public List<EqualRule> EqualRules { get; set; }

        /// <summary>
        /// <para>The regex matching rules.</para>
        /// </summary>
        [NameInMap("regexRules")]
        [Validation(Required=false)]
        public List<RegexRule> RegexRules { get; set; }

        /// <summary>
        /// <para>The wildcard matching rules.</para>
        /// </summary>
        [NameInMap("wildcardRules")]
        [Validation(Required=false)]
        public List<WildcardRule> WildcardRules { get; set; }

    }

}
