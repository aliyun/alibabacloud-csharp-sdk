// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailListOfOrderNumRequest : TeaModel {
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
