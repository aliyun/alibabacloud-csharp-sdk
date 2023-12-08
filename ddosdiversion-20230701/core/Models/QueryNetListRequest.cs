// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListRequest : TeaModel {
        [NameInMap("MainNet")]
        [Validation(Required=false)]
        public string MainNet { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

    }

}
