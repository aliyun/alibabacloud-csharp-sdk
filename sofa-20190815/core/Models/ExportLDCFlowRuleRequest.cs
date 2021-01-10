// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExportLDCFlowRuleRequest : TeaModel {
        [NameInMap("Check")]
        [Validation(Required=false)]
        public bool? Check { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

        [NameInMap("AppsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppsRepeatList { get; set; }

    }

}
