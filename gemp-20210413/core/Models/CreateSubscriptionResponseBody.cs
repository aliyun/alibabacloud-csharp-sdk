// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// request id
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateSubscriptionResponseBodyData Data { get; set; }
        public class CreateSubscriptionResponseBodyData : TeaModel {
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public long? SubscriptionId { get; set; }
        };

    }

}
