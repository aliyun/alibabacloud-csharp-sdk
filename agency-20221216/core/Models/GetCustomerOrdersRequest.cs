// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCustomerOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The customer account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_123</para>
        /// </summary>
        [NameInMap("CustomerAccount")]
        [Validation(Required=false)]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// <para>The account manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myBd</para>
        /// </summary>
        [NameInMap("CustomerManager")]
        [Validation(Required=false)]
        public string CustomerManager { get; set; }

        /// <summary>
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        /// <summary>
        /// <para>The end time. This parameter is used in combination with TimeType. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-23 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>209335720330622</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The order source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Regular customer.</description></item>
        /// <item><description>1: Enterprise customer.</description></item>
        /// <item><description>2: Tier-2 distributor.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OrderSource")]
        [Validation(Required=false)]
        public int? OrderSource { get; set; }

        /// <summary>
        /// <para>The order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Unpaid.</description></item>
        /// <item><description>2: Canceled.</description></item>
        /// <item><description>3: Paid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: New purchase.</description></item>
        /// <item><description>UPGRADE: Upgrade.</description></item>
        /// <item><description>DOWNGRADE: Downgrade.</description></item>
        /// <item><description>RENEW: Renewal.</description></item>
        /// <item><description>REFUND: Refund.</description></item>
        /// <item><description>OTHERS: Others.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RENEW</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product detail code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vm_intl</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time. This parameter is used in combination with TimeType. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-13 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The time type used as the basis for the query. This is not a date or time value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Payment time.</description></item>
        /// <item><description>2: Order placement time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

    }

}
