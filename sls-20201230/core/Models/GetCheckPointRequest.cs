// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCheckPointRequest : TeaModel {
        /// <summary>
        /// The shard ID.
        /// 
        /// *   If the specified shard does not exist, an empty list is returned.
        /// *   If no shard ID is specified, the checkpoints of all shards are returned.
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

    }

}
