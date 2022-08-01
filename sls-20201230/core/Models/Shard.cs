// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Shard : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("exclusiveEndKey")]
        [Validation(Required=false)]
        public string ExclusiveEndKey { get; set; }

        [NameInMap("inclusiveBeginKey")]
        [Validation(Required=false)]
        public string InclusiveBeginKey { get; set; }

        [NameInMap("shardID")]
        [Validation(Required=false)]
        public int? ShardID { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
