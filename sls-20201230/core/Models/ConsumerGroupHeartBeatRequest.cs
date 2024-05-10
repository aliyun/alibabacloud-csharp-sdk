// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConsumerGroupHeartBeatRequest : TeaModel {
        /// <summary>
        /// The IDs of shards whose data is being consumed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<int?> Body { get; set; }

        /// <summary>
        /// The consumer.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

    }

}
