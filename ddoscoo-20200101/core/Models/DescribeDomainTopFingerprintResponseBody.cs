// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopFingerprintResponseBody : TeaModel {
        [NameInMap("DomainTopFp")]
        [Validation(Required=false)]
        public List<DescribeDomainTopFingerprintResponseBodyDomainTopFp> DomainTopFp { get; set; }
        public class DescribeDomainTopFingerprintResponseBodyDomainTopFp : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8a374c9724582b14a4cfa58c8c9fb2bc</para>
            /// </summary>
            [NameInMap("Fingerprinting")]
            [Validation(Required=false)]
            public string Fingerprinting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22121</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
