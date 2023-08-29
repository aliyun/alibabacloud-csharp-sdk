// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class DatabaseProfile : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("FileCnt")]
        [Validation(Required=false)]
        public long? FileCnt { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("LatestDate")]
        [Validation(Required=false)]
        public string LatestDate { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ObjectCnt")]
        [Validation(Required=false)]
        public long? ObjectCnt { get; set; }

        [NameInMap("ObjectSize")]
        [Validation(Required=false)]
        public long? ObjectSize { get; set; }

    }

}
