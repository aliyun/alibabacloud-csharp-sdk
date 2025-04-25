// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationConfigResponseBodyData Data { get; set; }
        public class DescribeApplicationConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is used to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/190675.html">Pull images across Alibaba Cloud accounts</a> and <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions across Alibaba Cloud accounts by using a RAM role</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/adminrole</para>
            /// </summary>
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-xxxxxx</para>
            /// </summary>
            [NameInMap("AcrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The SAE application type.</para>
            /// <list type="bullet">
            /// <item><description>micro_service</description></item>
            /// <item><description>web</description></item>
            /// <item><description>job</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>micro_service</para>
            /// </summary>
            [NameInMap("AppSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            /// <summary>
            /// <para>Indicates whether an elastic IP address (EIP) is associated with the application instance. Valid values:</para>
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

            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <para>The interval between batches in a phased release. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The command that is used to start the image. The command must be an existing executable object in the container. Example:</para>
            /// <pre><c>
            /// command:
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
            /// <para>The parameters of the image startup command. The CommandArgs parameter contains the parameters that are required for the <b>Command</b> parameter. Format:</para>
            /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
            /// <para>In the preceding <b>Command</b> example, the CommandArgs parameter is set to <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The data type of <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be an array of strings in the JSON format. You do not need to configure this parameter if it does not exist in the Command parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// <para>The details of the ConfigMap.</para>
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// <para>The ID of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// <para>The name of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConfigMapName")]
                [Validation(Required=false)]
                public string ConfigMapName { get; set; }

                /// <summary>
                /// <para>The key-value pair that is stored in the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The path on which the ConfigMap is mounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// <para>The CPU specifications that are required for each instance. Unit: millicores. You cannot set this parameter to 0. Valid values:</para>
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
            /// <para>The custom mappings between hostnames and IP addresses in the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hostName</b>: the domain name or hostname.</description></item>
            /// <item><description><b>ip</b>: the IP address.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;hostName&quot;:&quot;test.host.name&quot;,&quot;ip&quot;:&quot;0.0.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }

            [NameInMap("CustomImageNetworkType")]
            [Validation(Required=false)]
            public string CustomImageNetworkType { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

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
            /// <para>Indicates whether access to Application High Availability Service (AHAS) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Access to AHAS is enabled.</description></item>
            /// <item><description><b>false</b>: Access to AHAS is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAhas")]
            [Validation(Required=false)]
            public string EnableAhas { get; set; }

            [NameInMap("EnableCpuBurst")]
            [Validation(Required=false)]
            public string EnableCpuBurst { get; set; }

            /// <summary>
            /// <para>Indicates whether canary release rules are enabled. Canary release rules apply only to applications in Spring Cloud and Dubbo frameworks. Valid values:</para>
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

            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            [NameInMap("EnableNewArms")]
            [Validation(Required=false)]
            public bool? EnableNewArms { get; set; }

            /// <summary>
            /// <para>The environment variables. Variable description:</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the environment variable.</description></item>
            /// <item><description><b>value</b>: the value or reference of the environment variable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
            /// </summary>
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }

            /// <summary>
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
            /// <para>docker.io/library/nginx:1.14.2</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("InitContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataInitContainersConfig> InitContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataInitContainersConfig : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc : TeaModel {
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                }

                [NameInMap("Envs")]
                [Validation(Required=false)]
                public string Envs { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The arguments in the JAR package. The arguments are used to start the application container. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// <para>The option settings in the JAR package. The settings are used to start the application container. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-Dtest=true</para>
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
            /// <para>The logging configurations of Message Queue for Apache Kafka. The following parameters are involved:</para>
            /// <list type="bullet">
            /// <item><description><para><b>KafkaConfigs</b>: the configurations of Message Queue for Apache Kafka.</para>
            /// </description></item>
            /// <item><description><para><b>createTime</b>: the time when the Message Queue for Apache Kafka instance was created.</para>
            /// </description></item>
            /// <item><description><para><b>kafkaTopic</b>: the message topic that is used to classify messages.</para>
            /// </description></item>
            /// <item><description><para><b>logDir</b>: the path in which logs are stored.</para>
            /// </description></item>
            /// <item><description><para><b>logType</b>: the type of collected logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file_log</b>: the file log that is stored in the container. The path of the file logs in the container is returned.</description></item>
            /// <item><description><b>stdout</b>: the standard output log of the container. You can specify only one stdout value.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>kafkaEndpoint</b>: the endpoint of the Message Queue for Apache Kafka service.</para>
            /// </description></item>
            /// <item><description><para><b>kafkaInstanceId</b>: the ID of the Message Queue for Apache Kafka instance.</para>
            /// </description></item>
            /// <item><description><para><b>region</b>: the region where the Message Queue for Apache Kafka instance resides.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("KafkaConfigs")]
            [Validation(Required=false)]
            public string KafkaConfigs { get; set; }

            /// <summary>
            /// <para>The details of the availability check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. You can use one of the following methods to perform the health check:</para>
            /// <list type="bullet">
            /// <item><description>Sample code of the <b>exec</b> method: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></description></item>
            /// <item><description>Sample code of the <b>httpGet</b> method: <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
            /// <item><description>Sample code of the <b>tcpSocket</b> method: <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
            /// </list>
            /// <remarks>
            /// <para> You can use only one method to perform the health check.</para>
            /// </remarks>
            /// <para>The following parameters are involved:</para>
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
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;curl <a href="http://localhost:8080%22%5D%7D,%22initialDelaySeconds%22:20,%22timeoutSeconds%22:3%7D">http://localhost:8080&quot;]},&quot;initialDelaySeconds&quot;:20,&quot;timeoutSeconds&quot;:3}</a></para>
            /// </summary>
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }

            /// <summary>
            /// <para>The size of memory required by each instance. Unit: MB. You cannot set this parameter to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
            /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 1000.</description></item>
            /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
            /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8000.</description></item>
            /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
            /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
            /// <item><description>This parameter is set to <b>24567</b> if the Cpu parameter is set to 12000.</description></item>
            /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
            /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
            /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;0&quot;</para>
            /// </summary>
            [NameInMap("MicroRegistration")]
            [Validation(Required=false)]
            public string MicroRegistration { get; set; }

            [NameInMap("MicroRegistrationConfig")]
            [Validation(Required=false)]
            public string MicroRegistrationConfig { get; set; }

            [NameInMap("MicroserviceEngineConfig")]
            [Validation(Required=false)]
            public string MicroserviceEngineConfig { get; set; }

            /// <summary>
            /// <para>The percentage of the minimum number of available instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: the default value. This value indicates that the minimum number of available instances is not measured by percentage. If you do not configure this parameter, the default value <b>-1</b> is used.</description></item>
            /// <item><description><b>0 to 100</b>: indicates that the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). If the calculated result is not an integer, the result is rounded up to the nearest integer. For example, if the percentage is set to <b>50</b>% and five instances are available, the minimum number of available instances is 3.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> parameters are returned and the value of the <b>MinReadyInstanceRatio</b> parameter is not <b>-1</b>, the value of the <b>MinReadyInstanceRatio</b> parameter takes effect. If the <b>MinReadyInstances</b> parameter is set to <b>5</b> and the <b>MinReadyInstanceRatio</b> parameter is set to <b>50</b>, the value of the <b>MinReadyInstanceRatio</b> parameter determines the minimum number of available instances.</para>
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
            /// <item><description>If you set the value to <b>0</b>, business interruptions occur when the application is updated.</description></item>
            /// <item><description>If you set the value to <b>-1</b>, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// <para>The details of the mounted NAS file system.</para>
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataMountDesc : TeaModel {
                /// <summary>
                /// <para>The path on which the NAS file system is mounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The directory in the NAS file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("NasPath")]
                [Validation(Required=false)]
                public string NasPath { get; set; }

            }

            /// <summary>
            /// <para>The mount target of the NAS file system in the VPC where the application is deployed. If you do not need to modify this configuration during the deployment, configure the <b>MountHost</b> parameter only in the first request. You do not need to include this parameter in subsequent requests. If you need to remove this configuration, leave the <b>MountHost</b> parameter empty in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// <para>The ID of the microservice application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxx@xxxxx</para>
            /// </summary>
            [NameInMap("MseApplicationId")]
            [Validation(Required=false)]
            public string MseApplicationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen-alb-demo-5c****</para>
            /// </summary>
            [NameInMap("MseApplicationName")]
            [Validation(Required=false)]
            public string MseApplicationName { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
            /// </summary>
            [NameInMap("NasConfigs")]
            [Validation(Required=false)]
            public string NasConfigs { get; set; }

            /// <summary>
            /// <para>The ID of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKSN89**</para>
            /// </summary>
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }

            [NameInMap("NewSaeVersion")]
            [Validation(Required=false)]
            public string NewSaeVersion { get; set; }

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
            /// <para>The description of the mounted OSS bucket.</para>
            /// </summary>
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeApplicationConfigResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The directory or object in OSS. If the specified directory or object does not exist, an error is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data/user.data</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <para>The path of the container in SAE. The parameter value that you specified overwrites the original value. If the specified path does not exist, SAE automatically creates the path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/data/user.data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>Indicates whether the application can use the container path to read data from or write data to resources in the directory of the OSS bucket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The application has the read-only permissions.</description></item>
                /// <item><description><b>false</b>: The application has the read and write permissions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The type of the deployment package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you deploy the application by using a Java Archive (JAR) package, you can set this parameter to <b>FatJar</b>, <b>War</b>, or <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>If you deploy the application by using a PHP package, you can set this parameter to one of the following values:</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>War</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The URL of the deployment package. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>FatJar</b> or <b>War</b>.</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the deployment package. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>FatJar</b> or <b>War</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
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
            /// <para>The path on which the PHP configuration file for application monitoring is mounted. Make sure that the PHP server loads the configuration file.</para>
            /// <para>SAE automatically generates the corresponding configuration file. No manual operations are required.</para>
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
            /// <para>The script that is run immediately after the container is started. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The script that is run before the container is stopped. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The programming language that is used to create the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>java</b>: Java</description></item>
            /// <item><description><b>php</b>: PHP</description></item>
            /// <item><description><b>other</b>: Other programming languages, such as Python, C++, Go, .NET, and Node.js.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;serviceName&quot;:&quot;bwm-poc-sc-gateway-cn-beijing-front&quot;,&quot;namespaceId&quot;:&quot;cn-beijing:front&quot;,&quot;portAndProtocol&quot;:{&quot;18012&quot;:&quot;TCP&quot;},&quot;enable&quot;:true}</para>
            /// </summary>
            [NameInMap("PvtzDiscovery")]
            [Validation(Required=false)]
            public string PvtzDiscovery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PYTHON 3.9.15</para>
            /// </summary>
            [NameInMap("Python")]
            [Validation(Required=false)]
            public string Python { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Flask==2.0</para>
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// <para>The details of the health check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. Containers that fail health checks cannot receive traffic from Server Load Balancer (SLB) instances. You can use the <b>exec</b>, <b>httpGet</b>, or <b>tcpSocket</b> method to perform health checks. For more information, see the description of the <b>Liveness</b> parameter.</para>
            /// <remarks>
            /// <para> You can use only one method to perform the health check.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;curl <a href="http://localhost:8080%22%5D%7D,%22initialDelaySeconds%22:20,%22timeoutSeconds%22:5%7D">http://localhost:8080&quot;]},&quot;initialDelaySeconds&quot;:20,&quot;timeoutSeconds&quot;:5}</a></para>
            /// </summary>
            [NameInMap("Readiness")]
            [Validation(Required=false)]
            public string Readiness { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SecretMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSecretMountDesc> SecretMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSecretMountDesc : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz969ngg2e49q5i4****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The canary tag configured for the application.</para>
            /// </summary>
            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

            [NameInMap("SidecarContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfig> SidecarContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfig : TeaModel {
                [NameInMap("AcrInstanceId")]
                [Validation(Required=false)]
                public string AcrInstanceId { get; set; }

                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc : TeaModel {
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("EmptyDirDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc> EmptyDirDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc : TeaModel {
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Envs")]
                [Validation(Required=false)]
                public string Envs { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The logging configurations of Log Service.</para>
            /// <list type="bullet">
            /// <item><description>To use Log Service resources that are automatically created by SAE, set this parameter to <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</description></item>
            /// <item><description>To use custom Log Service resources, set this parameter to <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
            /// </list>
            /// <para>The following parameters are involved:</para>
            /// <list type="bullet">
            /// <item><description><b>projectName</b>: the name of the Log Service project.</description></item>
            /// <item><description><b>logDir</b>: the path in which logs are stored.</description></item>
            /// <item><description><b>logType</b>: the log type. <b>stdout</b>: the standard output log of the container. You can specify only one stdout value for this parameter. If you leave this parameter empty, file logs are collected.</description></item>
            /// <item><description><b>logstoreName</b>: the name of the Logstore in Log Service.</description></item>
            /// <item><description><b>logtailName</b>: the name of the Logtail configuration in Log Service. If you do not configure this parameter, a new Logtail configuration is created.</description></item>
            /// </list>
            /// <para>If you do not need to modify the logging configurations when you deploy the application, configure the <b>SlsConfigs</b> parameter only in the first request. You do not need to include this parameter in subsequent requests. If you no longer need to use Log Service, leave the <b>SlsConfigs</b> parameter empty in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            [NameInMap("SwimlanePvtzDiscovery")]
            [Validation(Required=false)]
            public string SwimlanePvtzDiscovery { get; set; }

            /// <summary>
            /// <para>The details of the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataTags> Tags { get; set; }
            public class DescribeApplicationConfigResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
            /// <para>The Tomcat configuration. If you want to delete the configuration, set this parameter to {} or leave this parameter empty. The following parameters are involved:</para>
            /// <list type="bullet">
            /// <item><description><b>port</b>: the port number. Valid values: 1024 to 65535. The root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not configure this parameter, the default port number 8080 is used.</description></item>
            /// <item><description><b>contextPath</b>: the path. Default value: /. This value indicates the root directory.</description></item>
            /// <item><description><b>maxThreads</b>: the maximum number of connections in the connection pool. Default value: 400.</description></item>
            /// <item><description><b>uriEncoding</b>: the URI encoding scheme in the Tomcat container. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If you do not configure this parameter, the default value <b>ISO-8859-1</b> is used.</description></item>
            /// <item><description><b>useBodyEncoding</b>: indicates whether to use the encoding scheme that is specified by <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</description></item>
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
            /// <para>The following parameters are involved:</para>
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
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The option settings in the WAR package. The settings are used to start the application container. The default startup command is <c>java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap &quot;$@&quot; start</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-option</para>
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

        /// <summary>
        /// <para>The returned error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the configurations of an application were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The configurations were obtained.</description></item>
        /// <item><description><b>false</b>: The configurations failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
