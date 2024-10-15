// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPayRequest : TeaModel {
        /// <summary>
        /// <para>供应商订单号（取自创单返回的订单号）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002202194207077022</para>
        /// </summary>
        [NameInMap("btrip_order_id")]
        [Validation(Required=false)]
        public long? BtripOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23918781</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("company_pay_fee")]
        [Validation(Required=false)]
        public long? CompanyPayFee { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("person_pay_fee")]
        [Validation(Required=false)]
        public long? PersonPayFee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("third_pay_account")]
        [Validation(Required=false)]
        public string ThirdPayAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("third_trade_no")]
        [Validation(Required=false)]
        public string ThirdTradeNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
