// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class VerifyConsumeMessageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

    }

}
