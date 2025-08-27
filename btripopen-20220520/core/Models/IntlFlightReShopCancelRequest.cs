// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopCancelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017035199763856322</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JPT2025032400000001</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JPM20241024354</para>
        /// </summary>
        [NameInMap("out_re_shop_apply_id")]
        [Validation(Required=false)]
        public string OutReShopApplyId { get; set; }

        /// <summary>
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
