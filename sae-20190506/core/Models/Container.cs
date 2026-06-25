// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Container : TeaModel {
        /// <summary>
        /// <para>Container startup arguments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// <para>Container start command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/bin/sh&quot;]</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>Container environment variables.</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>Container image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/serverless_devsxxxxx</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>Image repository configuration.</para>
        /// </summary>
        [NameInMap("ImageRegistryConfig")]
        [Validation(Required=false)]
        public ImageRegistryConfig ImageRegistryConfig { get; set; }

        /// <summary>
        /// <para>Monitoring collection configuration.</para>
        /// </summary>
        [NameInMap("MetricsCollectConfig")]
        [Validation(Required=false)]
        public MetricsCollectConfig MetricsCollectConfig { get; set; }

        /// <summary>
        /// <para>Container port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>Maximum concurrent requests per instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestConcurrency")]
        [Validation(Required=false)]
        public int? RequestConcurrency { get; set; }

        /// <summary>
        /// <para>Container request timeout, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>Container resource configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ContainerResources Resources { get; set; }

        /// <summary>
        /// <para>Container log collection configuration.</para>
        /// </summary>
        [NameInMap("SLSCollectConfigs")]
        [Validation(Required=false)]
        public SLSCollectConfigs SLSCollectConfigs { get; set; }

        /// <summary>
        /// <para>Container startup probe configuration.</para>
        /// </summary>
        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public StartupProbe StartupProbe { get; set; }

        /// <summary>
        /// <para>Container NAS configuration.</para>
        /// </summary>
        [NameInMap("WebNASConfig")]
        [Validation(Required=false)]
        public WebNASConfig WebNASConfig { get; set; }

        /// <summary>
        /// <para>Container OSS mount configuration.</para>
        /// </summary>
        [NameInMap("WebOSSConfig")]
        [Validation(Required=false)]
        public WebOSSConfig WebOSSConfig { get; set; }

    }

}
