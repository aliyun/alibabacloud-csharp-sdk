// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolRequest : TeaModel {
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
        /// <para>The ID of the origin pool, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2863947.html">ListOriginPools</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038520525196928</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Information about the origins added to the origin pool. Multiple origins are passed as an array.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<UpdateOriginPoolRequestOrigins> Origins { get; set; }
        public class UpdateOriginPoolRequestOrigins : TeaModel {
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
            /// <para>Authentication information. When the origin is OSS or S3 and requires authentication, you need to pass the related configuration information for authentication.</para>
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
                /// <para>The type of authentication.</para>
                /// <list type="bullet">
                /// <item><description>public: Public read/write, used when the origin is OSS or S3 and is set to public read/write;</description></item>
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
                /// <para>The region of the origin required when the origin is AWS S3.</para>
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
            /// <para>The request header to be included when fetching from the origin, supporting only Host.</para>
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

            [NameInMap("IpVersionPolicy")]
            [Validation(Required=false)]
            public string IpVersionPolicy { get; set; }

            /// <summary>
            /// <para>The name of the origin, which must be unique under one origin pool.</para>
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
            /// <para>OSS</para>
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
        /// <para>The site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
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
