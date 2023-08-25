// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StorageDescriptorModel : TeaModel {
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
        public long? NumBuckets { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("SdId")]
        [Validation(Required=false)]
        public long? SdId { get; set; }

        [NameInMap("SerDeInfo")]
        [Validation(Required=false)]
        public SerDeInfoModel SerDeInfo { get; set; }

        [NameInMap("StoredAsSubDirectories")]
        [Validation(Required=false)]
        public bool? StoredAsSubDirectories { get; set; }

    }

}
