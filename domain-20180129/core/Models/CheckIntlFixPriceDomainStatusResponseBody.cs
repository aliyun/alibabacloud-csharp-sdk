// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckIntlFixPriceDomainStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckIntlFixPriceDomainStatusResponseBodyModule Module { get; set; }
        public class CheckIntlFixPriceDomainStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RMB: Chinese Yuan.</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The expiration date of the domain name. After this date, the domain name requires renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("DeadDate")]
            [Validation(Required=false)]
            public long? DeadDate { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The sale deadline of the domain name. After this time, the domain name is no longer available for sale.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is a premium domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The domain name is a premium domain name.</para>
            /// </description></item>
            /// <item><description><para>false: The domain name is not a premium domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Premium")]
            [Validation(Required=false)]
            public bool? Premium { get; set; }

            /// <summary>
            /// <para>The price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// <para>The registration date of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1566353497</para>
            /// </summary>
            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public long? RegDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40F46D3D-F4F3-4CCB-AC30-2DD20E32E528</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
