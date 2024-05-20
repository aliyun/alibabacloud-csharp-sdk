// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyData Data { get; set; }
        public class DescribeJobResponseBodyData : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is used to pull images across accounts. For more information, see [Pull images across Alibaba Cloud accounts](https://help.aliyun.com/document_detail/190675.html) and [Grant permissions across Alibaba Cloud accounts by using a RAM role](https://help.aliyun.com/document_detail/223585.html).
            /// </summary>
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }

            /// <summary>
            /// The ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("AcrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The number of times that the job was retried.
            /// </summary>
            [NameInMap("BackoffLimit")]
            [Validation(Required=false)]
            public long? BackoffLimit { get; set; }

            /// <summary>
            /// The command that is used to start the image. The command must be an existing executable object in the container. Example:
            /// 
            ///     command:
            ///           - echo
            ///           - abc
            ///           - >
            ///           - file0
            /// 
            /// In this example, the Command parameter is set to `Command="echo", CommandArgs=["abc", ">", "file0"]`.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// The arguments of the image startup command. This parameter contains the arguments that are required for **Command**. Format:
            /// 
            /// `["a","b"]`
            /// 
            /// In the preceding **Command** example, the CommandArgs parameter is set to `CommandArgs=["abc", ">", "file0"]`. The data type of `["abc", ">", "file0"]` must be an array of strings in the JSON format. If this parameter does not exist in the Command parameter, you do not need to configure it.
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// The concurrency policy of the job. Valid values:
            /// 
            /// *   **Forbid**: Concurrent running is prohibited. If the previous job is not completed, no new job is created.
            /// *   **Allow**: Concurrent running is allowed.
            /// *   **Replace**: If the previous job is not completed when the time to create a new job is reached, the new job replaces the previous job.
            /// </summary>
            [NameInMap("ConcurrencyPolicy")]
            [Validation(Required=false)]
            public string ConcurrencyPolicy { get; set; }

            /// <summary>
            /// The details of the ConfigMap.
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeJobResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// The ConfigMap ID.
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// The ConfigMap name.
                /// </summary>
                [NameInMap("ConfigMapName")]
                [Validation(Required=false)]
                public string ConfigMapName { get; set; }

                /// <summary>
                /// The key-value pair that is stored in the ConfigMap.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The path on which the NAS file system is mounted.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// The CPU specifications required for each instance. Unit: millicore. This parameter cannot be set to 0. Valid values:
            /// 
            /// *   **500**
            /// *   **1000**
            /// *   **2000**
            /// *   **4000**
            /// *   **8000**
            /// *   **16000**
            /// *   **32000**
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The custom mapping between the hostname and IP address in the container. Valid values:
            /// 
            /// *   **hostName**: the domain name or hostname.
            /// *   **ip**: the IP address.
            /// </summary>
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }

            /// <summary>
            /// The version of the container, such as Ali-Tomcat, in which an application developed based on High-speed Service Framework (HSF) is deployed.
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// The environment variables. You can configure custom environment variables or reference a ConfigMap. If you want to reference a ConfigMap, you must first create a ConfigMap. For more information, see [CreateConfigMap](https://help.aliyun.com/document_detail/176914.html). Valid values:
            /// 
            /// *   Custom configuration
            /// 
            ///     *   **name**: the name of the environment variable.
            ///     *   **value**: the value of the environment variable.
            /// 
            /// *   Reference a ConfigMap
            /// 
            ///     *   **name**: the name of the environment variable. You can reference one or all keys. To reference all keys, specify `sae-sys-configmap-all-<ConfigMap name>`. Example: `sae-sys-configmap-all-test1`.
            ///     *   **valueFrom**: the reference of the environment variable. Set the value to `configMapRef`.
            ///     *   **configMapId**: the ID of the ConfigMap.
            ///     *   **key**: the key. If you want to reference all keys, you do not need to configure this parameter.
            /// </summary>
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }

            /// <summary>
            /// The ID of the corresponding secret.
            /// </summary>
            [NameInMap("ImagePullSecrets")]
            [Validation(Required=false)]
            public string ImagePullSecrets { get; set; }

            /// <summary>
            /// The URL of the image. This parameter is returned only if **PackageType** is set to **Image**.
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// The arguments in the JAR package. The arguments are used to start the application container. The default startup command is `$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS "$package_path" $JarStartArgs`.
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// The option settings in the JAR package. The settings are used to start the application container. The default startup command is `$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS "$package_path" $JarStartArgs`.
            /// </summary>
            [NameInMap("JarStartOptions")]
            [Validation(Required=false)]
            public string JarStartOptions { get; set; }

            /// <summary>
            /// The version of the Java Development Kit (JDK) on which the deployment package of the application depends. The following versions are supported:
            /// 
            /// *   **Open JDK 8**
            /// *   **Open JDK 7**
            /// *   **Dragonwell 11**
            /// *   **Dragonwell 8**
            /// *   **openjdk-8u191-jdk-alpine3.9**
            /// *   **openjdk-7u201-jdk-alpine3.9**
            /// 
            /// This parameter is not returned if **PackageType** is set to **Image**.
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// The size of memory that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:
            /// 
            /// *   This parameter is set to **1024** if the Cpu parameter is set to 500 or 1000.
            /// *   This parameter is set to **2048** if the Cpu parameter is set to 500, 1000, or 2000.
            /// *   This parameter is set to **4096** if the Cpu parameter is set to 1000, 2000, or 4000.
            /// *   This parameter is set to **8192** if the Cpu parameter is set to 2000, 4000, or 8000.
            /// *   This parameter is set to **12288** if the Cpu parameter is set to 12000.
            /// *   This parameter is set to **16384** if the Cpu parameter is set to 4000, 8000, or 16000.
            /// *   This parameter is set to **24567** if the Cpu parameter is set to 12000.
            /// *   This parameter is set to **32768** if the Cpu parameter is set to 16000.
            /// *   This parameter is set to **65536** if the Cpu parameter is set to 8000, 16000, or 32000.
            /// *   This parameter is set to **131072** if the Cpu parameter is set to 32000.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The details of the mounted NAS file system.
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeJobResponseBodyDataMountDesc : TeaModel {
                /// <summary>
                /// The path on which the NAS file system is mounted.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The directory in the NAS file system.
                /// </summary>
                [NameInMap("NasPath")]
                [Validation(Required=false)]
                public string NasPath { get; set; }

            }

            /// <summary>
            /// The mount target of the NAS file system in the VPC in which the application is deployed. If you do not need to modify this configuration during the deployment, configure **MountHost** only in the first request. If you need to remove this configuration, leave **MountHost** empty in the request.
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// The namespace ID.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The configurations for mounting the NAS file system.
            /// </summary>
            [NameInMap("NasConfigs")]
            [Validation(Required=false)]
            public string NasConfigs { get; set; }

            /// <summary>
            /// The ID of the NAS file system.
            /// </summary>
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }

            /// <summary>
            /// The AccessKey ID that is used to read data from and write data to Object Storage Service (OSS).
            /// </summary>
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }

            /// <summary>
            /// The AccessKey secret that is used to read data from and write data to OSS.
            /// </summary>
            [NameInMap("OssAkSecret")]
            [Validation(Required=false)]
            public string OssAkSecret { get; set; }

            /// <summary>
            /// The description of mounted OSS buckets.
            /// </summary>
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeJobResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// The bucket name.
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// The directory or object in OSS. If the specified directory or object does not exist, an error is returned.
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// The path of the container in SAE. The parameter value that you specified overwrites the original value. If the specified path does not exist, SAE automatically creates the path.
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// Indicates whether the application can use the container path to read data from or write data to resources in the directory of the OSS bucket. Valid values:
                /// 
                /// *   **true**: The application has the read-only permission.
                /// *   **false**: The application has read and write permissions.
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// The type of the deployment package. Valid values:
            /// 
            /// *   If you deploy the application by using a Java Archive (JAR) package, this parameter is set to **FatJar**, **War**, or **Image**.
            /// 
            /// *   If you deploy the application by using a PHP package, this parameter is set to one of the following values:
            /// 
            ///     *   **PhpZip**
            ///     *   **IMAGE_PHP_5_4**
            ///     *   **IMAGE_PHP_5_4_ALPINE**
            ///     *   **IMAGE_PHP_5_5**
            ///     *   **IMAGE_PHP_5_5_ALPINE**
            ///     *   **IMAGE_PHP_5_6**
            ///     *   **IMAGE_PHP_5_6_ALPINE**
            ///     *   **IMAGE_PHP_7_0**
            ///     *   **IMAGE_PHP_7_0_ALPINE**
            ///     *   **IMAGE_PHP_7_1**
            ///     *   **IMAGE_PHP_7_1_ALPINE**
            ///     *   **IMAGE_PHP_7_2**
            ///     *   **IMAGE_PHP_7_2_ALPINE**
            ///     *   **IMAGE_PHP_7_3**
            ///     *   **IMAGE_PHP_7_3_ALPINE**
            /// 
            /// *   If you deploy the application by using a Pythhon package, this parameter is set to **PythonZip** or **Image**.
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// The URL of the deployment package. This parameter is returned only if **PackageType** is set to **FatJar** or **War**.
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// The version of the deployment package. This parameter is required only if **PackageType** is set to **FatJar** or **War**.
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// The details of the PHP configuration file.
            /// </summary>
            [NameInMap("PhpConfig")]
            [Validation(Required=false)]
            public string PhpConfig { get; set; }

            /// <summary>
            /// The path on which the PHP configuration file for application startup is mounted. Make sure that the PHP server uses this configuration file during the startup.
            /// </summary>
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }

            /// <summary>
            /// The script that is run immediately after the container is started. Example: `{"exec":{"command":["cat","/etc/group"\\]}}`
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// The script that is run before the container is stopped. Example: `{"exec":{"command":["cat","/etc/group"\\]}}`
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// The programming language that is used to create the application. Valid values:
            /// 
            /// *   **java**: Java
            /// *   **php**: PHP
            /// *   **python**: Python
            /// *   **other**: other programming languages, such as C++, Go, .NET, and Node.js.
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// The Internet request URLs of one-time jobs.
            /// </summary>
            [NameInMap("PublicWebHookUrls")]
            [Validation(Required=false)]
            public List<string> PublicWebHookUrls { get; set; }

            /// <summary>
            /// The Python environment. PYTHON 3.9.15 is supported.
            /// </summary>
            [NameInMap("Python")]
            [Validation(Required=false)]
            public string Python { get; set; }

            /// <summary>
            /// The configurations for installing custom module dependencies. By default, the dependencies defined by the requirements.txt file in the root directory are installed. If no software package is configured, you can specify dependencies based on your business requirements.
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// The ID of the job template that you reference.
            /// </summary>
            [NameInMap("RefAppId")]
            [Validation(Required=false)]
            public string RefAppId { get; set; }

            /// <summary>
            /// The IDs of the referenced job templates.
            /// </summary>
            [NameInMap("RefedAppIds")]
            [Validation(Required=false)]
            public List<string> RefedAppIds { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of application instances.
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// Indicates whether job sharding is enabled.
            /// </summary>
            [NameInMap("Slice")]
            [Validation(Required=false)]
            public bool? Slice { get; set; }

            /// <summary>
            /// The parameters of job sharding.
            /// </summary>
            [NameInMap("SliceEnvs")]
            [Validation(Required=false)]
            public string SliceEnvs { get; set; }

            /// <summary>
            /// The logging configurations of Log Service.
            /// 
            /// *   To use Log Service resources that are automatically created by SAE, set this parameter to `[{"logDir":"","logType":"stdout"},{"logDir":"/tmp/a.log"}]`.
            /// *   To use custom Log Service resources, set this parameter to `[{"projectName":"test-sls","logType":"stdout","logDir":"","logstoreName":"sae","logtailName":""},{"projectName":"test","logDir":"/tmp/a.log","logstoreName":"sae","logtailName":""}]`.
            /// 
            /// Parameter description:
            /// 
            /// *   **projectName**: the name of the Log Service project.
            /// *   **logDir**: the path in which logs are stored.
            /// *   **logType**: the log type. **stdout**: the standard output (stdout) log of the container. Only one stdout value for this parameter can be specified. If this parameter is not configured, file logs are collected.
            /// *   **logstoreName**: the name of the Logstore in Log Service.
            /// *   **logtailName**: the name of the Logtail in Log Service. If this parameter is not configured, a new Logtail is created.
            /// 
            /// If you do not need to modify the logging configurations when you deploy the application, configure **SlsConfigs** only in the first request. If you no longer need to use Log Service, leave **SlsConfigs** empty in the request.
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// Indicates whether the job template is suspended.
            /// </summary>
            [NameInMap("Suspend")]
            [Validation(Required=false)]
            public bool? Suspend { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyDataTags> Tags { get; set; }
            public class DescribeJobResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The timeout period for a graceful shutdown. Default value: 30. Unit: seconds. Valid values: 1 to 300.
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// The timeout period for the job. Unit: seconds.
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// The time zone. Default value: **Asia/Shanghai**.
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// The Tomcat configuration. If you want to delete the configuration, set this parameter to {} or leave this parameter empty. Parameter description:
            /// 
            /// *   **port**: the port number. Valid values: 1024 to 65535. The root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If this parameter is not configured, the default value 8080 is used.
            /// *   **contextPath**: the path. Default value: /. The value indicates the root directory.
            /// *   **maxThreads**: the maximum number of connections in the connection pool. Default value: 400.
            /// *   **uriEncoding**: the URI encoding scheme in the Tomcat container. Valid values: **UTF-8**, **ISO-8859-1**, **GBK**, and **GB2312**. If this parameter is not configured, the default value **ISO-8859-1** is used.
            /// *   **useBodyEncoding**: indicates whether to use the encoding scheme that is specified by **BodyEncoding for URL**. Default value: **true**.
            /// </summary>
            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public string TomcatConfig { get; set; }

            [NameInMap("TriggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The internal request URLs for one-time jobs.
            /// </summary>
            [NameInMap("VpcWebHookUrls")]
            [Validation(Required=false)]
            public List<string> VpcWebHookUrls { get; set; }

            /// <summary>
            /// The option settings in the WAR package. The settings are used to start the application container. The default startup command is `java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap "$@" start`.
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// The version of the Tomcat container on which the deployment package depends. The following versions are supported:
            /// 
            /// *   **apache-tomcat-7.0.91**
            /// *   **apache-tomcat-8.5.42**
            /// 
            /// This parameter is not returned if **PackageType** is set to **Image**.
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, **ErrorCode** is not returned.
        /// *   If the call fails, **ErrorCode** is returned. For more information, see the "**Error codes**" section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the configurations of an application were obtained. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
