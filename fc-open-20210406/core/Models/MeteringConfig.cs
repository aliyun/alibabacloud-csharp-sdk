// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class MeteringConfig : TeaModel {
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        [NameInMap("payerId")]
        [Validation(Required=false)]
        public string PayerId { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
