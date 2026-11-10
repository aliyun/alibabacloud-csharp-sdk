// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of origin address pools.</para>
        /// </summary>
        [NameInMap("OriginPools")]
        [Validation(Required=false)]
        public List<ListOriginPoolsResponseBodyOriginPools> OriginPools { get; set; }
        public class ListOriginPoolsResponseBodyOriginPools : TeaModel {
            /// <summary>
            /// <para>Indicates whether the origin address pool is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The origin address pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1038520525196928</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the origin address pool. The name must be unique within a site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The origin server information added to the origin address pool.</para>
            /// </summary>
            [NameInMap("Origins")]
            [Validation(Required=false)]
            public List<ListOriginPoolsResponseBodyOriginPoolsOrigins> Origins { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsOrigins : TeaModel {
                /// <summary>
                /// <para>The addresses of the origin server, such as <a href="http://www.example.com">www.example.com</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The authentication information. If the origin server is an OSS or S3 origin server that requires authentication, you must provide the authentication configuration information.</para>
                /// </summary>
                [NameInMap("AuthConf")]
                [Validation(Required=false)]
                public ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf AuthConf { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey required for private authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourAccessKeyID</para>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>The authentication type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>public: public read/write. Used when the origin server is an OSS or S3 origin server with public read/write permissions.</description></item>
                    /// <item><description>private_same_account: private within the same account. Used when the origin server is an OSS origin server and the authentication type is private authentication within the same account.</description></item>
                    /// <item><description>private_cross_account: private across accounts. Used when the origin server is an OSS origin server and the authentication type is private authentication across accounts.</description></item>
                    /// <item><description>private: private. Used when the origin server is an S3 origin server and the authentication type is private.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>The region of the origin server required when the origin server is an AWS S3 origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>us-east-1</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The SecretKey required for private authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourAccessKeySecret</para>
                    /// </summary>
                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                    /// <summary>
                    /// <para>The signature version required when the origin server is an AWS S3 origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the origin server is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enabled.</description></item>
                /// <item><description>false: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The request header included in back-to-origin requests. Only the Host header is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///         &quot;Host&quot;: [
                ///           &quot;example.com&quot;
                ///         ]
                ///       }</para>
                /// </summary>
                [NameInMap("Header")]
                [Validation(Required=false)]
                public object Header { get; set; }

                /// <summary>
                /// <para>The origin server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>997502094872132</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The IP protocol version used for back-to-origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>round_robin: the default policy. Randomly polls IPv4 or IPv6 origin servers.</description></item>
                /// <item><description>ipv4_first: prioritizes IPv4 origin servers.</description></item>
                /// <item><description>ipv6_first: prioritizes IPv6 origin servers.</description></item>
                /// <item><description>follow: prioritizes the IP version used by the client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>round_robin</para>
                /// </summary>
                [NameInMap("IpVersionPolicy")]
                [Validation(Required=false)]
                public string IpVersionPolicy { get; set; }

                /// <summary>
                /// <para>The origin server name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The origin server type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ip_domain: an origin server that uses an IP address or a domain name.</description></item>
                /// <item><description>OSS: an OSS origin server.</description></item>
                /// <item><description>S3: an AWS S3 origin server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S3</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The weight. The value must be an integer from 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The domain name allocated to the origin IPAM pool. It can be used as the addresses of the origin server for records under the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The number of load balancing instances that reference this origin IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReferenceLBCount")]
            [Validation(Required=false)]
            public int? ReferenceLBCount { get; set; }

            /// <summary>
            /// <para>The reference information of the origin IPAM pool. An origin IPAM pool is considered referenced when it is configured for load balancing or configured as an origin server in a record.</para>
            /// </summary>
            [NameInMap("References")]
            [Validation(Required=false)]
            public ListOriginPoolsResponseBodyOriginPoolsReferences References { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsReferences : TeaModel {
                /// <summary>
                /// <para>The list of Layer 7 records that use this origin address pool as the origin server.</para>
                /// </summary>
                [NameInMap("DnsRecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords> DnsRecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords : TeaModel {
                    /// <summary>
                    /// <para>The record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The record name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of Layer 4 records that use this origin address pool as the origin server.</para>
                /// </summary>
                [NameInMap("IPARecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords> IPARecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords : TeaModel {
                    /// <summary>
                    /// <para>The record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The record name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ipa.example.com</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The list of load balancing instances that use this origin IPAM pool.</para>
                /// </summary>
                [NameInMap("LoadBalancers")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers> LoadBalancers { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers : TeaModel {
                    /// <summary>
                    /// <para>The load balancing instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>998740660522624</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the load balancing instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb1.example.com</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the site to which the origin address pool belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>216558609793952</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
