// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListHealthCheckTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of health check templates.</para>
        /// </summary>
        [NameInMap("HealthCheckTemplates")]
        [Validation(Required=false)]
        public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplates> HealthCheckTemplates { get; set; }
        public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplates : TeaModel {
            /// <summary>
            /// <para>The list of status codes that indicate a successful health check.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The port used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
            /// <para>Default value: <b>0</b>, which indicates that the port of the backend server is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The domain name used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>$SERVER_IP</b> (default): the private IP of the backend server. If you specify an IP address or leave this parameter empty, load balancing uses the private IP of each backend server as the domain name for health checks.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain only letters, digits, periods (.), and hyphens (-).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>$SERVER_IP</para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The HTTP version used for health checks.</para>
            /// <para>Valid values: <b>HTTP 1.0</b> and <b>HTTP 1.1</b>.</para>
            /// <para>Default value: <b>HTTP 1.1</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP 1.0</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval between two consecutive health checks. Unit: seconds. Valid values: <b>1</b> to <b>50</b>. Default value: <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The health check method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HEAD</b> (default): The default method for HTTP and HTTPS health checks.</para>
            /// </description></item>
            /// <item><description><para><b>GET</b>: If the length of the response message exceeds 8 KB, the message is truncated. However, the truncation does not affect the health check result.</para>
            /// </description></item>
            /// <item><description><para><b>POST</b>: The default method for gRPC health checks.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HEAD</para>
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// <para>The URL used for health checks.</para>
            /// <para>The URL must be 1 to 80 characters in length and can contain only letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), ampersands (&amp;), and the following extended characters: <c>_;~!()*[]@$^:\&quot;,+</c>. The URL must start with a forward slash (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/index.html</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The protocol used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b> (default): sends HEAD or GET requests to perform browser access impersonation and check whether the server application is healthy.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: sends HEAD or GET requests to perform browser access impersonation and check whether the server application is healthy. (With data encryption, it is more secure than HTTP.)</para>
            /// </description></item>
            /// <item><description><para><b>TCP</b>: sends SYN handshake messages to check whether the server port is alive.</para>
            /// </description></item>
            /// <item><description><para><b>gRPC</b>: sends POST or GET requests to check whether the server application is healthy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The health check template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hct-bp1qjwo61pqz3ahltv****</para>
            /// </summary>
            [NameInMap("HealthCheckTemplateId")]
            [Validation(Required=false)]
            public string HealthCheckTemplateId { get; set; }

            /// <summary>
            /// <para>The health check template name.</para>
            /// <para>The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>HealthCheckTemplate1</para>
            /// </summary>
            [NameInMap("HealthCheckTemplateName")]
            [Validation(Required=false)]
            public string HealthCheckTemplateName { get; set; }

            /// <summary>
            /// <para>The timeout period for receiving a response from a health check. If the backend ECS instance does not return a correct response within the specified timeout period, the health check is considered failed.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
            /// <para>Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks required to change the health check status of a backend server from <b>Failed</b> to <b>Successful</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags> Tags { get; set; }
            public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive failed health checks required to change the health check status of a backend server from <b>Successful</b> to <b>Failed</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
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
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
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
        /// <para>365F4154-92F6-4AE4-92F8-7FF3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
