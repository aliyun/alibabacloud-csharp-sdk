// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) required for a RAM role to obtain images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions across Alibaba Cloud accounts by using a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The ID of Container Registry Enterprise Edition instance N. This parameter is required when the <b>ImageUrl</b> parameter is set to the URL of an image in an ACR Enterprise Edition instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the template. The description cannot exceed 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test description.</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The name of the application. The name can contain digits, letters, and hyphens (-). The name must start with a letter and cannot end with a hyphen (-). It cannot exceed 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Select micro_service, which is the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>Specifies whether to associate an EIP with the node pool. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The EIP is associated with the application instance.</description></item>
        /// <item><description><b>false</b>: The EIP is not associated with the application instance.</description></item>
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
        /// <item><description><b>true</b>: SAE automatically configures the network environment when you create the application. If you set this parameter to true, the values of the <b>NamespaceId</b>, <b>VpcId</b>, <b>vSwitchId</b>, and <b>SecurityGroupId</b> parameters are ignored.</description></item>
        /// <item><description><b>false</b>: SAE configures the network environment based on your settings when you create the application.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you select <b>true</b>, other <b>NamespaceId</b> will be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public bool? AutoConfig { get; set; }

        /// <summary>
        /// <para>The ID of the basic application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9de8a41</para>
        /// </summary>
        [NameInMap("BaseAppId")]
        [Validation(Required=false)]
        public string BaseAppId { get; set; }

        /// <summary>
        /// <para>The command that is used to start the image. The command must be an existing executable object in the container. Sample statements:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>In this example, the Command parameter is set to <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The parameters of the image startup command. The CommandArgs parameter specifies the parameters that are required for the <b>Command</b> parameter. You can specify the name in one of the following formats:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the preceding example, the CommandArgs parameter is set to <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The data type of <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be an array of strings in the JSON format. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The description of the <b>ConfigMap</b> instance mounted to the application. Use configurations created on the Configuration Items page to configure containers. The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><b>congfigMapId</b>: the ID of the ConfigMap instance. You can call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation to obtain the ID.</description></item>
        /// <item><description><b>key</b>: the key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use <c>sae-sys-configmap-all</c> to mount all keys.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the mount path in the container.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:</para>
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
        /// <para>The custom mappings between hostnames and IP addresses in the container. Take note of the following rules:</para>
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
        /// <para>Custom image type. To it to empty string to use pre-built image.</para>
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
        /// <para>Whether to deploy now.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Deploy now.</description></item>
        /// <item><description><b>false</b>: Deploy later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public bool? Deploy { get; set; }

        /// <summary>
        /// <para>The disk size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>. NET Framework version number:</para>
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
        /// <para>The version of the container in HSF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Enable CPU Burst.</para>
        /// <list type="bullet">
        /// <item><description>true: enable</description></item>
        /// <item><description>false: disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuBurst")]
        [Validation(Required=false)]
        public bool? EnableCpuBurst { get; set; }

        /// <summary>
        /// <para>Enable application monitoring for non-Java applications based on eBPF technology. The value options are as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: Enable.</description></item>
        /// <item><description>false: Disable (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableEbpf")]
        [Validation(Required=false)]
        public string EnableEbpf { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable the new ARMS feature:</para>
        /// <list type="bullet">
        /// <item><description>true: enables this parameter.</description></item>
        /// <item><description>false: disables this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        [NameInMap("EnablePrometheus")]
        [Validation(Required=false)]
        public bool? EnablePrometheus { get; set; }

        /// <summary>
        /// <para>Enable Sidecar resource isolation.</para>
        /// <list type="bullet">
        /// <item><description>true: enable</description></item>
        /// <item><description>false: disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSidecarResourceIsolated")]
        [Validation(Required=false)]
        public bool? EnableSidecarResourceIsolated { get; set; }

        /// <summary>
        /// <para>The environment variables. You can configure custom environment variables or reference a ConfigMap. Before you can reference a ConfigMap, you must create a ConfigMap. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom configuration</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable.</description></item>
        /// <item><description><b>value</b>: the value of the environment variable. The priority of the custom configuration is higher than valueFrom.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference a ConfigMap (valueFrom)</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable. You can reference one or all keys. To reference all keys, specify <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>. Example: <c>sae-sys-configmap-all-test1</c>.</description></item>
        /// <item><description><b>valueFrom</b>: the reference of the environment variable. Valid value: <c>configMapRef</c>.</description></item>
        /// <item><description><b>configMapId</b>: the ID of the ConfigMap.</description></item>
        /// <item><description><b>key</b>: the key. If you want to reference all key values, you do not need to configure this parameter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;envtmp&quot;,&quot;value&quot;:&quot;0&quot;}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("GpuConfig")]
        [Validation(Required=false)]
        public string GpuConfig { get; set; }

        [NameInMap("HeadlessPvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string HeadlessPvtzDiscoverySvc { get; set; }

        [NameInMap("Html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        /// <summary>
        /// <para>The ID of the corresponding Secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// <para>The URL of the image. This parameter is required if you set the <c>PackageType</c> parameter to <c>Image</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Initialize container configuration.</para>
        /// </summary>
        [NameInMap("InitContainersConfig")]
        [Validation(Required=false)]
        public List<InitContainerConfig> InitContainersConfig { get; set; }

        [NameInMap("IsStateful")]
        [Validation(Required=false)]
        public bool? IsStateful { get; set; }

        /// <summary>
        /// <para>The arguments in the JAR package. The arguments are used to start the application container. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-args</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The option settings in the JAR package. The settings are used to start the application container. The default startup command for application deployment is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The version of the Java development kit (JDK) on which the deployment package of the application depends. The following versions are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Open JDK 8</b></description></item>
        /// <item><description><b>Open JDK 7</b></description></item>
        /// <item><description><b>Dragonwell 11</b></description></item>
        /// <item><description><b>Dragonwell 8</b></description></item>
        /// <item><description><b>openjdk-8u191-jdk-alpine3.9</b></description></item>
        /// <item><description><b>openjdk-7u201-jdk-alpine3.9</b></description></item>
        /// </list>
        /// <para>This parameter is not returned if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The logging configurations of Message Queue for Apache Kafka. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>kafkaEndpoint</b>: the endpoint of the Message Queue for Apache Kafka API.</description></item>
        /// <item><description><b>kafkaInstanceId</b>: the ID of the Message Queue for Apache Kafka instance.</description></item>
        /// <item><description><b>kafkaConfigs</b>: One or more logging configurations of Message Queue for Apache Kafka. For information about sample values and parameters, see the request parameter <b>KafkaLogfileConfig</b> in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kafkaEndpoint&quot;:&quot;10.0.X.XXX:XXXX,10.0.X.XXX:XXXX,10.0.X.XXX:XXXX\&quot;,&quot;kafkaInstanceId&quot;:&quot;alikafka_pre-cn-7pp2l8kr****&quot;,&quot;kafkaConfigs&quot;:[{&quot;logType&quot;:&quot;file_log&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;kafkaTopic&quot;:&quot;test2&quot;},{&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;kafkaTopic&quot;:&quot;test&quot;}]}</para>
        /// </summary>
        [NameInMap("KafkaConfigs")]
        [Validation(Required=false)]
        public string KafkaConfigs { get; set; }

        /// <summary>
        /// <para>Container health check. If the container fails this check, it will be revoked and relaunch again. Use one of the following methods to perform the health check:</para>
        /// <list type="bullet">
        /// <item><description>Example of <b>exec</b>: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></description></item>
        /// <item><description>Sample code of the <b>httpGet</b> method: <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
        /// <item><description>Sample code of the <b>tcpSocket</b> method: <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use only one method to perform the health check.</para>
        /// </remarks>
        /// <para>The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><b>exec.command</b>: the health check command.</description></item>
        /// <item><description><b>httpGet.path</b>: the request path.</description></item>
        /// <item><description><b>httpGet.scheme</b>: the protocol that is used to perform the health check. Valid values: <b>HTTP</b> and <b>HTTPS</b>.</description></item>
        /// <item><description><b>httpGet.isContainKeyWord</b>: indicates whether the response contains keywords. Valid values: <b>true</b> and <b>false</b>. If this field is not returned, the advanced settings are not used.</description></item>
        /// <item><description><b>httpGet.keyWord</b>: the custom keyword. This parameter is available only if the <b>isContainKeyWord</b> field is returned.</description></item>
        /// <item><description><b>tcpSocket.port</b>: the port that is used to check the status of TCP connections.</description></item>
        /// <item><description><b>initialDelaySeconds</b>: the delay of the health check. Default value: 10. Unit: seconds.</description></item>
        /// <item><description><b>periodSeconds</b>: the interval at which health checks are performed. Default value: 30. Unit: seconds.</description></item>
        /// <item><description><b>timeoutSeconds</b>: the timeout period of the health check. Default value: 1. Unit: seconds. If you set this parameter to 0 or leave this parameter empty, the timeout period is automatically set to 1 second.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The memory size that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
        /// <list type="bullet">
        /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
        /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
        /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
        /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8,000.</description></item>
        /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
        /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
        /// <item><description>This parameter is set to <b>24576</b> if the Cpu parameter is set to 12000.</description></item>
        /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
        /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
        /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The Nacos registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: SAE built-in Nacos registry</description></item>
        /// <item><description><b>1</b>: self-managed Nacos registry</description></item>
        /// <item><description><b>2</b> : MSE enterprise edition Nacos registry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <para>The Registry configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// <para>Configure microservices governance</para>
        /// <para>Whether to enable microservices governance (enable):</para>
        /// <list type="bullet">
        /// <item><description>true: Enable</description></item>
        /// <item><description>false: Disable</description></item>
        /// </list>
        /// <para>Configure lossless online/offline deployment (mseLosslessRule):</para>
        /// <para>delayTime: Delay duration (unit: seconds)</para>
        /// <para>enable: Whether to enable lossless deployment</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// <para>notice: Whether to enable notifications</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// <para>warmupTime: Small-traffic warm-up duration (unit: seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;: true,&quot;mseLosslessRule&quot;: {&quot;delayTime&quot;: 0,&quot;enable&quot;: false,&quot;notice&quot;: false,&quot;warmupTime&quot;: 120}}</para>
        /// </summary>
        [NameInMap("MicroserviceEngineConfig")]
        [Validation(Required=false)]
        public string MicroserviceEngineConfig { get; set; }

        /// <summary>
        /// <para>It is not recommended to configure this field; configuring NasConfigs instead. This field specifies the NAS mount description. When deploying, if the configuration has not changed, you do not need to set this parameter (i.e., the MountDesc field does not need to be included in the request). If you need to clear the NAS configuration, set the value of this field to an empty string in the request (i.e., set the value of the MountDesc field to &quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>It is not recommended to configure this field; configuring NasConfigs instead. This field specifies the NAS mount point within the application\&quot;s VPC. When deploying, if the configuration has not changed, you do not need to set this parameter (i.e., the MountHost field does not need to be included in the request). If you need to clear the NAS configuration, set the value of this field to an empty string in the request (i.e., set the value of the MountHost field to &quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>SAE namespace ID. Only namespaces consisting of lowercase letters and hyphens (-) are supported, and the name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The configurations of mounting the NAS file system. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: the mount path of the container.</description></item>
        /// <item><description><b>readOnly</b>: If you set the value to <b>false</b>, the application has the read and write permissions.</description></item>
        /// <item><description><b>nasId</b>: the ID of the NAS file system.</description></item>
        /// <item><description><b>mountDomain</b>: the domain name of the mount target. For more information, see <a href="https://help.aliyun.com/document_detail/62626.html">DescribeMountTargets</a>.</description></item>
        /// <item><description><b>nasPath</b>: the directory in the NAS file system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// <para>It is not recommended to configure this field; configuring NasConfigs instead. The ID of the mounted NAS must be in the same region as the cluster. The NAS must have available mount point quota or its mount point must already be on a switch within the VPC. If this field is not specified and the mountDescs field exists, a NAS will be automatically purchased and mounted to a switch within the VPC by default.</para>
        /// <para>When deploying, if the configuration has not changed, you do not need to set this parameter (i.e., the NASId field does not need to be included in the request). If you need to clear the NAS configuration, set the value of this field to an empty string in the request (i.e., set the value of the NASId field to &quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KSAK****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>SAE edition.</para>
        /// <list type="bullet">
        /// <item><description><para>lite: the lightweight edition.</para>
        /// </description></item>
        /// <item><description><para>std: the standard edition.</para>
        /// </description></item>
        /// <item><description><para>pro: the professional edition.</para>
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
        /// <para>The name of the RAM role used to authenticate the user identity.</para>
        /// <remarks>
        /// <para> You need to create an OpenID Connect (OIDC) identity provider (IdP) and an identity provider (IdP) for role-based single sign-on (SSO) in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2331022.html">Creates an OpenID Connect (OIDC) identity provider (IdP)</a> and <a href="https://help.aliyun.com/document_detail/2331016.html">Creates an identity provider (IdP) for role-based single sign-on (SSO)</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sae-test</para>
        /// </summary>
        [NameInMap("OidcRoleName")]
        [Validation(Required=false)]
        public string OidcRoleName { get; set; }

        /// <summary>
        /// <para>The Accesskey ID that the OSS reads and writes from.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// <para>The AccessKey Secret that the OSS reads and writes from.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// <para>Information of the Object Storage Service (OSS) bucket mounted to the application. The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><para><b>bucketName</b>: the name of the OSS bucket.</para>
        /// </description></item>
        /// <item><description><para><b>bucketPath</b>: the directory or object in OSS. If the specified directory or object does not exist, an error is returned.</para>
        /// </description></item>
        /// <item><description><para><b>mountPath</b>: the directory of the container in SAE. If the path already exists, the newly specified path overwrites the previous one. If the path does not exist, it is created.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: specifies whether to only allow the container path to read data from the OSS directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The container path only has read permission on the OSS directory.</description></item>
        /// <item><description><b>false</b>: The application has read and write permissions.</description></item>
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
        /// <para>The type of the deployment package. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you deploy the application by using a Java Archive (JAR) package, you can set this parameter to <b>FatJar</b>, <b>War</b>, or <b>Image</b>.</description></item>
        /// <item><description>If you deploy the application by using a PHP package, you can set this parameter to one of the following values:</description></item>
        /// </list>
        /// <para><b>PhpZip</b> <b>IMAGE_PHP_5_4</b> <b>IMAGE_PHP_5_4_ALPINE</b> <b>IMAGE_PHP_5_5</b> <b>IMAGE_PHP_5_5_ALPINE</b> <b>IMAGE_PHP_5_6</b> <b>IMAGE_PHP_5_6_ALPINE</b> <b>IMAGE_PHP_7_0</b> <b>IMAGE_PHP_7_0_ALPINE</b> <b>IMAGE_PHP_7_1</b> <b>IMAGE_PHP_7_1_ALPINE</b> <b>IMAGE_PHP_7_2</b> <b>IMAGE_PHP_7_2_ALPINE</b> <b>IMAGE_PHP_7_3</b> <b>IMAGE_PHP_7_3_ALPINE</b></para>
        /// <list type="bullet">
        /// <item><description>If you deploy the application by using a <b>Python</b> package, you can set this parameter to <b>PythonZip</b> or <b>Image</b>:</description></item>
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
        /// <para>The address of the deployment package. This parameter is required if you set <b>PackageType</b> to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required when the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The dependent PHP version of PHP package. Image is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHP-FPM 7.0</para>
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// <para>The path on which the PHP configuration file for application monitoring is mounted. Make sure that the PHP server loads the configuration file. SAE automatically generates the corresponding configuration file. No manual operations are required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/conf.d/arms.ini</para>
        /// </summary>
        [NameInMap("PhpArmsConfigLocation")]
        [Validation(Required=false)]
        public string PhpArmsConfigLocation { get; set; }

        /// <summary>
        /// <para>The details of the PHP configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k1=v1</para>
        /// </summary>
        [NameInMap("PhpConfig")]
        [Validation(Required=false)]
        public string PhpConfig { get; set; }

        /// <summary>
        /// <para>The path on which the PHP configuration file for application startup is mounted. Make sure that the PHP server uses this configuration file during the startup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>Control whether to run a script after the container is initialized. Example: {&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>To controle whether to run a script before the container stops. Example: {&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The programming language for the application’s technology stack. The value options are as follows:</para>
        /// <list type="bullet">
        /// <item><description>java: Java language</description></item>
        /// <item><description>php: PHP language</description></item>
        /// <item><description>python: Python language</description></item>
        /// <item><description>dotnet: .NET Core language</description></item>
        /// <item><description>other: Multi-language, such as C++, Go, Node.js, etc.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// <para>The configurations of Kubernetes Service-based service registration and discovery. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>serviceName</b>: the name of the Alibaba Cloud service. Format: <c>&lt;Custom content&gt;-&lt;Namespace ID&gt;</c>. <c>-&lt;Namespace ID&gt;</c> is automatically specified based on the namespace in which an application resides and cannot be changed. For example, if you select the default namespace in the China (Beijing) region, <c>-cn-beijing-default</c> is automatically specified.</description></item>
        /// <item><description><b>namespaceId</b>: the namespace ID.</description></item>
        /// <item><description><b>portAndProtocol</b>: the port number and protocol. Valid values of the port number: 1 to 65535. Valid values of the protocol: <b>TCP</b> and <b>UDP</b>.</description></item>
        /// <item><description><b>enable</b>: enables the Kubernetes Service-based registration and discovery feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serviceName&quot;:&quot;bwm-poc-sc-gateway-cn-beijing-front&quot;,&quot;namespaceId&quot;:&quot;cn-beijing:front&quot;,&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The Python environment. Set the value to <b>PYTHON 3.9.15</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHON 3.9.15</para>
        /// </summary>
        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        /// <summary>
        /// <para>The configurations for installing custom module dependencies. By default, the dependencies defined by the requirements.txt file in the root directory are installed. If the package does not contain this file and you do not configure custom dependencies in the package, specify the dependencies that you want to install in the text box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// <para>Check the launch status of the container. Containers that fail health checks more than once will not receive traffic from Server Load Balancer (SLB) instances any loner. You can use the <b>exec</b>, <b>httpGet</b>, or <b>tcpSocket</b> method to perform health checks. For more information, see the description of the <b>Liveness</b> parameter.</para>
        /// <remarks>
        /// <para>You can use only one method to perform the health check.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat /home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>The number of instances when initialized.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The resource type. Supports NULL (default) and haiguang (haiguang server).</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNLL</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The SAE version. Supported versions:</para>
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
        /// <para>Secret Mount Description
        /// Use the secret dictionaries created in the Namespace Secret Dictionary page to inject information into containers. Parameter descriptions are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>secretId: Secret instance ID. Obtain via the ListSecrets interface.</para>
        /// </description></item>
        /// <item><description><para>key: Key-value pair. Note: Set the parameter sae-sys-secret-all to mount all keys.</para>
        /// </description></item>
        /// <item><description><para>mountPath: Mount path.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{“secretId&quot;:10,”key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("SecretMountDesc")]
        [Validation(Required=false)]
        public string SecretMountDesc { get; set; }

        /// <summary>
        /// <para>Security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-wz969ngg2e49q5i4****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The canary tag configured for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;alicloud.service.tag\&quot;:\&quot;g1\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceTags")]
        [Validation(Required=false)]
        public string ServiceTags { get; set; }

        /// <summary>
        /// <para>The configuration of the container.</para>
        /// </summary>
        [NameInMap("SidecarContainersConfig")]
        [Validation(Required=false)]
        public List<SidecarContainerConfig> SidecarContainersConfig { get; set; }

        /// <summary>
        /// <para>The logging configurations of Log Service.</para>
        /// <list type="bullet">
        /// <item><description>To use Log Service resources that are automatically created by SAE, set this parameter to <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</description></item>
        /// <item><description>To use custom Log Service resources, set this parameter to <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
        /// </list>
        /// <para>The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><b>projectName</b>: the name of the Log Service project.</description></item>
        /// <item><description><b>logDir</b>: the path in which logs are stored.</description></item>
        /// <item><description><b>logType</b>: the log type. <b>stdout</b>: the standard output log of the container. You can specify only one stdout value for this parameter. If you leave this parameter empty, file logs are collected.</description></item>
        /// <item><description><b>logstoreName</b>: the name of the Logstore in Log Service.</description></item>
        /// <item><description><b>logtailName</b>: the name of the Logtail configuration in Log Service. If you do not configure this parameter, a new Logtail configuration is created.</description></item>
        /// </list>
        /// <para>If you do not need to modify the logging configurations when you deploy the application, configure the <b>SlsConfigs</b> parameter only in the first request. You do not need to include this parameter in subsequent requests. If you no longer need to use Log Service, leave the <b>SlsConfigs</b> parameter empty in the request.</para>
        /// <remarks>
        /// <para>A Log Service project that is automatically created by SAE when you create an application is deleted when the application is deleted. Therefore, when you create an application, you cannot select a Log Service project that is automatically created by SAE for log collection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>Enable application startup probe.</para>
        /// <para>Check succeeded: Indicates that the application has started successfully. If you have configured Liveness and Readiness checks, they will be performed after the application startup is successful.
        /// Check failed: Indicates that the application failed to start; an exception will be reported and the application will be automatically restarted.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>exec, httpGet, and tcpSocket methods are supported. For specific examples, see the Liveness parameter documentation.</description></item>
        /// <item><description>Only one health check method can be selected.</description></item>
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
        /// <para>The timeout period for a graceful shutdown. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>Time zone. Default to time zone of Asia/Shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The Tomcat configuration. If you want to cancel this configuration, set this parameter to &quot;&quot; or &quot;{}&quot;. The following variables are included in the configuration: Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not specify this parameter, the default port number 8080 is used.</description></item>
        /// <item><description><b>contextPath</b>: the path. Default value: /. This value indicates the root directory.</description></item>
        /// <item><description><b>maxThreads</b>: the maximum number of connections in the connection pool. Default value: 400.</description></item>
        /// <item><description><b>uriEncoding</b>: the URI encoding scheme in the Tomcat container. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312.************ If you do not specify this parameter, the default value <b>ISO-8859-1</b> is used.</description></item>
        /// <item><description><b>useBodyEncoding</b>: specifies whether to use the encoding scheme specified in the request body for URI query parameters. Default value: true.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        /// <summary>
        /// <para>The vSwitch to which the elastic network interface (ENI) of the application instance is connected. The vSwitch must be located in the VPC specified by the VpcId parameter. The SAE namespace is bound with this vSwitch. The default value is the ID of the vSwitch that is bound to the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) that corresponds to the SAE namespace. In SAE, once correspondence is configured between a namespace and a VPC, the namespace cannot correspond to other VPCs. When the SAE application is created within the namespace, the application is bound with the VPC. Multiple namespaces can correspond to the same VPC. The default value is the ID of the VPC that is bound to the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sofi8mh1q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The startup command of the WAR package. For information about how to configure the startup command, see <a href="https://help.aliyun.com/document_detail/96677.html">Configure startup commands</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The version of the Tomcat container on which the deployment package depends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>apache-tomcat-7.0.91</b></description></item>
        /// <item><description><b>apache-tomcat-8.5.42</b></description></item>
        /// </list>
        /// <para>This parameter is not returned if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
