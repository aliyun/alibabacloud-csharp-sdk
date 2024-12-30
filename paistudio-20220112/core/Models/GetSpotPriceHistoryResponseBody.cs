// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetSpotPriceHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8BDA4440-DD3C-5F4B-BBDD-94A9CE1E75C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpotPriceHistory")]
        [Validation(Required=false)]
        public List<SpotPriceItem> SpotPriceHistory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>194</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
