// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiPluginStatus : TeaModel {
        /// <summary>
        /// <para>An object containing error logs, where each key is a string identifying an error and the value is a string describing that error.</para>
        /// </summary>
        [NameInMap("errorLogs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ErrorLogs { get; set; }

        /// <summary>
        /// <para>The unique identifier of the plugin.</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Indicates if the service is healthy. <c>true</c> indicates normal operation, and <c>false</c> indicates an issue.</para>
        /// </summary>
        [NameInMap("serviceHealthy")]
        [Validation(Required=false)]
        public bool? ServiceHealthy { get; set; }

    }

}
