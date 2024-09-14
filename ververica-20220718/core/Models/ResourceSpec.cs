// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ResourceSpec : TeaModel {
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public double? Cpu { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
