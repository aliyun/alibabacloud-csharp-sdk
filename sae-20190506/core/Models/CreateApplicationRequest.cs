// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationRequest : TeaModel {
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
        /// <para>The instance ID of the Container Registry Enterprise instance. This parameter is required when <b>ImageUrl</b> is set to a Container Registry Enterprise Edition image.</para>
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
        /// <para>The application description. The description can be up to 1024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test description.</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The application name. The name can contain digits, letters, and hyphens (-). The name must start with a letter and cannot end with a hyphen (-). The name can be up to 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Set this parameter to micro_service to create a microservice application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>Specifies whether to associate an EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: associate an EIP.</description></item>
        /// <item><description><b>false</b>: do not associate an EIP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssociateEip")]
        [Validation(Required=false)]
        public bool? AssociateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically configure the network environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: SAE automatically configures the network environment when the application is created. The values of <b>NamespaceId</b>, <b>VpcId</b>, <b>vSwitchId</b>, and <b>SecurityGroupId</b> are ignored.</description></item>
        /// <item><description><b>false</b>: SAE manually configures the network environment when the application is created.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>true</b>, any other <b>NamespaceId</b> value that is passed is ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public bool? AutoConfig { get; set; }

        /// <summary>
        /// <para>The base application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9de8a41</para>
        /// </summary>
        [NameInMap("BaseAppId")]
        [Validation(Required=false)]
        public string BaseAppId { get; set; }

        /// <summary>
        /// <para>The command that is used to start the image. The command must be an executable object in the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>In the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when PackageType is set to DotnetZip.</para>
        /// </remarks>
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
        /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>, where <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to the String type. The internal format is a JSON array. If this parameter is not required, leave it empty.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when PackageType is set to DotnetZip.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The <b>ConfigMap</b> mount description. Use a ConfigMap created on the namespace configuration items page to inject configuration information into the container. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>configMapId</b>: the ConfigMap instance ID. You can obtain the ID by invoking the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation.</description></item>
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
        /// <para>The CPU specifications required for each instance, in millicores. This parameter cannot be set to 0. Only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>500</b></description></item>
        /// <item><description><b>1000</b></description></item>
        /// <item><description><b>2000</b></description></item>
        /// <item><description><b>4000</b></description></item>
        /// <item><description><b>8000</b></description></item>
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
        /// <para>The custom image type. Set this parameter to an empty string if the image is not a custom image:</para>
        /// <list type="bullet">
        /// <item><description>internet: public image</description></item>
        /// <item><description>intranet: private image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("CustomImageNetworkType")]
        [Validation(Required=false)]
        public string CustomImageNetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately deploy the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: default value. The application is deployed immediately.</description></item>
        /// <item><description><b>false</b>: the application is deployed later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public bool? Deploy { get; set; }

        /// <summary>
        /// <para>The disk storage size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The version of the .NET framework:</para>
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
        /// <para>Specifies whether to enable the CPU Burst feature:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuBurst")]
        [Validation(Required=false)]
        public bool? EnableCpuBurst { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable application monitoring for non-Java applications based on eBPF technology. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableEbpf")]
        [Validation(Required=false)]
        public string EnableEbpf { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse the namespace agent version configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNamespaceAgentVersion")]
        [Validation(Required=false)]
        public bool? EnableNamespaceAgentVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse the namespace SLS log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNamespaceSlsConfig")]
        [Validation(Required=false)]
        public bool? EnableNamespaceSlsConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the new ARMS feature:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus custom metric collection.</para>
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
        /// <item><description>true: Isolated.</description></item>
        /// <item><description>false: Not isolated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSidecarResourceIsolated")]
        [Validation(Required=false)]
        public bool? EnableSidecarResourceIsolated { get; set; }

        /// <summary>
        /// <para>The container environment variable parameters. You can customize environment variables or reference a ConfigMap. To reference a ConfigMap, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom configuration<list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable.</description></item>
        /// <item><description><b>value</b>: the value of the environment variable. This takes priority over valueFrom.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Reference a ConfigMap (valueFrom)<list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, such as <c>sae-sys-configmap-all-test1</c>.</description></item>
        /// <item><description><b>valueFrom</b>: the environment variable reference. Set the value to <c>configMapRef</c>.<list type="bullet">
        /// <item><description><b>configMapId</b>: the ConfigMap ID.</description></item>
        /// <item><description><b>key</b>: the key. If you reference all keys, do not set this field.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;name&quot;: &quot;sae-sys-configmap-all-hello&quot;,
        ///         &quot;valueFrom&quot;: {
        ///             &quot;configMapRef&quot;: {
        ///                 &quot;configMapId&quot;: 100,
        ///                 &quot;key&quot;: &quot;&quot;
        ///             }
        ///         }
        ///     },
        ///     {
        ///         &quot;name&quot;: &quot;hello&quot;,
        ///         &quot;valueFrom&quot;: {
        ///             &quot;configMapRef&quot;: {
        ///                 &quot;configMapId&quot;: 101,
        ///                 &quot;key&quot;: &quot;php-fpm&quot;
        ///             }
        ///         }
        ///     },
        ///     {
        ///         &quot;name&quot;: &quot;envtmp&quot;,
        ///         &quot;value&quot;: &quot;newenv&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("GpuConfig")]
        [Validation(Required=false)]
        public string GpuConfig { get; set; }

        /// <summary>
        /// <para>The K8s Headless Service-based service registration and discovery.</para>
        /// <list type="bullet">
        /// <item><description>serviceName: the service name.</description></item>
        /// <item><description>namespaceId: the namespace ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;serviceName\&quot;:\&quot;leaf-test-headless\&quot;,\&quot;namespaceId\&quot;:\&quot;cn-zhangjiakou:prod\&quot;}</para>
        /// </summary>
        [NameInMap("HeadlessPvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string HeadlessPvtzDiscoverySvc { get; set; }

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
        /// <para>The image address. This parameter is required when <b>Package Type</b> is set to <b>Image</b>.</para>
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
        /// <para>Specifies whether the application is stateful.</para>
        /// </summary>
        [NameInMap("IsStateful")]
        [Validation(Required=false)]
        public bool? IsStateful { get; set; }

        /// <summary>
        /// <para>The arguments for starting the JAR package application. The default startup command for the application: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-args</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The options for starting the JAR package application. The default startup command for the application: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
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
        /// <para>The summary of configurations for log collection to Kafka. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kafkaEndpoint</b>: the service registration address of the Kafka API.</description></item>
        /// <item><description><b>kafkaInstanceId</b>: the Kafka instance ID.</description></item>
        /// <item><description><b>kafkaConfigs</b>: the summary of configurations for one or more log entries. For more information about the valid values, see the <b>kafkaConfigs</b> request parameter in this topic.</description></item>
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
        /// <para>You can use only one method for health checks.</para>
        /// </remarks>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>exec.command</b>: the health check command.</description></item>
        /// <item><description><b>httpGet.path</b>: the access path.</description></item>
        /// <item><description><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</description></item>
        /// <item><description><b>httpGet.isContainKeyWord</b>: <b>true</b> indicates that the keyword is included. <b>false</b> indicates that the keyword is not included. If this field is missing, the advanced feature is not used.</description></item>
        /// <item><description><b>httpGet.keyWord</b>: the custom keyword. The <b>isContainKeyWord</b> field must be present when this field is used.</description></item>
        /// <item><description><b>tcpSocket.port</b>: the port for TCP connection detection.</description></item>
        /// <item><description><b>initialDelaySeconds</b>: the health check delay detection time. Default value: 10. Unit: seconds.</description></item>
        /// <item><description><b>periodSeconds</b>: the health check period. Default value: 30. Unit: seconds.</description></item>
        /// <item><description><b>timeoutSeconds</b>: the health check timeout period. Default value: 1. Unit: seconds. If this parameter is set to 0 or is not set, the default timeout period is 1 second.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        [NameInMap("LokiConfigs")]
        [Validation(Required=false)]
        public string LokiConfigs { get; set; }

        /// <summary>
        /// <para>The memory required for each instance, in MB. This parameter cannot be set to 0. The memory has a one-to-one mapping with CPU. Only the following defined specifications are supported:</para>
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
        /// <item><description><b>0</b>: SAE built-in Nacos.</description></item>
        /// <item><description><b>1</b>: self-managed Nacos.</description></item>
        /// <item><description><b>2</b>: MSE commercial edition Nacos.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <para>The registry configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// <para>Configures the microservice governance feature.</para>
        /// <list type="bullet">
        /// <item><description><para>Specifies whether to enable microservice governance (enable):</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Configures lossless online/offline (mseLosslessRule):</para>
        /// <list type="bullet">
        /// <item><description><para>delayTime: the delay time.</para>
        /// </description></item>
        /// <item><description><para>enable: specifies whether to enable the lossless online feature. true indicates enabled. false indicates disabled.</para>
        /// </description></item>
        /// <item><description><para>notice: specifies whether to enable the notification feature. true indicates enabled. false indicates disabled.</para>
        /// </description></item>
        /// <item><description><para>warmupTime: the warm-up duration for traffic ramping, in seconds.</para>
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
        /// <para>We recommend that you do not set this parameter. Set <b>NasConfigs</b> instead. The NAS mount description. If the configuration does not change during deployment, you do not need to set this parameter (that is, the <b>MountDesc</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>MountDesc</b> field to &quot;&quot; in the request).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>We recommend that you do not set this parameter. Set <b>NasConfigs</b> instead. The mount target of the NAS file system in the VPC of the application. If the configuration does not change during deployment, you do not need to set this parameter (that is, the <b>MountHost</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>MountHost</b> field to &quot;&quot; in the request).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The SAE namespace ID. Only namespaces whose names contain lowercase letters and hyphens (-) are supported. The name must start with a letter.
        /// You can obtain namespaces by calling the <a href="https://help.aliyun.com/document_detail/126547.html">DescribeNamespaceList</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The NAS mount configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the container mount path.</description></item>
        /// <item><description><b>readOnly</b>: set to <b>false</b> to grant read and write permission.</description></item>
        /// <item><description><b>nasId</b>: the NAS ID.</description></item>
        /// <item><description><b>mountDomain</b>: the container mount target address. For more information, see <a href="https://help.aliyun.com/document_detail/62626.html">DescribeMountTargets</a>.</description></item>
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
        /// <para>We recommend that you do not set this parameter. Set <b>NasConfigs</b> instead. The ID of the mounted NAS file system. The NAS file system must be in the same region as the cluster. The NAS file system must have available mount target creation quota, or its mount target must already be on a vSwitch in the VPC. If this parameter is left empty and the <b>mountDescs</b> field exists, a NAS file system is automatically purchased and mounted to a vSwitch in the VPC.</para>
        /// <para>If the configuration does not change during deployment, you do not need to set this parameter (that is, the <b>NASId</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string (that is, set the value of the <b>NASId</b> field to &quot;&quot; in the request).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KSAK****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The application version:</para>
        /// <list type="bullet">
        /// <item><description>lite: Lite Edition</description></item>
        /// <item><description>std: Standard Edition</description></item>
        /// <item><description>pro: Professional Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>Specifies the RAM role for identity authentication.</para>
        /// <remarks>
        /// <para>Create an OIDC identity provider and an identity provider role in the same region in advance. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/ram/developer-reference/api-ims-2019-08-15-createoidcprovider">CreateOIDCProvider</a> and <a href="https://www.alibabacloud.com/help/en/ram/developer-reference/api-ims-2019-08-15-createsamlprovider">CreateSAMLProvider</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/ram/developer-reference/api-ims-2019-08-15-createoidcprovider">CreateOIDCProvider</a> and <a href="https://www.alibabacloud.com/help/zh/ram/developer-reference/api-ims-2019-08-15-createsamlprovider">CreateSAMLProvider</a>.</para>
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
        /// <para>The OSS mount description. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>bucketName</b>: the bucket name.</description></item>
        /// <item><description><b>bucketPath</b>: the folder or object that you created in OSS. If the OSS mount folder does not exist, an exception is triggered.</description></item>
        /// <item><description><b>mountPath</b>: the container path in SAE. If the path already exists, it is an overwrite relationship. If the path does not exist, it is created.</description></item>
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
        /// <para>The type of the application deployment package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you use Java for deployment, <b>FatJar</b>, <b>War</b>, and <b>Image</b> are supported.</para>
        /// </description></item>
        /// <item><description><para>If you use PHP for deployment, the following types are supported:</para>
        /// <list type="bullet">
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
        /// <item><description><para>If you use Python for deployment, <b>PythonZip</b> and <b>Image</b> are supported.</para>
        /// </description></item>
        /// <item><description><para>If you use .NET Core for deployment, <b>DotnetZip</b> and <b>Image</b> are supported.</para>
        /// <remarks>
        /// <para>When DotnetZip is selected, Dotnet specifies the version of the .NET Core runtime. .NET 3.1, .NET 5.0, .NET 6.0, .NET 7.0, and .NET 8.0 are supported. The Dotnet, Command, and CommandArgs parameters are required.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FatJar</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The address of the deployment package. This parameter is required when <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required when <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
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
        /// <para>The mount path for PHP application monitoring. Make sure that the PHP server loads the configuration file from this path.
        /// You do not need to manage the configuration content. SAE automatically renders the correct configuration file.</para>
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
        /// <para>The mount path for the PHP application startup configuration. Make sure that the PHP server uses this configuration file to start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>The script that is run after the container is started. A script is triggered and run immediately after the container is created. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script that is run before the container is stopped. A script is triggered and run before the container is deleted. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The programming language of the technology stack used to create the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>java</b>: Java.</description></item>
        /// <item><description><b>php</b>: PHP.</description></item>
        /// <item><description><b>python</b>: Python.</description></item>
        /// <item><description><b>dotnet</b>: .NET Core.</description></item>
        /// <item><description><b>other</b>: multiple languages, such as C++, Go, and Node.js.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// <para>Enables K8s Service-based service registration and discovery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serviceName</b>: the service name. Format: <c>custom name-namespace ID</c>. The suffix <c>-namespace ID</c> cannot be customized and must be set based on the namespace of the application. For example, if you select the default namespace in the China (Beijing) region, the suffix is <c>-cn-beijing-default</c>.</description></item>
        /// <item><description><b>namespaceId</b>: the namespace ID.</description></item>
        /// <item><description><b>portProtocols</b>: the port and protocol. Valid port values: [1,65535]. Valid protocol values: <b>TCP</b> and <b>UDP</b>.</description></item>
        /// <item><description><b>portAndProtocol</b>: the port and protocol. Valid port values: [1,65535]. Valid protocol values: <b>TCP</b> and <b>UDP</b>. <b>portProtocols is recommended. If portProtocols is set, only portProtocols takes effect</b>.</description></item>
        /// <item><description><b>enable</b>: enables K8s Service-based service registration and discovery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serviceName&quot;:&quot;bwm-poc-sc-gateway-cn-beijing-front&quot;,&quot;namespaceId&quot;:&quot;cn-beijing:front&quot;,&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true,&quot;portProtocols&quot;:[{&quot;port&quot;:18012,&quot;protocol&quot;:&quot;TCP&quot;}]}</para>
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
        /// <para>The custom installation module dependencies. By default, the dependencies defined in the requirements.txt file in the root folder are installed. If the file is not configured or you need custom packages, specify the dependencies to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        [NameInMap("RaspConfig")]
        [Validation(Required=false)]
        public CreateApplicationRequestRaspConfig RaspConfig { get; set; }
        public class CreateApplicationRequestRaspConfig : TeaModel {
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
        /// <para>You can use only one method for health checks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>The initial number of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values: NULL (default), default, and haiguang (Hygon server).</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The SAE version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>v1</b></description></item>
        /// <item><description><b>v2</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("SaeVersion")]
        [Validation(Required=false)]
        public string SaeVersion { get; set; }

        /// <summary>
        /// <para>The <b>Secret</b> mount description. Use a secret created on the namespace secrets page to inject sensitive information into the container. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>secretId</b>: the secret instance ID. You can obtain the ID by calling the ListSecrets operation.</description></item>
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
        /// <para>The configurations for log collection to Simple Log Service.</para>
        /// <list type="bullet">
        /// <item><description>Use SLS resources that are automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</description></item>
        /// <item><description>Use custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
        /// </list>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>projectName</b>: the Project name in Simple Log Service.  </description></item>
        /// <item><description><b>logDir</b>: the log path.</description></item>
        /// <item><description><b>logType</b>: the log type. <b>stdout</b> indicates container standard output logs. You can configure only one entry for this type. If this parameter is not set, file logs are collected.</description></item>
        /// <item><description><b>logstoreName</b>: the Logstore name in Simple Log Service.</description></item>
        /// <item><description><b>logtailName</b>: the Logtail name in Simple Log Service. If this parameter is not specified, a new Logtail is created.</description></item>
        /// </list>
        /// <para>If the SLS collection configuration does not change during multiple deployments, you do not need to set this parameter (that is, the <b>SlsConfigs</b> field does not need to be included in the request). If you no longer need the SLS collection feature, set the value of this field to an empty string (that is, set the value of the <b>SlsConfigs</b> field to &quot;&quot; in the request).</para>
        /// <remarks>
        /// <para>Projects that are automatically created with the application are deleted when the application is deleted. Therefore, do not select a project that is automatically created by SAE when you select an existing project.</para>
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
        /// <item><description>Check failed: indicates that the application failed to start. An exception is reported and the application is automatically restarted.<remarks>
        /// <list type="bullet">
        /// <item><description>The exec, httpGet, and tcpSocket methods are supported. For specific examples, see the Liveness parameter.</description></item>
        /// <item><description>You can use only one method for health checks.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public string StartupProbe { get; set; }

        /// <summary>
        /// <para>The timeout period for graceful shutdown. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
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
        /// <para>The Tomcat configuration. Set this parameter to &quot;&quot; or &quot;{}&quot; to delete the configuration:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port number. Valid values: 1024 to 65535. Ports less than 1024 require root permissions. Because the container is configured with admin permissions, specify a port greater than 1024. Default value: 8080.</description></item>
        /// <item><description><b>contextPath</b>: the access path. Default value: root directory &quot;/&quot;.</description></item>
        /// <item><description><b>maxThreads</b>: the maximum number of connections in the connection pool. Default value: 400.</description></item>
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
        /// <para>The vSwitch where the elastic network interface controller (NIC) of the application instance resides. The vSwitch must be in the specified VPC. The vSwitch also has a binding relationship with the SAE namespace. If you leave this parameter empty, the vSwitch attached to the namespace is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC that corresponds to the SAE namespace. In SAE, a namespace can correspond to only one VPC, and the mapping cannot be modified. The binding relationship is established when the first SAE application is created in the namespace. Multiple namespaces can correspond to the same VPC. If you leave this parameter empty, the VPC bound to the namespace is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sofi8mh1q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The startup command for deploying a WAR package application. The configuration procedure is the same as that for the startup command of an image deployment. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Configure a startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The version of Tomcat on which the WebContainer deployment package depends. Valid values:</para>
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
