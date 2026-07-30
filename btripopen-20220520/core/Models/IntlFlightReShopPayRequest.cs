// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopPayRequest : TeaModel {
        /// <summary>
        /// <para>The business travel order ID. Required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017035200059399795</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JPT2025032400000001</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The external change application ID. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JPM20241024354</para>
        /// </summary>
        [NameInMap("out_re_shop_apply_id")]
        [Validation(Required=false)]
        public string OutReShopApplyId { get; set; }

        /// <summary>
        /// <para>The change application ID. Required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019202345889633</para>
        /// </summary>
        [NameInMap("re_shop_apply_id")]
        [Validation(Required=false)]
        public string ReShopApplyId { get; set; }

    }

}
