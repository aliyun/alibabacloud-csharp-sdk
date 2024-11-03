// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsBySourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names corresponding to each origin server.</para>
        /// </summary>
        [NameInMap("DomainsList")]
        [Validation(Required=false)]
        public DescribeDomainsBySourceResponseBodyDomainsList DomainsList { get; set; }
        public class DescribeDomainsBySourceResponseBodyDomainsList : TeaModel {
            [NameInMap("DomainsData")]
            [Validation(Required=false)]
            public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsData> DomainsData { get; set; }
            public class DescribeDomainsBySourceResponseBodyDomainsListDomainsData : TeaModel {
                /// <summary>
                /// <para>Information about the domain name.</para>
                /// </summary>
                [NameInMap("DomainInfos")]
                [Validation(Required=false)]
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos DomainInfos { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos : TeaModel {
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo> DomainInfo { get; set; }
                    public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo : TeaModel {
                        /// <summary>
                        /// <para>The workload type of the accelerated domain name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>web</b>: images and small files</description></item>
                        /// <item><description><b>download</b>: large files</description></item>
                        /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>web</para>
                        /// </summary>
                        [NameInMap("CdnType")]
                        [Validation(Required=false)]
                        public string CdnType { get; set; }

                        /// <summary>
                        /// <para>The creation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-07-12T11:53:19+08:00</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>The CNAME record assigned to the domain name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>***.alikunlun.com</para>
                        /// </summary>
                        [NameInMap("DomainCname")]
                        [Validation(Required=false)]
                        public string DomainCname { get; set; }

                        /// <summary>
                        /// <para>The domain name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.org</para>
                        /// </summary>
                        [NameInMap("DomainName")]
                        [Validation(Required=false)]
                        public string DomainName { get; set; }

                        /// <summary>
                        /// <para>The status of the domain name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>applying</b>: The domain name is under review.</description></item>
                        /// <item><description><b>configuring</b>: The domain name is being configured.</description></item>
                        /// <item><description><b>online</b>: The domain name is working as expected.</description></item>
                        /// <item><description><b>stopping</b>: The domain name is being stopped.</description></item>
                        /// <item><description><b>offline</b>: The domain name is disabled.</description></item>
                        /// <item><description><b>disabling</b>: The domain name is being removed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>online</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The update time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2017-03-31T04:49:00+08:00</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The domain names that correspond to each origin server.</para>
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains Domains { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains : TeaModel {
                    [NameInMap("domainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                }

                /// <summary>
                /// <para>The origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0F074E5-A1AC-4B32-8EA2-6F450410D1E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The origin servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,aliyundoc.com</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

    }

}
