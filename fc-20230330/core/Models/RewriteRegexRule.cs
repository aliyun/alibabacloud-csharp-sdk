// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RewriteRegexRule : TeaModel {
        [NameInMap("regexStr")]
        [Validation(Required=false)]
        public string RegexStr { get; set; }

        [NameInMap("replacement")]
        [Validation(Required=false)]
        public string Replacement { get; set; }

    }

}
