// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchConnectionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchConnectionInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchConnectionInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardbx:DescribeOpenSearchConnectionInfo</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authenticated principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample RAM user</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authenticated principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The description is as above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>NoPermissionType</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchConnectionInfoResponseBodyData Data { get; set; }
        public class DescribeOpenSearchConnectionInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The internal endpoint of OpenSearch Dashboard.</para>
            /// </summary>
            [NameInMap("DashboardEndpoint")]
            [Validation(Required=false)]
            public DescribeOpenSearchConnectionInfoResponseBodyDataDashboardEndpoint DashboardEndpoint { get; set; }
            public class DescribeOpenSearchConnectionInfoResponseBodyDataDashboardEndpoint : TeaModel {
                /// <summary>
                /// <para>Specifies whether still frame checking is enabled. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The host address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.118.102.0/24</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The article URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg">https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The public network access endpoint of OpenSearch Dashboard.</para>
            /// </summary>
            [NameInMap("DashboardPublicEndpoint")]
            [Validation(Required=false)]
            public DescribeOpenSearchConnectionInfoResponseBodyDataDashboardPublicEndpoint DashboardPublicEndpoint { get; set; }
            public class DescribeOpenSearchConnectionInfoResponseBodyDataDashboardPublicEndpoint : TeaModel {
                /// <summary>
                /// <para>The service activation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: Activated.</description></item>
                /// <item><description><b>off</b>: Not activated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://secnet-defense-vastip.oss-cn-hangzhou.aliyuncs.com">https://secnet-defense-vastip.oss-cn-hangzhou.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The article URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg">https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The default username for OpenSearch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elastic</para>
            /// </summary>
            [NameInMap("DefaultUsername")]
            [Validation(Required=false)]
            public string DefaultUsername { get; set; }

            /// <summary>
            /// <para>The VPC endpoint of the instance.</para>
            /// </summary>
            [NameInMap("PrivateEndpoint")]
            [Validation(Required=false)]
            public DescribeOpenSearchConnectionInfoResponseBodyDataPrivateEndpoint PrivateEndpoint { get; set; }
            public class DescribeOpenSearchConnectionInfoResponseBodyDataPrivateEndpoint : TeaModel {
                /// <summary>
                /// <para>Specifies whether additional features are enabled. This parameter is required. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The OSS domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.118.214.0/24</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The protocol of the probe task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ICMP</b></description></item>
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>HTTP</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Internal network probing supports only the ICMP and TCP protocols.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The public endpoint of the instance.</para>
            /// </summary>
            [NameInMap("PublicEndpoint")]
            [Validation(Required=false)]
            public DescribeOpenSearchConnectionInfoResponseBodyDataPublicEndpoint PublicEndpoint { get; set; }
            public class DescribeOpenSearchConnectionInfoResponseBodyDataPublicEndpoint : TeaModel {
                /// <summary>
                /// <para>Specifies whether dead-letter message delivery is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The machine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.98.83.0/24</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
