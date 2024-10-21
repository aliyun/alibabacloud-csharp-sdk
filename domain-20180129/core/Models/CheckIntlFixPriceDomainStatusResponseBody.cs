// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckIntlFixPriceDomainStatusResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckIntlFixPriceDomainStatusResponseBodyModule Module { get; set; }
        public class CheckIntlFixPriceDomainStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("DeadDate")]
            [Validation(Required=false)]
            public long? DeadDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Premium")]
            [Validation(Required=false)]
            public bool? Premium { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1566353497</para>
            /// </summary>
            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public long? RegDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40F46D3D-F4F3-4CCB-AC30-2DD20E32E528</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
