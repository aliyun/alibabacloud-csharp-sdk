// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomRuntimeConfig : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
