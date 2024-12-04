// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Shard : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1453949705</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("exclusiveEndKey")]
        [Validation(Required=false)]
        public string ExclusiveEndKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("inclusiveBeginKey")]
        [Validation(Required=false)]
        public string InclusiveBeginKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("shardID")]
        [Validation(Required=false)]
        public int? ShardID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>readwrite</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
