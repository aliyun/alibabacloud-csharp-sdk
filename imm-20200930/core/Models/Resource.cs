// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Resource : TeaModel {
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public long? CPU { get; set; }

        [NameInMap("ECSInstance")]
        [Validation(Required=false)]
        public string ECSInstance { get; set; }

        [NameInMap("GPUModel")]
        [Validation(Required=false)]
        public string GPUModel { get; set; }

        [NameInMap("GPUNum")]
        [Validation(Required=false)]
        public long? GPUNum { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RAM")]
        [Validation(Required=false)]
        public long? RAM { get; set; }

    }

}
