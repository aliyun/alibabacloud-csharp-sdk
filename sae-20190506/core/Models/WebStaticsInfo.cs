// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebStaticsInfo : TeaModel {
        [NameInMap("CpuUsage")]
        [Validation(Required=false)]
        public long? CpuUsage { get; set; }

        [NameInMap("InternetTrafficOut")]
        [Validation(Required=false)]
        public long? InternetTrafficOut { get; set; }

        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public long? Invocations { get; set; }

        [NameInMap("MemoryUsage")]
        [Validation(Required=false)]
        public long? MemoryUsage { get; set; }

    }

}
