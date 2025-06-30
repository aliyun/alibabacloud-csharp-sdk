// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ResourceSpec : TeaModel {
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        [NameInMap("diskNumber")]
        [Validation(Required=false)]
        public int? DiskNumber { get; set; }

        [NameInMap("localStorageInstanceType")]
        [Validation(Required=false)]
        public string LocalStorageInstanceType { get; set; }

        [NameInMap("nodeNumber")]
        [Validation(Required=false)]
        public int? NodeNumber { get; set; }

        [NameInMap("specType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        [NameInMap("storagePerformanceLevel")]
        [Validation(Required=false)]
        public string StoragePerformanceLevel { get; set; }

        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

    }

}
