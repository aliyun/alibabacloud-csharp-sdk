// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PartitionError : TeaModel {
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ErrorDetail ErrorDetail { get; set; }

        [NameInMap("PartitionValues")]
        [Validation(Required=false)]
        public List<string> PartitionValues { get; set; }

    }

}
