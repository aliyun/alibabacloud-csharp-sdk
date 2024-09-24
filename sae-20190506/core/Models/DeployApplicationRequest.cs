// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeployApplicationRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) required for a RAM role to obtain images across accounts. For more information, see [Grant permissions across Alibaba Cloud accounts by using a RAM role](https://help.aliyun.com/document_detail/223585.html).
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// The ID of Container Registry Enterprise Edition instance N. This parameter is required when the **ImageUrl** parameter is set to the URL of an image in an ACR Enterprise Edition instance.
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to associate an EIP with the node pool. Take note of the following rules:
        /// 
        /// *   **true**: The EIP is associated with the application instance.
        /// *   **false**: The EIP is not associated with the application instance.
        /// </summary>
        [NameInMap("AssociateEip")]
        [Validation(Required=false)]
        public bool? AssociateEip { get; set; }

        /// <summary>
        /// Specifies whether to automatically enable an auto scaling policy for the application. Take note of the following rules:
        /// 
        /// *   **true**: turns on Logon-free Sharing
        /// *   **false**: turns off Logon-free Sharing
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// The interval between batches during a batch release. Unit: minutes.
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// The description of the change order.
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        /// <summary>
        /// The command that is used to start the image. The command must be an existing executable object in the container. Sample statements:
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
        /// The parameters of the image startup command. The CommandArgs parameter specifies the parameters that are required for the **Command** parameter. You can specify the name in one of the following formats:
        /// 
        /// `["a","b"]`
        /// 
        /// In the preceding example, the CommandArgs parameter is set to `CommandArgs=["abc", ">", "file0"]`. The data type of `["abc", ">", "file0"]` must be an array of strings in the JSON format. This parameter is optional.
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// The description of the **ConfigMap** instance mounted to the application. Use configurations created on the Configuration Items page to configure containers. The following table describes the parameters that are used in the preceding statements.
        /// 
        /// *   **congfigMapId**: the ID of the ConfigMap instance. You can call the [ListNamespacedConfigMaps](https://help.aliyun.com/document_detail/176917.html) operation to obtain the ID.
        /// *   **key**: the key.
        /// 
        /// > You can use `sae-sys-configmap-all` to mount all keys.
        /// 
        /// *   **mountPath**: the mount path in the container.
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The custom mappings between hostnames and IP addresses in the container. Take note of the following rules:
        /// 
        /// *   **hostName**: the domain name or hostname.
        /// *   **ip**: the IP address.
        /// </summary>
        [NameInMap("CustomHostAlias")]
        [Validation(Required=false)]
        public string CustomHostAlias { get; set; }

        /// <summary>
        /// This parameter takes effect only for applications that are in the Stopped state. If you call the **DeployApplication** operation to manage a running application, the application is immediately redeployed.
        /// 
        /// *   **true** (default): specifies that the system immediately deploys the application, enables new configurations, and pulls application instances.
        /// *   **false**: specifies that the system only enables the new configurations.
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public string Deploy { get; set; }

        [NameInMap("Dotnet")]
        [Validation(Required=false)]
        public string Dotnet { get; set; }

        /// <summary>
        /// The version of the container, such as Ali-Tomcat, in which an application developed based on High-speed Service Framework (HSF) is deployed.
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// Indicates whether access to Application High Availability Service (AHAS) is enabled. Take note of the following rules:
        /// 
        /// *   **true**: Access to AHAS is enabled.
        /// *   **false**: Access to AHAS is disabled.
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public string EnableAhas { get; set; }

        /// <summary>
        /// Indicates whether canary release rules are enabled. Canary release rules apply only to applications in Spring Cloud and Dubbo frameworks. Take note of the following rules:
        /// 
        /// *   **true**: The canary release rules are enabled.
        /// *   **false**: The canary release rules are disabled.
        /// </summary>
        [NameInMap("EnableGreyTagRoute")]
        [Validation(Required=false)]
        public bool? EnableGreyTagRoute { get; set; }

        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// The environment variables. You can configure custom environment variables or reference a ConfigMap. If you want to reference a ConfigMap, you must first create a ConfigMap. For more information, see [CreateConfigMap](https://help.aliyun.com/document_detail/176914.html). Take note of the following rules:
        /// 
        /// *   Customize
        /// 
        ///     *   **name**: the name of the environment variable.
        ///     *   **value**: the value of the environment variable.
        /// 
        /// *   Reference ConfigMap
        /// 
        ///     *   **name**: the name of the environment variable. You can reference one or all keys. If you want to reference all keys, specify `sae-sys-configmap-all-<ConfigMap name>`. Example: `sae-sys-configmap-all-test1`.
        ///     *   **valueFrom**: the reference of the environment variable. Set the value to `configMapRef`.
        ///     *   **configMapId**: the ConfigMap ID.
        ///     *   **key**: the key. If you want to reference all keys, do not configure this parameter.
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// The ID of the corresponding Secret.
        /// </summary>
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
        /// The option settings in the JAR package. The settings are used to start the application container. The default startup command for application deployment is `$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS "$package_path" $JarStartArgs`.
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
        /// The logging configurations of Message Queue for Apache Kafka. Take note of the following rules:
        /// 
        /// *   **kafkaEndpoint**: the endpoint of the Message Queue for Apache Kafka API.
        /// *   **kafkaInstanceId**: the ID of the Message Queue for Apache Kafka instance.
        /// *   **kafkaConfigs**: One or more logging configurations of Message Queue for Apache Kafka. For information about sample values and parameters, see the request parameter **KafkaLogfileConfig** in this topic.
        /// </summary>
        [NameInMap("KafkaConfigs")]
        [Validation(Required=false)]
        public string KafkaConfigs { get; set; }

        /// <summary>
        /// The details of the availability check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. You can use one of the following methods to perform the health check:
        /// 
        /// *   Example of **exec**: `{"exec":{"command":["sh","-c","cat/home/admin/start.sh"]},"initialDelaySeconds":30,"periodSeconds":30,"timeoutSeconds":2}`
        /// *   Sample code of the **httpGet** method: `{"httpGet":{"path":"/","port":18091,"scheme":"HTTP","isContainKeyWord":true,"keyWord":"SAE"},"initialDelaySeconds":11,"periodSeconds":10,"timeoutSeconds":1}`
        /// *   Sample code of the **tcpSocket** method: `{"tcpSocket":{"port":18091},"initialDelaySeconds":11,"periodSeconds":10,"timeoutSeconds":1}`
        /// 
        /// > You can use only one method to perform the health check.
        /// 
        /// The following table describes the parameters that are used in the preceding statements.
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

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// The Nacos registry. Valid values:
        /// 
        /// *   **0**: SAE built-in Nacos registry
        /// *   **1**: self-managed Nacos registry
        /// *   **2** : MSE Nacos registry
        /// </summary>
        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// The percentage of the minimum number of available instances. Take note of the following rules:
        /// 
        /// *   If you set the value to **-1**, the minimum number of available instances is not determined based on this parameter. Default value: -1.
        /// *   If you set the value to a number **from 0 to 100**, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if the percentage is set to **50**% and five instances are available, the minimum number of available instances is 3.
        /// 
        /// > When both **MinReadyInstance** and **MinReadyInstanceRatio** are specified and **MinReadyInstanceRatio** is set to a number from 0 to 100, the value of **MinReadyInstanceRatio**** takes precedence. For example, if **MinReadyInstances** is set to **5, and **MinReadyInstanceRatio** is set to **50**, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × **50%**.
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// The minimum number of available instances. Special values:
        /// 
        /// *   If you set the value to **0**, business interruptions occur when the application is updated.
        /// *   If you set the value to \\*\\*-1\\*\\*, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.
        /// 
        /// > Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// The configurations for mounting the NAS file system. After the application is created, you may want to call other operations to manage the application. If you do not want to change the NAS configurations in these subsequent operations, you can omit the **MountDesc** parameter in the requests. If you want to unmount the NAS file system, you must set the **MountDesc** values in the subsequent requests to an empty string ("").
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// The mount target of the NAS file system in the VPC where the application is deployed. If you do not need to modify this configuration during the deployment, configure the **MountHost** parameter only in the first request. You do not need to include this parameter in subsequent requests. If you need to remove this configuration, leave the **MountHost** parameter empty in the request.
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// The configurations of mounting the NAS file system. Take note of the following rules:
        /// 
        /// *   **mountPath**: the mount path of the container.
        /// *   **readOnly**: If you set the value to **false**, the application has the read and write permissions.
        /// *   **nasId**: the ID of the NAS file system.
        /// *   **mountDomain**: the domain name of the mount target. For more information, see [DescribeMountTargets](https://help.aliyun.com/document_detail/62626.html).
        /// *   **nasPath**: the directory in the NAS file system.
        /// </summary>
        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// The ID of the Apsara File Storage NAS file system. After the application is created, you may want to call other operations to manage the application. If you do not want to change the NAS configurations in these subsequent operations, you can omit the **NasId** parameter in the requests. If you want to unmount the NAS file system, you must set the **NasId** values in the subsequent requests to an empty string ("").
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
        /// Information of the Object Storage Service (OSS) bucket mounted to the application. The following table describes the parameters that are used in the preceding statements.
        /// 
        /// *   **bucketName**: the name of the OSS bucket.
        /// 
        /// *   **bucketPath**: the directory or object in OSS. If the specified directory or object does not exist, an error is returned.
        /// 
        /// *   **mountPath**: the directory of the container in SAE. If the path already exists, the newly specified path overwrites the previous one. If the path does not exist, it is created.
        /// 
        /// *   **readOnly**: specifies whether to only allow the container path to read data from the OSS directory. Valid values:
        /// 
        ///     *   **true**: The container path only has read permission on the OSS directory.
        ///     *   **false**: The application has read and write permissions.
        /// </summary>
        [NameInMap("OssMountDescs")]
        [Validation(Required=false)]
        public string OssMountDescs { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// The address of the deployment package. This parameter is required when the **PackageType** parameter is set to **FatJar**, **War**, or **PythonZip**.
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// The version of the deployment package. This parameter is required when the **PackageType** parameter is set to **FatJar**, **War**, or **PythonZip**.
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// The path on which the PHP configuration file for application monitoring is mounted. Make sure that the PHP server loads the configuration file. SAE automatically generates the corresponding configuration file. No manual operations are required.
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
        /// The script that is run immediately after the container is started. Example: `{"exec":{"command":["sh","-c","echo hello"\\]}}`
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// The script that is run before the container is stopped. Example: `{"exec":{"command":["sh","-c","echo hello"\\]}}`
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// The configurations of Kubernetes Service-based service registration and discovery. Take note of the following rules:
        /// 
        /// *   **serviceName**: the name of the Alibaba Cloud service. Format: `<Custom content>-<Namespace ID>`. `-<Namespace ID>` is automatically specified based on the namespace in which an application resides and cannot be changed. For example, if you select the default namespace in the China (Beijing) region, `-cn-beijing-default` is automatically specified.
        /// *   **namespaceId**: the namespace ID.
        /// *   **portAndProtocol**: the port number and protocol. Valid values of the port number: 1 to 65535. Valid values of the protocol: **TCP** and **UDP**.
        /// *   **enable**: enables the Kubernetes Service-based registration and discovery feature.
        /// </summary>
        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        /// <summary>
        /// The Python environment. Set the value to **PYTHON 3.9.15**.
        /// </summary>
        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        /// <summary>
        /// The configurations for installing custom module dependencies. By default, the dependencies defined by the requirements.txt file in the root directory are installed. If the package does not contain this file and you do not configure custom dependencies in the package, specify the dependencies that you want to install in the text box.
        /// </summary>
        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// The details of the health check that was performed on the container. If the container fails this health check multiple times, the system disables and restarts the container. Containers that fail health checks cannot receive traffic from Server Load Balancer (SLB) instances. You can use the **exec**, **httpGet**, or **tcpSocket** method to perform health checks. For more information, see the description of the **Liveness** parameter.
        /// 
        /// > You can use only one method to perform the health check.
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("ServiceTags")]
        [Validation(Required=false)]
        public string ServiceTags { get; set; }

        /// <summary>
        /// The logging configurations of Log Service.
        /// 
        /// *   To use Log Service resources that are automatically created by SAE, set this parameter to `[{"logDir":"","logType":"stdout"},{"logDir":"/tmp/a.log"}]`.
        /// *   To use custom Log Service resources, set this parameter to `[{"projectName":"test-sls","logType":"stdout","logDir":"","logstoreName":"sae","logtailName":""},{"projectName":"test","logDir":"/tmp/a.log","logstoreName":"sae","logtailName":""}]`.
        /// 
        /// The following table describes the parameters that are used in the preceding statements.
        /// 
        /// *   **projectName**: the name of the Log Service project.
        /// *   **logDir**: the path in which logs are stored.
        /// *   **logType**: the log type. **stdout**: the standard output log of the container. You can specify only one stdout value for this parameter. If you leave this parameter empty, file logs are collected.
        /// *   **logstoreName**: the name of the Logstore in Log Service.
        /// *   **logtailName**: the name of the Logtail configuration in Log Service. If you do not configure this parameter, a new Logtail configuration is created.
        /// 
        /// If you do not need to modify the logging configurations when you deploy the application, configure the **SlsConfigs** parameter only in the first request. You do not need to include this parameter in subsequent requests. If you no longer need to use Log Service, leave the **SlsConfigs** parameter empty in the request.
        /// 
        /// > A Log Service project that is automatically created by SAE when you create an application is deleted when the application is deleted. Therefore, when you create an application, you cannot select a Log Service project that is automatically created by SAE for log collection.
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

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
        /// The Tomcat configuration. If you want to cancel this configuration, set this parameter to "" or "{}". The following variables are included in the configuration: Take note of the following rules:
        /// 
        /// *   **port**: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not specify this parameter, the default port number 8080 is used.
        /// *   **contextPath**: the path. Default value: /. This value indicates the root directory.
        /// *   **maxThreads**: the maximum number of connections in the connection pool. Default value: 400.
        /// *   **uriEncoding**: the URI encoding scheme in the Tomcat container. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312.************ If you do not specify this parameter, the default value **ISO-8859-1** is used.
        /// *   **useBodyEncoding**: specifies whether to use the encoding scheme specified in the request body for URI query parameters. Default value: true.
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
        /// The following table describes the parameters that are used in the preceding statements.
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

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The startup command of the WAR package. For information about how to configure the startup command, see [Configure startup commands](https://help.aliyun.com/document_detail/96677.html).
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

}
