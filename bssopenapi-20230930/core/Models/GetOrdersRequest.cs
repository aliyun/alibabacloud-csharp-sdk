// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The end of the order creation time range. If not specified, orders created within the most recent hour are queried. Format: YYYY-MM-ddTHH:mm:ssZ. Time zone: UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the order creation time range. If not specified, orders created within the most recent hour are queried. Format: YYYY-MM-ddTHH:mm:ssZ. Time zone: UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T13:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The UID of a member account in an enterprise with multiple member accounts. Leave this parameter empty if this scenario does not apply.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779628988149763</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>New: new purchase.</description></item>
        /// <item><description>Renew: renewal.</description></item>
        /// <item><description>Upgrade: upgrade.</description></item>
        /// <item><description>TempUpgrade: temporary upgrade.</description></item>
        /// <item><description>Downgrade: downgrade.</description></item>
        /// <item><description>Refund: refund.</description></item>
        /// <item><description>Convert: billing method conversion.</description></item>
        /// <item><description>ResizeDisk: cloud disk resizing.</description></item>
        /// <item><description>CompensatoryRenew: compensatory renewal.</description></item>
        /// <item><description>IncreaseUpgrade: bandwidth upgrade.</description></item>
        /// <item><description>Exchange: exchange.</description></item>
        /// <item><description>ChangeOperatingSystem: operating system change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>New</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The payment status. For non-refund orders, valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unpaid: unpaid.</description></item>
        /// <item><description>Paid: paid.</description></item>
        /// <item><description>Cancelled: canceled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For refund orders, set this parameter to NULL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Paid</para>
        /// </summary>
        [NameInMap("PaymentStatus")]
        [Validation(Required=false)]
        public string PaymentStatus { get; set; }

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
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: upfront.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
