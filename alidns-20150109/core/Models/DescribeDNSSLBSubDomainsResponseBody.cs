// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The subdomains for which weighted round-robin is enabled.</para>
        /// </summary>
        [NameInMap("SlbSubDomains")]
        [Validation(Required=false)]
        public DescribeDNSSLBSubDomainsResponseBodySlbSubDomains SlbSubDomains { get; set; }
        public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomains : TeaModel {
            [NameInMap("SlbSubDomain")]
            [Validation(Required=false)]
            public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain> SlbSubDomain { get; set; }
            public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain : TeaModel {
                /// <summary>
                /// <para>The lines for which weighted round-robin is enabled.</para>
                /// </summary>
                [NameInMap("LineAlgorithms")]
                [Validation(Required=false)]
                public DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms LineAlgorithms { get; set; }
                public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms : TeaModel {
                    [NameInMap("LineAlgorithm")]
                    [Validation(Required=false)]
                    public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm> LineAlgorithm { get; set; }
                    public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm : TeaModel {
                        /// <summary>
                        /// <para>The DNS resolution line. The line can be China Telecom, China Mobile, and China Unicom.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public string Line { get; set; }

                        /// <summary>
                        /// <para>Indicates whether weighted round-robin is enabled for the line. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b> (default): Weighted round-robin is enabled.</description></item>
                        /// <item><description><b>false</b>: Weighted round-robin is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Open")]
                        [Validation(Required=false)]
                        public bool? Open { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether weighted round-robin is enabled for the subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Open")]
                [Validation(Required=false)]
                public bool? Open { get; set; }

                /// <summary>
                /// <para>The number of DNS records added for the subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                /// <summary>
                /// <para>The name of the subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                /// <summary>
                /// <para>The type of the Domain Name System (DNS) record that supports weighted round-robin. Valid values: A, AAAA, and CNAME.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
