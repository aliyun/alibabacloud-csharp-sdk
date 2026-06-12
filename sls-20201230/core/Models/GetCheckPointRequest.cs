// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCheckPointRequest : TeaModel {
        /// <summary>
        /// <para>The shard ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the specified shard does not exist, an empty list is returned.</para>
        /// </description></item>
        /// <item><description><para>If no shard ID is specified, the checkpoints of all shards are returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

    }

}
