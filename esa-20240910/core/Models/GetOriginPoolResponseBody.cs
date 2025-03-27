// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether the origin pool is enabled:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled;</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Origin pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103852052519****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Name of the origin pool. The name is unique under a single site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Information about the origins added to the origin pool.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<GetOriginPoolResponseBodyOrigins> Origins { get; set; }
        public class GetOriginPoolResponseBodyOrigins : TeaModel {
            /// <summary>
            /// <para>The address of the origin, e.g., <a href="http://www.example.com">www.example.com</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Authentication information. When the origin is an OSS or S3, and authentication is required, you need to provide the relevant configuration information.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetOriginPoolResponseBodyOriginsAuthConf AuthConf { get; set; }
            public class GetOriginPoolResponseBodyOriginsAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey required when AuthType is set to private_cross_account or private.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourAccessKeyID</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The type of authentication:</para>
                /// <list type="bullet">
                /// <item><description>public: Public read/write, used when the origin is OSS or S3 and is publicly readable/writable;</description></item>
                /// <item><description>private_same_account: Private same account, used when the origin is OSS and the authentication type is private within the same account;</description></item>
                /// <item><description>private_cross_account: Private cross account, used when the origin is OSS and the authentication type is private across accounts;</description></item>
                /// <item><description>private: Used when the origin is S3 and the authentication type is private.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The source Region to be passed when the origin is AWS S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SecretKey required when AuthType is set to private_cross_account or private.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourAccessKeySecret</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature version required when the origin is an AWS S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Whether the origin is enabled:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled;</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The request header to be included when fetching from the origin, only supports Host.</para>
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
            /// <para>99750209487****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
            /// <para>The type of the origin:</para>
            /// <list type="bullet">
            /// <item><description>ip_domain: IP or domain type origin;</description></item>
            /// <item><description>OSS: OSS address origin;</description></item>
            /// <item><description>S3: AWS S3 origin.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_domain</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight, an integer between 0 and 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The domain name assigned to the origin pool, which can be used as the origin address for records under the site.</para>
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
        /// <para>Reference information for the origin pool. The origin pool is considered referenced when it is configured in a load balancer or set as the origin for a record.</para>
        /// </summary>
        [NameInMap("References")]
        [Validation(Required=false)]
        public GetOriginPoolResponseBodyReferences References { get; set; }
        public class GetOriginPoolResponseBodyReferences : TeaModel {
            /// <summary>
            /// <para>List of layer 7 records using this origin pool as the origin.</para>
            /// </summary>
            [NameInMap("DnsRecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesDnsRecords> DnsRecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesDnsRecords : TeaModel {
                /// <summary>
                /// <para>Record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>104285288635****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Record name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>List of layer 4 records using this origin pool as the origin.</para>
            /// </summary>
            [NameInMap("IPARecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesIPARecords> IPARecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesIPARecords : TeaModel {
                /// <summary>
                /// <para>记录ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>104285288635****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Record name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipa.example.com</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>List of load balancers using this origin pool.</para>
            /// </summary>
            [NameInMap("LoadBalancers")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesLoadBalancers> LoadBalancers { get; set; }
            public class GetOriginPoolResponseBodyReferencesLoadBalancers : TeaModel {
                /// <summary>
                /// <para>ID of the load balancer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99874066052****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Name of the load balancer.</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>ID of the site to which the origin pool belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21655860979****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
