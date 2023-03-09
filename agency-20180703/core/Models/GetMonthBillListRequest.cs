// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetMonthBillListRequest : TeaModel {
        [NameInMap("MonthBillTime")]
        [Validation(Required=false)]
        public string MonthBillTime { get; set; }

        [NameInMap("MonthBillType")]
        [Validation(Required=false)]
        public string MonthBillType { get; set; }

        [NameInMap("MonthUserType")]
        [Validation(Required=false)]
        public string MonthUserType { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
