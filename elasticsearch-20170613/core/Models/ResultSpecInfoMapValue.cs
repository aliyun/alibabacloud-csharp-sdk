// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ResultSpecInfoMapValue : TeaModel {
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public string CpuCount { get; set; }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public string MemorySize { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("specGroupType")]
        [Validation(Required=false)]
        public string SpecGroupType { get; set; }

        [NameInMap("disk")]
        [Validation(Required=false)]
        public string Disk { get; set; }

        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

    }

}
