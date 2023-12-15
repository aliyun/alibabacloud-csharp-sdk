// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmIssueOrderRequest : TeaModel {
        [NameInMap("ExtOrderId")]
        [Validation(Required=false)]
        public string ExtOrderId { get; set; }

        [NameInMap("ExtUserId")]
        [Validation(Required=false)]
        public string ExtUserId { get; set; }

        [NameInMap("LockSeatApplyKey")]
        [Validation(Required=false)]
        public string LockSeatApplyKey { get; set; }

        [NameInMap("ParamsJson")]
        [Validation(Required=false)]
        public string ParamsJson { get; set; }

        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
