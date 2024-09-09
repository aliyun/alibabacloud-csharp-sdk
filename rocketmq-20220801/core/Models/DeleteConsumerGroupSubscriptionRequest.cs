// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DeleteConsumerGroupSubscriptionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("filterExpression")]
        [Validation(Required=false)]
        public string FilterExpression { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
