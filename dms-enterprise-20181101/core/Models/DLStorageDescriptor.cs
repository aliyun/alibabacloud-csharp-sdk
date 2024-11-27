// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLStorageDescriptor : TeaModel {
        [NameInMap("BucketCols")]
        [Validation(Required=false)]
        public List<string> BucketCols { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<DLColumn> Columns { get; set; }

        [NameInMap("InputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        [NameInMap("IsCompressed")]
        [Validation(Required=false)]
        public bool? IsCompressed { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("NumBuckets")]
        [Validation(Required=false)]
        public int? NumBuckets { get; set; }

        [NameInMap("OriginalColumns")]
        [Validation(Required=false)]
        public List<DLColumn> OriginalColumns { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("SerdeInfo")]
        [Validation(Required=false)]
        public DLSerdeInfo SerdeInfo { get; set; }

        [NameInMap("SkewedInfo")]
        [Validation(Required=false)]
        public DLSkewedInfo SkewedInfo { get; set; }

        [NameInMap("SortCols")]
        [Validation(Required=false)]
        public List<DLOrder> SortCols { get; set; }

    }

}
