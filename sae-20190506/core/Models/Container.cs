// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Container : TeaModel {
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("MetricsCollectConfig")]
        [Validation(Required=false)]
        public MetricsCollectConfig MetricsCollectConfig { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("RequestConcurrency")]
        [Validation(Required=false)]
        public int? RequestConcurrency { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ContainerResources Resources { get; set; }

        [NameInMap("SLSCollectConfigs")]
        [Validation(Required=false)]
        public SLSCollectConfigs SLSCollectConfigs { get; set; }

        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public StartupProbe StartupProbe { get; set; }

        [NameInMap("WebNASConfig")]
        [Validation(Required=false)]
        public WebNASConfig WebNASConfig { get; set; }

        [NameInMap("WebOSSConfig")]
        [Validation(Required=false)]
        public WebOSSConfig WebOSSConfig { get; set; }

    }

}
