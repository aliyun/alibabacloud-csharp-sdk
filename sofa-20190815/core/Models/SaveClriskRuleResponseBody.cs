// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveClriskRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("RuleInfo")]
        [Validation(Required=false)]
        public SaveClriskRuleResponseBodyRuleInfo RuleInfo { get; set; }
        public class SaveClriskRuleResponseBodyRuleInfo : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("ModelCode")]
            [Validation(Required=false)]
            public string ModelCode { get; set; }
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }
        };

    }

}
