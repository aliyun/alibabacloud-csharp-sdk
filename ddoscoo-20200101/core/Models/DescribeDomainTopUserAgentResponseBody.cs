// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopUserAgentResponseBody : TeaModel {
        [NameInMap("DomainTopUa")]
        [Validation(Required=false)]
        public List<DescribeDomainTopUserAgentResponseBodyDomainTopUa> DomainTopUa { get; set; }
        public class DescribeDomainTopUserAgentResponseBodyDomainTopUa : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22121</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TW96aWxsYS81LjAgKFgxMTsgTGludXggeDg2XzY0KSBBcHBsZVdlYktpdC81MzcuMzYgKEtIVE1MLCBsaWtlIEdlY2tvKSBDaHJvbWUvOTYuMC40NjY0LjExMCACYWZhcmkvNTM3LjM2</para>
            /// </summary>
            [NameInMap("UserAgent")]
            [Validation(Required=false)]
            public string UserAgent { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
