// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StorageLayer : TeaModel {
        [NameInMap("Archive")]
        [Validation(Required=false)]
        public long? Archive { get; set; }

        [NameInMap("ColdArchive")]
        [Validation(Required=false)]
        public long? ColdArchive { get; set; }

        [NameInMap("Infrequent")]
        [Validation(Required=false)]
        public long? Infrequent { get; set; }

        [NameInMap("Standard")]
        [Validation(Required=false)]
        public long? Standard { get; set; }

        [NameInMap("Unknown")]
        [Validation(Required=false)]
        public long? Unknown { get; set; }

    }

}
