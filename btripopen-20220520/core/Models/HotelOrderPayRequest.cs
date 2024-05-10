// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPayRequest : TeaModel {
        /// <summary>
        /// 供应商订单号（取自创单返回的订单号）
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_order_id")]
        [Validation(Required=false)]
        public long? BtripOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("company_pay_fee")]
        [Validation(Required=false)]
        public long? CompanyPayFee { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("person_pay_fee")]
        [Validation(Required=false)]
        public long? PersonPayFee { get; set; }

        [NameInMap("third_pay_account")]
        [Validation(Required=false)]
        public string ThirdPayAccount { get; set; }

        [NameInMap("third_trade_no")]
        [Validation(Required=false)]
        public string ThirdTradeNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
