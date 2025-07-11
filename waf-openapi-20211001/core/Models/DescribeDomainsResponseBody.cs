// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names that are added to WAF in CNAME record mode.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The back-to-origin settings.</para>
            /// </summary>
            [NameInMap("Backeds")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsBackeds Backeds { get; set; }
            public class DescribeDomainsResponseBodyDomainsBackeds : TeaModel {
                /// <summary>
                /// <para>The HTTP addresses of the origin server.</para>
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttp> Http { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttp : TeaModel {
                    /// <summary>
                    /// <para>The HTTP address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.1.XX.XX</para>
                    /// </summary>
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

                /// <summary>
                /// <para>The HTTPS addresses of the origin server.</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttps> Https { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttps : TeaModel {
                    /// <summary>
                    /// <para>The HTTPS address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.1.XX.XX</para>
                    /// </summary>
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

            }

            /// <summary>
            /// <para>The CNAME assigned by WAF to the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxcvdaf.****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name that is added to WAF in CNAME record mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The configurations of the listeners.</para>
            /// </summary>
            [NameInMap("ListenPorts")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsListenPorts ListenPorts { get; set; }
            public class DescribeDomainsResponseBodyDomainsListenPorts : TeaModel {
                /// <summary>
                /// <para>The HTTP listener ports.</para>
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<long?> Http { get; set; }

                /// <summary>
                /// <para>The HTTPS listener ports.</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<long?> Https { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmvtc5z52****</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1:</b> The domain name is in a normal state.</description></item>
            /// <item><description><b>2:</b> The domain name is being created.</description></item>
            /// <item><description><b>3:</b> The domain name is being modified.</description></item>
            /// <item><description><b>4:</b> The domain name is being released.</description></item>
            /// <item><description><b>5:</b> WAF no longer forwards traffic that is sent to the domain name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABF68BB3-2C48-5FA4-9750-D5FE55700E36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
