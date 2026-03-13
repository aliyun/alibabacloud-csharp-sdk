// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The arguments that are passed to the startup command.</para>
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <para>The startup commands.</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The custom health check configuration of the function.</para>
        /// </summary>
        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>The port on which the HTTP server is listening.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
