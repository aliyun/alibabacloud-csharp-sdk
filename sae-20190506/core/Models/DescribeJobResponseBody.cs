// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobResponseBody : TeaModel {
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
        /// <para>The information of the job template.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyData Data { get; set; }
        public class DescribeJobResponseBodyData : TeaModel {
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
            /// <para>The description of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample application</para>
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <para>The ID of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The number of times that the job was retried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BackoffLimit")]
            [Validation(Required=false)]
            public long? BackoffLimit { get; set; }

            /// <summary>
            /// <para>The command that is used to start the image. The command must be an existing executable object in the container. Example:</para>
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
            /// <para>The arguments of the image startup command. This parameter contains the arguments that are required for <b>Command</b>. Format:</para>
            /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
            /// <para>In the preceding <b>Command</b> example, the CommandArgs parameter is set to <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The data type of <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be an array of strings in the JSON format. If this parameter does not exist in the Command parameter, you do not need to configure it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// <para>The concurrency policy of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Forbid</b>: Concurrent running is prohibited. If the previous job is not completed, no new job is created.</description></item>
            /// <item><description><b>Allow</b>: Concurrent running is allowed.</description></item>
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
            /// <para>The details of the ConfigMap.</para>
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeJobResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// <para>The ConfigMap ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// <para>The ConfigMap name.</para>
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
            /// <para>The CPU specifications required for each instance. Unit: millicore. This parameter cannot be set to 0. Valid values:</para>
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
            /// <para>The custom mapping between the hostname and IP address in the container. Valid values:</para>
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

            /// <summary>
            /// <para>The version of the container, such as Ali-Tomcat, in which a job that is developed based on High-speed Service Framework (HSF) is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The environment variables. You can configure custom environment variables or reference a ConfigMap. If you want to reference a ConfigMap, you must first create a ConfigMap. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Custom configuration</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the environment variable.</description></item>
            /// <item><description><b>value</b>: the value of the environment variable.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Reference a ConfigMap</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the environment variable. You can reference one or all keys. To reference all keys, specify <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>. Example: <c>sae-sys-configmap-all-test1</c>.</description></item>
            /// <item><description><b>valueFrom</b>: the reference of the environment variable. Set the value to <c>configMapRef</c>.</description></item>
            /// <item><description><b>configMapId</b>: the ID of the ConfigMap.</description></item>
            /// <item><description><b>key</b>: the key. If you want to reference all keys, you do not need to configure this parameter.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
            /// </summary>
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }

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
            /// <para>The URL of the image. This parameter is returned only if <b>PackageType</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker.io/library/nginx:1.14.2</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The arguments in the JAR package. The arguments are used to start the job. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// <para>The option settings in the JAR package. The settings are used to start the job. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-Dtest=true</para>
            /// </summary>
            [NameInMap("JarStartOptions")]
            [Validation(Required=false)]
            public string JarStartOptions { get; set; }

            /// <summary>
            /// <para>The version of the Java Development Kit (JDK) on which the deployment package of the application depends. The following versions are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>Open JDK 8</b></description></item>
            /// <item><description><b>Open JDK 7</b></description></item>
            /// <item><description><b>Dragonwell 11</b></description></item>
            /// <item><description><b>Dragonwell 8</b></description></item>
            /// <item><description><b>openjdk-8u191-jdk-alpine3.9</b></description></item>
            /// <item><description><b>openjdk-7u201-jdk-alpine3.9</b></description></item>
            /// </list>
            /// <para>This parameter is not returned if <b>PackageType</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <para>The size of memory that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
            /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
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
            /// <para>The details of the mounted NAS file system.</para>
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeJobResponseBodyDataMountDesc : TeaModel {
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
            /// <para>The mount target of the Apsara File Storage NAS (NAS) file system in the virtual private cloud (VPC) where the job template is deployed. If you do not need to modify the NAS configurations when you deploy the job template, configure the <b>MountHost</b> parameter only in the first request. You do not need to include this parameter in subsequent requests. If you no longer need to use NAS, leave the <b>MountHost</b> parameter empty in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The configurations for mounting the NAS file system.</para>
            /// 
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

            /// <summary>
            /// <para>The AccessKey ID that is used to read data from and write data to Object Storage Service (OSS).</para>
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
            /// <para>The description of mounted OSS buckets.</para>
            /// </summary>
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeJobResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// <para>The name of the bucket.</para>
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
                /// <para>Indicates whether the job template can use the container directory to read data from or write data to resources in the directory of the OSS bucket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The job template has the read-only permissions.</description></item>
                /// <item><description><b>false</b>: The job template has the read and write permissions.</description></item>
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
            /// <item><description><para>If you deploy a Java job template, you can set this parameter to <b>FatJar</b>, <b>War</b>, or <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>If you deploy a PHP job template, the following types are available:</para>
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
            /// <item><description><para>If you deploy a Python job template, you can set this parameter to <b>PythonZip</b> or <b>Image</b>.</para>
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
            /// <para>The URL of the deployment package. This parameter is returned only if <b>PackageType</b> is set to <b>FatJar</b> or <b>War</b>.</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the deployment package. This parameter is required only if <b>PackageType</b> is set to <b>FatJar</b> or <b>War</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
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
            /// <para>The path on which the PHP configuration file for job startup is mounted. Make sure that the PHP server uses this configuration file during the startup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/etc/php/php.ini</para>
            /// </summary>
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }

            /// <summary>
            /// <para>The script that is run immediately after the container is started. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The script that is run before the container is stopped. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The programming language in which the job template is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>java</b>: Java</description></item>
            /// <item><description><b>php</b>: PHP</description></item>
            /// <item><description><b>python</b>: Python</description></item>
            /// <item><description><b>other</b>: other programming languages, such as C++, Go, .NET, and Node.js</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <para>The Internet request URLs of one-time jobs.</para>
            /// </summary>
            [NameInMap("PublicWebHookUrls")]
            [Validation(Required=false)]
            public List<string> PublicWebHookUrls { get; set; }

            /// <summary>
            /// <para>The Python environment. PYTHON 3.9.15 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON 3.9.15</para>
            /// </summary>
            [NameInMap("Python")]
            [Validation(Required=false)]
            public string Python { get; set; }

            /// <summary>
            /// <para>The configurations for installing custom module dependencies. By default, the dependencies defined by the requirements.txt file in the root directory are installed. If no software package is configured, you can specify dependencies based on your business requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Flask==2.0</para>
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// <para>The ID of the job template that you reference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("RefAppId")]
            [Validation(Required=false)]
            public string RefAppId { get; set; }

            /// <summary>
            /// <para>The IDs of the referenced job templates.</para>
            /// </summary>
            [NameInMap("RefedAppIds")]
            [Validation(Required=false)]
            public List<string> RefedAppIds { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of job instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>Indicates whether job sharding is enabled.</para>
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
            /// <para>SliceEnvs</para>
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
            /// <para>Parameter description:</para>
            /// <list type="bullet">
            /// <item><description><b>projectName</b>: the name of the Log Service project.</description></item>
            /// <item><description><b>logDir</b>: the path in which logs are stored.</description></item>
            /// <item><description><b>logType</b>: the log type. <b>stdout</b>: the standard output (stdout) log of the container. Only one stdout value for this parameter can be specified. If this parameter is not configured, file logs are collected.</description></item>
            /// <item><description><b>logstoreName</b>: the name of the Logstore in Log Service.</description></item>
            /// <item><description><b>logtailName</b>: the name of the Logtail in Log Service. If this parameter is not configured, a new Logtail is created.</description></item>
            /// </list>
            /// <para>If you do not need to modify the logging configurations when you deploy the application, configure <b>SlsConfigs</b> only in the first request. If you no longer need to use Log Service, leave <b>SlsConfigs</b> empty in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>Indicates whether the job template is suspended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Suspend")]
            [Validation(Required=false)]
            public bool? Suspend { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataTags> Tags { get; set; }
            public class DescribeJobResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <para>The timeout period of the job. Unit: seconds.</para>
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
            /// <para>The Tomcat configuration. If you want to delete the configuration, set this parameter to {} or leave this parameter empty. Parameter description:</para>
            /// <list type="bullet">
            /// <item><description><b>port</b>: the port number. Valid values: 1024 to 65535. The root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If this parameter is not configured, the default value 8080 is used.</description></item>
            /// <item><description><b>contextPath</b>: the path. Default value: /. The value indicates the root directory.</description></item>
            /// <item><description><b>maxThreads</b>: the maximum number of connections in the connection pool. Default value: 400.</description></item>
            /// <item><description><b>uriEncoding</b>: the URI encoding scheme in the Tomcat container. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If this parameter is not configured, the default value <b>ISO-8859-1</b> is used.</description></item>
            /// <item><description><b>useBodyEncoding</b>: indicates whether to use the encoding scheme that is specified by <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</description></item>
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
            /// <para>The vSwitch ID.</para>
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
            /// <para>The internal request URLs for one-time jobs.</para>
            /// </summary>
            [NameInMap("VpcWebHookUrls")]
            [Validation(Required=false)]
            public List<string> VpcWebHookUrls { get; set; }

            /// <summary>
            /// <para>The option settings in the WAR package. The settings are used to start the job. The default startup command is <c>java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap &quot;$@&quot; start</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-option</para>
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// <para>The version of the Tomcat container on which the deployment package depends. The following versions are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>apache-tomcat-7.0.91</b></description></item>
            /// <item><description><b>apache-tomcat-8.5.42</b></description></item>
            /// </list>
            /// <para>This parameter is not returned if <b>PackageType</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apache-tomcat-7.0.91</para>
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// <para>The error code returned. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the call fails, <b>ErrorCode</b> is returned. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the configurations of the job template were obtained. Valid values:</para>
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
