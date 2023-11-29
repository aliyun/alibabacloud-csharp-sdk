// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SplitShardRequest : TeaModel {
        /// <summary>
        /// The position where the shard is split.
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The number of new shards that are generated after splitting.
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

    }

}
