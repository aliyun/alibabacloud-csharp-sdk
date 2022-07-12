// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateCheckPointRequest : TeaModel {
        /// <summary>
        /// checkpoint值。
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// shard 的 id。
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        /// <summary>
        /// 消费者。
        /// </summary>
        [NameInMap("consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        /// <summary>
        /// 当不指定消费者时，必须指定forceSuccess为true才能更新checkpoint。
        /// </summary>
        [NameInMap("forceSuccess")]
        [Validation(Required=false)]
        public bool? ForceSuccess { get; set; }

        /// <summary>
        /// 固定为 checkpoint。
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
