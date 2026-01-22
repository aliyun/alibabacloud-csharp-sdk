// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class EcIdAccountId : TeaModel {
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        [NameInMap("EcId")]
        [Validation(Required=false)]
        public string EcId { get; set; }

    }

}
