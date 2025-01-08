// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetSavingPlanUserDeductRuleRequest : TeaModel {
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<SetSavingPlanUserDeductRuleRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class SetSavingPlanUserDeductRuleRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        [NameInMap("SpnInstanceCode")]
        [Validation(Required=false)]
        public string SpnInstanceCode { get; set; }

        [NameInMap("UserDeductRules")]
        [Validation(Required=false)]
        public List<SetSavingPlanUserDeductRuleRequestUserDeductRules> UserDeductRules { get; set; }
        public class SetSavingPlanUserDeductRuleRequestUserDeductRules : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("SkipDeduct")]
            [Validation(Required=false)]
            public bool? SkipDeduct { get; set; }

        }

    }

}
