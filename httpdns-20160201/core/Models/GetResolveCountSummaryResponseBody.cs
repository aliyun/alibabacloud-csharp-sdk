// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetResolveCountSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3106FFF3-3612-542A-B2CD-3CF4CD48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics result.</para>
        /// </summary>
        [NameInMap("ResolveSummary")]
        [Validation(Required=false)]
        public GetResolveCountSummaryResponseBodyResolveSummary ResolveSummary { get; set; }
        public class GetResolveCountSummaryResponseBodyResolveSummary : TeaModel {
            [NameInMap("Doh")]
            [Validation(Required=false)]
            public long? Doh { get; set; }

            /// <summary>
            /// <para>The number of IPv4 HTTP resolution requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Http")]
            [Validation(Required=false)]
            public long? Http { get; set; }

            /// <summary>
            /// <para>The number of IPv6 HTTP resolution requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Http6")]
            [Validation(Required=false)]
            public long? Http6 { get; set; }

            [NameInMap("HttpAes")]
            [Validation(Required=false)]
            public string HttpAes { get; set; }

            /// <summary>
            /// <para>The number of IPv4 HTTPS resolution requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Https")]
            [Validation(Required=false)]
            public long? Https { get; set; }

            /// <summary>
            /// <para>The number of IPv6 HTTPS resolution requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Https6")]
            [Validation(Required=false)]
            public long? Https6 { get; set; }

            [NameInMap("HttpsAes")]
            [Validation(Required=false)]
            public string HttpsAes { get; set; }

        }

    }

}
