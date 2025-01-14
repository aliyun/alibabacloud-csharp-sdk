// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AuthReportInterval : TeaModel {
        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public long? Value { get; set; }

    }

}
