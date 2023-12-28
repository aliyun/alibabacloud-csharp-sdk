// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class SetQuotaResponseBody : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public int? Quota { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
