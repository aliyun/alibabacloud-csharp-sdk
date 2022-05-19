// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillToOSSSubscriptionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBillToOSSSubscriptionResponseBodyData Data { get; set; }
        public class QueryBillToOSSSubscriptionResponseBodyData : TeaModel {
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryBillToOSSSubscriptionResponseBodyDataItems Items { get; set; }
            public class QueryBillToOSSSubscriptionResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryBillToOSSSubscriptionResponseBodyDataItemsItem> Item { get; set; }
                public class QueryBillToOSSSubscriptionResponseBodyDataItemsItem : TeaModel {
                    [NameInMap("BucketOwnerId")]
                    [Validation(Required=false)]
                    public long? BucketOwnerId { get; set; }

                    [NameInMap("BucketPath")]
                    [Validation(Required=false)]
                    public string BucketPath { get; set; }

                    [NameInMap("SubscribeBucket")]
                    [Validation(Required=false)]
                    public string SubscribeBucket { get; set; }

                    [NameInMap("SubscribeLanguage")]
                    [Validation(Required=false)]
                    public string SubscribeLanguage { get; set; }

                    [NameInMap("SubscribeTime")]
                    [Validation(Required=false)]
                    public string SubscribeTime { get; set; }

                    [NameInMap("SubscribeType")]
                    [Validation(Required=false)]
                    public string SubscribeType { get; set; }

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
