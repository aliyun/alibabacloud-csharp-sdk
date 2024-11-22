// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information about the application.</para>
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
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name that is associated with the application. If no domain name is associated with the application, the value is an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.1feel.cn">www.1feel.cn</a></para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The type of the gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>l7: Layer 7 gateway.</description></item>
            /// <item><description>l4: Layer 4 gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>l7</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The information about health checks.</para>
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public GetEdgeContainerAppResponseBodyAppHealthCheck HealthCheck { get; set; }
            public class GetEdgeContainerAppResponseBodyAppHealthCheck : TeaModel {
                /// <summary>
                /// <para>The number of consecutive failed health checks required for an application to be considered as unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public int? FailTimes { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The range of health check status codes that indicate successful health checks.</para>
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
                /// <para>The HTTP method that the health check request uses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The health check port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required for an application to be considered as healthy.</para>
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
                /// <item><description>l7</description></item>
                /// <item><description>l4</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>l7</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The health check URL.</para>
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
            /// <para>Indicates whether QUIC is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("QuicCid")]
            [Validation(Required=false)]
            public string QuicCid { get; set; }

            /// <summary>
            /// <para>The remarks about the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test app</para>
            /// </summary>
            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <para>The server port. Valid values: 1 to 65535.</para>
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
            /// <item><description>creating: The application is being created.</description></item>
            /// <item><description>failed: The application failed to be created.</description></item>
            /// <item><description>created: The application is created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The backend port, which is also the service port of the application. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

            /// <summary>
            /// <para>The time when the application was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-26T02:35:58Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The number of versions of the application.</para>
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
