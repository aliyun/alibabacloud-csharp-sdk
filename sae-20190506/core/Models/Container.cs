// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Container : TeaModel {
        /// <summary>
        /// <para>The startup parameters of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// <para>The startup command of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/bin/sh&quot;]</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The container environment variables.</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The container image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/serverless_devsxxxxx</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The configuration of the image repository.</para>
        /// </summary>
        [NameInMap("ImageRegistryConfig")]
        [Validation(Required=false)]
        public ImageRegistryConfig ImageRegistryConfig { get; set; }

        /// <summary>
        /// <para>The configuration for collecting monitoring records.</para>
        /// </summary>
        [NameInMap("MetricsCollectConfig")]
        [Validation(Required=false)]
        public MetricsCollectConfig MetricsCollectConfig { get; set; }

        /// <summary>
        /// <para>The port of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The number of concurrent requests on a single instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestConcurrency")]
        [Validation(Required=false)]
        public int? RequestConcurrency { get; set; }

        /// <summary>
        /// <para>The timeout period of the container request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The configurations of the container resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ContainerResources Resources { get; set; }

        /// <summary>
        /// <para>The configuration of container log collection.</para>
        /// </summary>
        [NameInMap("SLSCollectConfigs")]
        [Validation(Required=false)]
        public SLSCollectConfigs SLSCollectConfigs { get; set; }

        /// <summary>
        /// <para>The container startup check configuration.</para>
        /// </summary>
        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public StartupProbe StartupProbe { get; set; }

        /// <summary>
        /// <para>The container NAS configuration.</para>
        /// </summary>
        [NameInMap("WebNASConfig")]
        [Validation(Required=false)]
        public WebNASConfig WebNASConfig { get; set; }

        /// <summary>
        /// <para>The container OSS mount configuration.</para>
        /// </summary>
        [NameInMap("WebOSSConfig")]
        [Validation(Required=false)]
        public WebOSSConfig WebOSSConfig { get; set; }

    }

}
