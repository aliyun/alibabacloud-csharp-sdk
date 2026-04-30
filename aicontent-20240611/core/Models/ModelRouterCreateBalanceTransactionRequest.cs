// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateBalanceTransactionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>充值</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
