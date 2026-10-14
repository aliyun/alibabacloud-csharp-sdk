// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainH2FingerprintResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of top N HTTP/2.0 fingerprints for the domain name.</para>
        /// </summary>
        [NameInMap("DomainH2Fp")]
        [Validation(Required=false)]
        public List<DescribeDomainH2FingerprintResponseBodyDomainH2Fp> DomainH2Fp { get; set; }
        public class DescribeDomainH2FingerprintResponseBodyDomainH2Fp : TeaModel {
            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The HTTP/2.0 fingerprint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>532501bc316d02c8b1a007db76f2c796</para>
            /// </summary>
            [NameInMap("H2Fingerprint")]
            [Validation(Required=false)]
            public string H2Fingerprint { get; set; }

            /// <summary>
            /// <para>The number of times the HTTP/2.0 fingerprint is matched for the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>471755</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112777CC-2AD6-46FC-A263-00B931406FCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
