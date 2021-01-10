// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RunClriskTemplateRuleRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        [NameInMap("RuleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
