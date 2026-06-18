// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies if the origin pool is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The origin pool is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: The origin pool is disabled.</para>
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
        /// <para>The origin pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103852052519****</para>
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
        public List<GetOriginPoolResponseBodyOrigins> Origins { get; set; }
        public class GetOriginPoolResponseBodyOrigins : TeaModel {
            /// <summary>
            /// <para>The origin address. For example, www\.example.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The authentication configuration. This parameter is required if the origin is an OSS or S3 bucket that requires authentication.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetOriginPoolResponseBodyOriginsAuthConf AuthConf { get; set; }
            public class GetOriginPoolResponseBodyOriginsAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID. This parameter is required if <c>AuthType</c> is set to <c>private_cross_account</c> or <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourAccessKeyID</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The authentication type.</para>
                /// <list type="bullet">
                /// <item><description><para>public: Public access. For OSS or S3 origins with public read access.</para>
                /// </description></item>
                /// <item><description><para>private_same_account: Private, same account. For private OSS origins in the same account.</para>
                /// </description></item>
                /// <item><description><para>private_cross_account: Private, cross-account. For private OSS origins in a different account.</para>
                /// </description></item>
                /// <item><description><para>private: Private. For private S3 origins.</para>
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
                /// <para>The AWS Region of the origin. Required if the origin is an AWS S3 bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The AccessKey secret. This parameter is required if <c>AuthType</c> is set to <c>private_cross_account</c> or <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourAccessKeySecret</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature version. Required if the origin is an AWS S3 bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Specifies if the origin is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The origin is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: The origin is disabled.</para>
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
            /// <para>The request header to include in origin requests. Only the Host header is supported.</para>
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
            /// <para>The origin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99750209487****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The IP version policy for origin requests.</para>
            /// <list type="bullet">
            /// <item><description><para>round_robin: Default policy. Routes requests to IPv4 and IPv6 origins on a round-robin basis.</para>
            /// </description></item>
            /// <item><description><para>ipv4_first: Prioritizes IPv4. Routes requests to IPv4 origins first.</para>
            /// </description></item>
            /// <item><description><para>ipv6_first: Prioritizes IPv6. Routes requests to IPv6 origins first.</para>
            /// </description></item>
            /// <item><description><para>follow: Matches the client\&quot;s IP version. The origin request uses the same IP version as the incoming request.</para>
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
            /// <para>The origin name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the origin.</para>
            /// <list type="bullet">
            /// <item><description><para>ip_domain: An IP address or a domain name.</para>
            /// </description></item>
            /// <item><description><para>OSS: An OSS bucket.</para>
            /// </description></item>
            /// <item><description><para>S3: An AWS S3 bucket.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_domain</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of the origin. Must be an integer from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The domain name assigned to the origin pool. It serves as the origin address for records within the site.</para>
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
        /// <para>Resources that reference the origin pool. An origin pool is referenced if a load balancer or record uses it as an origin.</para>
        /// </summary>
        [NameInMap("References")]
        [Validation(Required=false)]
        public GetOriginPoolResponseBodyReferences References { get; set; }
        public class GetOriginPoolResponseBodyReferences : TeaModel {
            /// <summary>
            /// <para>The Layer 7 records that use this origin pool as their origin.</para>
            /// </summary>
            [NameInMap("DnsRecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesDnsRecords> DnsRecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesDnsRecords : TeaModel {
                /// <summary>
                /// <para>The ID of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>104285288635****</para>
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
            /// <para>The Layer 4 records that use this origin pool as their origin.</para>
            /// </summary>
            [NameInMap("IPARecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesIPARecords> IPARecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesIPARecords : TeaModel {
                /// <summary>
                /// <para>The ID of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>104285288635****</para>
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
            /// <para>The load balancers that use this origin pool.</para>
            /// </summary>
            [NameInMap("LoadBalancers")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesLoadBalancers> LoadBalancers { get; set; }
            public class GetOriginPoolResponseBodyReferencesLoadBalancers : TeaModel {
                /// <summary>
                /// <para>The ID of the load balancer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99874066052****</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the site that contains the origin pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21655860979****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
