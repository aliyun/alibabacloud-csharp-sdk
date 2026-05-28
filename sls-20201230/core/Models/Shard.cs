// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Shard : TeaModel {
        /// <summary>
        /// <para>The time at which the shard was created. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1524222931</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>The end of the MD5 hash range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("exclusiveEndKey")]
        [Validation(Required=false)]
        public string ExclusiveEndKey { get; set; }

        /// <summary>
        /// <para>The start of the MD5 hash range. The value is included in the MD5 hash range of the shard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("inclusiveBeginKey")]
        [Validation(Required=false)]
        public string InclusiveBeginKey { get; set; }

        /// <summary>
        /// <para>shard id</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("shardID")]
        [Validation(Required=false)]
        public int? ShardID { get; set; }

        /// <summary>
        /// <para>The status of the shard. After you create a shard, the shard enters the readwrite state. If you split a shard or merge shards, the shard status changes to readonly. The newly generated shards are in the readwrite state. The status of a shard does not affect the performance of read operations that are performed on the shard. Data can be written to the shards that are in the readwrite state, but data cannot be written to the shards that are in the readonly state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>readwrite</description></item>
        /// <item><description>readonly</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>readwrite</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
