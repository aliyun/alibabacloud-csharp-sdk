// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried applications.</para>
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListEdgeContainerAppsResponseBodyApps> Apps { get; set; }
        public class ListEdgeContainerAppsResponseBodyApps : TeaModel {
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
            /// <para>The time when the version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-01T16:16:27.418298794+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name associated with the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
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
            public ListEdgeContainerAppsResponseBodyAppsHealthCheck HealthCheck { get; set; }
            public class ListEdgeContainerAppsResponseBodyAppsHealthCheck : TeaModel {
                /// <summary>
                /// <para>The number of consecutive failed health checks for an application to be considered unhealthy.</para>
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
                /// <para>http_2XX</para>
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
                /// <para>The HTTP method used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The health check port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks for an application to be considered healthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccTimes")]
                [Validation(Required=false)]
                public int? SuccTimes { get; set; }

                /// <summary>
                /// <para>The timeout period of health checks. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The type of health checks. Valid values:</para>
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
            /// <para>app-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The progress of the application creation task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

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
            /// <para>The remarks.</para>
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
            /// <para>2023-11-15T12:11:02Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The number of versions of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("VersionCount")]
            [Validation(Required=false)]
            public int? VersionCount { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2430E05E-1340-5773-B5E1-B743929F46F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
