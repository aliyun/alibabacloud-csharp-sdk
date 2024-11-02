// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListHealthCheckTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The health check templates.</para>
        /// </summary>
        [NameInMap("HealthCheckTemplates")]
        [Validation(Required=false)]
        public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplates> HealthCheckTemplates { get; set; }
        public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplates : TeaModel {
            /// <summary>
            /// <para>The HTTP status codes that indicate healthy backend servers.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The port that is used for health checks.</para>
            /// <para>Valid values: \<em>\</em> 0 to 65535\<em>\</em>.</para>
            /// <para>The default value is <b>0</b>, which specifies that the port of a backend server is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The domain name that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>$SERVER_IP</b> (default): the private IP address of a backend server. If an IP address is specified, or this parameter is not specified, the ALB instance uses the private IP address of each backend server as the domain name for health checks.</description></item>
            /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <c>HealthCheckProtocol</c> to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>$_ip</para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The HTTP version for health checks.</para>
            /// <para>Valid values: <b>HTTP 1.0</b> and <b>HTTP 1.1</b>.</para>
            /// <para>Default value: <b>HTTP 1.1</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <c>HealthCheckProtocol</c> to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP 1.0</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds. Valid values: <b>1 to 50</b>. Default value: <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The HTTP method that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HEAD</b> (default): By default, HTTP and HTTPS health checks use the HEAD method.</description></item>
            /// <item><description><b>GET</b>: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.</description></item>
            /// <item><description><b>POST</b>: gRPC health checks use the POST method by default.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HEAD</para>
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// <para>The URL path that you want to use for health checks.</para>
            /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, the following special characters: - / . % ? # &amp;, and the following extended characters: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>. The URL must start with a forward slash (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/index.html</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The protocol that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b> (default): The ALB instance sends HEAD or GET requests, which simulate browser requests, to check whether the backend server is healthy.</description></item>
            /// <item><description><b>HTTPS</b>: HTTPS health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers. HTTPS provides higher security because HTTPS supports data encryption.</description></item>
            /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.</description></item>
            /// <item><description><b>gRPC</b>: gRPC health checks send POST or GET requests to a backend server to check whether the backend server is healthy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The ID of the health check template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hct-bp1qjwo61pqz3ahltv****</para>
            /// </summary>
            [NameInMap("HealthCheckTemplateId")]
            [Validation(Required=false)]
            public string HealthCheckTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the health check template.</para>
            /// <para>The name must be 2 to 128 character characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HealthCheckTemplate1</para>
            /// </summary>
            [NameInMap("HealthCheckTemplateName")]
            [Validation(Required=false)]
            public string HealthCheckTemplateName { get; set; }

            /// <summary>
            /// <para>The timeout period of a health check response. If a backend Elastic Compute Service (ECS) instance does not respond within the specified timeout period, the ECS instance fails to pass the health check.</para>
            /// <para>Valid values: <b>1 to 300</b>. Unit: seconds.</para>
            /// <para>Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2 to 10</b>.</para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags> Tags { get; set; }
            public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from <b>success</b> to <b>fail</b>.</para>
            /// <para>Valid values: <b>2 to 10</b>.</para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
