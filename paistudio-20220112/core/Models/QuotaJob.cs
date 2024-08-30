// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaJob : TeaModel {
        [NameInMap("Queuing")]
        [Validation(Required=false)]
        public long? Queuing { get; set; }

        [NameInMap("Running")]
        [Validation(Required=false)]
        public long? Running { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
