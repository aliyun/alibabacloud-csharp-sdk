// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ServiceHealthCheck : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The healthy threshold for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("healthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The health check domain name. This parameter is optional when the health check protocol is HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("httpHost")]
        [Validation(Required=false)]
        public string HttpHost { get; set; }

        /// <summary>
        /// <para>The health check path. This parameter is required when the health check protocol is HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/health</para>
        /// </summary>
        [NameInMap("httpPath")]
        [Validation(Required=false)]
        public string HttpPath { get; set; }

        /// <summary>
        /// <para>The health check interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The health check protocol. Valid values: TCP, HTTP, and GRPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The health check response timeout period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The unhealthy threshold for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("unhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
