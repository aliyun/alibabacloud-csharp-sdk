// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ResetConsumeOffsetRequest : TeaModel {
        /// <summary>
        /// The time when the consumer offset is reset.
        /// </summary>
        [NameInMap("resetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        /// <summary>
        /// The method that is used to reset the consumer offset. Valid values: LATEST_OFFSET and SPECIFIED_TIME.
        /// </summary>
        [NameInMap("resetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
