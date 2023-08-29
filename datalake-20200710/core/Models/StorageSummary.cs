// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StorageSummary : TeaModel {
        [NameInMap("DatabaseNum")]
        [Validation(Required=false)]
        public int? DatabaseNum { get; set; }

        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        [NameInMap("TableNum")]
        [Validation(Required=false)]
        public int? TableNum { get; set; }

    }

}
