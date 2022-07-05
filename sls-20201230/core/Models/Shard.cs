// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Shard : TeaModel {
        /// <summary>
        /// Shard的创建时间。Unix时间戳格式，表示从1970-1-1 00:00:00 UTC计算起的秒数。
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 指定Shard范围的结束值，Shard范围中不包含该值。即 shard 包含MD5值在 [inclusiveBeginKey, exclusiveEndKey) 之间的日志。
        /// </summary>
        [NameInMap("exclusiveEndKey")]
        [Validation(Required=false)]
        public string ExclusiveEndKey { get; set; }

        /// <summary>
        /// 指定Shard范围的起始值，Shard范围中包含该值。即 shard 包含MD5值在 [inclusiveBeginKey, exclusiveEndKey) 之间的日志。
        /// </summary>
        [NameInMap("inclusiveBeginKey")]
        [Validation(Required=false)]
        public string InclusiveBeginKey { get; set; }

        /// <summary>
        /// shard id
        /// </summary>
        [NameInMap("shardID")]
        [Validation(Required=false)]
        public int? ShardID { get; set; }

        /// <summary>
        /// shard 的读写状态，readwrite 或者 readonly。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
