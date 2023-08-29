// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LocationStorageRankDTO : TeaModel {
        [NameInMap("FileCnt")]
        [Validation(Required=false)]
        public long? FileCnt { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public long? Storage { get; set; }

    }

}
