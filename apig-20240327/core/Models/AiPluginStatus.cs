// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiPluginStatus : TeaModel {
        /// <summary>
        /// <para>The list of plug-in runtime error logs. Each item is a map[string]any key-value pair.</para>
        /// </summary>
        [NameInMap("errorLogs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ErrorLogs { get; set; }

        /// <summary>
        /// <para>The plug-in instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-xxx</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Indicates whether the backend service that the plug-in depends on is healthy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serviceHealthy")]
        [Validation(Required=false)]
        public bool? ServiceHealthy { get; set; }

    }

}
