// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchConnectionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchConnectionInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchConnectionInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The description is the same as above.</para>
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
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchConnectionInfoResponseBodyData Data { get; set; }
        public class DescribeOpenSearchConnectionInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The internal endpoint of the OpenSearch Dashboard.</para>
            /// </summary>
            [NameInMap("DashboardEndpoint")]
            [Validation(Required=false)]
            public DescribeOpenSearchConnectionInfoResponseBodyDataDashboardEndpoint DashboardEndpoint { get; set; }
            public class DescribeOpenSearchConnectionInfoResponseBodyDataDashboardEndpoint : TeaModel {
                /// <summary>
                /// <para>Specifies whether static frame check is enabled. Default value: false.</para>
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
                /// <para>The URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg">https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The public network access endpoint of the OpenSearch Dashboard.</para>
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
                /// <para>The hostname. Retrieves data under the specified host.</para>
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
                /// <para>The URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg">https://static.yipigai.cn/timuocr/tmp_c29e30497575a40193a24a7a83654e30e21b951cc6856cdb.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The default account name of OpenSearch.</para>
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
                /// <para>Specifies whether to enable the echo feature. This parameter is required. Valid values: true/false.</para>
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
            /// <para>The protocol of the monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ICMP</b>.</description></item>
            /// <item><description><b>TCP</b>.</description></item>
            /// <item><description><b>HTTP</b>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Private network monitoring supports only the ICMP and TCP protocols.</para>
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
                /// <para>Specifies whether to enable dead-letter message delivery.</para>
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
