// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppRequest : TeaModel {
        /// <summary>
        /// <para>The number of consecutive failed health checks required for an application to be considered as unhealthy. Valid values: 1 to 10. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckFailTimes")]
        [Validation(Required=false)]
        public int? HealthCheckFailTimes { get; set; }

        /// <summary>
        /// <para>The domain name that is used for health checks. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned for a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b> (default)</description></item>
        /// <item><description><b>http_3xx</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Unit: seconds. Valid values: <b>1</b> to <b>50</b>. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The HTTP request method for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HEAD</b> (default): requests the headers of the resource.</description></item>
        /// <item><description><b>GET</b>: requests the specified resource and returns both the headers and entity body.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HEAD</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: 1 to 65535. Default value: 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required for an application to be considered as healthy. Valid values: 1 to 10. Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckSuccTimes")]
        [Validation(Required=false)]
        public int? HealthCheckSuccTimes { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend ECS instance does not respond within the specified timeout period, the ECS instance fails the health check. Unit: seconds.\
        /// Valid values: <b>1</b> to <b>100</b>.\
        /// Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The health check type. By default, this parameter is left empty.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l4</b>: Layer 4 health check.</description></item>
        /// <item><description><b>l7</b>: Layer 7 health check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>l7</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI used for health checks. The URI must be <b>1</b> to <b>80</b> characters in length. Default value: &quot;/&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/health_check</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The name of the application. The name must start with a lowercase letter and can contain lowercase letters, digits, and hyphens (-). The name must be 6 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The server port. Valid values: 1 to 65535.</para>
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
