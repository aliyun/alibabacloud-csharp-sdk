// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConsumerGroupUpdateCheckPointRequest : TeaModel {
        /// <summary>
        /// The value of the checkpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// The ID of the shard.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        /// <summary>
        /// The consumer.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        /// <summary>
        /// Specifies whether to enable forceful updates. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("forceSuccess")]
        [Validation(Required=false)]
        public bool? ForceSuccess { get; set; }

    }

}
