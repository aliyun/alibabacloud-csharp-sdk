// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateOriginPoolRequest : TeaModel {
        /// <summary>
        /// <para>Whether the origin address pool is enabled:</para>
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
        /// <para>The name of the origin address pool, which must be unique within a site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Information about the origins added to the origin address pool, with multiple origins passed as an array.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<CreateOriginPoolRequestOrigins> Origins { get; set; }
        public class CreateOriginPoolRequestOrigins : TeaModel {
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
            /// <para>Authentication information, required when the origin is OSS or S3 and needs authentication, including related configuration details.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public CreateOriginPoolRequestOriginsAuthConf AuthConf { get; set; }
            public class CreateOriginPoolRequestOriginsAuthConf : TeaModel {
                /// <summary>
                /// <para>The access key required for private authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTAI5tGLgmPe1wFwpX86****</para>
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
                /// <para>The secret key required for private authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bd8tjba5lXxxxxiRXFIBvoCIfJI****</para>
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
            /// <para>The request header to be included when fetching from the origin, only Host is supported.</para>
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
            /// <para>The name of the origin, which must be unique within an origin address.</para>
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
            /// <item><description>ip_domain: IP or domain name type origin;</description></item>
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
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
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
