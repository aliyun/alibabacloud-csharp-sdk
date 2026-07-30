// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightPayOrderRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise payment amount, in cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>The external order ID of the distribution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <para>The personal payment amount, in cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("personal_pay_price")]
        [Validation(Required=false)]
        public long? PersonalPayPrice { get; set; }

        /// <summary>
        /// <para>The total payment amount of the order, in cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_pay_price")]
        [Validation(Required=false)]
        public long? TotalPayPrice { get; set; }

    }

}
