// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class CheckDataConsistencyResponseBody : TeaModel {
        [NameInMap("IsDataConsistency")]
        [Validation(Required=false)]
        public bool? IsDataConsistency { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
