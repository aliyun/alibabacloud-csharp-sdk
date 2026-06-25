// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is required to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions to pull images across Alibaba Cloud accounts by using a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry (ACR) Enterprise Edition instance. This parameter is required when <b>ImageUrl</b> points to an image in an ACR Enterprise Edition instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the job template. It cannot exceed 1,024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test description.</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The name of the job template. The name can contain letters, digits, and hyphens (-). It must start with a letter and be no longer than 36 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically configure the network environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: SAE automatically configures the network environment when you create the job template. The values of <b>NamespaceId</b>, <b>VpcId</b>, <b>vSwitchId</b>, and <b>SecurityGroupId</b> are ignored.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: You must manually configure the network environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public bool? AutoConfig { get; set; }

        /// <summary>
        /// <para>The maximum number of retries for a task before it is marked as failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BackoffLimit")]
        [Validation(Required=false)]
        public long? BackoffLimit { get; set; }

        /// <summary>
        /// <para>The BestEffort policy.</para>
        /// </summary>
        [NameInMap("BestEffortType")]
        [Validation(Required=false)]
        public string BestEffortType { get; set; }

        /// <summary>
        /// <para>The entrypoint command for the container. The command must be an executable inside the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>For the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>Arguments for the entrypoint command (<b>Command</b>). The format is as follows:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the example for the <c>Command</c> parameter, the value for <c>CommandArgs</c> is <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. This value must be a string that contains a JSON array. If the command takes no arguments, you can omit this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The concurrency policy for the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Forbid</b>: Prohibits concurrent runs. A new task is not created if the previous one is not complete.</para>
        /// </description></item>
        /// <item><description><para><b>Allow</b>: Allows concurrent running.</para>
        /// </description></item>
        /// <item><description><para><b>Replace</b>: If a previous task is still running when the next one is scheduled, the new task replaces the old one.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("ConcurrencyPolicy")]
        [Validation(Required=false)]
        public string ConcurrencyPolicy { get; set; }

        /// <summary>
        /// <para>The <b>ConfigMap</b> mount description. Use a ConfigMap created in the namespace to inject configurations into the container. The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap. You can call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation to obtain this ID.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can pass the <c>sae-sys-configmap-all</c> parameter to mount all keys.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>mountPath</b>: The mount path in the container.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>The CPU required for each instance, in millicores. This value cannot be 0. Only the following fixed specifications are currently supported:</para>
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
        /// <para>The host alias that maps a hostname to an IP address in the container. The parameters are described as follows:</para>
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
        /// <para>The version of the HSF runtime environment for the task, such as an Ali-Tomcat container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables image acceleration.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables image acceleration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableImageAccl")]
        [Validation(Required=false)]
        public bool? EnableImageAccl { get; set; }

        /// <summary>
        /// <para>Environment variables to set in the container. To reference variables, the ConfigMap must already exist. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. The value can be configured in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description><para>Specify custom variables</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The value of the environment variable.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference a ConfigMap</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter a value in the <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c> format. Example: <c>sae-sys-configmap-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: The source of the environment variable. Set the value to <c>configMapRef</c>.</para>
        /// </description></item>
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key to reference. If you want to reference all key-value pairs, do not specify this parameter.</para>
        /// </description></item>
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

        /// <summary>
        /// <para>The ID of the secret used to pull the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// <para>The URL of the image. This parameter is required when <b>PackageType</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The startup arguments for the JAR package. The default startup command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The startup options for the JAR package. The default startup command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-option</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The JDK version that the deployment package requires. The following versions are supported:</para>
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
        /// <para>This parameter is not supported when <b>PackageType</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The memory required for each instance, in MB. This value cannot be 0. CPU and memory specifications are coupled. The following specifications are currently supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1024</b>: corresponds to 500 or 1,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>2048</b>: corresponds to 500, 1,000, or 2,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>4096</b>: corresponds to 1,000, 2,000, or 4,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>8192</b>: corresponds to 2,000, 4,000, or 8,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>12288</b>: corresponds to 12,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>16384</b>: corresponds to 4,000, 8,000, or 16,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>24576</b>: corresponds to 12,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>32768</b>: corresponds to 16,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>65536</b>: corresponds to 8,000, 16,000, or 32,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>131072</b>: corresponds to 32,000 millicores of CPU.</para>
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
        /// <para>The NAS mount description. If this configuration does not change in subsequent deployments, you can omit this parameter. To clear the NAS configuration, set this parameter to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>The NAS mount target in the VPC of the job template. If this configuration does not change in subsequent deployments, you can omit this parameter. To clear the NAS configuration, set this parameter to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4bc9****.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The ID of the SAE namespace. The namespace name can contain only lowercase letters and hyphens (-), and must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The configurations for mounting a NAS file system.</para>
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system. If this configuration does not change in subsequent deployments, you can omit this parameter. To clear the NAS configuration, set this parameter to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The AccessKey ID for reading from and writing to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret for reading from and writing to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// <para>The description of the Object Storage Service (OSS) mount. The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>bucketName</b>: The name of the bucket.</para>
        /// </description></item>
        /// <item><description><para><b>bucketPath</b>: The directory or object in OSS. If the specified directory or object does not exist, an exception is thrown.</para>
        /// </description></item>
        /// <item><description><para><b>mountPath</b>: The path in the SAE container. If the path exists, it is overwritten. If the path does not exist, it is created.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: Specifies whether the container has read-only access to the resources in the mount directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: read-only permission.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: read and write permissions.</para>
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
        /// <para>The type of the deployment package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>For Java applications, valid values are <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</para>
        /// </description></item>
        /// <item><description><para>For PHP applications, the valid values are:</para>
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
        /// <item><description><para>For <b>Python</b> applications, valid values are <b>PythonZip</b> and <b>Image</b>.</para>
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
        /// <para>The URL of the deployment package. This parameter is required when <b>PackageType</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required when <b>PackageType</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

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
        /// <para>The mount path of the startup configuration file for a PHP task. You must make sure that the PHP server uses this configuration file on startup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>A PostStart hook. This script runs immediately after the container is created. The value must be a JSON string, for example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>A PreStop hook. This script runs immediately before the container is stopped. The value must be a JSON string, for example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The programming language. Valid values: <b>java</b>, <b>php</b>, <b>python</b>, and <b>shell</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

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
        /// <para>Python dependencies to install by using pip. If you do not set this parameter, SAE installs dependencies from the \&quot;requirements.txt\&quot; file in the root directory of your project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// <para>The ID of the referenced job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("RefAppId")]
        [Validation(Required=false)]
        public string RefAppId { get; set; }

        /// <summary>
        /// <para>The number of concurrent task instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

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
        /// <para>Specifies whether to enable task sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Slice")]
        [Validation(Required=false)]
        public bool? Slice { get; set; }

        /// <summary>
        /// <para>The parameters for task sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,1,2]</para>
        /// </summary>
        [NameInMap("SliceEnvs")]
        [Validation(Required=false)]
        public string SliceEnvs { get; set; }

        /// <summary>
        /// <para>The configuration for collecting logs to Simple Log Service (SLS).</para>
        /// <list type="bullet">
        /// <item><description><para>To use SLS resources that are automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
        /// </description></item>
        /// <item><description><para>To use your own SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>projectName</b>: The name of the SLS Project.</para>
        /// </description></item>
        /// <item><description><para><b>logDir</b>: The path of the log file.</para>
        /// </description></item>
        /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> indicates the standard output of the container. You can specify only one standard output. If you do not set this parameter, file logs are collected.</para>
        /// </description></item>
        /// <item><description><para><b>logstoreName</b>: The name of the Logstore in SLS.</para>
        /// </description></item>
        /// <item><description><para><b>logtailName</b>: The name of the Logtail in SLS. If you do not specify this parameter, a new Logtail is created.</para>
        /// </description></item>
        /// </list>
        /// <para>If the log collection configuration does not change during subsequent deployments, you do not need to set this parameter (the request does not need to include the <b>SlsConfigs</b> field). If you no longer need to use the log collection feature, set the value of this parameter to an empty string (&quot;&quot;) in your request.</para>
        /// <remarks>
        /// <para>SAE deletes a project that it automatically created when you delete the corresponding job template. Therefore, if you specify an existing project, do not use one that was automatically created by SAE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>The graceful shutdown timeout, in seconds. The value must be an integer from 1 to 300. Default: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The task timeout, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

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
        /// <para>The Tomcat configuration. To delete the configuration, set this parameter to <c>&quot;&quot;</c> or <c>{}</c>. The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: The port number. The valid range is 1024 to 65535. Ports below 1024 require root permissions. Because the container is configured with administrator permissions, specify a port number greater than 1024. If this parameter is not configured, the default port 8080 is used.</para>
        /// </description></item>
        /// <item><description><para><b>contextPath</b>: The context path. Default value: /.</para>
        /// </description></item>
        /// <item><description><para><b>maxThreads</b>: The maximum number of threads in the connection pool. Default value: 400.</para>
        /// </description></item>
        /// <item><description><para><b>uriEncoding</b>: The URI encoding scheme for Tomcat. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If this parameter is not set, the default value <b>ISO-8859-1</b> is used.</para>
        /// </description></item>
        /// <item><description><para><b>useBodyEncodingForUri</b>: Specifies whether to use the encoding specified in <c>request.getCharacterEncoding()</c> to decode the request URI. Default value: <b>true</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch for the elastic network interface of the task instance. The vSwitch must be located in the specified VPC. The vSwitch is also bound to the SAE namespace. If you do not specify this parameter, the ID of the vSwitch that is bound to the namespace is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC for the SAE namespace. In SAE, a namespace can be bound to only one VPC, and this binding cannot be changed. The binding is established when you create the first SAE job template in the namespace. A single VPC can be associated with multiple namespaces. If you do not specify this parameter, the ID of the VPC that is bound to the namespace is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sofi8mh1q****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The startup command for a WAR package deployment. The configuration steps are the same as for an image-based deployment. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Set a startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The Tomcat version that the deployment package requires. The following versions are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>apache-tomcat-7.0.91</b></para>
        /// </description></item>
        /// <item><description><para><b>apache-tomcat-8.5.42</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is not supported when <b>PackageType</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        /// <summary>
        /// <para>The workload. Set the value to <c>job</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}
