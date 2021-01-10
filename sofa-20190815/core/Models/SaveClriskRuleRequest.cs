// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveClriskRuleRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("RuleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
