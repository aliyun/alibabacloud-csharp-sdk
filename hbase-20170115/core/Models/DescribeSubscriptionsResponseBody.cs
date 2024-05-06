// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeSubscriptionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Subscriptions")]
        [Validation(Required=false)]
        public List<DescribeSubscriptionsResponseBodySubscriptions> Subscriptions { get; set; }
        public class DescribeSubscriptionsResponseBodySubscriptions : TeaModel {
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionsResponseBodySubscriptionsDBInstances> DBInstances { get; set; }
            public class DescribeSubscriptionsResponseBodySubscriptionsDBInstances : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            [NameInMap("Mapping")]
            [Validation(Required=false)]
            public string Mapping { get; set; }

            [NameInMap("SubscriptionDescription")]
            [Validation(Required=false)]
            public string SubscriptionDescription { get; set; }

            [NameInMap("SubscriptionId")]
            [Validation(Required=false)]
            public string SubscriptionId { get; set; }

            [NameInMap("SubscriptionStatus")]
            [Validation(Required=false)]
            public string SubscriptionStatus { get; set; }

            [NameInMap("SubscriptionType")]
            [Validation(Required=false)]
            public string SubscriptionType { get; set; }

        }

    }

}
