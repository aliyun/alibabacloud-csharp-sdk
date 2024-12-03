// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillToOSSSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
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
            /// <para>The ID of the account used to perform the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185xxxxx03489</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The name of the account used to perform the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The details of the subscribed bill.</para>
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
                    /// <para>The owner ID of the Object Storage Service (OSS) bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1369168081849304</para>
                    /// </summary>
                    [NameInMap("BucketOwnerId")]
                    [Validation(Required=false)]
                    public long? BucketOwnerId { get; set; }

                    /// <summary>
                    /// <para>The path in the OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Billing/BillingItemDetailMonthly/</para>
                    /// </summary>
                    [NameInMap("BucketPath")]
                    [Validation(Required=false)]
                    public string BucketPath { get; set; }

                    /// <summary>
                    /// <para>The maximum number of data rows in a single file. If the number of data rows in a bill exceeds the upper limit, the bill is split into multiple files. Then, multiple files are merged and compressed into a package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000</para>
                    /// </summary>
                    [NameInMap("RowLimitPerFile")]
                    [Validation(Required=false)]
                    public int? RowLimitPerFile { get; set; }

                    /// <summary>
                    /// <para>The ID of the OSS bucket that stores the subscribed bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>billingtestbucket</para>
                    /// </summary>
                    [NameInMap("SubscribeBucket")]
                    [Validation(Required=false)]
                    public string SubscribeBucket { get; set; }

                    /// <summary>
                    /// <para>The code of the language.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>en: English</description></item>
                    /// <item><description>zh: Chinese</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("SubscribeLanguage")]
                    [Validation(Required=false)]
                    public string SubscribeLanguage { get; set; }

                    /// <summary>
                    /// <para>The time when the subscribed bill was stored in the OSS bucket. The time is displayed in the YYYY-MM-DD hh:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-10-30 15:40:11</para>
                    /// </summary>
                    [NameInMap("SubscribeTime")]
                    [Validation(Required=false)]
                    public string SubscribeTime { get; set; }

                    /// <summary>
                    /// <para>The type of the subscribed bill. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BillingItemDetailForBillingPeriod: the bill of a billable item.</description></item>
                    /// <item><description>InstanceDetailForBillingPeriod: the bill of an instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BillingItemDetailForBillingPeriod</para>
                    /// </summary>
                    [NameInMap("SubscribeType")]
                    [Validation(Required=false)]
                    public string SubscribeType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9EEAE43F-1E4D-4734-AE93-5049878AC103</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
