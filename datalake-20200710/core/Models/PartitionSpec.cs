// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PartitionSpec : TeaModel {
        [NameInMap("SharedSDPartitions")]
        [Validation(Required=false)]
        public List<Partition> SharedSDPartitions { get; set; }

        [NameInMap("SharedStorageDescriptor")]
        [Validation(Required=false)]
        public PartitionSpecSharedStorageDescriptor SharedStorageDescriptor { get; set; }
        public class PartitionSpecSharedStorageDescriptor : TeaModel {
            [NameInMap("Cols")]
            [Validation(Required=false)]
            public List<FieldSchema> Cols { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

    }

}
