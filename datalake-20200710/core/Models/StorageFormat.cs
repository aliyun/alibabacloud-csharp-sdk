// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StorageFormat : TeaModel {
        [NameInMap("Avro")]
        [Validation(Required=false)]
        public long? Avro { get; set; }

        [NameInMap("Csv")]
        [Validation(Required=false)]
        public long? Csv { get; set; }

        [NameInMap("Delta")]
        [Validation(Required=false)]
        public long? Delta { get; set; }

        [NameInMap("Hudi")]
        [Validation(Required=false)]
        public long? Hudi { get; set; }

        [NameInMap("Iceberg")]
        [Validation(Required=false)]
        public long? Iceberg { get; set; }

        [NameInMap("Json")]
        [Validation(Required=false)]
        public long? Json { get; set; }

        [NameInMap("Orc")]
        [Validation(Required=false)]
        public long? Orc { get; set; }

        [NameInMap("Parquet")]
        [Validation(Required=false)]
        public long? Parquet { get; set; }

        [NameInMap("Uncategorized")]
        [Validation(Required=false)]
        public long? Uncategorized { get; set; }

    }

}
