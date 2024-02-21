// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableInstanceDasConfigRequest : TeaModel {
        /// <summary>
        /// The database engine. Set the value to Redis.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of auto scaling. Valid values:
        /// 
        /// *   **specScale**: The specifications of a database instance are automatically scaled up or down.
        /// *   **shardScale**: The number of shards for a database instance is automatically increased or decreased.
        /// *   **bandwidthScale**: The bandwidth of a database instance is automatically increased or decreased.
        /// </summary>
        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

    }

}
