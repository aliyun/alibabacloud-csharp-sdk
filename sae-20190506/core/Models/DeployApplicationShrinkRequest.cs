// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeployApplicationShrinkRequest : TeaModel {
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
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

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
        /// <para>Specifies whether to automatically enable an auto scaling policy for the application. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: turns on Logon-free Sharing</description></item>
        /// <item><description><b>false</b>: turns off Logon-free Sharing</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// <para>The interval between batches during a batch release. Unit: minutes.</para>
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
        /// <para>Start the application</para>
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

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
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("CustomImageNetworkType")]
        [Validation(Required=false)]
        public string CustomImageNetworkType { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only for applications that are in the Stopped state. If you call the <b>DeployApplication</b> operation to manage a running application, the application is immediately redeployed.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): specifies that the system immediately deploys the application, enables new configurations, and pulls application instances.</description></item>
        /// <item><description><b>false</b>: specifies that the system only enables the new configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public string Deploy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>.NET 3.1</para>
        /// </summary>
        [NameInMap("Dotnet")]
        [Validation(Required=false)]
        public string Dotnet { get; set; }

        /// <summary>
        /// <para>The version of the container, such as Ali-Tomcat, in which an application developed based on High-speed Service Framework (HSF) is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether access to Application High Availability Service (AHAS) is enabled. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Access to AHAS is enabled.</description></item>
        /// <item><description><b>false</b>: Access to AHAS is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public string EnableAhas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuBurst")]
        [Validation(Required=false)]
        public bool? EnableCpuBurst { get; set; }

        /// <summary>
        /// <para>Indicates whether canary release rules are enabled. Canary release rules apply only to applications in Spring Cloud and Dubbo frameworks. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The canary release rules are enabled.</description></item>
        /// <item><description><b>false</b>: The canary release rules are disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableGreyTagRoute")]
        [Validation(Required=false)]
        public bool? EnableGreyTagRoute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSidecarResourceIsolated")]
        [Validation(Required=false)]
        public bool? EnableSidecarResourceIsolated { get; set; }

        /// <summary>
        /// <para>The environment variables. You can configure custom environment variables or reference a ConfigMap. If you want to reference a ConfigMap, you must first create a ConfigMap. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><para>Customize</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable.</description></item>
        /// <item><description><b>value</b>: the value of the environment variable.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference ConfigMap</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the environment variable. You can reference one or all keys. If you want to reference all keys, specify <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>. Example: <c>sae-sys-configmap-all-test1</c>.</description></item>
        /// <item><description><b>valueFrom</b>: the reference of the environment variable. Set the value to <c>configMapRef</c>.</description></item>
        /// <item><description><b>configMapId</b>: the ConfigMap ID.</description></item>
        /// <item><description><b>key</b>: the key. If you want to reference all keys, do not configure this parameter.</description></item>
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
        /// <para>The URL of the image. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InitContainersConfig")]
        [Validation(Required=false)]
        public string InitContainersConfigShrink { get; set; }

        /// <summary>
        /// <para>The arguments in the JAR package. The arguments are used to start the application container. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The option settings in the JAR package. The settings are used to start the application container. The default startup command for application deployment is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-option</para>
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
        /// <para>The details of the availability check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. You can use one of the following methods to perform the health check:</para>
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
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sleep&quot;,&quot;5s&quot;]},&quot;initialDelaySeconds&quot;:10,&quot;timeoutSeconds&quot;:11}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
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
        /// <item><description><b>2</b> : MSE Nacos registry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-zvp2bh6h70r\&quot;,\&quot;namespace\&quot;:\&quot;4c0aa74f-57cb-423c-b6af-5d9f2d0e3dbd\&quot;}</para>
        /// </summary>
        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        [NameInMap("MicroserviceEngineConfig")]
        [Validation(Required=false)]
        public string MicroserviceEngineConfig { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum number of available instances. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>-1</b>, the minimum number of available instances is not determined based on this parameter. Default value: -1.</description></item>
        /// <item><description>If you set the value to a number <b>from 0 to 100</b>, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if the percentage is set to <b>50</b>% and five instances are available, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When both <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and <b>MinReadyInstanceRatio</b> is set to a number from 0 to 100, the value of <b>MinReadyInstanceRatio</b>** takes precedence. For example, if <b>MinReadyInstances</b> is set to **5, and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × <b>50%</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Special values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>0</b>, business interruptions occur when the application is updated.</description></item>
        /// <item><description>If you set the value to \<em>\</em>-1\<em>\</em>, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>The configurations for mounting the NAS file system. After the application is created, you may want to call other operations to manage the application. If you do not want to change the NAS configurations in these subsequent operations, you can omit the <b>MountDesc</b> parameter in the requests. If you want to unmount the NAS file system, you must set the <b>MountDesc</b> values in the subsequent requests to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>The mount target of the NAS file system in the VPC where the application is deployed. If you do not need to modify this configuration during the deployment, configure the <b>MountHost</b> parameter only in the first request. You do not need to include this parameter in subsequent requests. If you need to remove this configuration, leave the <b>MountHost</b> parameter empty in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4bc9****.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

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
        /// <para>The ID of the File Storage NAS file system. After the application is created, you may want to call other operations to manage the application. If you do not want to change the NAS configurations in these subsequent operations, you can omit the <b>NasId</b> parameter in the requests. If you want to unmount the NAS file system, you must set the <b>NasId</b> values in the subsequent requests to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

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
        /// <para>The AccessKey ID that is used to read data from and write data to Object Storage Service (OSS) buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret that is used to read data from and write data to OSS buckets.</para>
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
        /// <b>Example:</b>
        /// <para>FatJar</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The address of the deployment package. This parameter is required when the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required when the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
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
        /// <para>The script that is run immediately after the container is started. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;\\]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script that is run before the container is stopped. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;\\]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

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
        /// <para>The details of the health check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. Containers that fail health checks cannot receive traffic from Server Load Balancer (SLB) instances. You can use the <b>exec</b>, <b>httpGet</b>, or <b>tcpSocket</b> method to perform health checks. For more information, see the description of the <b>Liveness</b> parameter.</para>
        /// <remarks>
        /// <para>You can use only one method to perform the health check.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sleep&quot;,&quot;6s&quot;]},&quot;initialDelaySeconds&quot;:15,&quot;timeoutSeconds&quot;:12}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{“secretId&quot;:10,”key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("SecretMountDesc")]
        [Validation(Required=false)]
        public string SecretMountDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-wz969ngg2e49q5i4****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
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
        public string SidecarContainersConfigShrink { get; set; }

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

        [NameInMap("StartupProbe")]
        [Validation(Required=false)]
        public string StartupProbe { get; set; }

        [NameInMap("SwimlanePvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string SwimlanePvtzDiscoverySvc { get; set; }

        /// <summary>
        /// <para>The timeout period for a graceful shutdown. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
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
        /// <para>The deployment policy. If the minimum number of available instances is 1, the value of the <b>UpdateStrategy</b> parameter is an empty string (&quot;&quot;). If the minimum number of available instances is greater than 1, the following strategies can be configured:</para>
        /// <list type="bullet">
        /// <item><description>The application is deployed on an instance. The remaining instances are automatically classified into two release batches whose interval is set to 1. In this case, the parameter is set to <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c>.</description></item>
        /// <item><description>The application is deployed on an instance. The remaining instances are manually classified into two release batches. In this case, the parameter is set to <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c>.</description></item>
        /// <item><description>All instances are automatically classified into two release batches. The application is deployed on the instances of the two batches in parallel. In this case, the parameter is set to <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></description></item>
        /// </list>
        /// <para>The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the release policy. Valid values: <b>GrayBatchUpdate</b> and <b>BatchUpdate</b>.</para>
        /// </description></item>
        /// <item><description><para><b>batchUpdate</b>: the phased release policy.</para>
        /// <list type="bullet">
        /// <item><description><b>batch</b>: the number of release batches.</description></item>
        /// <item><description><b>releaseType</b>: the processing method for the batches. Valid values: <b>auto</b> and <b>manual</b>.</description></item>
        /// <item><description><b>batchWaitTime</b>: the interval between release batches. Unit: seconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>grayUpdate</b>: the number of release batches in the phased release after a canary release. This parameter is returned only if the <b>type</b> parameter is set to <b>GrayBatchUpdate</b>.</para>
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
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

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
