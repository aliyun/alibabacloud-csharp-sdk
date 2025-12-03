// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeDomainExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of additional certificates.</para>
        /// </summary>
        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public DescribeDomainExtensionsResponseBodyDomainExtensions DomainExtensions { get; set; }
        public class DescribeDomainExtensionsResponseBodyDomainExtensions : TeaModel {
            [NameInMap("DomainExtension")]
            [Validation(Required=false)]
            public List<DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension> DomainExtension { get; set; }
            public class DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The ID of the additional certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de-bp1rp7ta1****</para>
                /// </summary>
                [NameInMap("DomainExtensionId")]
                [Validation(Required=false)]
                public string DomainExtensionId { get; set; }

                /// <summary>
                /// <para>The ID of the certificate used by the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231579085529123_166f8204689_1714763408_70998****</para>
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48C1B671-C6DB-4DDE-9B30-10557E36CDE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
