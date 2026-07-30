// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelGoodsQueryRequest : TeaModel {
        /// <summary>
        /// <para>The number of adults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        /// <summary>
        /// <para>Specifies whether the price is a negotiated rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("agreement_price")]
        [Validation(Required=false)]
        public bool? AgreementPrice { get; set; }

        /// <summary>
        /// <para>The start date in yyyy-MM-dd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-27</para>
        /// </summary>
        [NameInMap("begin_date")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <para>Specifies whether breakfast is included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("breakfast_included")]
        [Validation(Required=false)]
        public bool? BreakfastIncluded { get; set; }

        /// <summary>
        /// <para>The user ID. If organization members are synchronized, use btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The city code. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <para>The end date in yyyy-MM-dd format. The maximum span between check-in and check-out dates per query is 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-28</para>
        /// </summary>
        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The hotel code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182873</para>
        /// </summary>
        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>Specifies whether mixed payment is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Supported.</description></item>
        /// <item><description>1: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pay_over_type")]
        [Validation(Required=false)]
        public int? PayOverType { get; set; }

        /// <summary>
        /// <para>The payment method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: corporate payment.</description></item>
        /// <item><description>1: personal payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        /// <summary>
        /// <para>Specifies whether special VAT invoices are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("special_invoice")]
        [Validation(Required=false)]
        public bool? SpecialInvoice { get; set; }

        /// <summary>
        /// <para>The role type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: regular user.</description></item>
        /// <item><description>1: special applicant.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
