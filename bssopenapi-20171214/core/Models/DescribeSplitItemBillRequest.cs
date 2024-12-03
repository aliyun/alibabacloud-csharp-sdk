// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member. If you specify this parameter, the bills of the member are queried. If you do not specify this parameter, the bills of the current account are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle. Specify the parameter in the YYYY-MM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when the Granularity parameter is set to DAILY. Format: YYYY-MM-DD.</para>
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
        /// <item><description>MONTHLY: queries bills on a monthly basis. The data that you query is the same as the data that is queried by billing cycles in the Split Bill module of the User Center console.</description></item>
        /// <item><description>DAILY: queries bills on a daily basis. The data that you query is the same as the data that is queried by days in the Split Bill module of the User Center console.</description></item>
        /// </list>
        /// <para>If you specify DAILY for this parameter, the BillingDate parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-kjhdskjgshfdlkjfdh</para>
        /// </summary>
        [NameInMap("InstanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter bills if both the pretax gross amount and pretax amount are 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: does not filter bills.</description></item>
        /// <item><description>true: filters bills.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to query. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. The parameter must be left empty or set to the value of the NextToken parameter returned in the last call. Otherwise, an error is returned. If the parameter is left empty, the data is queried from the first entry.</para>
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
        /// <para>The code of the service. The code is the same as that in Cost Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("PipCode")]
        [Validation(Required=false)]
        public string PipCode { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the split item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-kjhdskjgshfdlkjfdh</para>
        /// </summary>
        [NameInMap("SplitItemID")]
        [Validation(Required=false)]
        public string SplitItemID { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: Subscription: the subscription billing method. PayAsYouGo: the pay-as-you-go billing method. This parameter must be used with the ProductCode parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// <para>The tags that are used to filter split bills. You can specify multiple tag values. If you specify multiple tag values, split bills that match one of the tag values are queried.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<DescribeSplitItemBillRequestTagFilter> TagFilter { get; set; }
        public class DescribeSplitItemBillRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The TagFilter.N parameter is used to query bills that match a specified tag. The value of the TagFilter.N parameter must be a key-value pair. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>If only the TagFilter.N.TagKey parameter is specified, all bills associated with the tag key are queried.</description></item>
            /// <item><description>If you specify multiple tag key-value pairs at the same time, bills that meet any one of the tag key-value pairs are queried.</description></item>
            /// <item><description>If the tags added to resources change, you can query only the bills that are generated within the period in which the tags and resources are associated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>You can specify the TagValues.N parameter to query bills that match the specified tag value. The value of the TagValues.N parameter must be a string. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>If you specify the TagValues.N parameter, the TagFilter.N.TagKey parameter is required. Otherwise, the error message InvalidParameter.TagValues is returned.</description></item>
            /// <item><description>If you specify multiple tag values, split bills that match one of the tag values are queried.</description></item>
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
