// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigResponseBody : TeaModel {
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
        public DescribeApplicationConfigResponseBodyData Data { get; set; }
        public class DescribeApplicationConfigResponseBodyData : TeaModel {
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
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The SAE application type.
            /// </summary>
            [NameInMap("AppSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            /// <summary>
            /// Indicates whether an elastic IP address (EIP) is associated with the application instance. Valid values:
            /// 
            /// *   **true**: The EIP is associated with the application instance.
            /// *   **false**: The EIP is not associated with the application instance.
            /// </summary>
            [NameInMap("AssociateEip")]
            [Validation(Required=false)]
            public bool? AssociateEip { get; set; }

            /// <summary>
            /// The interval between batches in a phased release. Unit: seconds.
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            /// <summary>
            /// The command that is used to start the image. The command must be an existing executable object in the container. Example:
            /// 
            /// ```
            /// 
            /// command:
            ///       - echo
            ///       - abc
            ///       - >
            ///       - file0
            /// ```
            /// 
            /// In this example, the Command parameter is set to `Command="echo", CommandArgs=["abc", ">", "file0"]`.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// The parameters of the image startup command. The CommandArgs parameter contains the parameters that are required for the **Command** parameter. Format:
            /// 
            /// `["a","b"]`
            /// 
            /// In the preceding **Command** example, the CommandArgs parameter is set to `CommandArgs=["abc", ">", "file0"]`. The data type of `["abc", ">", "file0"]` must be an array of strings in the JSON format. You do not need to configure this parameter if it does not exist in the Command parameter.
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// The details of the ConfigMap.
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// The ID of the ConfigMap.
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// The name of the ConfigMap.
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
                /// The path on which the ConfigMap is mounted.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// The CPU specifications that are required for each instance. Unit: millicores. You cannot set this parameter to 0. Valid values:
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
            /// The custom mappings between hostnames and IP addresses in the container. Valid values:
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
            /// Indicates whether access to Application High Availability Service (AHAS) is enabled. Valid values:
            /// 
            /// *   **true**: Access to AHAS is enabled.
            /// *   **false**: Access to AHAS is disabled.
            /// </summary>
            [NameInMap("EnableAhas")]
            [Validation(Required=false)]
            public string EnableAhas { get; set; }

            /// <summary>
            /// Indicates whether canary release rules are enabled. Canary release rules apply only to applications in Spring Cloud and Dubbo frameworks. Valid values:
            /// 
            /// *   **true**: The canary release rules are enabled.
            /// *   **false**: The canary release rules are disabled.
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
            /// The environment variables. Variable description:
            /// 
            /// *   **name**: the name of the environment variable.
            /// *   **value**: the value or reference of the environment variable.
            /// </summary>
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }

            [NameInMap("ImagePullSecrets")]
            [Validation(Required=false)]
            public string ImagePullSecrets { get; set; }

            /// <summary>
            /// The URL of the image. This parameter is returned only if the **PackageType** parameter is set to **Image**.
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
            /// The version of the Java development kit (JDK) on which the deployment package of the application depends. The following versions are supported:
            /// 
            /// *   **Open JDK 8**
            /// *   **Open JDK 7**
            /// *   **Dragonwell 11**
            /// *   **Dragonwell 8**
            /// *   **openjdk-8u191-jdk-alpine3.9**
            /// *   **openjdk-7u201-jdk-alpine3.9**
            /// 
            /// This parameter is not returned if the **PackageType** parameter is set to **Image**.
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// The logging configurations of Message Queue for Apache Kafka. The following parameters are involved:
            /// 
            /// *   **KafkaConfigs**: the configurations of Message Queue for Apache Kafka.
            /// 
            /// *   **createTime**: the time when the Message Queue for Apache Kafka instance was created.
            /// 
            /// *   **kafkaTopic**: the message topic that is used to classify messages.
            /// 
            /// *   **logDir**: the path in which logs are stored.
            /// 
            /// *   **logType**: the type of collected logs. Valid values:
            /// 
            ///     *   **file_log**: the file log that is stored in the container. The path of the file logs in the container is returned.
            ///     *   **stdout**: the standard output log of the container. You can specify only one stdout value.
            /// 
            /// *   **kafkaEndpoint**: the endpoint of the Message Queue for Apache Kafka service.
            /// 
            /// *   **kafkaInstanceId**: the ID of the Message Queue for Apache Kafka instance.
            /// 
            /// *   **region**: the region where the Message Queue for Apache Kafka instance resides.
            /// </summary>
            [NameInMap("KafkaConfigs")]
            [Validation(Required=false)]
            public string KafkaConfigs { get; set; }

            /// <summary>
            /// The details of the availability check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. You can use one of the following methods to perform the health check:
            /// 
            /// *   Sample code of the **exec** method: `{"exec":{"command":["sh","-c","cat/home/admin/start.sh"]},"initialDelaySeconds":30,"periodSeconds":30,"timeoutSeconds":2}`
            /// *   Sample code of the **httpGet** method: `{"httpGet":{"path":"/","port":18091,"scheme":"HTTP","isContainKeyWord":true,"keyWord":"SAE"},"initialDelaySeconds":11,"periodSeconds":10,"timeoutSeconds":1}`
            /// *   Sample code of the **tcpSocket** method: `{"tcpSocket":{"port":18091},"initialDelaySeconds":11,"periodSeconds":10,"timeoutSeconds":1}`
            /// 
            /// >  You can use only one method to perform the health check.
            /// 
            /// The following parameters are involved:
            /// 
            /// *   **exec.command**: the health check command.
            /// *   **httpGet.path**: the request path.
            /// *   **httpGet.scheme**: the protocol that is used to perform the health check. Valid values: **HTTP** and **HTTPS**.
            /// *   **httpGet.isContainKeyWord**: indicates whether the response contains keywords. Valid values: **true** and **false**. If this field is not returned, the advanced settings are not used.
            /// *   **httpGet.keyWord**: the custom keyword. This parameter is available only if the **isContainKeyWord** field is returned.
            /// *   **tcpSocket.port**: the port that is used to check the status of TCP connections.
            /// *   **initialDelaySeconds**: the delay of the health check. Default value: 10. Unit: seconds.
            /// *   **periodSeconds**: the interval at which health checks are performed. Default value: 30. Unit: seconds.
            /// *   **timeoutSeconds**: the timeout period of the health check. Default value: 1. Unit: seconds. If you set this parameter to 0 or leave this parameter empty, the timeout period is automatically set to 1 second.
            /// </summary>
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }

            /// <summary>
            /// The size of memory required by each instance. Unit: MB. You cannot set this parameter to 0. The values of this parameter correspond to the values of the Cpu parameter:
            /// 
            /// *   This parameter is set to **1024** if the Cpu parameter is set to 500 or 1000.
            /// *   This parameter is set to **2048** if the Cpu parameter is set to 500, 1000, or 1000.
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

            [NameInMap("MicroRegistration")]
            [Validation(Required=false)]
            public string MicroRegistration { get; set; }

            [NameInMap("MicroRegistrationConfig")]
            [Validation(Required=false)]
            public string MicroRegistrationConfig { get; set; }

            /// <summary>
            /// The percentage of the minimum number of available instances. Valid values:
            /// 
            /// *   **-1**: the default value. This value indicates that the minimum number of available instances is not measured by percentage. If you do not configure this parameter, the default value **-1** is used.
            /// *   **0 to 100**: indicates that the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). If the calculated result is not an integer, the result is rounded up to the nearest integer. For example, if the percentage is set to **50**% and five instances are available, the minimum number of available instances is 3.
            /// 
            /// >  If the **MinReadyInstance** and **MinReadyInstanceRatio** parameters are returned and the value of the **MinReadyInstanceRatio** parameter is not **-1**, the value of the **MinReadyInstanceRatio** parameter takes effect. If the **MinReadyInstances** parameter is set to **5** and the **MinReadyInstanceRatio** parameter is set to **50**, the value of the **MinReadyInstanceRatio** parameter determines the minimum number of available instances.
            /// </summary>
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            /// <summary>
            /// The minimum number of available instances. Valid values:
            /// 
            /// *   If you set the value to **0**, business interruptions occur when the application is updated.
            /// *   If you set the value to **-1**, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.
            /// 
            /// >  Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// The details of the mounted NAS file system.
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataMountDesc : TeaModel {
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
            /// The mount target of the NAS file system in the VPC where the application is deployed. If you do not need to modify this configuration during the deployment, configure the **MountHost** parameter only in the first request. You do not need to include this parameter in subsequent requests. If you need to remove this configuration, leave the **MountHost** parameter empty in the request.
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// The ID of the microservice application.
            /// </summary>
            [NameInMap("MseApplicationId")]
            [Validation(Required=false)]
            public string MseApplicationId { get; set; }

            [NameInMap("MseApplicationName")]
            [Validation(Required=false)]
            public string MseApplicationName { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

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
            /// The AccessKey ID that is used to read data from and write data to Object Storage Service (OSS) buckets.
            /// </summary>
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }

            /// <summary>
            /// The AccessKey secret that is used to read data from and write data to OSS buckets.
            /// </summary>
            [NameInMap("OssAkSecret")]
            [Validation(Required=false)]
            public string OssAkSecret { get; set; }

            /// <summary>
            /// The description of the mounted OSS bucket.
            /// </summary>
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeApplicationConfigResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// The name of the OSS bucket.
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
                /// *   **true**: The application has the read-only permissions.
                /// *   **false**: The application has the read and write permissions.
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// The type of the deployment package. Valid values:
            /// 
            /// *   If you deploy the application by using a Java Archive (JAR) package, you can set this parameter to **FatJar**, **War**, or **Image**.
            /// 
            /// *   If you deploy the application by using a PHP package, you can set this parameter to one of the following values:
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
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// The URL of the deployment package. This parameter is returned only if the **PackageType** parameter is set to **FatJar** or **War**.
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// The version of the deployment package. This parameter is returned only if the **PackageType** parameter is set to **FatJar** or **War**.
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            [NameInMap("Php")]
            [Validation(Required=false)]
            public string Php { get; set; }

            /// <summary>
            /// The path on which the PHP configuration file for application monitoring is mounted. Make sure that the PHP server loads the configuration file.
            /// 
            /// SAE automatically generates the corresponding configuration file. No manual operations are required.
            /// </summary>
            [NameInMap("PhpArmsConfigLocation")]
            [Validation(Required=false)]
            public string PhpArmsConfigLocation { get; set; }

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
            /// The script that is run immediately after the container is started. Example: `{"exec":{"command":["cat","/etc/group"]}}`
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// The script that is run before the container is stopped. Example: `{"exec":{"command":["cat","/etc/group"]}}`
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// The programming language that is used to create the application. Valid values:
            /// 
            /// *   **java**: Java
            /// *   **php**: PHP
            /// *   **other**: Other programming languages, such as Python, C++, Go, .NET, and Node.js.
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            [NameInMap("PvtzDiscovery")]
            [Validation(Required=false)]
            public string PvtzDiscovery { get; set; }

            [NameInMap("Python")]
            [Validation(Required=false)]
            public string Python { get; set; }

            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// The details of the health check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. Containers that fail health checks cannot receive traffic from Server Load Balancer (SLB) instances. You can use the **exec**, **httpGet**, or **tcpSocket** method to perform health checks. For more information, see the description of the **Liveness** parameter.
            /// 
            /// >  You can use only one method to perform the health check.
            /// </summary>
            [NameInMap("Readiness")]
            [Validation(Required=false)]
            public string Readiness { get; set; }

            /// <summary>
            /// The ID of the region.
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

            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

            /// <summary>
            /// The logging configurations of Log Service.
            /// 
            /// *   To use Log Service resources that are automatically created by SAE, set this parameter to `[{"logDir":"","logType":"stdout"},{"logDir":"/tmp/a.log"}]`.
            /// *   To use custom Log Service resources, set this parameter to `[{"projectName":"test-sls","logType":"stdout","logDir":"","logstoreName":"sae","logtailName":""},{"projectName":"test","logDir":"/tmp/a.log","logstoreName":"sae","logtailName":""}]`.
            /// 
            /// The following parameters are involved:
            /// 
            /// *   **projectName**: the name of the Log Service project.
            /// *   **logDir**: the path in which logs are stored.
            /// *   **logType**: the log type. **stdout**: the standard output log of the container. You can specify only one stdout value for this parameter. If you leave this parameter empty, file logs are collected.
            /// *   **logstoreName**: the name of the Logstore in Log Service.
            /// *   **logtailName**: the name of the Logtail configuration in Log Service. If you do not configure this parameter, a new Logtail configuration is created.
            /// 
            /// If you do not need to modify the logging configurations when you deploy the application, configure the **SlsConfigs** parameter only in the first request. You do not need to include this parameter in subsequent requests. If you no longer need to use Log Service, leave the **SlsConfigs** parameter empty in the request.
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// The details of the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataTags> Tags { get; set; }
            public class DescribeApplicationConfigResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
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
            /// The time zone. Default value: **Asia/Shanghai**.
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// The Tomcat configuration. If you want to delete the configuration, set this parameter to {} or leave this parameter empty. The following parameters are involved:
            /// 
            /// *   **port**: the port number. Valid values: 1024 to 65535. The root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not configure this parameter, the default port number 8080 is used.
            /// *   **contextPath**: the path. Default value: /. This value indicates the root directory.
            /// *   **maxThreads**: the maximum number of connections in the connection pool. Default value: 400.
            /// *   **uriEncoding**: the URI encoding scheme in the Tomcat container. Valid values: **UTF-8**, **ISO-8859-1**, **GBK**, and **GB2312**. If you do not configure this parameter, the default value **ISO-8859-1** is used.
            /// *   **useBodyEncoding**: indicates whether to use the encoding scheme that is specified by **BodyEncoding for URL**. Default value: **true**.
            /// </summary>
            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public string TomcatConfig { get; set; }

            /// <summary>
            /// The deployment policy. If the minimum number of available instances is 1, the value of the **UpdateStrategy** parameter is an empty string (""). If the minimum number of available instances is greater than 1, the following strategies can be configured:
            /// 
            /// *   The application is deployed on an instance. The remaining instances are automatically classified into two release batches whose interval is set to 1. In this case, the parameter is set to `{"type":"GrayBatchUpdate","batchUpdate":{"batch":2,"releaseType":"auto","batchWaitTime":1},"grayUpdate":{"gray":1}}`.
            /// *   The application is deployed on an instance. The remaining instances are manually classified into two release batches. In this case, the parameter is set to `{"type":"GrayBatchUpdate","batchUpdate":{"batch":2,"releaseType":"manual"},"grayUpdate":{"gray":1}}`.
            /// *   All instances are automatically classified into two release batches. The application is deployed on the instances of the two batches in parallel. In this case, the parameter is set to `{"type":"BatchUpdate","batchUpdate":{"batch":2,"releaseType":"auto","batchWaitTime":0}}`
            /// 
            /// The following parameters are involved:
            /// 
            /// *   **type**: the type of the release policy. Valid values: **GrayBatchUpdate** and **BatchUpdate**.
            /// 
            /// *   **batchUpdate**: the phased release policy.
            /// 
            ///     *   **batch**: the number of release batches.
            ///     *   **releaseType**: the processing method for the batches. Valid values: **auto** and **manual**.
            ///     *   **batchWaitTime**: the interval between release batches. Unit: seconds.
            /// 
            /// *   **grayUpdate**: the number of release batches in the phased release after a canary release. This parameter is returned only if the **type** parameter is set to **GrayBatchUpdate**.
            /// </summary>
            [NameInMap("UpdateStrategy")]
            [Validation(Required=false)]
            public string UpdateStrategy { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
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
            /// The option settings in the WAR package. The settings are used to start the application container. The default startup command is `java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap "$@" start`.
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// The version of the Tomcat container on which the deployment package depends. Valid values:
            /// 
            /// *   **apache-tomcat-7.0.91**
            /// *   **apache-tomcat-8.5.42**
            /// 
            /// This parameter is not returned if the **PackageType** parameter is set to **Image**.
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// The returned error code. Valid values:
        /// 
        /// *   If the call is successful, the **ErrorCode** parameter is not returned.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the configurations of an application were obtained. Valid values:
        /// 
        /// *   **true**: The configurations were obtained.
        /// *   **false**: The configurations failed to be obtained.
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
