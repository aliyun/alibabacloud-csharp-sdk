// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StorageDescriptor : TeaModel {
        [NameInMap("BucketCols")]
        [Validation(Required=false)]
        public List<string> BucketCols { get; set; }

        [NameInMap("Cols")]
        [Validation(Required=false)]
        public List<FieldSchema> Cols { get; set; }

        [NameInMap("Compressed")]
        [Validation(Required=false)]
        public bool? Compressed { get; set; }

        [NameInMap("InputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("NumBuckets")]
        [Validation(Required=false)]
        public int? NumBuckets { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("SerDeInfo")]
        [Validation(Required=false)]
        public SerDeInfo SerDeInfo { get; set; }

        [NameInMap("SkewedInfo")]
        [Validation(Required=false)]
        public SkewedInfo SkewedInfo { get; set; }

        [NameInMap("SortCols")]
        [Validation(Required=false)]
        public List<Order> SortCols { get; set; }

        [NameInMap("StoredAsSubDirectories")]
        [Validation(Required=false)]
        public bool? StoredAsSubDirectories { get; set; }

    }

}
