// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StorageRankDTO : TeaModel {
        [NameInMap("dbStorageRank")]
        [Validation(Required=false)]
        public List<DbStorageRank> DbStorageRank { get; set; }

        [NameInMap("smallFileCntRank")]
        [Validation(Required=false)]
        public List<SmallFileCntRank> SmallFileCntRank { get; set; }

        [NameInMap("tableStorageRank")]
        [Validation(Required=false)]
        public List<TableStorageRank> TableStorageRank { get; set; }

    }

}
