// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateOriginPoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the origin pool is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled</para>
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
        /// <para>The name of the origin pool. The name must be unique within a site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of origins to add to the origin pool. Use an array to specify multiple origins.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<CreateOriginPoolRequestOrigins> Origins { get; set; }
        public class CreateOriginPoolRequestOrigins : TeaModel {
            /// <summary>
            /// <para>The address of the origin. For example, www\.example.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The authentication configuration for the origin. Required if the origin is an OSS or AWS S3 bucket that requires authentication.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public CreateOriginPoolRequestOriginsAuthConf AuthConf { get; set; }
            public class CreateOriginPoolRequestOriginsAuthConf : TeaModel {
                /// <summary>
                /// <para>The access key required for private authentication.</para>
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
                /// <item><description><para><c>public</c>: Public read/write. Use this for public OSS or AWS S3 buckets.</para>
                /// </description></item>
                /// <item><description><para><c>private_same_account</c>: Private authentication for an OSS bucket in the same Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para><c>private_cross_account</c>: Private authentication for an OSS bucket in a different Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para><c>private</c>: Private authentication for an AWS S3 bucket.</para>
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
                /// <para>The secret key required for private authentication.</para>
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
            /// <para>Specifies whether the origin is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
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
            /// <para>The request header to include in back-to-origin requests. Only the <c>Host</c> header is supported.</para>
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
            /// <para>The IP protocol version for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>round_robin</c>: Default. Randomly selects an IPv4 or IPv6 origin.</para>
            /// </description></item>
            /// <item><description><para><c>ipv4_first</c>: Prioritizes IPv4 origins.</para>
            /// </description></item>
            /// <item><description><para><c>ipv6_first</c>: Prioritizes IPv6 origins.</para>
            /// </description></item>
            /// <item><description><para><c>follow</c>: Uses the same IP protocol version as the client\&quot;s request.</para>
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
            /// <para>The name of the origin. The name must be unique within the origin pool.</para>
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
            /// <item><description><para><c>ip_domain</c>: An IP address or a domain name.</para>
            /// </description></item>
            /// <item><description><para><c>OSS</c>: An Alibaba Cloud OSS bucket.</para>
            /// </description></item>
            /// <item><description><para><c>S3</c>: An AWS S3 bucket.</para>
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
            /// <para>The weight of the origin. The value must be an integer from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The site ID. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21655860979****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
