// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The job template information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyData Data { get; set; }
        public class DescribeJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ARN of the RAM role that is required to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/190675.html">Pull images across Alibaba Cloud accounts</a> and <a href="https://help.aliyun.com/document_detail/223585.html">Grant permissions across Alibaba Cloud accounts by using a RAM role</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/adminrole</para>
            /// </summary>
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry (ACR) Enterprise Edition instance.</para>
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
            /// <para>The maximum number of retries for a failed job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BackoffLimit")]
            [Validation(Required=false)]
            public long? BackoffLimit { get; set; }

            /// <summary>
            /// <para>The Best-Effort policy.</para>
            /// </summary>
            [NameInMap("BestEffortType")]
            [Validation(Required=false)]
            public string BestEffortType { get; set; }

            /// <summary>
            /// <para>The image startup command. The command must be an executable that exists in the container. Example:</para>
            /// <pre><c>command:
            ///       - echo
            ///       - abc
            ///       - &gt;
            ///       - file0
            /// </c></pre>
            /// <para>In this example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The arguments of the image startup command. The arguments are passed to the <b>Command</b> parameter. Format:</para>
            /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
            /// <para>In the example of the <b>Command</b> parameter, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. In this case, <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to a string in the format of a JSON array. If this parameter is not specified, you do not need to configure it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// <para>The concurrency policy for the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Forbid</b>: Forbids concurrent runs. A new job is not created if the previous one has not completed.</para>
            /// </description></item>
            /// <item><description><para><b>Allow</b>: Allows concurrent runs.</para>
            /// </description></item>
            /// <item><description><para><b>Replace</b>: If the previous job has not completed, the new job replaces it.</para>
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
            /// <para>The information about the mounted ConfigMap.</para>
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
                /// <para>The name of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConfigMapName")]
                [Validation(Required=false)]
                public string ConfigMapName { get; set; }

                /// <summary>
                /// <para>The key of the key-value pair in the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The container mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// <para>The number of CPU cores that are required by each instance. Unit: millicores. This parameter cannot be set to 0. Only the following fixed specifications are supported:</para>
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
            /// <para>The custom host mapping in the container. The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>hostName</b>: The domain name or hostname.</para>
            /// </description></item>
            /// <item><description><para><b>ip</b>: The IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;hostName&quot;:&quot;test.host.name&quot;,&quot;ip&quot;:&quot;0.0.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }

            /// <summary>
            /// <para>The version of the runtime environment in the HSF framework, such as an Ali-Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The container environment variables. You can define custom variables or reference a ConfigMap. To reference a ConfigMap, you must first create a ConfigMap. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Define custom variables</para>
            /// <list type="bullet">
            /// <item><description><para><b>name</b>: The name of the environment variable.</para>
            /// </description></item>
            /// <item><description><para><b>value</b>: The value of the environment variable.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Reference a ConfigMap</para>
            /// <list type="bullet">
            /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, for example, <c>sae-sys-configmap-all-test1</c>.</para>
            /// </description></item>
            /// <item><description><para><b>valueFrom</b>: The source of the environment variable. Set the value to <c>configMapRef</c>.</para>
            /// </description></item>
            /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
            /// </description></item>
            /// <item><description><para><b>key</b>: The key of the key-value pair. If you reference all keys in the ConfigMap, you do not need to specify this parameter.</para>
            /// </description></item>
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
            /// <para>The ID of the Secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ImagePullSecrets")]
            [Validation(Required=false)]
            public string ImagePullSecrets { get; set; }

            /// <summary>
            /// <para>The image URL. This parameter is required if <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker.io/library/nginx:1.14.2</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The arguments for the startup of a JAR package. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// <para>The options for the startup of a JAR package. The default startup command is <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-Dtest=true</para>
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
            /// <para>This parameter is not applicable if <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <para>The memory required by each instance, in MB. This value cannot be 0. CPU and memory resources are allocated in fixed ratios. The following combinations are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1024</b>: corresponds to 500 millicores and 1,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>2048</b>: corresponds to 500, 1,000, and 2,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>4096</b>: corresponds to 1,000, 2,000, and 4,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>8192</b>: corresponds to 2,000, 4,000, and 8,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>12288</b>: corresponds to 12,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>16384</b>: corresponds to 4,000, 8,000, and 16,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>24576</b>: corresponds to 12,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>32768</b>: corresponds to 16,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>65536</b>: corresponds to 8,000, 16,000, and 32,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>131072</b>: corresponds to 32,000 millicores.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The mount description.</para>
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeJobResponseBodyDataMountDesc : TeaModel {
                /// <summary>
                /// <para>The container mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The directory in the Apsara File Storage NAS file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("NasPath")]
                [Validation(Required=false)]
                public string NasPath { get; set; }

            }

            /// <summary>
            /// <para>The mount target of the Apsara File Storage NAS file system in the job template\&quot;s VPC. You can omit this parameter if the NAS configuration is unchanged during redeployment. To clear the NAS configuration, set this parameter to an empty string (<c>&quot;&quot;</c>).</para>
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
            /// <para>The configuration for mounting an Apsara File Storage NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
            /// </summary>
            [NameInMap("NasConfigs")]
            [Validation(Required=false)]
            public string NasConfigs { get; set; }

            /// <summary>
            /// <para>The ID of the Apsara File Storage NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKSN89**</para>
            /// </summary>
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }

            /// <summary>
            /// <para>The AccessKey ID for accessing Object Storage Service (OSS) buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret for accessing OSS buckets.</para>
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
            public List<DescribeJobResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeJobResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The directory or object that you created in the OSS bucket. An exception is returned if the specified mount directory does not exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data/user.data</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <para>The path in your SAE container. If the path exists, it is overwritten. If the path does not exist, a new path is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/data/user.data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>Specifies whether the container has read-only access to the mounted resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The path has read-only permissions.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The path has read and write permissions.</para>
                /// </description></item>
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
            /// <para>The type of the job package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For Java deployments, <b>FatJar</b>, <b>War</b>, and <b>Image</b> are supported.</para>
            /// </description></item>
            /// <item><description><para>For PHP deployments, the following package types are supported:</para>
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
            /// <item><description><para>For Python deployments, <b>PythonZip</b> and <b>Image</b> are supported.</para>
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
            /// <para>The URL of the package. This parameter is required if <b>Package Type</b> is set to <b>FatJar</b> or <b>War</b>.</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the package. This parameter is required if <b>Package Type</b> is set to <b>FatJar</b> or <b>War</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
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
            /// <para>The mount path of the PHP job startup configuration. Make sure that the PHP server uses this configuration to start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/etc/php/php.ini</para>
            /// </summary>
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }

            /// <summary>
            /// <para>The script to execute after the container starts. This script runs immediately after the system creates the container. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The script to execute before the container stops. This script runs before the system deletes the container. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The programming language that is used for the job template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>java</b>: Java</para>
            /// </description></item>
            /// <item><description><para><b>php</b>: PHP</para>
            /// </description></item>
            /// <item><description><para><b>python</b>: Python</para>
            /// </description></item>
            /// <item><description><para><b>other</b>: Other languages, such as C++, Go, .NET, and Node.js.</para>
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
            /// <para>The list of public request URLs for the one-time task.</para>
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
            /// <para>The Python module dependencies to install. By default, SAE installs dependencies from a <c>requirements.txt</c> file in the package\&quot;s root directory. Use this parameter to specify dependencies if a <c>requirements.txt</c> file is not present or to add extra modules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Flask==2.0</para>
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// <para>The ID of the referenced job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("RefAppId")]
            [Validation(Required=false)]
            public string RefAppId { get; set; }

            /// <summary>
            /// <para>The IDs of job templates that reference this template.</para>
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
            /// <para>The security group ID.</para>
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
            /// <para>The parameters for job sharding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SliceEnvs</para>
            /// </summary>
            [NameInMap("SliceEnvs")]
            [Validation(Required=false)]
            public string SliceEnvs { get; set; }

            /// <summary>
            /// <para>The configuration for collecting logs to Log Service (SLS).</para>
            /// <list type="bullet">
            /// <item><description><para>Use an SLS resource that SAE automatically creates: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
            /// </description></item>
            /// <item><description><para>Use a custom SLS resource: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>projectName</b>: The name of the SLS project.</para>
            /// </description></item>
            /// <item><description><para><b>logDir</b>: The log path.</para>
            /// </description></item>
            /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> specifies the container\&quot;s standard output logs. You can specify only one log of the stdout type. If this parameter is omitted, file logs are collected.</para>
            /// </description></item>
            /// <item><description><para><b>logstoreName</b>: The name of the Logstore in SLS.</para>
            /// </description></item>
            /// <item><description><para><b>logtailName</b>: The name of the Logtail configuration in SLS. If you do not specify this parameter, a new Logtail configuration is created.</para>
            /// </description></item>
            /// </list>
            /// <para>You can omit this parameter if the Log Service configuration is unchanged during redeployment. To disable log collection, set this parameter to an empty string (<c>&quot;&quot;</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>Specifies whether to suspend the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Suspend")]
            [Validation(Required=false)]
            public bool? Suspend { get; set; }

            /// <summary>
            /// <para>The tags of the job template.</para>
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
            /// <para>The timeout for a graceful stop, in seconds. Default: 30. Valid values: 1 to 300.</para>
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
            /// <para>The Tomcat file configuration. To delete the configuration, set this parameter to &quot;&quot; or &quot;{}&quot;.</para>
            /// <list type="bullet">
            /// <item><description><para><b>port</b>: The port number. Valid values: 1024 to 65535. Ports below 1024 are reserved. If you do not specify a port, the default value is 8080.</para>
            /// </description></item>
            /// <item><description><para><b>contextPath</b>: The access path. Default value: /.</para>
            /// </description></item>
            /// <item><description><para><b>maxThreads</b>: The maximum number of connections in the connection pool. Default value: 400.</para>
            /// </description></item>
            /// <item><description><para><b>uriEncoding</b>: The URI encoding scheme for Tomcat. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If you do not specify this parameter, the default value <b>ISO-8859-1</b> is used.</para>
            /// </description></item>
            /// <item><description><para><b>useBodyEncodingForUri</b>: Specifies whether to use the character encoding from the request body for the URI. Default value: <b>true</b>.</para>
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
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The list of private request URLs for the one-time task.</para>
            /// </summary>
            [NameInMap("VpcWebHookUrls")]
            [Validation(Required=false)]
            public List<string> VpcWebHookUrls { get; set; }

            /// <summary>
            /// <para>The options for the startup of a WAR package. The default startup command is <c>java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap &quot;$@&quot; start</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-option</para>
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// <para>The version of the Tomcat container on which the package depends. The following versions are supported:</para>
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

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>The <b>ErrorCode</b> parameter is returned only if the request fails.</para>
        /// </description></item>
        /// <item><description><para>For a list of possible <b>ErrorCode</b> values, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the call result.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
