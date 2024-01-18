// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailListOfBuyerRequest : TeaModel {
        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("utc_create_begin")]
        [Validation(Required=false)]
        public long? UtcCreateBegin { get; set; }

        [NameInMap("utc_create_end")]
        [Validation(Required=false)]
        public long? UtcCreateEnd { get; set; }

    }

}
