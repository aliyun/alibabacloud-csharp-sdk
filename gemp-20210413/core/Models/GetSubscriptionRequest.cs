// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSubscriptionRequest : TeaModel {
        [NameInMap("notFilterScopeObjectDeleted")]
        [Validation(Required=false)]
        public bool? NotFilterScopeObjectDeleted { get; set; }

        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public long? SubscriptionId { get; set; }

    }

}
