// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Shard : TeaModel {
        /// <summary>
        /// createTime
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// exclusiveEndKey
        /// </summary>
        [NameInMap("exclusiveEndKey")]
        [Validation(Required=false)]
        public string ExclusiveEndKey { get; set; }

        /// <summary>
        /// inclusiveBeginKey
        /// </summary>
        [NameInMap("inclusiveBeginKey")]
        [Validation(Required=false)]
        public string InclusiveBeginKey { get; set; }

        /// <summary>
        /// shard id
        /// </summary>
        [NameInMap("shardId")]
        [Validation(Required=false)]
        public int? ShardId { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
