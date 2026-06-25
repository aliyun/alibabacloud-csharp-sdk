// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateJobRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is required to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions across Alibaba Cloud accounts by using a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry Enterprise Edition instance. This parameter is required if <b>ImageUrl</b> is set to an image in a Container Registry Enterprise Edition instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the job template to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The number of retries for the job.</para>
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
        /// <para>The startup command of the image. The command must be an executable object that exists in the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>In this example, <c>Command=&quot;echo&quot; and CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments of the image startup <b>Command</b>. The value must be a JSON array that is converted to a string. Format:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> array is converted to a string. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The policy of running concurrent jobs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Forbid</b>: A new job is not created if the previous job is not completed.</para>
        /// </description></item>
        /// <item><description><para><b>Allow</b>: Concurrent jobs are allowed.</para>
        /// </description></item>
        /// <item><description><para><b>Replace</b>: When the time to create a new job is reached, the new job replaces the previous job if the previous job is not completed.</para>
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
        /// <para>The description of the <b>ConfigMap</b> instance that is mounted to the container. You can use the ConfigMap instance created on the Namespace Configurations page to inject configurations into the container. The value is a JSON string. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap instance. You can call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation to obtain the ID.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key of the key-value pair.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can pass the <c>sae-sys-configmap-all</c> parameter to mount all key-value pairs.</para>
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
        /// <para>The custom mapping between a hostname and an IP address in the container. The value is a JSON string. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hostName</b>: the domain name or hostname.</para>
        /// </description></item>
        /// <item><description><para><b>ip</b>: the IP address.</para>
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
        /// <para>The version of the application runtime environment in High-speed Service Framework (HSF), such as an Ali-Tomcat container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image acceleration.</para>
        /// </summary>
        [NameInMap("EnableImageAccl")]
        [Validation(Required=false)]
        public bool? EnableImageAccl { get; set; }

        /// <summary>
        /// <para>The environment variables of the container. You can customize environment variables or reference variables from a ConfigMap. To reference a ConfigMap, you must create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. The value is a JSON string. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom variables</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: the name of the environment variable.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: the value of the environment variable.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference variables from a ConfigMap</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key-value pair or all key-value pairs. To reference all key-value pairs, set the value to <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>. Example: <c>sae-sys-configmap-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: the reference of the environment variable. Set the value to <c>configMapRef</c>.</para>
        /// </description></item>
        /// <item><description><para><b>configMapId</b>: the ID of the ConfigMap.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key of the key-value pair. If you want to reference all key-value pairs, do not configure this field.</para>
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
        /// <para>The ID of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// <para>The URL of the image. This parameter is required if <b>Package Type</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The arguments of the JAR package to start the application. The default startup command of the application is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>The options of the JAR package to start the application. The default startup command of the application is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-option</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The Java Development Kit (JDK) version that the deployment package depends on. The following versions are supported:</para>
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
        /// <para>This parameter is not supported when <b>Package Type</b> is set to <b>Image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The description of the NAS mount. If the configurations are not changed during a deployment, you do not need to configure this parameter. To clear the NAS configurations, set the value of this parameter to an empty string (<c>&quot;&quot;</c>) in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{mountPath: &quot;/tmp&quot;, nasPath: &quot;/&quot;}]</para>
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// <para>The mount target of the NAS file system in the virtual private cloud (VPC) where the job template is located. If the configurations are not changed during a deployment, you do not need to configure this parameter. To clear the NAS configurations, set the value of this parameter to an empty string (<c>&quot;&quot;</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4bc9****.com</para>
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// <para>The configurations of mounting a NAS file system.</para>
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// <para>The ID of the Apsara File Storage NAS file system. If the configurations are not changed during a deployment, you do not need to configure this parameter. To clear the NAS configurations, set the value of this parameter to an empty string (<c>&quot;&quot;</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10d3b4****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The AccessKey ID that is used to read data from and write data to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret that is used to read data from and write data to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// <para>The description of the OSS mount. The value is a JSON string. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>bucketName</b>: the name of the bucket.</para>
        /// </description></item>
        /// <item><description><para><b>bucketPath</b>: the directory or object that you created in OSS. An exception occurs if the specified OSS mount directory does not exist.</para>
        /// </description></item>
        /// <item><description><para><b>mountPath</b>: The path in the SAE container. If the path exists, the new path overwrites the existing one. If the path does not exist, a new path is created.</para>
        /// </description></item>
        /// <item><description><para><b>readOnly</b>: specifies whether a container has the read-only permission on the resources in the mount directory.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The container has the read-only permission.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The container has the read and write permissions.</para>
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
        /// <para>The URL of the deployment package. This parameter is required if <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-hangzhou.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required if <b>Package Type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PythonZip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

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
        /// <para>The path on which the PHP application startup configuration file is mounted. Make sure that the PHP server uses this configuration file to start the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/etc/php/php.ini</para>
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// <para>The script that is executed after the container is started. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script that is executed before the container is stopped. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;echo hello&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The programming language. Supported values: <b>java</b>, <b>php</b>, <b>python</b>, and <b>shell</b>.</para>
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
        /// <para>The custom module dependencies. By default, the dependencies that are defined in the requirements.txt file in the root directory of the package are installed. If you do not configure this parameter or the package does not have a requirements.txt file, you can specify the dependencies that you want to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flask==2.0</para>
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// <para>The ID of the referenced application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("RefAppId")]
        [Validation(Required=false)]
        public string RefAppId { get; set; }

        /// <summary>
        /// <para>The number of concurrent instances for the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public string Replicas { get; set; }

        /// <summary>
        /// <para>Enables job sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Slice")]
        [Validation(Required=false)]
        public bool? Slice { get; set; }

        /// <summary>
        /// <para>The parameters for job sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,1,2]</para>
        /// </summary>
        [NameInMap("SliceEnvs")]
        [Validation(Required=false)]
        public string SliceEnvs { get; set; }

        /// <summary>
        /// <para>The configurations of collecting logs to Log Service.</para>
        /// <list type="bullet">
        /// <item><description><para>Use the Log Service resources that are automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
        /// </description></item>
        /// <item><description><para>Use a custom Log Service resource: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>projectName</b>: The name of the Log Service project.</para>
        /// </description></item>
        /// <item><description><para><b>logDir</b>: The log path.</para>
        /// </description></item>
        /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> indicates the standard output log of the container. You can specify only one standard output. If you do not configure this field, file logs are collected.</para>
        /// </description></item>
        /// <item><description><para><b>logstoreName</b>: The name of the Logstore in Log Service.</para>
        /// </description></item>
        /// <item><description><para><b>logtailName</b>: The name of the Logtail. If you do not specify this parameter, a new Logtail is created.</para>
        /// </description></item>
        /// </list>
        /// <para>If the SLS configuration is not changed during a deployment, you do not need to configure this parameter. To stop using the log collection feature, set the value of this parameter to an empty string (<c>&quot;&quot;</c>).</para>
        /// <remarks>
        /// <para>Projects that are automatically created with a job template are deleted when the job template is deleted. Therefore, when you select an existing project, do not select a project that is automatically created by SAE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>The graceful timeout period. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The timeout period for the job. Unit: seconds.</para>
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
        /// <para>The configurations of the Tomcat file. If you set this parameter to &quot;&quot; or &quot;{}&quot;, the configurations are deleted. The value is a JSON string. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: The port number. Valid values: 1024 to 65535. The root permission is required to perform operations on ports whose number is smaller than 1024. The container is configured with the administrator permission. Therefore, specify a port whose number is greater than 1024. If you do not configure this field, the default port 8080 is used.</para>
        /// </description></item>
        /// <item><description><para><b>contextPath</b>: The context path. Default value: /.</para>
        /// </description></item>
        /// <item><description><para><b>maxThreads</b>: The maximum number of connections in the connection pool. Default value: 400.</para>
        /// </description></item>
        /// <item><description><para><b>uriEncoding</b>: The URI encoding scheme in Tomcat. Supported values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If you do not set this parameter, the default value <b>ISO-8859-1</b> is used.</para>
        /// </description></item>
        /// <item><description><para><b>useBodyEncodingForUri</b>: Specifies whether to use <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</para>
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
        /// <para>The startup command for the application that is deployed in a WAR package. The procedure is the same as that for configuring the startup command for an image. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Set a startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// <para>The Tomcat version that the deployment package depends on. The following versions are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>apache-tomcat-7.0.91</b></para>
        /// </description></item>
        /// <item><description><para><b>apache-tomcat-8.5.42</b></para>
        /// </description></item>
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
