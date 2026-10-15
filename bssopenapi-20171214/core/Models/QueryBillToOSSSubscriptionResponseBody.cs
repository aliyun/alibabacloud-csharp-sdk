// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillToOSSSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBillToOSSSubscriptionResponseBodyData Data { get; set; }
        public class QueryBillToOSSSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the current query account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185xxxxx03489</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The name of the current query account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
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

                    [NameInMap("RowLimitPerFile")]
                    [Validation(Required=false)]
                    public int? RowLimitPerFile { get; set; }

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

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9EEAE43F-1E4D-4734-AE93-5049878AC103</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
