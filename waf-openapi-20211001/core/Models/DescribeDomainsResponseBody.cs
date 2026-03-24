// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The back-to-origin configuration.</para>
            /// </summary>
            [NameInMap("Backeds")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsBackeds Backeds { get; set; }
            public class DescribeDomainsResponseBodyDomainsBackeds : TeaModel {
                /// <summary>
                /// <para>The list of origin addresses for the HTTP protocol.</para>
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttp> Http { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttp : TeaModel {
                    /// <summary>
                    /// <para>The origin address for the HTTP protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.1.XX.XX</para>
                    /// </summary>
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

                /// <summary>
                /// <para>The list of origin addresses for the HTTPS protocol.</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttps> Https { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttps : TeaModel {
                    /// <summary>
                    /// <para>The origin address for the HTTPS protocol.</para>
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
            /// <para>The canonical name (CNAME) that is assigned to the domain name by WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxcvdaf.****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com-waf">www.aliyundoc.com-waf</a></para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The listener configuration.</para>
            /// </summary>
            [NameInMap("ListenPorts")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsListenPorts ListenPorts { get; set; }
            public class DescribeDomainsResponseBodyDomainsListenPorts : TeaModel {
                /// <summary>
                /// <para>The list of listening ports for the HTTP protocol.</para>
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<long?> Http { get; set; }

                /// <summary>
                /// <para>The list of listening ports for the HTTPS protocol.</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<long?> Https { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
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
            /// <item><description><para><b>1</b>: The domain name is in a normal state.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The domain name is being created.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: The domain name is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: The domain name is being released.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Forwarding is disabled for the domain name.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABF68BB3-2C48-5FA4-9750-D5FE55700E36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain name configurations returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
