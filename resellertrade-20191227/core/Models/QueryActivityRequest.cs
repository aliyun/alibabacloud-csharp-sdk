// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class QueryActivityRequest : TeaModel {
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public long? ActivityId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("SnapType")]
        [Validation(Required=false)]
        public string SnapType { get; set; }

    }

}
