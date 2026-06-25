// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeployApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ARN of the RAM role required to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Authorize cross-account image pulls using RAM roles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The Container Registry Enterprise Edition instance ID. Required when <b>ImageUrl</b> is from Container Registry Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The AliyunAgent version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.4.2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The ALB gateway readiness gate configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AlbIngressReadinessGate")]
        [Validation(Required=false)]
        public string AlbIngressReadinessGate { get; set; }

        /// <summary>
        /// <para>The ID of the application to deploy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Whether to associate an EIP. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Associate.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not associate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssociateEip")]
        [Validation(Required=false)]
        public bool? AssociateEip { get; set; }

        /// <summary>
        /// <para>Whether to automatically enable application Auto Scaling rules. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// <para>The wait time between batches, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The description of the release task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start application</para>
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        /// <summary>
        /// <para>The startup command for your image. This command must be an executable object inside the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>In this example, Command=&quot;echo&quot; and <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments for the startup command <b>Command</b>. Format:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the earlier example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The value <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to a string in JSON array format. Leave this field empty if no arguments are needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The mount description for a <b>ConfigMap</b>. Use configuration items created on the namespace configuration page to inject configuration into your container. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap instance. Get it by calling the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> API.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing <c>sae-sys-configmap-all</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: The mount path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>The CPU required per instance, in milliCPU. Cannot be zero. Supported fixed specifications:</para>
        /// <list type="bullet">
        /// <item><description><para><b>500</b></para>
        /// </description></item>
        /// <item><description><para><b>1000</b></para>
        /// </description></item>
        /// <item><description><para><b>2000</b></para>
        /// </description></item>
        /// <item><description><para><b>4000</b></para>
        /// </description></item>
        /// <item><description><para><b>8000</b></para>
        /// </description></item>
        /// <item><description><para><b>12000</b></para>
        /// </description></item>
        /// <item><description><para><b>16000</b></para>
        /// </description></item>
        /// <item><description><para><b>32000</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>Custom host mappings inside your container. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hostName</b>: A domain name or hostname.</para>
        /// </description></item>
        /// <item><description><para><b>ip</b>: An IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;hostName&quot;:&quot;samplehost&quot;,&quot;ip&quot;:&quot;127.0.0.1&quot;}]</para>
        /// </summary>
        [NameInMap("CustomHostAlias")]
        [Validation(Required=false)]
        public string CustomHostAlias { get; set; }

        /// <summary>
        /// <para>The custom image type. Set to an empty string for non-custom images:</para>
        /// <list type="bullet">
        /// <item><description><para>internet: Public network image</para>
        /// </description></item>
        /// <item><description><para>intranet: Private network image</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("CustomImageNetworkType")]
        [Validation(Required=false)]
        public string CustomImageNetworkType { get; set; }

        /// <summary>
        /// <para>This parameter applies only to stopped applications. If you call <b>DeployApplication</b> on a running application, it deploys immediately.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Default. Deploys immediately, applies the new configuration, and starts instances.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Applies the new configuration only. Does not start application instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public string Deploy { get; set; }

        /// <summary>
        /// <para>The .NET framework version:</para>
        /// <list type="bullet">
        /// <item><description><para>.NET 3.1</para>
        /// </description></item>
        /// <item><description><para>.NET 5.0</para>
        /// </description></item>
        /// <item><description><para>.NET 6.0</para>
        /// </description></item>
        /// <item><description><para>.NET 7.0</para>
        /// </description></item>
        /// <item><description><para>.NET 8.0</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>.NET 3.1</para>
        /// </summary>
        [NameInMap("Dotnet")]
        [Validation(Required=false)]
        public string Dotnet { get; set; }

        /// <summary>
        /// <para>The version of the application runtime environment for HSF applications, such as Ali-Tomcat containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>The configuration for shared temporary storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;workdir\&quot;,\&quot;mountPath\&quot;:\&quot;/usr/local/tomcat/webapps\&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirDesc")]
        [Validation(Required=false)]
        public string EmptyDirDesc { get; set; }

        /// <summary>
        /// <para>Whether to integrate with AHAS. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Integrate with AHAS.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not integrate with AHAS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public string EnableAhas { get; set; }

        /// <summary>
        /// <para>Whether to enable CPU Burst:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuBurst")]
        [Validation(Required=false)]
        public bool? EnableCpuBurst { get; set; }

        /// <summary>
        /// <para>Whether to enable traffic canary rules. These rules apply only to Spring Cloud and Dubbo applications. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable canary rules.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable canary rules.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableGreyTagRoute")]
        [Validation(Required=false)]
        public bool? EnableGreyTagRoute { get; set; }

        /// <summary>
        /// <para>Whether to reuse the namespace Agent version configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNamespaceAgentVersion")]
        [Validation(Required=false)]
        public bool? EnableNamespaceAgentVersion { get; set; }

        /// <summary>
        /// <para>Whether to enable the new ARMS feature:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// <para>Whether to enable Prometheus custom metric collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePrometheus")]
        [Validation(Required=false)]
        public bool? EnablePrometheus { get; set; }

        /// <summary>
        /// <para>Whether to isolate sidecar resources:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Isolate.</para>
        /// </description></item>
        /// <item><description><para>false: Do not isolate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSidecarResourceIsolated")]
        [Validation(Required=false)]
        public bool? EnableSidecarResourceIsolated { get; set; }

        /// <summary>
        /// <para>The environment variables for your container. You can define custom variables or reference configuration items. To reference a configuration item, first create a ConfigMap instance. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom configuration</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The value of the environment variable. Takes precedence over valueFrom.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference a configuration item (valueFrom)</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, use <c>sae-sys-configmap-all-&lt;configmap-name&gt;</c>, for example <c>sae-sys-configmap-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: The reference type. Set to <c>configMapRef</c>.</para>
        /// </description></item>
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap instance.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key. Omit this field if you reference all keys.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference a secret (valueFrom)</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, use <c>sae-sys-secret-all-&lt;secret-name&gt;</c>, for example <c>sae-sys-secret-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: The reference type. Set to <c>secretRef</c>.</para>
        /// </description></item>
        /// <item><description><para><b>secretId</b>: The ID of the secret.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key. Omit this field if you reference all keys.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;name&quot;: &quot;sae-sys-configmap-all-hello&quot;, &quot;valueFrom&quot;: { &quot;configMapRef&quot;: { &quot;configMapId&quot;: 100, &quot;key&quot;: &quot;&quot; } } }, { &quot;name&quot;: &quot;hello&quot;, &quot;valueFrom&quot;: { &quot;configMapRef&quot;: { &quot;configMapId&quot;: 101, &quot;key&quot;: &quot;php-fpm&quot; } } }, { &quot;name&quot;: &quot;sae-sys-secret-all-hello&quot;, &quot;valueFrom&quot;: { “secretRef&quot;: { “secretId&quot;: 100, &quot;key&quot;: &quot;&quot; } } }, { &quot;name&quot;: “password”, &quot;valueFrom&quot;: { “secretRef&quot;: { “secretId&quot;: 101, &quot;key&quot;: “password” } } }, { &quot;name&quot;: &quot;envtmp&quot;, &quot;value&quot;: &quot;newenv&quot; } ]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("GpuConfig")]
        [Validation(Required=false)]
        public string GpuConfig { get; set; }

        /// <summary>
        /// <para>The Nginx version:</para>
        /// <list type="bullet">
        /// <item><description><para>nginx 1.20</para>
        /// </description></item>
        /// <item><description><para>nginx 1.22</para>
        /// </description></item>
        /// <item><description><para>nginx 1.24</para>
        /// </description></item>
        /// <item><description><para>nginx 1.26</para>
        /// </description></item>
        /// <item><description><para>nginx 1.28</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nginx 1.28</para>
        /// </summary>
        [NameInMap("Html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        /// <summary>
        /// <para>The ID of the corresponding secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// <para>The registry address of your image. Required when <b>Package Type</b> is <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The initialization container configuration.</para>
        /// </summary>
        [NameInMap("InitContainersConfig")]
        [Validation(Required=false)]
        public string InitContainersConfigShrink { get; set; }

        /// <summary>
        /// <para>Startup arguments for your JAR package. Default startup command: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>Startup options for your JAR package. Default startup command: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-option</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The JDK version that your deployment package depends on. Supported versions include the following:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Open JDK 8</b></para>
        /// </description></item>
        /// <item><description><para><b>Open JDK 7</b></para>
        /// </description></item>
        /// <item><description><para><b>Dragonwell 11</b></para>
        /// </description></item>
        /// <item><description><para><b>Dragonwell 8</b></para>
        /// </description></item>
        /// <item><description><para><b>openjdk-8u191-jdk-alpine3.9</b></para>
        /// </description></item>
        /// <item><description><para><b>openjdk-7u201-jdk-alpine3.9</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is not supported when <b>Package Type</b> is <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The configuration for collecting logs to Kafka. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>kafkaEndpoint</b>: The endpoint for the Kafka API.</para>
        /// </description></item>
        /// <item><description><para><b>kafkaInstanceId</b>: The Kafka instance ID.</para>
        /// </description></item>
        /// <item><description><para><b>kafkaConfigs</b>: The configuration for one or more log entries. For examples and details, see the \<em>\<em>kafkaConfigs\</em>\</em> request parameter in this topic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kafkaEndpoint&quot;:&quot;10.0.X.XXX:XXXX,10.0.X.XXX:XXXX,10.0.X.XXX:XXXX&quot;,&quot;kafkaInstanceId&quot;:&quot;alikafka_pre-cn-7pp2l8kr****&quot;,&quot;kafkaConfigs&quot;:[{&quot;logType&quot;:&quot;file_log&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;kafkaTopic&quot;:&quot;test2&quot;},{&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;kafkaTopic&quot;:&quot;test&quot;}]}</para>
        /// </summary>
        [NameInMap("KafkaConfigs")]
        [Validation(Required=false)]
        public string KafkaConfigs { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>Health checks for your container. Containers that fail health checks are terminated and restarted. Supported methods:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exec</b>: For example, <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></para>
        /// </description></item>
        /// <item><description><para><b>httpGet</b>: For example, <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
        /// </description></item>
        /// <item><description><para><b>tcpSocket</b>: For example, <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can select only one health check method.</para>
        /// </remarks>
        /// <para>Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exec.command</b>: The health check command.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.path</b>: The path to access.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.isContainKeyWord</b>: <b>true</b> means the response contains a keyword. <b>false</b> means it does not. If omitted, advanced features are disabled.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.keyWord</b>: Your custom keyword. Include <b>isContainKeyWord</b> when using this field.</para>
        /// </description></item>
        /// <item><description><para><b>tcpSocket.port</b>: The port for TCP connection checks.</para>
        /// </description></item>
        /// <item><description><para><b>initialDelaySeconds</b>: The delay before the first health check, in seconds. Default is 10.</para>
        /// </description></item>
        /// <item><description><para><b>periodSeconds</b>: The interval between health checks, in seconds. Default is 30.</para>
        /// </description></item>
        /// <item><description><para><b>timeoutSeconds</b>: The timeout for each health check, in seconds. Default is 1. If set to 0 or omitted, the default is 1 second.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sleep&quot;,&quot;5s&quot;]},&quot;initialDelaySeconds&quot;:10,&quot;timeoutSeconds&quot;:11}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        [NameInMap("LokiConfigs")]
        [Validation(Required=false)]
        public string LokiConfigs { get; set; }

        /// <summary>
        /// <para>The maximum number of surge instances as a percentage of total instances. Values:</para>
        /// <para>If the minimum available instances is 100%, the maximum surge cannot be set to 0. If set to -1, the system uses its recommended value: 30% of your current instance count. For example, with 10 instances, 10 × 30% = 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MaxSurgeInstanceRatio")]
        [Validation(Required=false)]
        public int? MaxSurgeInstanceRatio { get; set; }

        /// <summary>
        /// <para>The maximum number of surge instances during a rolling update. Values:</para>
        /// <para>If the minimum available instances is 100%, the maximum surge cannot be set to 0. If set to -1, the system uses its recommended value: 30% of your current instance count. For example, with 10 instances, 10 × 30% = 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MaxSurgeInstances")]
        [Validation(Required=false)]
        public int? MaxSurgeInstances { get; set; }

        /// <summary>
        /// <para>The memory required per instance, in MB. Cannot be zero. Memory and CPU are paired. Supported fixed specifications:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1024</b>: Pairs with 500 and 1000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>2048</b>: Pairs with 500, 1000, and 2000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>4096</b>: Pairs with 1000, 2000, and 4000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>8192</b>: Pairs with 2000, 4000, and 8000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>12288</b>: Pairs with 12000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>16384</b>: Pairs with 4000, 8000, and 16000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>24576</b>: Pairs with 12000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>32768</b>: Pairs with 16000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>65536</b>: Pairs with 8000, 16000, and 32000 milliCPU.</para>
        /// </description></item>
        /// <item><description><para><b>131072</b>: Pairs with 32000 milliCPU.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>Select a Nacos registry center. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Built-in Nacos in SAE.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Self-managed Nacos.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: MSE Nacos Commercial Edition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you select built-in Nacos in SAE, you cannot retrieve its configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <para>The registry configuration. Applies only when the registry type is MSE Nacos Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// <para>Configure microservice governance features.</para>
        /// <list type="bullet">
        /// <item><description><para>Enable microservice governance (enable):</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Configure graceful start and shutdown (mseLosslessRule):</para>
        /// <list type="bullet">
        /// <item><description><para>delayTime: Delay time</para>
        /// </description></item>
        /// <item><description><para>enable: Whether to enable graceful start. true enables it. false disables it.</para>
        /// </description></item>
        /// <item><description><para>notice: Whether to enable notifications. true enables them. false disables them.</para>
        /// </description></item>
        /// <item><description><para>warmupTime: Warm-up duration for small traffic, in seconds.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;: true,&quot;mseLosslessRule&quot;: {&quot;delayTime&quot;: 0,&quot;enable&quot;: false,&quot;notice&quot;: false,&quot;warmupTime&quot;: 120}}</para>
        /// </summary>
        [NameInMap("MicroserviceEngineConfig")]
        [Validation(Required=false)]
        public string MicroserviceEngineConfig { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances as a percentage of total instances. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: Use the default value. No percentage is applied.</para>
        /// </description></item>
        /// <item><description><para><b>0–100</b>: Percentage value. Rounded up. For example, if set to <b>50</b>% and you have 5 instances, the minimum is 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If both <b>MinReadyInstances</b> and <b>MinReadyInstanceRatio</b> are provided, and <b>MinReadyInstanceRatio</b> is not <b>-1</b>, then <b>MinReadyInstanceRatio</b> takes precedence. For example, if <b>MinReadyInstances</b> is <b>5</b> and <b>MinReadyInstanceRatio</b> is <b>50</b>, the system calculates the minimum based on 50%.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that remain available during a rolling update. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>If set to <b>0</b>, your application experiences downtime during updates.</para>
        /// </description></item>
        /// <item><description><para>If set to -1, the system uses its recommended value: 25% of your current instance count. For example, with 5 instances, 5 × 25% = 1.25, rounded up to 2.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>We recommend setting this value to at least 1 to avoid service interruptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>We recommend using <b>NasConfigs</b> instead of this field. The NAS mount description. If your NAS configuration remains unchanged, omit this parameter. To clear your NAS configuration, set this field to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>We recommend using <b>NasConfigs</b> instead of this field. The mount target of the NAS in your application\&quot;s VPC. If your NAS configuration remains unchanged, omit this parameter. To clear your NAS configuration, set this field to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4bc9****.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The configuration for mounting NAS. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>mountPath</b>: The mount path in the container.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: Set to <b>false</b> for read and write permissions.</para>
        /// </description></item>
        /// <item><description><para><b>nasId</b>: The NAS ID.</para>
        /// </description></item>
        /// <item><description><para><b>mountDomain</b>: The mount target address. For more information, see <a href="https://help.aliyun.com/document_detail/62626.html">DescribeMountTargets</a>.</para>
        /// </description></item>
        /// <item><description><para><b>nasPath</b>: The relative directory in NAS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// <para>We recommend using <b>NasConfigs</b> instead of this field. The ID of the NAS file system. If your NAS configuration remains unchanged, omit this parameter. To clear your NAS configuration, set this field to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The application version:</para>
        /// <list type="bullet">
        /// <item><description><para>lite: Lite Edition</para>
        /// </description></item>
        /// <item><description><para>std: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>pro: Professional Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>The RAM role for identity authentication.</para>
        /// <remarks>
        /// <para>Create an OIDC identity provider and an associated role in the same region before using this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/2331022.html">Create an OIDC identity provider</a> and <a href="https://help.aliyun.com/document_detail/2331016.html">Create a role for SSO identity providers</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sae-test</para>
        /// </summary>
        [NameInMap("OidcRoleName")]
        [Validation(Required=false)]
        public string OidcRoleName { get; set; }

        /// <summary>
        /// <para>The AccessKey ID for OSS read and write operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret for OSS read and write operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// <para>The OSS mount description. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>bucketName</b>: The name of the bucket.</para>
        /// </description></item>
        /// <item><description><para><b>bucketPath</b>: The directory or object in OSS. If the directory does not exist, an error occurs.</para>
        /// </description></item>
        /// <item><description><para><b>mountPath</b>: The path in your SAE container. If the path exists, it is overwritten. If it does not exist, it is created.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: Whether the container path has read-only access to the mounted resource. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Read-only.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Read and write.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;bucketName&quot;: &quot;oss-bucket&quot;, &quot;bucketPath&quot;: &quot;data/user.data&quot;, &quot;mountPath&quot;: &quot;/usr/data/user.data&quot;, &quot;readOnly&quot;: true}]</para>
        /// </summary>
        [NameInMap("OssMountDescs")]
        [Validation(Required=false)]
        public string OssMountDescs { get; set; }

        /// <summary>
        /// <para>The type of your application package. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>For Java applications: <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</para>
        /// </description></item>
        /// <item><description><para>For PHP applications:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PhpZip</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_4</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_4_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_5</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_5_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_6</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_5_6_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_0</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_0_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_1</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_1_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_2</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_2_ALPINE</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_3</b></para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_PHP_7_3_ALPINE</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For Python applications: <b>PythonZip</b> and <b>Image</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FatJar</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The URL of your deployment package. Required when <b>Package Type</b> is <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version number of your deployment package. Required when <b>Package Type</b> is <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The PHP version that your PHP deployment package depends on. Not supported for images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP-FPM 7.0</para>
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// <para>The mount path for PHP application monitoring. Ensure your PHP server loads the configuration file at this path. You do not need to manage the configuration content. SAE renders the correct configuration automatically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/conf.d/arms.ini</para>
        /// </summary>
        [NameInMap("PhpArmsConfigLocation")]
        [Validation(Required=false)]
        public string PhpArmsConfigLocation { get; set; }

        /// <summary>
        /// <para>The content of the PHP configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k1=v1</para>
        /// </summary>
        [NameInMap("PhpConfig")]
        [Validation(Required=false)]
        public string PhpConfig { get; set; }

        /// <summary>
        /// <para>The mount path for the PHP startup configuration. Ensure your PHP server uses this configuration file to start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>A script that runs after your container starts. It executes immediately after the container is created. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>A script that runs before your container stops. It executes just before the container is deleted. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>Enable K8s Service registration and discovery. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>portProtocols</b>: Port and protocol. Port range is [1,65535]. Protocols supported: <b>TCP</b> and <b>UDP</b>.</para>
        /// </description></item>
        /// <item><description><para>portAndProtocol: Port and protocol. Port range is [1,65535]. Protocols supported: <b>TCP</b> and <b>UDP</b>. <b>portProtocols</b> takes precedence. If both are set, only <b>portProtocols</b> applies.</para>
        /// </description></item>
        /// <item><description><para><b>enable</b>: Enable K8s Service registration and discovery.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;portProtocols&quot;:[{&quot;port&quot;:18012,&quot;protocol&quot;:&quot;TCP&quot;}],&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The Python runtime environment. Supported: <b>PYTHON 3.9.15</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHON 3.9.15</para>
        /// </summary>
        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        /// <summary>
        /// <para>Custom module dependencies. By default, dependencies defined in requirements.txt in the root directory are installed. If no configuration or custom packages exist, specify the dependencies to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// <para>Startup status checks for your application. Containers that repeatedly fail readiness checks are terminated and restarted. Containers that fail readiness checks receive no SLB traffic. Supports <b>exec</b>, <b>httpGet</b>, and <b>tcpSocket</b>. For examples, see the <b>Liveness</b> parameter.</para>
        /// <remarks>
        /// <para>You can select only one health check method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sleep&quot;,&quot;6s&quot;]},&quot;initialDelaySeconds&quot;:15,&quot;timeoutSeconds&quot;:12}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>The number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The mount description for a <b>Secret</b>. Use secrets created on the namespace secrets page to inject sensitive information into your container. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>secretId</b>: The ID of the secret instance. Get it by calling the ListSecrets API.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing <c>sae-sys-secret-all</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: The mount path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{“secretId&quot;:10,”key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("SecretMountDesc")]
        [Validation(Required=false)]
        public string SecretMountDesc { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-wz969ngg2e49q5i4****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The canary tags configured for your application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;alicloud.service.tag\&quot;:\&quot;g1\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceTags")]
        [Validation(Required=false)]
        public string ServiceTags { get; set; }

        /// <summary>
        /// <para>Container configuration information.</para>
        /// </summary>
        [NameInMap("SidecarContainersConfig")]
        [Validation(Required=false)]
        public string SidecarContainersConfigShrink { get; set; }

        /// <summary>
        /// <para>The configuration for collecting logs to Simple Log Service (SLS).</para>
        /// <list type="bullet">
        /// <item><description><para>Using SAE-managed SLS resources: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
        /// </description></item>
        /// <item><description><para>Using custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>projectName</b>: The name of the SLS project.</para>
        /// </description></item>
        /// <item><description><para><b>logDir</b>: The log file path.</para>
        /// </description></item>
        /// <item><description><para>logType: The log type. <b>stdout</b> means standard output logs from the container. Only one <b>stdout</b> entry is allowed. If omitted, file logs are collected.</para>
        /// </description></item>
        /// <item><description><para><b>logstoreName</b>: The name of the SLS Logstore.</para>
        /// </description></item>
        /// <item><description><para><b>logtailName</b>: The name of the SLS Logtail. If omitted, a new Logtail is created.</para>
        /// </description></item>
        /// </list>
        /// <para>If your SLS collection configuration remains unchanged across deployments, omit this parameter. To disable SLS collection, set this field to an empty string.</para>
        /// <remarks>
        /// <para>Projects automatically created by SAE are deleted when the application is deleted. Do not select these projects when choosing an existing project.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>The SLS log tags.</para>
        /// </summary>
        [NameInMap("SlsLogEnvTags")]
        [Validation(Required=false)]
        public string SlsLogEnvTags { get; set; }

        /// <summary>
        /// <para>Enable application startup probing.</para>
        /// <list type="bullet">
        /// <item><description><para>Success: The application starts successfully. If you configure Liveness and Readiness checks, they run after startup.</para>
        /// </description></item>
        /// <item><description><para>Failure: The application fails to start. SAE reports an error and restarts the container automatically.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Description</para>
        /// <list type="bullet">
        /// <item><description><para>Supports exec, httpGet, and tcpSocket. For examples, see the Liveness parameter.</para>
        /// </description></item>
        /// <item><description><para>You can select only one health check method.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public string StartupProbe { get; set; }

        /// <summary>
        /// <para>Configures service discovery and end-to-end canary release based on a Kubernetes Service:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Specifies whether to enable the end-to-end canary release feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false: Disables the feature.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>namespaceId: The namespace ID.</para>
        /// </description></item>
        /// <item><description><para>portAndProtocol: The listening port and protocol. The format is {&quot;\<port>:\<protocol>&quot;:&quot;\<target_port>&quot;}.</para>
        /// </description></item>
        /// <item><description><para>portProtocols: A list of ports and protocols for the service.</para>
        /// <list type="bullet">
        /// <item><description><para>port: The port number.</para>
        /// </description></item>
        /// <item><description><para>protocol: The protocol.</para>
        /// </description></item>
        /// <item><description><para>targetPort: The container port.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>pvtzDiscoveryName: The service discovery name.</para>
        /// </description></item>
        /// <item><description><para>serviceId: The service ID.</para>
        /// </description></item>
        /// <item><description><para>serviceName: The service name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enable\&quot;:\&quot;false\&quot;,\&quot;namespaceId\&quot;:\&quot;cn-beijing:test\&quot;,\&quot;portAndProtocol\&quot;:{\&quot;2000:TCP\&quot;:\&quot;18081\&quot;},\&quot;portProtocols\&quot;:[{\&quot;port\&quot;:2000,\&quot;protocol\&quot;:\&quot;TCP\&quot;,\&quot;targetPort\&quot;:18081}],\&quot;pvtzDiscoveryName\&quot;:\&quot;cn-beijing-1421801774382676\&quot;,\&quot;serviceId\&quot;:\&quot;3513\&quot;,\&quot;serviceName\&quot;:\&quot;demo-gray.test\&quot;}</para>
        /// </summary>
        [NameInMap("SwimlanePvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string SwimlanePvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The graceful shutdown timeout, in seconds. Default is 30. Valid values: 1–300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The time zone. Default is <b>Asia/Shanghai</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The Tomcat configuration. Set to an empty string or {} to delete the configuration. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: Port range is 1024–65535. Ports below 1024 require root privileges. Because containers run with admin privileges, use ports above 1024. Default is 8080.</para>
        /// </description></item>
        /// <item><description><para><b>contextPath</b>: The access path. Default is the root directory /.</para>
        /// </description></item>
        /// <item><description><para><b>maxThreads</b>: The size of the connection pool. Default is 400.</para>
        /// </description></item>
        /// <item><description><para>uriEncoding: The encoding format for Tomcat. Options include <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. Default is <b>ISO-8859-1</b>.</para>
        /// </description></item>
        /// <item><description><para><b>useBodyEncodingForUri</b>: Whether to use body encoding for URLs. Default is <b>true</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        /// <summary>
        /// <para>The release strategy. When MinReadyInstances equals 1, set UpdateStrategy to an empty string. When <b>MinReadyInstances</b> is greater than 1, examples include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>Canary release with 1 instance, followed by 2 automatic batches with a 1-minute interval: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Canary release with 1 instance, followed by 2 manual batches: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Two automatic batches with a 0-minute interval: <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
        /// </description></item>
        /// </list>
        /// <para>Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: The release strategy type. Options are <b>GrayBatchUpdate</b> (canary release) or <b>BatchUpdate</b> (phased release).</para>
        /// </description></item>
        /// <item><description><para><b>batchUpdate</b>: The phased release strategy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>batch</b>: The number of batches.</para>
        /// </description></item>
        /// <item><description><para><b>releaseType</b>: How batches are processed. Options are <b>auto</b> (automatic) or <b>manual</b> (manual).</para>
        /// </description></item>
        /// <item><description><para><b>batchWaitTime</b>: The wait time between batches, in minutes.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>grayUpdate</b>: The number of canary instances. Required when <b>type</b> is <b>GrayBatchUpdate</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</para>
        /// </summary>
        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        /// <summary>
        /// <para>The virtual switch where your application instance elastic network interfaces reside. This switch must be in the specified VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The startup command for your WAR package. Configure it the same way as the startup command for images. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Set the startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The Tomcat version that your deployment package depends on. Supported versions include the following:</para>
        /// <list type="bullet">
        /// <item><description><para><b>apache-tomcat-7.0.91</b></para>
        /// </description></item>
        /// <item><description><para><b>apache-tomcat-8.5.42</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is not supported when <b>Package Type</b> is <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
