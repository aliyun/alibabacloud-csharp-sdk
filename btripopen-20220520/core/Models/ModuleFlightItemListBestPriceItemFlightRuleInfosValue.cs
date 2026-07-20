// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListBestPriceItemFlightRuleInfosValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>退改规则简述</para>
        /// </summary>
        [NameInMap("refund_change_rule_desc")]
        [Validation(Required=false)]
        public string RefundChangeRuleDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>行李额规则简述</para>
        /// </summary>
        [NameInMap("baggage_desc")]
        [Validation(Required=false)]
        public string BaggageDesc { get; set; }

    }

}
