// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeHasRuleNameByEventCodeRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("excludeRuleId")]
        [Validation(Required=false)]
        public string ExcludeRuleId { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
