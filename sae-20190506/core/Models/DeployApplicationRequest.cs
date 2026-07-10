// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeployApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ARN of the RAM role required for cross-account image pulling. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions across Alibaba Cloud accounts by using a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The Container Registry Enterprise instance ID. This parameter is required when <b>ImageUrl</b> is set to a Container Registry Enterprise instance image.</para>
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
        /// <para>The ALB gateway ReadinessGate configuration.</para>
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
        /// <para>Specifies whether to associate an elastic IP address (EIP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: associates an EIP.</description></item>
        /// <item><description><b>false</b>: does not associate an EIP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssociateEip")]
        [Validation(Required=false)]
        public bool? AssociateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically enable the application elastic scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// <para>The interval between deployment batches. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The description of the change order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start application</para>
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        /// <summary>
        /// <para>The image startup command. The command must be an executable object in the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>Based on the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments of the image startup command. These are the arguments required by the startup command specified in <b>Command</b>. Format:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>, where <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to a String type, and the internal format is a JSON array. If this parameter is not required, leave it empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The <b>ConfigMap</b> mount description. Use a ConfigMap created on the namespace configuration items page to inject configuration information into the container. Settings:</para>
        /// <list type="bullet">
        /// <item><description><b>configMapId</b>: the ConfigMap instance ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation.</description></item>
        /// <item><description><b>key</b>: the key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing the <c>sae-sys-configmap-all</c> parameter.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the mount path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>The CPU resources required for each instance. Unit: millicores. This parameter cannot be set to 0. Only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>500</b></description></item>
        /// <item><description><b>1000</b></description></item>
        /// <item><description><b>2000</b></description></item>
        /// <item><description><b>4000</b></description></item>
        /// <item><description><b>8000</b></description></item>
        /// <item><description><b>12000</b></description></item>
        /// <item><description><b>16000</b></description></item>
        /// <item><description><b>32000</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The custom host mapping in the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hostName</b>: the domain name or hostname.</description></item>
        /// <item><description><b>ip</b>: the IP address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;hostName&quot;:&quot;samplehost&quot;,&quot;ip&quot;:&quot;127.0.0.1&quot;}]</para>
        /// </summary>
        [NameInMap("CustomHostAlias")]
        [Validation(Required=false)]
        public string CustomHostAlias { get; set; }

        /// <summary>
        /// <para>The custom image type. If the image is not a custom image, set this parameter to an empty string:</para>
        /// <list type="bullet">
        /// <item><description>internet: public image.</description></item>
        /// <item><description>intranet: private image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("CustomImageNetworkType")]
        [Validation(Required=false)]
        public string CustomImageNetworkType { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only for applications in the stopped state. If you call the <b>DeployApplication</b> operation for a running application, the application is immediately redeployed.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: default value. Deploys immediately, applies the new deployment configuration, and starts instances.</description></item>
        /// <item><description><b>false</b>: applies the new deployment configuration only, without starting application instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public string Deploy { get; set; }

        /// <summary>
        /// <para>The version of the .NET framework: </para>
        /// <list type="bullet">
        /// <item><description>.NET 3.1</description></item>
        /// <item><description>.NET 5.0</description></item>
        /// <item><description>.NET 6.0</description></item>
        /// <item><description>.NET 7.0</description></item>
        /// <item><description>.NET 8.0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>.NET 3.1</para>
        /// </summary>
        [NameInMap("Dotnet")]
        [Validation(Required=false)]
        public string Dotnet { get; set; }

        /// <summary>
        /// <para>The version of the application runtime environment in the HSF framework, such as the Ali-Tomcat container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>The shared ephemeral storage configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;workdir\&quot;,\&quot;mountPath\&quot;:\&quot;/usr/local/tomcat/webapps\&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirDesc")]
        [Validation(Required=false)]
        public string EmptyDirDesc { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Application High Availability Service (AHAS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables AHAS.</description></item>
        /// <item><description><b>false</b>: does not enable AHAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public string EnableAhas { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the CPU Burst feature:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuBurst")]
        [Validation(Required=false)]
        public bool? EnableCpuBurst { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable traffic canary release rules. This rule applies only to applications that use the Spring Cloud or Dubbo framework. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables canary release rules.</description></item>
        /// <item><description><b>false</b>: disables canary release rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableGreyTagRoute")]
        [Validation(Required=false)]
        public bool? EnableGreyTagRoute { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse the namespace Agent version configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNamespaceAgentVersion")]
        [Validation(Required=false)]
        public bool? EnableNamespaceAgentVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the new ARMS feature:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable custom Prometheus metric collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePrometheus")]
        [Validation(Required=false)]
        public bool? EnablePrometheus { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable sidecar resource isolation:</para>
        /// <list type="bullet">
        /// <item><description>true: enables isolation.</description></item>
        /// <item><description>false: does not enable isolation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSidecarResourceIsolated")]
        [Validation(Required=false)]
        public bool? EnableSidecarResourceIsolated { get; set; }

        /// <summary>
        /// <para>The container environment variable parameters. You can customize environment variables or reference ConfigMap items. To reference a ConfigMap item, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom configuration<list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable.</description></item>
        /// <item><description><b>value</b>: the value of the environment variable. This takes priority over valueFrom.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Reference a ConfigMap item (valueFrom)<list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, such as <c>sae-sys-configmap-all-test1</c>.</description></item>
        /// <item><description><b>valueFrom</b>: the environment variable reference. Set the value to <c>configMapRef</c>.</description></item>
        /// <item><description><b>configMapId</b>: the ConfigMap ID.</description></item>
        /// <item><description><b>key</b>: the key. Do not set this field if you want to reference all keys.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Reference a secret (valueFrom)<list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable. To reference all keys, enter <c>sae-sys-secret-all-&lt;secret name&gt;</c>, such as <c>sae-sys-secret-all-test1</c>.</description></item>
        /// <item><description><b>valueFrom</b>: the environment variable reference. Set the value to <c>secretRef</c>.</description></item>
        /// <item><description><b>secretId</b>: the secret ID.</description></item>
        /// <item><description><b>key</b>: the key. Do not set this field if you want to reference all keys.</description></item>
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
        /// <para>The Nginx version.</para>
        /// <list type="bullet">
        /// <item><description>nginx 1.20</description></item>
        /// <item><description>nginx 1.22</description></item>
        /// <item><description>nginx 1.24</description></item>
        /// <item><description>nginx 1.26</description></item>
        /// <item><description>nginx 1.28</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nginx 1.28</para>
        /// </summary>
        [NameInMap("Html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        /// <summary>
        /// <para>The corresponding secret ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// <para>The image URL. This parameter is required when <b>Package Type</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The init container configuration.</para>
        /// </summary>
        [NameInMap("InitContainersConfig")]
        [Validation(Required=false)]
        public List<InitContainerConfig> InitContainersConfig { get; set; }

        /// <summary>
        /// <para>The startup arguments for a JAR package-based application. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The startup options for a JAR package-based application. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-option</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The JDK version on which the deployment package depends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Open JDK 8</b></description></item>
        /// <item><description><b>Open JDK 7</b></description></item>
        /// <item><description><b>Dragonwell 11</b></description></item>
        /// <item><description><b>Dragonwell 8</b></description></item>
        /// <item><description><b>openjdk-8u191-jdk-alpine3.9</b></description></item>
        /// <item><description><b>openjdk-7u201-jdk-alpine3.9</b></description></item>
        /// </list>
        /// <para>This parameter is not supported when <b>Package Type</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The summary of log collection configurations for Kafka. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kafkaEndpoint</b>: the endpoint of the Kafka API.</description></item>
        /// <item><description><b>kafkaInstanceId</b>: the Kafka instance ID.</description></item>
        /// <item><description><b>kafkaConfigs</b>: the configuration summary for one or more log entries. For example values and parameter descriptions, see the <b>kafkaConfigs</b> request parameter in this topic.</description></item>
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
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The container health check. Containers that fail the health check are shutdown and recovered. The following methods are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>exec</b>: for example, <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></description></item>
        /// <item><description><b>httpGet</b>: for example, <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
        /// <item><description><b>tcpSocket</b>: for example, <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>Only one method can be selected for health checks.</para>
        /// </remarks>
        /// <para>Settings:</para>
        /// <list type="bullet">
        /// <item><description><b>exec.command</b>: sets the health check command.</description></item>
        /// <item><description><b>httpGet.path</b>: the access path.</description></item>
        /// <item><description><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</description></item>
        /// <item><description><b>httpGet.isContainKeyWord</b>: <b>true</b> indicates that the keyword is included, <b>false</b> indicates that the keyword is not included, and the absence of this field indicates that the advanced feature is not used.</description></item>
        /// <item><description><b>httpGet.keyWord</b>: the custom keyword. The <b>isContainKeyWord</b> field must be present when this parameter is used.</description></item>
        /// <item><description><b>tcpSocket.port</b>: the port for TCP connection detection.</description></item>
        /// <item><description><b>initialDelaySeconds</b>: sets the initial delay for the health check. Default value: 10. Unit: seconds.</description></item>
        /// <item><description><b>periodSeconds</b>: sets the health check epoch. Default value: 30. Unit: seconds.</description></item>
        /// <item><description><b>timeoutSeconds</b>: sets the health check timeout period. Default value: 1. Unit: seconds. If this parameter is set to 0 or is not set, the default timeout period is 1 second.</description></item>
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
        /// <para>The maximum surge instance percentage. Valid values:</para>
        /// <para>If the minimum number of available instances is 100%, the maximum surge cannot be set to 0. If this parameter is set to <b>-1</b>, the system-recommended value of 30% is used, which is 30% of the current number of instances. For example, if the current number of instances is 10, the value is 10 × 30% = 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MaxSurgeInstanceRatio")]
        [Validation(Required=false)]
        public int? MaxSurgeInstanceRatio { get; set; }

        /// <summary>
        /// <para>The maximum number of surge instances. Valid values:</para>
        /// <para>If the minimum number of available instances is 100%, the maximum surge cannot be set to 0.
        /// If this parameter is set to <b>-1</b>, the system-recommended value of 30% is used, which is 30% of the current number of instances. For example, if the current number of instances is 10, the value is 10 × 30% = 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MaxSurgeInstances")]
        [Validation(Required=false)]
        public int? MaxSurgeInstances { get; set; }

        /// <summary>
        /// <para>The memory required for each instance. Unit: MB. This parameter cannot be set to 0. The memory has a one-to-one mapping with CPU. Only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>1024</b>: corresponds to 500 and 1000 millicores of CPU.</description></item>
        /// <item><description><b>2048</b>: corresponds to 500, 1000, and 2000 millicores of CPU.</description></item>
        /// <item><description><b>4096</b>: corresponds to 1000, 2000, and 4000 millicores of CPU.</description></item>
        /// <item><description><b>8192</b>: corresponds to 2000, 4000, and 8000 millicores of CPU.</description></item>
        /// <item><description><b>12288</b>: corresponds to 12000 millicores of CPU.</description></item>
        /// <item><description><b>16384</b>: corresponds to 4000, 8000, and 16000 millicores of CPU.</description></item>
        /// <item><description><b>24576</b>: corresponds to 12000 millicores of CPU.</description></item>
        /// <item><description><b>32768</b>: corresponds to 16000 millicores of CPU.</description></item>
        /// <item><description><b>65536</b>: corresponds to 8000, 16000, and 32000 millicores of CPU.</description></item>
        /// <item><description><b>131072</b>: corresponds to 32000 millicores of CPU.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>Specifies the Nacos registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Serverless App Engine built-in Nacos.</description></item>
        /// <item><description><b>1</b>: self-managed Nacos.</description></item>
        /// <item><description><b>2</b>: Microservices Engine (MSE) commercial edition Nacos.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you select Serverless App Engine built-in Nacos, you cannot obtain the configuration of the built-in Nacos.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <para>The registry configuration, which takes effect only when the registry type is MSE Nacos Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// <para>Configures microservice governance.</para>
        /// <list type="bullet">
        /// <item><description><para>Specifies whether to enable microservice governance (enable):</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false: disabled.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Configures lossless online/offline (mseLosslessRule):</para>
        /// <list type="bullet">
        /// <item><description><para>delayTime: the delay time.</para>
        /// </description></item>
        /// <item><description><para>enable: specifies whether to enable the lossless online feature. true indicates enabled, and false indicates disabled.</para>
        /// </description></item>
        /// <item><description><para>notice: specifies whether to enable the notification feature. true indicates enabled, and false indicates disabled.</para>
        /// </description></item>
        /// <item><description><para>warmupTime: the warm-up duration for low-traffic scenarios. Unit: seconds.</para>
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
        /// <para>The minimum percentage of available instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: the initialization value, which indicates that the percentage is not used.</description></item>
        /// <item><description><b>0~100</b>: the unit is percentage, rounded up. For example, if this parameter is set to <b>50</b>% and the current number of instances is 5, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When both <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and the value of <b>MinReadyInstanceRatio</b> is not <b>-1</b>, the <b>MinReadyInstanceRatio</b> parameter takes precedence. For example, if <b>MinReadyInstances</b> is set to <b>5</b> and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the value <b>50</b> is used to calculate the minimum number of available instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is set to <b>0</b>, service is interrupted during the upgrade.</description></item>
        /// <item><description>If this parameter is set to <b>-1</b>, the system-recommended value is used, which is 25% of the current number of instances. If the current number of instances is 5, 5 × 25% = 1.25, which is rounded up to 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum number of available instances for each rolling deployment should be ≥ 1 to prevent service interruption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>We do not recommend that you configure this field. Configure <b>NasConfigs</b> instead. The NAS mount description. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the <b>MountDesc</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>MountDesc</b> field to &quot;&quot; in the request).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>We do not recommend that you configure this field. Configure <b>NasConfigs</b> instead. The mount point of the NAS file system in the VPC of the application. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the <b>MountHost</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>MountHost</b> field to &quot;&quot; in the request).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4bc9****.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The NAS mount configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the container mount path.</description></item>
        /// <item><description><b>readOnly</b>: set to <b>false</b> for read and write permission.</description></item>
        /// <item><description><b>nasId</b>: the NAS ID.</description></item>
        /// <item><description><b>mountDomain</b>: the container mount point address. For more information, see <a href="https://help.aliyun.com/document_detail/62626.html">DescribeMountTargets</a>.</description></item>
        /// <item><description><b>nasPath</b>: the NAS relative file directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// <para>We do not recommend that you configure this field. Configure <b>NasConfigs</b> instead. The ID of the NAS file system. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the <b>NasId</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>NasId</b> field to &quot;&quot; in the request).</para>
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
        /// <item><description>lite: lite edition.</description></item>
        /// <item><description>std: standard edition.</description></item>
        /// <item><description>pro: professional edition.</description></item>
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
        /// <para>Create an OIDC identity provider and an identity provider role in the same region in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2331022.html">Create an OIDC identity provider</a> and <a href="https://help.aliyun.com/document_detail/2331016.html">Create a role for SSO identity provider</a>.</para>
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
        /// <para>The AccessKey Secret for OSS read and write operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// <para>The OSS mount description. Parameter settings:</para>
        /// <list type="bullet">
        /// <item><description><b>bucketName</b>: the bucket name.</description></item>
        /// <item><description><b>bucketPath</b>: the folder or object that you created in OSS. If the OSS mount folder does not exist, an exception is triggered.</description></item>
        /// <item><description><b>mountPath</b>: the container path in Serverless App Engine. If the path already exists, it is an overwrite relationship. If the path does not exist, it is created.</description></item>
        /// <item><description><b>readOnly</b>: specifies whether the container path has read-only permission on the mounted folder resources. Valid values:<list type="bullet">
        /// <item><description><b>true</b>: read-only permission.</description></item>
        /// <item><description><b>false</b>: read and write permission.</description></item>
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
        /// <para>The application package type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When you deploy with Java, the following types are supported: <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</description></item>
        /// <item><description>When you deploy with PHP, the following types are supported:<list type="bullet">
        /// <item><description><b>PhpZip</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_4</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_4_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_5</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_5_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_6</b></description></item>
        /// <item><description><b>IMAGE_PHP_5_6_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_0</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_0_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_1</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_1_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_2</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_2_ALPINE</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_3</b></description></item>
        /// <item><description><b>IMAGE_PHP_7_3_ALPINE</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>When you deploy with Python, the following types are supported: <b>PythonZip</b> and <b>Image</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FatJar</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The URL of the deployment package. This parameter is required when <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version number of the deployment package. This parameter is required when <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The PHP version on which the deployment package depends. Not supported for images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP-FPM 7.0</para>
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// <para>The mount path for PHP application monitoring. Ensure that the PHP server loads the configuration file from this path. You do not need to manage the configuration content because Serverless App Engine automatically renders the correct configuration file.</para>
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
        /// <para>The mount path for the PHP application startup configuration. Ensure that the PHP server uses this configuration file for startup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>The script that is run after the container starts. A script is triggered immediately after the container is created. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;\\]}}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script that is run before the container stops. A script is triggered before the container is deleted. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;\\]}}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>Enables K8s Service-based service registration and discovery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>portProtocols</b>: the port and protocol. Valid port values: [1,65535]. Valid protocol values: <b>TCP</b> and <b>UDP</b>.</description></item>
        /// <item><description><b>portAndProtocol</b>: the port and protocol. Valid port values: [1,65535]. Valid protocol values: <b>TCP</b> and <b>UDP</b>. <b>portProtocols is recommended. If portProtocols is set, only portProtocols takes effect</b>.</description></item>
        /// <item><description><b>enable</b>: enables K8s Service-based service registration and discovery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;portProtocols&quot;:[{&quot;port&quot;:18012,&quot;protocol&quot;:&quot;TCP&quot;}],&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The Python environment. <b>PYTHON 3.9.15</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHON 3.9.15</para>
        /// </summary>
        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        /// <summary>
        /// <para>The custom installation module dependencies. By default, the dependencies defined in the requirements.txt file in the root folder are installed. If no dependencies are configured or custom packages are needed, you can specify the dependencies to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        [NameInMap("RaspConfig")]
        [Validation(Required=false)]
        public DeployApplicationRequestRaspConfig RaspConfig { get; set; }
        public class DeployApplicationRequestRaspConfig : TeaModel {
            [NameInMap("EnableRasp")]
            [Validation(Required=false)]
            public bool? EnableRasp { get; set; }

            [NameInMap("RaspAppKey")]
            [Validation(Required=false)]
            public string RaspAppKey { get; set; }

            [NameInMap("RaspAppName")]
            [Validation(Required=false)]
            public string RaspAppName { get; set; }

        }

        /// <summary>
        /// <para>The application startup status check. Containers that fail multiple health checks are shut down and restarted. Containers that do not pass the health check do not receive SLB traffic. The <b>exec</b>, <b>httpGet</b>, and <b>tcpSocket</b> methods are supported. For specific examples, see the <b>Liveness</b> parameter.</para>
        /// <remarks>
        /// <para>Only one method can be selected for health checks.</para>
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
        /// <para>The <b>Secret</b> mount description. Use a secret created on the namespace secrets page to inject sensitive information into the container. Settings:</para>
        /// <list type="bullet">
        /// <item><description><b>secretId</b>: the secret instance ID. You can obtain it by calling the ListSecrets operation.</description></item>
        /// <item><description><b>key</b>: the key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing the <c>sae-sys-secret-all</c> parameter.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the mount path.</description></item>
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
        /// <para>The canary release tags configured for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;alicloud.service.tag\&quot;:\&quot;g1\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceTags")]
        [Validation(Required=false)]
        public string ServiceTags { get; set; }

        /// <summary>
        /// <para>The sidecar container configuration.</para>
        /// </summary>
        [NameInMap("SidecarContainersConfig")]
        [Validation(Required=false)]
        public List<SidecarContainerConfig> SidecarContainersConfig { get; set; }

        /// <summary>
        /// <para>The configuration for log collection to Simple Log Service.</para>
        /// <list type="bullet">
        /// <item><description>Use SLS resources automatically created by Serverless App Engine: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</description></item>
        /// <item><description>Use custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
        /// </list>
        /// <para>Settings:</para>
        /// <list type="bullet">
        /// <item><description><b>projectName</b>: the name of the project in Simple Log Service.  </description></item>
        /// <item><description><b>logDir</b>: the log path.</description></item>
        /// <item><description><b>logType</b>: the log type. <b>stdout</b> indicates container standard output logs, and only one entry can be set. If this parameter is not set, file logs are collected.</description></item>
        /// <item><description><b>logstoreName</b>: the name of the Logstore in Simple Log Service.</description></item>
        /// <item><description><b>logtailName</b>: the name of the Logtail in Simple Log Service. If this parameter is not specified, a new Logtail is created by automatic creation.</description></item>
        /// </list>
        /// <para>If the SLS collection configuration has not changed during multiple deployments, you do not need to set this parameter (that is, the <b>SlsConfigs</b> field does not need to be included in the request). If you no longer need the SLS collection feature, set the value of this field to an empty string (that is, set the value of the <b>SlsConfigs</b> field to &quot;&quot; in the request).</para>
        /// <remarks>
        /// <para>A project that is automatically created with the application is deleted when the application is deleted. Therefore, do not select a project that is automatically created by Serverless App Engine when selecting an existing project.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>sls log tags</para>
        /// </summary>
        [NameInMap("SlsLogEnvTags")]
        [Validation(Required=false)]
        public string SlsLogEnvTags { get; set; }

        /// <summary>
        /// <para>Enables the application startup probe.</para>
        /// <list type="bullet">
        /// <item><description>Check succeeded: indicates that the application started successfully. If you configured Liveness and Readiness checks, they are performed after the application starts successfully.</description></item>
        /// <item><description>Check failed: indicates that the application failed to start. An exception is reported and the application is automatically restarted.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This is the description content.</para>
        /// <list type="bullet">
        /// <item><description>The exec, httpGet, and tcpSocket methods are supported. For specific examples, see the Liveness parameter.</description></item>
        /// <item><description>Only one method can be selected for health checks.</description></item>
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
        /// <para>Configures K8s Service-based service registration and discovery with end-to-end canary release:</para>
        /// <list type="bullet">
        /// <item><description>enable: specifies whether to enable end-to-end canary release based on K8s Service.<list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>namespaceId: the namespace ID.</description></item>
        /// <item><description>portAndProtocol: the listening port and protocol. Format: {&quot;port:protocol type&quot;:&quot;container port&quot;}.</description></item>
        /// <item><description>portProtocols: defines the service port and protocol.<list type="bullet">
        /// <item><description>port: the port.</description></item>
        /// <item><description>protocol: the protocol.</description></item>
        /// <item><description>targetPort: the container port.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>pvtzDiscoveryName: the service discovery name.</description></item>
        /// <item><description>serviceId: the service ID.</description></item>
        /// <item><description>serviceName: the service name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enable\&quot;:\&quot;false\&quot;,\&quot;namespaceId\&quot;:\&quot;cn-beijing:test\&quot;,\&quot;portAndProtocol\&quot;:{\&quot;2000:TCP\&quot;:\&quot;18081\&quot;},\&quot;portProtocols\&quot;:[{\&quot;port\&quot;:2000,\&quot;protocol\&quot;:\&quot;TCP\&quot;,\&quot;targetPort\&quot;:18081}],\&quot;pvtzDiscoveryName\&quot;:\&quot;cn-beijing-1421801774382676\&quot;,\&quot;serviceId\&quot;:\&quot;3513\&quot;,\&quot;serviceName\&quot;:\&quot;demo-gray.test\&quot;}</para>
        /// </summary>
        [NameInMap("SwimlanePvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string SwimlanePvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The graceful shutdown timeout period. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The time zone. Default value: <b>Asia/Shanghai</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The Tomcat configuration. Set this parameter to &quot;&quot; or &quot;{}&quot; to delete the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port number. Valid values: 1024 to 65535. Ports smaller than 1024 require root permissions. Because the container is configured with admin permissions, specify a port greater than 1024. Default value: 8080.</description></item>
        /// <item><description><b>contextPath</b>: the access path. Default value: root directory &quot;/&quot;.</description></item>
        /// <item><description><b>maxThreads</b>: the connection pool size. Default value: 400.</description></item>
        /// <item><description><b>uriEncoding</b>: the encoding format of Tomcat. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. Default value: <b>ISO-8859-1</b>.</description></item>
        /// <item><description><b>useBodyEncodingForUri</b>: specifies whether to use <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        /// <summary>
        /// <para>The deployment policy. When the minimum number of available instances is 1, the value of the <b>UpdateStrategy</b> field is &quot;&quot;. When the minimum number of available instances is greater than 1, examples are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Grayscale 1 instance + 2 subsequent batches + automatic batching + 1-minute batch interval: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></description></item>
        /// <item><description>Grayscale 1 instance + 2 subsequent batches + manual batching: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></description></item>
        /// <item><description>2 batches + automatic batching + 0-minute batch interval: <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></description></item>
        /// </list>
        /// <para>Settings:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the publish policy type. Valid values: <b>GrayBatchUpdate</b> (grayscale publish) and <b>BatchUpdate</b> (batch publish).</para>
        /// </description></item>
        /// <item><description><para><b>batchUpdate</b>: the batch publish policy.</para>
        /// <list type="bullet">
        /// <item><description><b>batch</b>: the number of publish batches.</description></item>
        /// <item><description><b>releaseType</b>: the processing method between batches. Valid values: <b>auto</b> (automatic) and <b>manual</b> (manual).</description></item>
        /// <item><description><b>batchWaitTime</b>: the interval between batches. Unit: minutes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>grayUpdate</b>: the number of grayscale instances. This parameter is required when <b>type</b> is set to <b>GrayBatchUpdate</b>.</para>
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
        /// <para>The vSwitch where the network interface controllers (NICs) of the application instance reside. The vSwitch must be in the specified VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The startup command for deploying a WAR package-based application. The configuration procedure is the same as that for the startup command of an image-based deployment. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Configure a startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The Tomcat version on which the deployment package depends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>apache-tomcat-7.0.91</b></description></item>
        /// <item><description><b>apache-tomcat-8.5.42</b></description></item>
        /// </list>
        /// <para>This parameter is not supported when <b>Package Type</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
