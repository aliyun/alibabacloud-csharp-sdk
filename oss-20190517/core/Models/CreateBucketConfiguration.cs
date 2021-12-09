// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CreateBucketConfiguration : TeaModel {
        [NameInMap("DataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
