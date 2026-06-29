// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the origin address pool is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The origin address pool ID. You can call the <a href="~~ListOriginPools~~">ListOriginPools</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038520525196928</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The origin server information added to the origin address pool. Use an array to pass multiple origin servers.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<UpdateOriginPoolRequestOrigins> Origins { get; set; }
        public class UpdateOriginPoolRequestOrigins : TeaModel {
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
            /// <para>The authentication information. This parameter is required when the origin server is OSS, S3, or another origin server that requires authentication.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public UpdateOriginPoolRequestOriginsAuthConf AuthConf { get; set; }
            public class UpdateOriginPoolRequestOriginsAuthConf : TeaModel {
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
                /// <item><description>public: public read/write. Use this value when the origin server is OSS or S3 with public read/write access.</description></item>
                /// <item><description>private_same_account: private same-account. Use this value when the origin server is OSS with same-account private authentication.</description></item>
                /// <item><description>private_cross_account: private cross-account. Use this value when the origin server is OSS with cross-account private authentication.</description></item>
                /// <item><description>private: Use this value when the origin server is S3 with private authentication.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region of the origin server required when the origin server is AWS S3.</para>
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
                /// <para>The signature version required when the origin server is AWS S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the origin server is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The request header included in back-to-origin requests. Only Host is supported.</para>
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
            /// <para>The IP protocol version used for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>round_robin: default policy. Randomly polls IPv4 or IPv6 origin servers.</description></item>
            /// <item><description>ipv4_first: preferentially uses IPv4 origin servers.</description></item>
            /// <item><description>ipv6_first: preferentially uses IPv6 origin servers.</description></item>
            /// <item><description>follow: preferentially follows the IP version used by the client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>round_robin</para>
            /// </summary>
            [NameInMap("IpVersionPolicy")]
            [Validation(Required=false)]
            public string IpVersionPolicy { get; set; }

            /// <summary>
            /// <para>The origin server name. The name must be unique within an origin address pool.</para>
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
            /// <item><description>ip_domain: an IP address or domain name-based origin server.</description></item>
            /// <item><description>OSS: an OSS address-based origin server.</description></item>
            /// <item><description>S3: an AWS S3 origin server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight. The value is an integer from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>216558609793952</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
