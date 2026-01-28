// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaTableEngineMeta : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DataBytes")]
        [Validation(Required=false)]
        public long? DataBytes { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IndexBytes")]
        [Validation(Required=false)]
        public long? IndexBytes { get; set; }

        [NameInMap("LastDdlTime")]
        [Validation(Required=false)]
        public string LastDdlTime { get; set; }

        [NameInMap("NumRows")]
        [Validation(Required=false)]
        public long? NumRows { get; set; }

        [NameInMap("RefInfo")]
        [Validation(Required=false)]
        public string RefInfo { get; set; }

        [NameInMap("StorageCapacity")]
        [Validation(Required=false)]
        public long? StorageCapacity { get; set; }

        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
