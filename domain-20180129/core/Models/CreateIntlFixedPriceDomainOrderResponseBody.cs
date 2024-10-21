// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CreateIntlFixedPriceDomainOrderResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateIntlFixedPriceDomainOrderResponseBodyModule Module { get; set; }
        public class CreateIntlFixedPriceDomainOrderResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31199295f2074ce895645d386cb2****</para>
            /// </summary>
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("PayPrice")]
            [Validation(Required=false)]
            public long? PayPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://</para>
            /// </summary>
            [NameInMap("PayUrl")]
            [Validation(Required=false)]
            public string PayUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E879DC07-38EE-4408-9F33-73B30CD965CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
