// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic application information.</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public GetEdgeContainerAppResponseBodyApp App { get; set; }
        public class GetEdgeContainerAppResponseBodyApp : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-88068867578379****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name bound to the application. If no domain name is bound, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.1feel.cn">www.1feel.cn</a></para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>l7</b>: Layer 7 gateway.</description></item>
            /// <item><description><b>l4</b>: Layer 4 gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>l7</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The health check information.</para>
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public GetEdgeContainerAppResponseBodyAppHealthCheck HealthCheck { get; set; }
            public class GetEdgeContainerAppResponseBodyAppHealthCheck : TeaModel {
                /// <summary>
                /// <para>The number of consecutive failed health checks required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public int? FailTimes { get; set; }

                /// <summary>
                /// <para>The domain name used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The range of HTTP status codes that indicate a successful health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http_2xx</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// <para>The interval between health checks. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The method used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The Health Check Port of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SuccTimes")]
                [Validation(Required=false)]
                public int? SuccTimes { get; set; }

                /// <summary>
                /// <para>The timeout period of the health check. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The health check type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>l7</b>: Layer 7 gateway.</description></item>
                /// <item><description><b>l4</b>: Layer 4 gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>l7</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The path used for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/health_check</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-app1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether QUIC support is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("QuicCid")]
            [Validation(Required=false)]
            public string QuicCid { get; set; }

            /// <summary>
            /// <para>The remarks of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test app</para>
            /// </summary>
            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <para>The service port number. Valid values: <b>1 to 65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// <para>The status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>creating</b>: Being created.</description></item>
            /// <item><description><b>failed</b>: Creation failed.</description></item>
            /// <item><description><b>created</b>: Created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The backend port, which is also the service port of the application. Valid values: <b>1 to 65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

            /// <summary>
            /// <para>The last modification time of the application. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-26T02:35:58Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The number of application versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionCount")]
            [Validation(Required=false)]
            public int? VersionCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
