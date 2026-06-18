// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of origin pools.</para>
        /// </summary>
        [NameInMap("OriginPools")]
        [Validation(Required=false)]
        public List<ListOriginPoolsResponseBodyOriginPools> OriginPools { get; set; }
        public class ListOriginPoolsResponseBodyOriginPools : TeaModel {
            /// <summary>
            /// <para>Indicates whether the origin pool is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the origin pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1038520525196928</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the origin pool. The name must be unique within a site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The origins in the origin pool.</para>
            /// </summary>
            [NameInMap("Origins")]
            [Validation(Required=false)]
            public List<ListOriginPoolsResponseBodyOriginPoolsOrigins> Origins { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsOrigins : TeaModel {
                /// <summary>
                /// <para>The address of the origin, such as <c>www.example.com</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The authentication configuration. This parameter is required if the origin is an OSS or AWS S3 bucket that requires authentication.</para>
                /// </summary>
                [NameInMap("AuthConf")]
                [Validation(Required=false)]
                public ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf AuthConf { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf : TeaModel {
                    /// <summary>
                    /// <para>The Access Key ID required for private authentication.</para>
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
                    /// <item><description><para><c>public</c>: Public read/write. Use for OSS or AWS S3 origins that have public access permissions.</para>
                    /// </description></item>
                    /// <item><description><para><c>private_same_account</c>: Private, same account. Use for OSS origins that use private authentication within the same account.</para>
                    /// </description></item>
                    /// <item><description><para><c>private_cross_account</c>: Private, cross-account. Use for OSS origins that use private authentication from a different account.</para>
                    /// </description></item>
                    /// <item><description><para><c>private</c>: Private. Use for AWS S3 origins that require private authentication.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>The region of the origin. Required for AWS S3 origins.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>us-east-1</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The Secret Access Key required for private authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourAccessKeySecret</para>
                    /// </summary>
                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                    /// <summary>
                    /// <para>The signature version. Required for AWS S3 origins.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the origin is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The request header to include in origin fetches. Only the <c>Host</c> header is supported.</para>
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
                /// <para>The ID of the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>997502094872132</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The IP protocol version used for origin fetch requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>round_robin</c>: Randomly selects an IPv4 or IPv6 origin.</para>
                /// </description></item>
                /// <item><description><para><c>ipv4_first</c>: Prioritizes IPv4 origins.</para>
                /// </description></item>
                /// <item><description><para><c>ipv6_first</c>: Prioritizes IPv6 origins.</para>
                /// </description></item>
                /// <item><description><para><c>follow</c>: Follows the IP version used by the client.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>round_robin</para>
                /// </summary>
                [NameInMap("IpVersionPolicy")]
                [Validation(Required=false)]
                public string IpVersionPolicy { get; set; }

                /// <summary>
                /// <para>The name of the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ip_domain</c>: An origin with an IP address or domain name.</para>
                /// </description></item>
                /// <item><description><para><c>OSS</c>: An Alibaba Cloud Object Storage Service (OSS) origin.</para>
                /// </description></item>
                /// <item><description><para><c>S3</c>: An AWS S3 origin.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S3</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The weight of the origin, an integer from 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The domain name assigned to the origin pool. This can be used as the origin address for records within the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The number of load balancers that reference this origin pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReferenceLBCount")]
            [Validation(Required=false)]
            public int? ReferenceLBCount { get; set; }

            /// <summary>
            /// <para>The resources that reference this origin pool. An origin pool is considered referenced when it is configured as an origin for a load balancer or a record.</para>
            /// </summary>
            [NameInMap("References")]
            [Validation(Required=false)]
            public ListOriginPoolsResponseBodyOriginPoolsReferences References { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsReferences : TeaModel {
                /// <summary>
                /// <para>A list of Layer 7 records that use this origin pool as an origin.</para>
                /// </summary>
                [NameInMap("DnsRecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords> DnsRecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords : TeaModel {
                    /// <summary>
                    /// <para>The ID of the record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>A list of Layer 4 records that use this origin pool as an origin.</para>
                /// </summary>
                [NameInMap("IPARecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords> IPARecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords : TeaModel {
                    /// <summary>
                    /// <para>The ID of the record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ipa.example.com</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>A list of load balancers that use this origin pool.</para>
                /// </summary>
                [NameInMap("LoadBalancers")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers> LoadBalancers { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers : TeaModel {
                    /// <summary>
                    /// <para>The ID of the load balancer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>998740660522624</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the load balancer.</para>
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
            /// <para>The ID of the site to which the origin pool belongs.</para>
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
        /// <para>The number of items returned per page.</para>
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
        /// <para>The total number of origin pools found.</para>
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
