// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateJobRequest : TeaModel {
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
        /// <para>The name of the job template. The name can contain digits, letters, and hyphens (-). The name must start with a letter and cannot exceed 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically configure the network environment. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The network environment is automatically configured by SAE when the application is created. In this case, the values of the <b>NamespaceId</b>, <b>VpcId</b>, <b>vSwitchId</b>, and <b>SecurityGroupId</b> parameters are ignored.</description></item>
        /// <item><description><b>false</b>: The network environment is manually configured based on your settings when the application is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public bool? AutoConfig { get; set; }

        /// <summary>
        /// <para>The number of times the job is retried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BackoffLimit")]
        [Validation(Required=false)]
        public long? BackoffLimit { get; set; }

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
        /// <para>The concurrency policy of the job. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>Forbid</b>: Prohibits concurrent running. If the previous job is not completed, no new job is created.</description></item>
        /// <item><description><b>Allow</b>: Allows concurrent running.</description></item>
        /// <item><description><b>Replace</b>: If the previous job is not completed when the time to create a new job is reached, the new job replaces the previous job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("ConcurrencyPolicy")]
        [Validation(Required=false)]
        public string ConcurrencyPolicy { get; set; }

        /// <summary>
        /// <para>The description of the <b>ConfigMap</b> instance mounted to the application. Use configurations created on the Configuration Items page to configure containers. The following table describes the parameters that are used in the preceding statements.</para>
        /// <list type="bullet">
        /// <item><description><b>congfigMapId</b>: the ID of the ConfigMap instance. You can call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation to obtain the ID.</description></item>
        /// <item><description><b>key</b>: the key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use the <c>sae-sys-configmap-all</c> key to mount all keys.</para>
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
        /// <para>The CPU specifications that are required for each instance. Unit: millicores. You cannot set this parameter to 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>500</description></item>
        /// <item><description>1000</description></item>
        /// <item><description>2000</description></item>
        /// <item><description>4000</description></item>
        /// <item><description>8000</description></item>
        /// <item><description>16000</description></item>
        /// <item><description>32000</description></item>
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
        /// <para>The version of the container, such as Ali-Tomcat, in which an application developed based on High-speed Service Framework (HSF) is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableImageAccl")]
        [Validation(Required=false)]
        public bool? EnableImageAccl { get; set; }

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
        /// <para>The size of memory required by each instance. Unit: MB. You cannot set this parameter to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
        /// <list type="bullet">
        /// <item><description>Set the value to 1024 when Cpu is set to 500 or 1000.</description></item>
        /// <item><description>Set the value to 2048 when Cpu is set to 500, 1000 or 2000.</description></item>
        /// <item><description>Set the value to 4096 when Cpu is set to 1000, 2000, or 4000.</description></item>
        /// <item><description>Set the value to 8192 when Cpu is set to 2000, 4000, or 8000.</description></item>
        /// <item><description>Set the value to 12288 when Cpu is set to 12000.</description></item>
        /// <item><description>Set the value to 16384 when Cpu is set to 4000, 8000, or 16000.</description></item>
        /// <item><description>Set the value to 24576 when Cpu is set to 12000.</description></item>
        /// <item><description>Set the value to 32768 when Cpu is set to 16000.</description></item>
        /// <item><description>Set the value to 65536 when Cpu is set to 8000, 16000, or 32000.</description></item>
        /// <item><description>Set the value to 131072 when Cpu is set to 32000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

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
        /// <para>The ID of the Serverless App Engine (SAE) namespace. The ID can contain only lowercase letters and hyphens (-). It must start with a lowercase letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The ID of the Apsara File Storage NAS file system. After the application is created, you may want to call other operations to manage the application. If you do not want to change the NAS configurations in these subsequent operations, you can omit the <b>NasId</b> parameter in the requests. If you want to unmount the NAS file system, you must set the <b>NasId</b> values in the subsequent requests to an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

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
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required if you set <b>PackageType</b> to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

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
        /// <para>The programming language. Valid values: <b>java</b>, <b>php</b>, <b>python</b>, and <b>shell</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

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
        /// <para>The ID of the job that you reference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("RefAppId")]
        [Validation(Required=false)]
        public string RefAppId { get; set; }

        /// <summary>
        /// <para>The number of concurrent instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

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
        /// <para>Specifies whether to enable job sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Slice")]
        [Validation(Required=false)]
        public bool? Slice { get; set; }

        /// <summary>
        /// <para>The parameters of job sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,1,2]</para>
        /// </summary>
        [NameInMap("SliceEnvs")]
        [Validation(Required=false)]
        public string SliceEnvs { get; set; }

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
        /// <para>The timeout period for a graceful shutdown. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: seconds.</para>
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

        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

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

        /// <summary>
        /// <para>Set the value to <c>job</c>.</para>
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
