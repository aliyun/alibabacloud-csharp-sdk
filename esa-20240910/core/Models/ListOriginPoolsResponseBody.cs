// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of origin pools.</para>
        /// </summary>
        [NameInMap("OriginPools")]
        [Validation(Required=false)]
        public List<ListOriginPoolsResponseBodyOriginPools> OriginPools { get; set; }
        public class ListOriginPoolsResponseBodyOriginPools : TeaModel {
            /// <summary>
            /// <para>Whether the origin pool is enabled:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled;</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>ID of the origin pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1038520525196928</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name of the origin pool, unique within a site.</para>
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
            public List<ListOriginPoolsResponseBodyOriginPoolsOrigins> Origins { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsOrigins : TeaModel {
                /// <summary>
                /// <para>Origin address, e.g., <a href="http://www.example.com">www.example.com</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Authentication information. When the origin is OSS or S3 and requires authentication, you need to provide related configuration information for authentication.</para>
                /// </summary>
                [NameInMap("AuthConf")]
                [Validation(Required=false)]
                public ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf AuthConf { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey required for private authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LTAI5tMfEib****ahybCpZqp</para>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>Authentication type.</para>
                    /// <list type="bullet">
                    /// <item><description>public: Public read/write, used when the origin is OSS or S3 and it is set to public read/write;</description></item>
                    /// <item><description>private_same_account: Private same account, used when the origin is OSS and the authentication type is private within the same account;</description></item>
                    /// <item><description>private_cross_account: Private cross-account, used when the origin is OSS and the authentication type is private across accounts;</description></item>
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
                    /// <para>The Region of the origin required when the origin is AWS S3.</para>
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
                    /// <para>VIxuvJSA2****fgYoZ3nkp208dy5w7</para>
                    /// </summary>
                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                    /// <summary>
                    /// <para>The signature version required when the origin is AWS S3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2</para>
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
                /// <para>The request header to be carried during back-to-origin, only supports Host.</para>
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
                /// <para>Origin ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>997502094872132</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Origin name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Origin type:</para>
                /// <list type="bullet">
                /// <item><description>ip_domain: IP or domain type origin; </description></item>
                /// <item><description>OSS: OSS address origin; </description></item>
                /// <item><description>S3: AWS S3 origin.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S3</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Weight, an integer between 0 and 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>Domain name assigned to the origin pool, which can be used as the origin address for records under the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>Number of load balancers that reference this origin pool.</para>
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
            public ListOriginPoolsResponseBodyOriginPoolsReferences References { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsReferences : TeaModel {
                /// <summary>
                /// <para>使用此源地址池为源站的七层记录列表。</para>
                /// </summary>
                [NameInMap("DnsRecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords> DnsRecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords : TeaModel {
                    /// <summary>
                    /// <para>Record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
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
                /// <para>List of layer 4 records that use this origin pool as the origin.</para>
                /// </summary>
                [NameInMap("IPARecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords> IPARecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords : TeaModel {
                    /// <summary>
                    /// <para>Record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1042852886352704</para>
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
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers> LoadBalancers { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers : TeaModel {
                    /// <summary>
                    /// <para>ID of the load balancer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>998740660522624</para>
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
            /// <para>ID of the site to which the origin pool belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>216558609793952</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

        }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
