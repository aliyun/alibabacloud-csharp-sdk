// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the origin pool:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the origin pool.</para>
        /// </description></item>
        /// <item><description><para>false: Disables the origin pool.</para>
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
        /// <para>The origin pool ID. Get this ID by calling the <a href="~~ListOriginPools~~">ListOriginPools</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038520525196928</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>An array of origin configurations.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<UpdateOriginPoolRequestOrigins> Origins { get; set; }
        public class UpdateOriginPoolRequestOrigins : TeaModel {
            /// <summary>
            /// <para>The origin\&quot;s domain name or IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The authentication configuration. Required for private OSS or S3 origins.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public UpdateOriginPoolRequestOriginsAuthConf AuthConf { get; set; }
            public class UpdateOriginPoolRequestOriginsAuthConf : TeaModel {
                /// <summary>
                /// <para>The access key for private authentication. Required for private origins.</para>
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
                /// <item><description><para>public: For public OSS or S3 origins.</para>
                /// </description></item>
                /// <item><description><para>private_same_account: For private OSS origins in the same account.</para>
                /// </description></item>
                /// <item><description><para>private_cross_account: For private OSS origins that use cross-account authentication.</para>
                /// </description></item>
                /// <item><description><para>private: For private S3 origins.</para>
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
                /// <para>The region of the origin. This parameter is required if the origin type is S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The secret key for private authentication. Required for private origins.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourAccessKeySecret</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature version. This parameter is required if the origin type is S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the origin:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables the origin.</para>
            /// </description></item>
            /// <item><description><para>false: Disables the origin.</para>
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
            /// <para>The request header to add to back-to-origin requests. Only the Host header is supported.</para>
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
            /// <para>The IP version policy for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>round_robin: (Default) Randomly selects an IPv4 or IPv6 origin.</para>
            /// </description></item>
            /// <item><description><para>ipv4_first: Prioritizes IPv4 origins.</para>
            /// </description></item>
            /// <item><description><para>ipv6_first: Prioritizes IPv6 origins.</para>
            /// </description></item>
            /// <item><description><para>follow: Uses the same IP version as the client request.</para>
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
            /// <para>The origin type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ip_domain: An IP address or a domain name.</para>
            /// </description></item>
            /// <item><description><para>OSS: An OSS origin.</para>
            /// </description></item>
            /// <item><description><para>S3: An AWS S3 origin.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
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
        /// <para>The site ID. Get this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
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
