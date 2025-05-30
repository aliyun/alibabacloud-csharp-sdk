// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class QueryPeriodBudgetBillResponseBody : TeaModel {
        [NameInMap("periodBudgetBillDTOS")]
        [Validation(Required=false)]
        public List<QueryPeriodBudgetBillResponseBodyPeriodBudgetBillDTOS> PeriodBudgetBillDTOS { get; set; }
        public class QueryPeriodBudgetBillResponseBodyPeriodBudgetBillDTOS : TeaModel {
            [NameInMap("bill")]
            [Validation(Required=false)]
            public double? Bill { get; set; }

            [NameInMap("budget")]
            [Validation(Required=false)]
            public double? Budget { get; set; }

            [NameInMap("lastYearBill")]
            [Validation(Required=false)]
            public double? LastYearBill { get; set; }

            [NameInMap("month")]
            [Validation(Required=false)]
            public string Month { get; set; }

        }

    }

}
