// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListMqttClientSubscriptionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientSubscriptions")]
        [Validation(Required=false)]
        public ListMqttClientSubscriptionsResponseBodyClientSubscriptions ClientSubscriptions { get; set; }
        public class ListMqttClientSubscriptionsResponseBodyClientSubscriptions : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMqttClientSubscriptionsResponseBodyClientSubscriptionsList> List { get; set; }
            public class ListMqttClientSubscriptionsResponseBodyClientSubscriptionsList : TeaModel {
                public string Topic { get; set; }
                public int? QoS { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListMqttClientSubscriptionsResponseBodyClientSubscriptionsPagination Pagination { get; set; }
            public class ListMqttClientSubscriptionsResponseBodyClientSubscriptionsPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

    }

}
