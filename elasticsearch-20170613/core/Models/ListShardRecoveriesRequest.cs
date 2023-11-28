// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return information about data restoration of shards. Valid values:
        /// 
        /// *   true: returns information about data restoration of shards that are being restored.
        /// *   false: returns information about data restoration of all shards.
        /// </summary>
        [NameInMap("activeOnly")]
        [Validation(Required=false)]
        public bool? ActiveOnly { get; set; }

    }

}
