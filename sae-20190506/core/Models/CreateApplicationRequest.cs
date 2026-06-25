// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ARN of the RAM role required to pull images across Alibaba Cloud accounts. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Authorize cross-account access using a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The Container Registry Enterprise Edition (ACR Enterprise Edition) instance ID. This parameter is required when <b>ImageUrl</b> is a Container Registry Enterprise Edition image.</para>
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
        /// <para>The application description. It cannot exceed 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test description.</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The application name. It can contain digits, letters, and hyphens (-). It must start with a letter and cannot end with a hyphen (-). The name cannot exceed 36 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Select micro_service for a microservice application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>Whether to bind an Elastic IP address (EIP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Bind.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not bind.</para>
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
        /// <para>Whether to automatically configure the network environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: SAE automatically configures the network environment when creating an application. The values of <b>NamespaceId</b>, <b>VpcId</b>, <b>vSwitchId</b>, and <b>SecurityGroupId</b> are ignored.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: SAE manually configures the network environment when creating an application.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you select <b>true</b>, other <b>NamespaceId</b> values passed are ignored.</para>
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
        /// <para>The image start command. This command must be an executable object that exists in the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>Based on the example, Command=&quot;echo&quot; and <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This option is required when PackageType is DotnetZip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The image start command parameters. These are the parameters required by the <b>Command</b> parameter. Format:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. Convert <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> to a string type, with the format as a JSON array. If this parameter is not needed, do not specify it.</para>
        /// <remarks>
        /// <para>Notice: This option is required when PackageType is DotnetZip.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The <b>ConfigMap</b> mount description. Use configuration items created on the namespace configuration item page to inject configuration information into the container. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>configMapId</b>: The ConfigMap instance ID. Obtain it by calling the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> API operation.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing the <c>sae-sys-configmap-all</c> parameter.</para>
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
        /// <para>The CPU required for each instance, in millicores. It cannot be 0. Currently, only the following defined specifications are supported:</para>
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
        /// <para>Custom Host mapping within the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hostName</b>: The domain name or hostname.</para>
        /// </description></item>
        /// <item><description><para><b>ip</b>: The IP address.</para>
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
        /// <para>The custom image type. If it is not a custom image, set it to an empty string:</para>
        /// <list type="bullet">
        /// <item><description><para>internet: Public network image.</para>
        /// </description></item>
        /// <item><description><para>intranet: Private network image.</para>
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
        /// <para>Whether to deploy immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Default value. Deploy immediately.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Deploy later.</para>
        /// </description></item>
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
        /// <para>The version number of the .NET framework:</para>
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
        /// <para>The application runtime environment version in the HSF framework, such as the Ali-Tomcat container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Shared temporary storage configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;workdir\&quot;,\&quot;mountPath\&quot;:\&quot;/usr/local/tomcat/webapps\&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirDesc")]
        [Validation(Required=false)]
        public string EmptyDirDesc { get; set; }

        /// <summary>
        /// <para>Whether to enable the CPU Burst feature:</para>
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
        /// <para>Enable application monitoring for non-Java applications based on eBPF technology. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable. Default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableEbpf")]
        [Validation(Required=false)]
        public string EnableEbpf { get; set; }

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
        /// <para>Whether to reuse the namespace SLS log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNamespaceSlsConfig")]
        [Validation(Required=false)]
        public bool? EnableNamespaceSlsConfig { get; set; }

        /// <summary>
        /// <para>Whether to enable new ARMS features:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
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
        /// <para>Whether to enable Sidecar resource isolation:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable isolation.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable isolation.</para>
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
        /// <para>Container environment variable parameters. Support custom configurations or referencing configuration items. To reference a configuration item, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom configuration</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The environment variable name.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The environment variable value. This has a higher priority than valueFrom.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference configuration item (valueFrom)</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The environment variable name. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;configuration item name&gt;</c>, for example, <c>sae-sys-configmap-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: The environment variable reference. Set this to <c>configMapRef</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>configMapId</b>: The configuration item ID.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key. If you reference all key-values, do not set this field.</para>
        /// </description></item>
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
        /// <para>K8s Headless Service service discovery.</para>
        /// <list type="bullet">
        /// <item><description><para>serviceName: The service name.</para>
        /// </description></item>
        /// <item><description><para>namespaceId: The namespace ID.</para>
        /// </description></item>
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
        /// <para>The image address. This parameter is required when <b>Package Type</b> is <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Initialization container configuration.</para>
        /// </summary>
        [NameInMap("InitContainersConfig")]
        [Validation(Required=false)]
        public List<InitContainerConfig> InitContainersConfig { get; set; }

        /// <summary>
        /// <para>Whether it is a stateful application.</para>
        /// </summary>
        [NameInMap("IsStateful")]
        [Validation(Required=false)]
        public bool? IsStateful { get; set; }

        /// <summary>
        /// <para>JAR package startup parameters for the application. The application\&quot;s default start command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-args</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>JAR package startup options for the application. The application\&quot;s default start command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The JDK version that the deployment package depends on. Supported versions:</para>
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
        /// <para>The summary configuration for collecting logs to Kafka. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>kafkaEndpoint</b>: The service registration address for the Kafka API.</para>
        /// </description></item>
        /// <item><description><para><b>kafkaInstanceId</b>: The Kafka instance ID.</para>
        /// </description></item>
        /// <item><description><para><b>kafkaConfigs</b>: The summary configuration for single or multiple logs. For valid values, see the <b>kafkaConfigs</b> request parameter in this topic.</para>
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
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>Container health check. Containers that fail the health check are shut down and recovered. Supported methods:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exec</b>: For example, <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></para>
        /// </description></item>
        /// <item><description><para><b>httpGet</b>: For example, <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
        /// </description></item>
        /// <item><description><para><b>tcpSocket</b>: For example, <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Select only one method for the health check.</para>
        /// </remarks>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exec.command</b>: Set the health check command.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.path</b>: The access path.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.isContainKeyWord</b>: <b>true</b> means the keyword is included, <b>false</b> means the keyword is not included. If this field is missing, advanced features are not used.</para>
        /// </description></item>
        /// <item><description><para><b>httpGet.keyWord</b>: The custom keyword. Do not omit the <b>isContainKeyWord</b> field when using it.</para>
        /// </description></item>
        /// <item><description><para><b>tcpSocket.port</b>: The port for TCP connection detection.</para>
        /// </description></item>
        /// <item><description><para><b>initialDelaySeconds</b>: Set the health check delay detection time. Default is 10 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>periodSeconds</b>: Set the health check period. Default is 30 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>timeoutSeconds</b>: Set the health check timeout duration. Default is 1 second. If you set it to 0 or do not set it, the default timeout is 1 second.</para>
        /// </description></item>
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
        /// <para>The memory required for each instance, in MB. It cannot be 0. It has a one-to-one correspondence with CPU. Currently, only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1024</b>: Corresponds to 500 millicores and 1000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>2048</b>: Corresponds to 500, 1000 millicores, and 2000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>4096</b>: Corresponds to 1000, 2000 millicores, and 4000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>8192</b>: Corresponds to 2000, 4000 millicores, and 8000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>12288</b>: Corresponds to 12000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>16384</b>: Corresponds to 4000, 8000 millicores, and 16000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>24576</b>: Corresponds to 12000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>32768</b>: Corresponds to 16000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>65536</b>: Corresponds to 8000, 16000, and 32000 millicores CPU.</para>
        /// </description></item>
        /// <item><description><para><b>131072</b>: Corresponds to 32000 millicores CPU.</para>
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
        /// <para>Select the Nacos registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: SAE built-in Nacos.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: User-managed Nacos.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: MSE Professional Edition Nacos.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <para>The registry configuration information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// <para>Configure microservice administration features.</para>
        /// <list type="bullet">
        /// <item><description><para>Whether to enable microservice administration (enable):</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Configure graceful start and graceful shutdown (mseLosslessRule):</para>
        /// <list type="bullet">
        /// <item><description><para>delayTime: The delay time.</para>
        /// </description></item>
        /// <item><description><para>enable: Whether to enable the graceful start feature. true means enabled, false means not enabled.</para>
        /// </description></item>
        /// <item><description><para>notice: Whether to enable the notification feature. true means enabled, false means enabled.</para>
        /// </description></item>
        /// <item><description><para>warmupTime: The duration of traffic prefetch, in seconds.</para>
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
        /// <para>Do not configure this field; configure <b>NasConfigs</b> instead. The NAS mount description. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the request does not need to include the <b>MountDesc</b> field). To clear the NAS configuration, set the value of this field to an empty string in the request (that is, the value of the <b>MountDesc</b> field in the request is &quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>Do not configure this field; configure <b>NasConfigs</b> instead. The NAS mount target within the application VPC. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the request does not need to include the <b>MountHost</b> field). To clear the NAS configuration, set the value of this field to an empty string in the request (that is, the value of the <b>MountHost</b> field in the request is &quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The SAE namespace ID. Only namespaces with names consisting of lowercase letters and hyphens (-) are supported. The name must start with a letter. Obtain the namespace by calling the <a href="https://help.aliyun.com/document_detail/126547.html">DescribeNamespaceList</a> API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The configuration for mounting NAS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>mountPath</b>: The container mount path.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: If the value is <b>false</b>, it indicates read and write permission.</para>
        /// </description></item>
        /// <item><description><para><b>nasId</b>: The NAS ID.</para>
        /// </description></item>
        /// <item><description><para><b>mountDomain</b>: The container mount target address. For more information, see <a href="https://help.aliyun.com/document_detail/62626.html">DescribeMountTargets</a>.</para>
        /// </description></item>
        /// <item><description><para><b>nasPath</b>: The relative file directory of NAS.</para>
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
        /// <para>Do not configure this field; configure <b>NasConfigs</b> instead. The ID of the mounted NAS. It must be in the same region as the cluster. It must have available mount target creation quotas, or its mount target must already be on a vSwitch within the VPC. If you do not specify this parameter and the <b>mountDescs</b> field exists, the system automatically purchases a NAS and mounts it to a vSwitch within the VPC by default.</para>
        /// <para>If the configuration has not changed during deployment, you do not need to set this parameter (that is, the request does not need to include the <b>NASId</b> field). To clear the NAS configuration, set the value of this field to an empty string in the request (that is, the value of the <b>NASId</b> field in the request is &quot;&quot;).</para>
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
        /// <item><description><para>lite: Lightweight Edition</para>
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
        /// <para>Set the identity authentication service RAM role.</para>
        /// <remarks>
        /// <para>Create an OpenID Connect (OIDC) identity provider and an identity provider role in the same region beforehand. For more information, see&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/ram/developer-reference/api-ims-2019-08-15-createoidcprovider?spm=a2c4g.11186623.help-menu-28625.d_4_1_0_3_2_7.7f0443efmdpxa3">Create an OIDC identity provider</a> and<a href="https://help.aliyun.com/zh/ram/developer-reference/api-ims-2019-08-15-createsamlprovider?spm=a2c4g.11186623.help-menu-28625.d_4_1_0_3_2_2.632244b1s8QbQt">Create a role SSO identity provider</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/ram/developer-reference/api-ims-2019-08-15-createoidcprovider">Create an OIDC identity provider</a> and<a href="https://www.alibabacloud.com/help/zh/ram/developer-reference/api-ims-2019-08-15-createsamlprovider">Create a role SSO identity provider</a>.</para>
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
        /// <para>OSS mount description. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>bucketName</b>: The Bucket name.</para>
        /// </description></item>
        /// <item><description><para><b>bucketPath</b>: The directory or OSS object you created in OSS. If the OSS mount directory does not exist, an exception is triggered.</para>
        /// </description></item>
        /// <item><description><para><b>mountPath</b>: The container path in SAE. If the path exists, it is overwritten. If the path does not exist, it is created.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: Whether the container path has read permission for the mounted directory resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Read-only permission.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Read and write permission.</para>
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
        /// <para>The application package type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you deploy with Java, supported types are <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</para>
        /// </description></item>
        /// <item><description><para>If you deploy with PHP, supported types are:</para>
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
        /// <item><description><para>If you deploy with Python, supported types are <b>PythonZip</b> and <b>Image</b>.</para>
        /// </description></item>
        /// <item><description><para>If you deploy with .NET Core, supported types are <b>DotnetZip</b> and <b>Image</b>.</para>
        /// <remarks>
        /// <para>When you select DotnetZip, Dotnet is the version number of the .NET Core environment. Supported versions are .NET 3.1, .NET 5.0, .NET 6.0, .NET 7.0, and .NET 8.0. The Dotnet, Command, and CommandArgs options are required.</para>
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
        /// <para>The URL of the deployment package. This parameter is required when <b>Package Type</b> is <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version number of the deployment package. This parameter is required when <b>Package Type</b> is <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The PHP version that the PHP deployment package depends on. Images do not support this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP-FPM 7.0</para>
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// <para>The mount path for PHP application monitoring. Ensure that the PHP server loads the configuration file from this path. You do not need to focus on the configuration content; SAE automatically renders the correct configuration file.</para>
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
        /// <para>The mount path for PHP application startup configuration. Ensure that the PHP server uses this configuration file to start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>The script to execute after the container starts. A script is triggered immediately after the container is created. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script to execute before the container stops. A script is triggered before the container is deleted. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The technology stack language for creating the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>java</b>: Java language.</para>
        /// </description></item>
        /// <item><description><para><b>php</b>: PHP language.</para>
        /// </description></item>
        /// <item><description><para><b>python</b>: Python language.</para>
        /// </description></item>
        /// <item><description><para><b>dotnet</b>: .NET Core language.</para>
        /// </description></item>
        /// <item><description><para><b>other</b>: Multi-language, such as C++, Go, and Node.js.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// <para>Enable K8s Service service discovery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>serviceName</b>: The service name. Format: <c>custom-namespace ID</c>. The suffix <c>-namespace ID</c> cannot be customized; specify it based on the application\&quot;s namespace. For example, if you select the default namespace in the China (Beijing) region, it is <c>-cn-beijing-default</c>.</para>
        /// </description></item>
        /// <item><description><para><b>namespaceId</b>: The namespace ID.</para>
        /// </description></item>
        /// <item><description><para><b>portProtocols</b>: The port and protocol. The port range is [1, 65535]. Supported protocols are <b>TCP</b> and <b>UDP</b>.</para>
        /// </description></item>
        /// <item><description><para>portAndProtocol: The port and protocol. The port range is [1, 65535]. Supported protocols are TCP and <b>UDP</b>. <b>portProtocols</b> is recommended. If <b>portProtocols</b> is set, only <b>portProtocols</b> takes effect.</para>
        /// </description></item>
        /// <item><description><para><b>enable</b>: Enable K8s Service service discovery.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serviceName&quot;:&quot;bwm-poc-sc-gateway-cn-beijing-front&quot;,&quot;namespaceId&quot;:&quot;cn-beijing:front&quot;,&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true,&quot;portProtocols&quot;:[{&quot;port&quot;:18012,&quot;protocol&quot;:&quot;TCP&quot;}]}</para>
        /// </summary>
        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The Python environment. Supports <b>PYTHON 3.9.15</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHON 3.9.15</para>
        /// </summary>
        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        /// <summary>
        /// <para>Custom installation of module dependencies. By default, the system installs dependencies defined in requirements.txt in the root directory. If you do not configure or customize packages, you can specify the dependencies to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// <para>Application startup status check. Containers that fail multiple health checks are shut down and restarted. Containers that do not pass the health check will not receive SLB traffic. Supported methods are <b>exec</b>, <b>httpGet</b>, and <b>tcpSocket</b>. For examples, see the <b>Liveness</b> parameter.</para>
        /// <remarks>
        /// <para>Select only one method for the health check.</para>
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
        /// <para>The resource type. Supports NULL (default), default, and haiguang (Haiguang server) types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The SAE version. Supported versions:</para>
        /// <list type="bullet">
        /// <item><description><para><b>v1</b></para>
        /// </description></item>
        /// <item><description><para><b>v2</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("SaeVersion")]
        [Validation(Required=false)]
        public string SaeVersion { get; set; }

        /// <summary>
        /// <para>The <b>Secret</b> mount description. Use secrets created on the namespace secret page to inject secret information into the container. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>secretId</b>: The secret instance ID. Obtain it by calling the ListSecrets API operation.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can mount all keys by passing the <c>sae-sys-secret-all</c> parameter.</para>
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
        /// <para>The grayscale tags for application configuration.</para>
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
        public List<SidecarContainerConfig> SidecarContainersConfig { get; set; }

        /// <summary>
        /// <para>The configuration for collecting logs to Simple Log Service (SLS).</para>
        /// <list type="bullet">
        /// <item><description><para>Use SLS resources automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
        /// </description></item>
        /// <item><description><para>Use custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>projectName</b>: The name of the Project on SLS.</para>
        /// </description></item>
        /// <item><description><para><b>logDir</b>: The log path.</para>
        /// </description></item>
        /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> indicates container standard output logs; you can set only one such entry. If you do not set this, the system collects file logs.</para>
        /// </description></item>
        /// <item><description><para><b>logstoreName</b>: The name of the Logstore on SLS.</para>
        /// </description></item>
        /// <item><description><para><b>logtailName</b>: The name of the Logtail on SLS. If you do not specify this, the system creates a new Logtail.</para>
        /// </description></item>
        /// </list>
        /// <para>If the SLS collection configuration has not changed during multiple deployments, you do not need to set this parameter (that is, the request does not need to include the <b>SlsConfigs</b> field). If you no longer need the SLS collection feature, set the value of this field to an empty string in the request (that is, the value of the <b>SlsConfigs</b> field in the request is &quot;&quot;).</para>
        /// <remarks>
        /// <para>Projects automatically created with an application are deleted when the application is deleted. Therefore, when selecting an existing Project, do not select a Project automatically created by SAE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>SLS log tags.</para>
        /// </summary>
        [NameInMap("SlsLogEnvTags")]
        [Validation(Required=false)]
        public string SlsLogEnvTags { get; set; }

        /// <summary>
        /// <para>Enable application startup probes.</para>
        /// <list type="bullet">
        /// <item><description><para>Successful check: Indicates that the application started successfully. If you configured Liveness and Readiness checks, the system performs Liveness and Readiness checks after the application starts successfully.</para>
        /// </description></item>
        /// <item><description><para>Failed check: Indicates that the application failed to start. The system reports an exception and automatically restarts the application.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Supported methods are exec, httpGet, and tcpSocket. For examples, see the Liveness parameter.</para>
        /// </description></item>
        /// <item><description><para>Select only one method for the health check.</para>
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
        /// <para>The graceful shutdown timeout duration. Default is 30 seconds. Valid values are 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
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
        /// <para>Tomcat file configuration. Set to &quot;&quot; or &quot;{}&quot; to delete the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: The port range is 1024 to 65535. Ports less than 1024 require root permissions to operate. Because the container is configured with Admin permissions, specify a port greater than 1024. If you do not configure this, the default is 8080.</para>
        /// </description></item>
        /// <item><description><para><b>contextPath</b>: The access path. Default is the root directory &quot;/&quot;.</para>
        /// </description></item>
        /// <item><description><para><b>maxThreads</b>: Configure the connection pool size. Default is 400.</para>
        /// </description></item>
        /// <item><description><para>uriEncoding: The encoding format for Tomcat, including <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If you do not set this, the default is <b>ISO-8859-1</b>.</para>
        /// </description></item>
        /// <item><description><para><b>useBodyEncodingForUri</b>: Whether to use <b>BodyEncoding for URL</b>. Default is <b>true</b>.</para>
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
        /// <para>The virtual switch (vSwitch) where the application instance\&quot;s Elastic Network Interface (ENI) is located. This vSwitch must be within the specified VPC. This vSwitch also has a binding relationship with the SAE namespace. If you do not specify this parameter, the system uses the vSwitch ID bound to the namespace by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC corresponding to the SAE namespace. In SAE, a namespace can only correspond to one VPC, and you cannot change it. The first time you create an SAE application in a namespace, a binding relationship forms. Multiple namespaces can correspond to one VPC. If you do not specify this parameter, the system uses the VPC ID bound to the namespace by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sofi8mh1q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Set the startup command for WAR package deployed applications. The procedure is the same as configuring the startup command for image deployments. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Set the startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The Tomcat version that the WebContainer deployment package depends on. Supported versions:</para>
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
