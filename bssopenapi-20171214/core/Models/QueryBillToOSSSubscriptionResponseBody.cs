// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillToOSSSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBillToOSSSubscriptionResponseBodyData Data { get; set; }
        public class QueryBillToOSSSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the account used to perform the query.
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// The name of the account used to perform the query.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The details of the subscribed bill.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryBillToOSSSubscriptionResponseBodyDataItems Items { get; set; }
            public class QueryBillToOSSSubscriptionResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryBillToOSSSubscriptionResponseBodyDataItemsItem> Item { get; set; }
                public class QueryBillToOSSSubscriptionResponseBodyDataItemsItem : TeaModel {
                    /// <summary>
                    /// The owner ID of the Object Storage Service (OSS) bucket.
                    /// </summary>
                    [NameInMap("BucketOwnerId")]
                    [Validation(Required=false)]
                    public long? BucketOwnerId { get; set; }

                    /// <summary>
                    /// The path in the OSS bucket.
                    /// </summary>
                    [NameInMap("BucketPath")]
                    [Validation(Required=false)]
                    public string BucketPath { get; set; }

                    /// <summary>
                    /// The maximum number of data rows in a single file. If the number of data rows in a bill exceeds the upper limit, the bill is split into multiple files. Then, multiple files are merged and compressed into a package.
                    /// </summary>
                    [NameInMap("RowLimitPerFile")]
                    [Validation(Required=false)]
                    public int? RowLimitPerFile { get; set; }

                    /// <summary>
                    /// The ID of the OSS bucket that stores the subscribed bill.
                    /// </summary>
                    [NameInMap("SubscribeBucket")]
                    [Validation(Required=false)]
                    public string SubscribeBucket { get; set; }

                    /// <summary>
                    /// The code of the language.
                    /// 
                    /// Valid values:
                    /// 
                    /// *   en: English
                    /// *   zh: Chinese
                    /// </summary>
                    [NameInMap("SubscribeLanguage")]
                    [Validation(Required=false)]
                    public string SubscribeLanguage { get; set; }

                    /// <summary>
                    /// The time when the subscribed bill was stored in the OSS bucket. The time is displayed in the YYYY-MM-DD hh:mm:ss format.
                    /// </summary>
                    [NameInMap("SubscribeTime")]
                    [Validation(Required=false)]
                    public string SubscribeTime { get; set; }

                    /// <summary>
                    /// The type of the subscribed bill. Valid values:
                    /// 
                    /// *   BillingItemDetailForBillingPeriod: the bill of a billable item.
                    /// *   InstanceDetailForBillingPeriod: the bill of an instance.
                    /// </summary>
                    [NameInMap("SubscribeType")]
                    [Validation(Required=false)]
                    public string SubscribeType { get; set; }

                }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
