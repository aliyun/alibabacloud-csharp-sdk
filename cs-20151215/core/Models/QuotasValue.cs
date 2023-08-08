// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class QuotasValue : TeaModel {
        [NameInMap("quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        [NameInMap("operation_code")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        [NameInMap("adjustable")]
        [Validation(Required=false)]
        public bool? Adjustable { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
