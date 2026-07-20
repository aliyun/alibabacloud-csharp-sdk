// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppRequest : TeaModel {
        /// <summary>
        /// <para>The number of consecutive failed health checks required. If an application is healthy, it is considered unhealthy after the specified number of consecutive failed probes.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1 to 10</b>. </description></item>
        /// <item><description>Default value: <b>5</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckFailTimes")]
        [Validation(Required=false)]
        public int? HealthCheckFailTimes { get; set; }

        /// <summary>
        /// <para>The domain name used for health checks. If this parameter is not specified, the value is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The HTTP status code that indicates the health check is Normal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b> (default).</description></item>
        /// <item><description><b>http_3xx</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between health checks.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1</b> to <b>50</b>.</description></item>
        /// <item><description>Default value: <b>5</b>.</description></item>
        /// <item><description>Unit: <b>seconds</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check method for HTTP-type listeners. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HEAD</b> (default): Requests only the headers of the page.</description></item>
        /// <item><description><b>GET</b>: Requests the specified page information and returns the entity body.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HEAD</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The port used for health checks.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1 to 65535</b>.</description></item>
        /// <item><description>Default value: <b>80</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required. If an application is unhealthy, it is considered healthy again after the specified number of consecutive successful probes.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1 to 10</b>.</description></item>
        /// <item><description>Default value: <b>2</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckSuccTimes")]
        [Validation(Required=false)]
        public int? HealthCheckSuccTimes { get; set; }

        /// <summary>
        /// <para>The amount of time to wait for a response from the health check. If the backend ECS instance does not respond correctly within the specified time, the health check is considered failed.    </para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1</b> to <b>100</b>.   </description></item>
        /// <item><description>Default value: <b>3</b>.</description></item>
        /// <item><description>Unit: <b>seconds</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The health check type, which includes Layer 4 and Layer 7 probing. If this parameter is not specified, the value is empty by default.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l4</b>: Layer 4 probing.</description></item>
        /// <item><description><b>l7</b>: Layer 7 probing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>l7</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI used for health checks.</para>
        /// <list type="bullet">
        /// <item><description>The length is limited to <b>1</b> to <b>80</b> characters.</description></item>
        /// <item><description>Default value: <b>&quot;/&quot;</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/health_check</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The application name. The name must start with a lowercase letter and can contain lowercase letters, digits, and hyphens (-). The name must be 6 to 128 characters in length.</para>
        /// <remarks>
        /// <para>Notice: Activate the EdgeContainer service in the console before calling this operation. Calls from accounts that have not activated the service will return a service activation error.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks. If this parameter is not specified, the value is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The server port number. Only 80 and 443 are accepted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ServicePort")]
        [Validation(Required=false)]
        public int? ServicePort { get; set; }

        /// <summary>
        /// <para>The backend port, which is also the service port of the application. Valid values: 1 to 65535.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public int? TargetPort { get; set; }

    }

}
