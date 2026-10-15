// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource ownership account. The resource ownership account is the account that actually uses the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle. Format: YYYY-MM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when Granularity is set to DAILY. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-02</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity at which bills are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTHLY: monthly. This value corresponds to the monthly bills on the Split Bill page in the User Center.</description></item>
        /// <item><description>DAILY: daily. This value corresponds to the daily bills on the Split Bill page in the User Center.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to DAILY, you must specify the BillingDate parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-kjhdskjgshfdlkjfdh</para>
        /// </summary>
        [NameInMap("InstanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out bills where both the original price (PretaxGrossAmount) and the payable amount (PretaxAmount) are 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: does not filter out the bills.</description></item>
        /// <item><description>true: filters out the bills.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in the current call. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which the current call starts to read data. The value must be empty or the value of NextToken returned in the previous response. Otherwise, an error occurs. An empty value indicates that the read operation starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCmd</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The product code. This value is the same as the product code in the bills of the User Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("PipCode")]
        [Validation(Required=false)]
        public string PipCode { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the attached resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-kjhdskjgshfdlkjfdh</para>
        /// </summary>
        [NameInMap("SplitItemID")]
        [Validation(Required=false)]
        public string SplitItemID { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be used together with the ProductCode parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// <para>The tag filter conditions. Multiple sets of TagValues query conditions are supported. The logical relationship between multiple sets of TagValues conditions is OR.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<DescribeSplitItemBillRequestTagFilter> TagFilter { get; set; }
        public class DescribeSplitItemBillRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>TagFilter.N is used to query bills that match the specified tags. It consists of a key-value pair. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>If you specify only TagFilter.N.TagKey, all bills associated with the tag key are returned.</description></item>
            /// <item><description>If you specify multiple tag key-value pairs, bills that match any of the tag key-value pairs are returned.</description></item>
            /// <item><description>If the tags on a resource change, you can only query the bills generated during the period when the tags were attached to the resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>TagValues.N is used to query bills that match the specified tag values. It consists of a list of strings. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>If you specify TagValues.N, you must also specify TagFilter.N.TagKey. Otherwise, the InvalidParameter.TagValues error is reported.</description></item>
            /// <item><description>If you specify multiple tag values, bills that match any of the tag values are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
