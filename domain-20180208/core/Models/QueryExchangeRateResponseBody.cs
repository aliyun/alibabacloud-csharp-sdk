// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryExchangeRateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7.12</para>
        /// </summary>
        [NameInMap("ExchangeRate")]
        [Validation(Required=false)]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D200000-C0B9-4CD3-B92A-9B44A000000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
