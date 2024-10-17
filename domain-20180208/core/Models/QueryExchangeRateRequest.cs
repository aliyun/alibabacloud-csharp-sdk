// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryExchangeRateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USD</para>
        /// </summary>
        [NameInMap("FromCurrency")]
        [Validation(Required=false)]
        public string FromCurrency { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("ToCurrency")]
        [Validation(Required=false)]
        public string ToCurrency { get; set; }

    }

}
