// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionsRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("notFilterScopeObjectDeleted")]
        [Validation(Required=false)]
        public bool? NotFilterScopeObjectDeleted { get; set; }

        [NameInMap("notifyObject")]
        [Validation(Required=false)]
        public string NotifyObject { get; set; }

        [NameInMap("notifyObjectType")]
        [Validation(Required=false)]
        public string NotifyObjectType { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("scopeObject")]
        [Validation(Required=false)]
        public string ScopeObject { get; set; }

        [NameInMap("subscriptionTitle")]
        [Validation(Required=false)]
        public string SubscriptionTitle { get; set; }

    }

}
