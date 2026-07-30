// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleItemListFlightRuleInfosValue : TeaModel {
        /// <summary>
        /// <para>The refund/change rule summary.&gt;Notice: This may not always be available. Returns null by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>退改规则简述</para>
        /// </summary>
        [NameInMap("refund_change_rule_desc")]
        [Validation(Required=false)]
        public string RefundChangeRuleDesc { get; set; }

        /// <summary>
        /// <para>The baggage allowance rule summary.&gt;Notice: This may not always be available. Returns null by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行李额规则简述</para>
        /// </summary>
        [NameInMap("baggage_desc")]
        [Validation(Required=false)]
        public string BaggageDesc { get; set; }

    }

}
