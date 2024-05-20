// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateJobRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is used to pull images across accounts. For more information, see [Grant permissions across Alibaba Cloud accounts by using a RAM role](https://help.aliyun.com/document_detail/223585.html).
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
        /// The number of times the job is retried.
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
        /// The parameters of the image startup command. The CommandArgs parameter specifies the parameters that are required for the **Command** parameter. The name must meet the following format requirements:
        /// 
        /// `["a","b"]`
        /// 
        /// In the preceding example, the CommandArgs parameter is set to `CommandArgs=["abc", ">", "file0"]`. The data type of `["abc", ">", "file0"]` must be an array of strings in the JSON format. This parameter is optional.
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// The concurrency policy of the job. Valid values:
        /// 
        /// *   **Forbid**: Prohibits concurrent running. If the previous job is not completed, no new job is created.
        /// *   **Allow**: Allows concurrent running.
        /// *   **Replace**: If the previous job is not completed when the time to create a new job is reached, the new job replaces the previous job.
        /// </summary>
        [NameInMap("ConcurrencyPolicy")]
        [Validation(Required=false)]
        public string ConcurrencyPolicy { get; set; }

        /// <summary>
        /// The description of the **ConfigMap** instance mounted to the application. Use configurations created on the Configuration Items page to configure containers. The following parameters are involved:
        /// 
        /// *   **congfigMapId**: the ID of the ConfigMap instance. You can call the [ListNamespacedConfigMaps](https://help.aliyun.com/document_detail/176917.html) operation to obtain the ID.
        /// *   **key**: the key.
        /// 
        /// > You can use the `sae-sys-configmap-all` key to mount all keys.
        /// 
        /// *   **mountPath**: the mount path.
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

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

        [NameInMap("EnableImageAccl")]
        [Validation(Required=false)]
        public bool? EnableImageAccl { get; set; }

        /// <summary>
        /// The environment variables. You can configure custom environment variables or reference a ConfigMap. If you want to reference a ConfigMap, you must first create a ConfigMap. For more information, see [CreateConfigMap](https://help.aliyun.com/document_detail/176914.html). Valid values:
        /// 
        /// *   Configure custom environment variables
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
        /// The configurations for mounting the NAS file system. If you do not need to modify the NAS configurations when you deploy the application, configure **MountDesc** only in the first request. If you no longer need to use NAS, leave **MountDesc** empty in the request.
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
        /// The ID of the Apsara File Storage NAS file system. If you do not need to modify the NAS configurations when you deploy the application, configure **NasId** only in the first request. If you no longer need to use NAS, leave **NasId** empty in the request.
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// The AccessKey ID that is used to read data from and write data to OSS.
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
        /// The information about the mounted Object Storage Service (OSS) bucket. The following parameters are involved:
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

        /// <summary>
        /// The address of the deployment package. This parameter is required if you set **PackageType** to **FatJar**, **War**, or **PythonZip**.
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// The version of the deployment package. This parameter is required if you set **PackageType** to **FatJar**, **War**, or **PythonZip**.
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// The ID of Container Registry Enterprise Edition instance N.
        /// </summary>
        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

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
        /// The script to be run after the container is started. Example: `{"exec":{"command":["sh","-c","echo hello"\\]}}`
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
        /// The programming language. Valid values: **java**, **php**, **python**, and **shell**.
        /// </summary>
        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

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
        /// The ID of the job that you reference.
        /// </summary>
        [NameInMap("RefAppId")]
        [Validation(Required=false)]
        public string RefAppId { get; set; }

        /// <summary>
        /// The number of concurrent instances.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public string Replicas { get; set; }

        /// <summary>
        /// Specifies whether to enable job sharding.
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
        /// The configurations of Log Service.
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
        /// The timeout period. Unit: seconds.
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
        /// The Tomcat configuration. If you want to delete the configuration, set this parameter to {} or leave this parameter empty. Valid values:
        /// 
        /// *   **port**: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is smaller than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not specify this parameter, the default port number 8080 is used.
        /// *   **contextPath**: the path. Default value: /. This value indicates the root directory.
        /// *   **maxThreads**: the maximum number of connections in the connection pool. Default value: 400.
        /// *   **uriEncoding**: the URI encoding scheme in the Tomcat container. Valid values: **UTF-8**, **ISO-8859-1**, **GBK**, and GB2312. If you do not specify this parameter, the default value **ISO-8859-1** is used.
        /// *   **useBodyEncoding**: specifies whether to use the encoding scheme that is specified by **BodyEncoding for URL**. Default value: **true**.
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// The startup command of the WAR package. For information about how to configure the startup command, see [Configure startup commands](https://help.aliyun.com/document_detail/96677.html).
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
        /// This parameter is not returned if the **PackageType** parameter is set to **Image**.
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
