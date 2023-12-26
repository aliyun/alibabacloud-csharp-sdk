// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class ImportServiceDataShrinkRequest : TeaModel {
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public string PartitionShrink { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("SubPath")]
        [Validation(Required=false)]
        public string SubPath { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
