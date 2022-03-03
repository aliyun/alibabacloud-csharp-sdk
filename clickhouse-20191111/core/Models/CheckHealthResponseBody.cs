// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckHealthResponseBody : TeaModel {
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        [NameInMap("IsHealthy")]
        [Validation(Required=false)]
        public bool? IsHealthy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
