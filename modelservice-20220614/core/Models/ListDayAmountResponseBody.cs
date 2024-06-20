// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelService20220614.Models
{
    public class ListDayAmountResponseBody : TeaModel {
        [NameInMap("DayAmounts")]
        [Validation(Required=false)]
        public List<ListDayAmountResponseBodyDayAmounts> DayAmounts { get; set; }
        public class ListDayAmountResponseBodyDayAmounts : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
