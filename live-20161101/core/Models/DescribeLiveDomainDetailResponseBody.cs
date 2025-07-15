// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration details of the domain name.</para>
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeLiveDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeLiveDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// <para>The name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveCert****</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME that is assigned to the domain name. You must add a CNAME record in the system of your Domain Name System (DNS) service provider to map the domain name to the CNAME.</para>
            /// <remarks>
            /// <para> A time-to-live (TTL) value is specified in the CNAME record of a domain name to indicate how long the CNAME record can be cached on the DNS resolver. If you modify the CNAME record of the domain name, the new settings take effect after the cache expires, which takes about 10 minutes. For more information, see <a href="https://help.aliyun.com/document_detail/362010.html">CNAME resolution</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>learn.developer.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The description of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The streaming domain or ingest domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The domain name is enabled.</description></item>
            /// <item><description><b>offline</b>: The domain name is disabled.</description></item>
            /// <item><description><b>configuring</b>: The domain is being configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>The time when the domain name was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-27T06:51:25Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-07T06:51Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The type of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>liveVideo</b>: streaming domain</description></item>
            /// <item><description><b>liveEdge</b>: ingest domain</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>liveVideo</para>
            /// </summary>
            [NameInMap("LiveDomainType")]
            [Validation(Required=false)]
            public string LiveDomainType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the domain name resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2ogvt4nwmi7i</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the SSL certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// <para>The public key of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public Key</para>
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// <para>The acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: regions in the Chinese mainland.</description></item>
            /// <item><description><b>overseas</b>: regions outside the Chinese mainland.</description></item>
            /// <item><description><b>global</b>: regions in and outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09ABE829-6CD3-4FE0-AFEE-556113E29727</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
