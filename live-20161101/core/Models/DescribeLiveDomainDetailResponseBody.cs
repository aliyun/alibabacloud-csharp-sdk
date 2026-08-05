// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the domain configuration.</para>
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
            /// <para>The canonical name (CNAME). A CNAME is generated for the live streaming domain. You must add a CNAME record at your DNS provider to map the live streaming domain to this CNAME.</para>
            /// <remarks>
            /// <para>Local DNS records are cached. After you add the CNAME record, it may take up to 10 minutes to take effect. For more information, see <a href="https://help.aliyun.com/document_detail/362010.html">FAQ about CNAME records</a>.</para>
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
            /// <para>The ingest domain or streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status of the domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>configuring</b>: being configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>The time when the domain was added. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-27T06:51:25Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the domain was last modified. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
            /// <item><description><para><b>liveVideo</b>: streaming domain.</para>
            /// </description></item>
            /// <item><description><para><b>liveEdge</b>: ingest domain.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>liveVideo</para>
            /// </summary>
            [NameInMap("LiveDomainType")]
            [Validation(Required=false)]
            public string LiveDomainType { get; set; }

            /// <summary>
            /// <para>The region where the domain name is added.</para>
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
            /// <para>rg-<b>k3bpq2yjw22</b></para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled.</para>
            /// </description></item>
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
            /// <item><description><para><b>domestic</b>: the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>overseas</b>: regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: global.</para>
            /// </description></item>
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
