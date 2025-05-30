// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class QueryPeriodBudgetBillRequest : TeaModel {
        [NameInMap("objectIds")]
        [Validation(Required=false)]
        public string ObjectIds { get; set; }

        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public string Period { get; set; }

    }

}
