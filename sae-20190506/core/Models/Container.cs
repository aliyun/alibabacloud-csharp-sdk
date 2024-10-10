// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Container : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;/bin/sh&quot;]</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/serverless_devsxxxxx</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("MetricsCollectConfig")]
        [Validation(Required=false)]
        public MetricsCollectConfig MetricsCollectConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestConcurrency")]
        [Validation(Required=false)]
        public int? RequestConcurrency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
