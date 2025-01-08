// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetSavingPlanUserDeductRuleShrinkRequest : TeaModel {
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        [NameInMap("SpnInstanceCode")]
        [Validation(Required=false)]
        public string SpnInstanceCode { get; set; }

        [NameInMap("UserDeductRules")]
        [Validation(Required=false)]
        public string UserDeductRulesShrink { get; set; }

    }

}
