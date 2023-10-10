// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertK8sApplicationRequest : TeaModel {
        /// <summary>
        /// The annotation of an application pod.
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// The application configuration when the application template is used. Set this parameter to a JSON array.
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// The name of the application. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 36 characters in length.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The name of the template used to create the application. If you specify an application template when you create an application, the application template and the AppConfig parameter are used to configure the application. Other configurations are ignored.
        /// </summary>
        [NameInMap("AppTemplateName")]
        [Validation(Required=false)]
        public string AppTemplateName { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("ApplicationDescription")]
        [Validation(Required=false)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// The version of `EDAS Container`. The value of this parameter conflicts with that of the `EdasContainerVersion` parameter. We recommend that you use the `EdasContainerVersion` parameter.
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public string BuildPackId { get; set; }

        /// <summary>
        /// The ID of the cluster. You can call the ListCluster operation to query the cluster ID. For more information, see [ListCluster](~~154995~~).
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The application startup command. If you specify this parameter, the value of this parameter will replace the startup command in the image.
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// The arguments in the command. The parameter value is a JSON array of strings. An example is `[{"argument":"-c"},{"argument":"test"}]`, where `-c` and `test` are two arguments that can be set.
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// The configuration for mounting a Kubernetes ConfigMap or Secret to a directory in an elastic container instance. The following parameters are included in the configuration:
        /// 
        /// *   name: the name of the Kubernetes ConfigMap or Secret.
        /// *   type: the type of the API object that you want to mount. You can mount a Kubernetes ConfigMap or Secret.
        /// *   mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).
        /// </summary>
        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public string ConfigMountDescs { get; set; }

        /// <summary>
        /// The ID of the repository used to build the image repository. If this parameter is left empty, the default repository provided by EDAS is used. Only the default repository provided by EDAS is supported.
        /// </summary>
        [NameInMap("ContainerRegistryId")]
        [Validation(Required=false)]
        public string ContainerRegistryId { get; set; }

        /// <summary>
        /// The ID of the cluster. This parameter is required only when you create the application in a cluster that has not been imported.
        /// </summary>
        [NameInMap("CsClusterId")]
        [Validation(Required=false)]
        public string CsClusterId { get; set; }

        /// <summary>
        /// The custom affinity.
        /// </summary>
        [NameInMap("CustomAffinity")]
        [Validation(Required=false)]
        public string CustomAffinity { get; set; }

        /// <summary>
        /// The custom tolerances.
        /// </summary>
        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        /// <summary>
        /// Specifies whether to distribute application instances across nodes. Value `true` indicates that application instances are distributed across nodes. Other values indicate that application instances are not distributed across nodes.
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        /// <summary>
        /// Specifies whether to distribute application instances across zones. Value `true` indicates that application instances are distributed across zones. Other values indicate that application instances are not distributed across zones.
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        /// <summary>
        /// The version of `EDAS Container` on which the deployment package of the application depends.
        /// 
        /// > This parameter is unavailable if you deploy applications by using images.
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// The configuration for mounting a Kubernetes emptyDir volume to a directory in an elastic container instance. The following parameters are included in the configuration:
        /// 
        /// *   mountPath: The mount path in the container. This parameter is required.
        /// *   readOnly: (Optional) The mount mode. Value true indicates the read-only mode. Value false indicates the read and write mode. Default value: false.
        /// *   subPathExpr: (Optional) The regular expression that is used to match the subdirectory.
        /// </summary>
        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public string EmptyDirs { get; set; }

        /// <summary>
        /// Specifies whether to enable access to Application High Availability Service (AHAS). Valid values:
        /// 
        /// *   true: enables access to AHAS.
        /// *   false: does not enable access to AHAS.
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// Specifies whether to activate Alibaba Cloud Service Mesh (ASM). Set this parameter to true only when you create the application in a cluster that has not been imported and you need to use ASM.
        /// </summary>
        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

        /// <summary>
        /// Specifies whether to enable the empty list protection feature. Valid values:
        /// 
        /// *   true: enables the empty list protection feature.
        /// *   false: disables the empty list protection feature.
        /// </summary>
        [NameInMap("EnableEmptyPushReject")]
        [Validation(Required=false)]
        public bool? EnableEmptyPushReject { get; set; }

        /// <summary>
        /// Specifies whether to enable graceful start rules. Valid values:
        /// 
        /// *   true: enables graceful start rules.
        /// *   false: disables graceful start rules.
        /// </summary>
        [NameInMap("EnableLosslessRule")]
        [Validation(Required=false)]
        public bool? EnableLosslessRule { get; set; }

        /// <summary>
        /// The Kubernetes environment variables that are configured in EnvFrom mode. A ConfigMap or Secret is mounted to a directory. Each key corresponds to a file in the directory, and the content of the file is the value of the key.
        /// 
        /// The following parameters are included in the configuration:
        /// 
        /// *   configMapRef: the ConfigMap that is referenced. The following parameter is contained:
        /// 
        ///     *   name: the name of the ConfigMap.
        /// 
        /// *   secretRef: the Secret that is referenced. The following parameter is contained:
        /// 
        ///     *   name: the name of the Secret.
        /// </summary>
        [NameInMap("EnvFroms")]
        [Validation(Required=false)]
        public string EnvFroms { get; set; }

        /// <summary>
        /// The environment variables that are used to deploy the application. The value must be a JSON array. Valid values: regular environment variables, Kubernetes ConfigMap environment variables, or Kubernetes Secret environment variables. Specify regular environment variables in the following format:
        /// 
        /// `{"name":"x", "value": "y"}`
        /// 
        /// Specify Kubernetes ConfigMap environment variables in the following format to reference values from ConfigMaps:
        /// 
        /// `{ "name": "x2", "valueFrom": { "configMapKeyRef": { "name": "my-config", "key": "y2" } } }`
        /// 
        /// Specify Kubernetes Secret environment variables in the following format to reference values from Secrets:
        /// 
        /// `{ "name": "x3", "valueFrom": { "secretKeyRef": { "name": "my-secret", "key": "y3" } } }`
        /// 
        /// >  If you want to cancel this configuration, set this parameter to an empty JSON array in the format of "\[]".
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("ImagePlatforms")]
        [Validation(Required=false)]
        public string ImagePlatforms { get; set; }

        /// <summary>
        /// The URL of the image. This parameter is required if you set the `PackageType` parameter to `Image`.
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public string InitContainers { get; set; }

        /// <summary>
        /// The ID of the Internet-facing SLB instance. If you do not specify this parameter, EDAS automatically purchases a new SLB instance for you.
        /// </summary>
        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        /// <summary>
        /// The frontend port of the Internet-facing SLB instance. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("InternetSlbPort")]
        [Validation(Required=false)]
        public int? InternetSlbPort { get; set; }

        /// <summary>
        /// The protocol used by the Internet-facing SLB instance. Valid values: TCP, HTTP, and HTTPS.
        /// </summary>
        [NameInMap("InternetSlbProtocol")]
        [Validation(Required=false)]
        public string InternetSlbProtocol { get; set; }

        /// <summary>
        /// The backend port of the internal-facing SLB instance. This port also serves as the service port of the application. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("InternetTargetPort")]
        [Validation(Required=false)]
        public int? InternetTargetPort { get; set; }

        /// <summary>
        /// The ID of the internal-facing SLB instance. If you do not specify this parameter, Enterprise Distributed Application Service (EDAS) automatically purchases a new SLB instance for you.
        /// </summary>
        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

        /// <summary>
        /// The frontend port of the internal-facing SLB instance. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("IntranetSlbPort")]
        [Validation(Required=false)]
        public int? IntranetSlbPort { get; set; }

        /// <summary>
        /// The protocol used by the internal-facing SLB instance. Valid values: TCP, HTTP, and HTTPS.
        /// </summary>
        [NameInMap("IntranetSlbProtocol")]
        [Validation(Required=false)]
        public string IntranetSlbProtocol { get; set; }

        /// <summary>
        /// The backend port of the internal-facing Server Load Balancer (SLB) instance. This port also serves as the service port of the application. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("IntranetTargetPort")]
        [Validation(Required=false)]
        public int? IntranetTargetPort { get; set; }

        /// <summary>
        /// Specifies whether the application is a multi-language application.
        /// </summary>
        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        /// <summary>
        /// The version of the Java Development Kit (JDK) on which the deployment package of the application depends. Valid values: Open JDK 7 and Open JDK 8. This parameter is unavailable if you deploy applications by using images.
        /// </summary>
        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        /// <summary>
        /// The configuration of Java startup parameters for a Java application. These startup parameters involve the memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom configurations. Appropriate parameter settings help reduce the GC overheads, shorten the server response time, and improve the throughput. Set this parameter to a JSON string. In the example, original indicates the configuration value, and startup indicates a startup parameter. The system automatically concatenates all startup values as the settings of Java startup parameters for the application. To delete this configuration, leave the parameter value empty by entering `""` or `"{}"`. The following parameters are included in the configuration:
        /// 
        /// *   InitialHeapSize: the initial size of the heap memory.
        /// *   MaxHeapSize: the maximum size of the heap memory.
        /// *   CustomParams: the custom parameters, such as JVM -D parameters.
        /// *   Other parameters: You can view the JSON structure submitted by the frontend.
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        /// <summary>
        /// The label of an application pod.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed for each application instance when the application is running. Unit: cores. If the LimitmCpu parameter is specified, you can ignore this parameter.
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public int? LimitCpu { get; set; }

        /// <summary>
        /// The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// The maximum size of memory allowed for each application instance when the application is running. Unit: MB. The value of LimitMem must be greater than that of RequestsMem.
        /// </summary>
        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public int? LimitMem { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed for each application instance when the application is running. Unit: millicores. Value 0 indicates that no limit is set on CPU cores.
        /// </summary>
        [NameInMap("LimitmCpu")]
        [Validation(Required=false)]
        public int? LimitmCpu { get; set; }

        /// <summary>
        /// The configuration for the liveness check on the container. Example: `{"failureThreshold": 3,"initialDelaySeconds": 5,"successThreshold": 1,"timeoutSeconds": 1,"tcpSocket":{"host":"", "port":8080}}`.
        /// 
        /// If you want to cancel this configuration, leave the parameter value empty by entering `""` or `{}`. If you do not specify this parameter, this configuration is ignored.
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// The configurations that are used when the host files are mounted to the container on which the application is running. Example: `\[{"type":"","nodePath":"/localfiles","mountPath":"/app/files"},{"type":"Directory","nodePath":"/mnt","mountPath":"/app/storage"}\]`. Description:
        /// 
        /// *   `nodePath`: the host path.
        /// *   `mountPath`: the path in the container.
        /// *   `type`: the mounting type.
        /// </summary>
        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        /// <summary>
        /// The ID of the EDAS namespace. This parameter is required for a non-default namespace.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the graceful rolling deployment mode and ensure that the service is registered before the readiness check. Valid values:
        /// 
        /// *   true: provides port 55199 and the /health path for the health check in a non-intrusive manner. When the service is registered, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.
        /// 
        ///     **
        /// 
        ///     **Note**If you set both the `LosslessRuleRelated` parameter and this parameter to `true`, the operation checks whether the service prefetching is complete.
        /// 
        /// *   false: does not check whether the service is registered.
        /// </summary>
        [NameInMap("LosslessRuleAligned")]
        [Validation(Required=false)]
        public bool? LosslessRuleAligned { get; set; }

        /// <summary>
        /// The delay of service registration. Valid values: 0 to 86400. Unit: seconds.
        /// </summary>
        [NameInMap("LosslessRuleDelayTime")]
        [Validation(Required=false)]
        public int? LosslessRuleDelayTime { get; set; }

        /// <summary>
        /// The number of prefetching curves. Valid values: 0 to 20. The default value is 2, which is suitable for common prefetching scenarios. This value indicates that the received traffic of the provider during prefetching is displayed as a quadratic curve.
        /// </summary>
        [NameInMap("LosslessRuleFuncType")]
        [Validation(Required=false)]
        public int? LosslessRuleFuncType { get; set; }

        /// <summary>
        /// Specifies whether to enable the graceful rolling deployment mode and ensure that the service prefetching is complete before the readiness check. Valid values:
        /// 
        /// *   true: provides port 55199 and the /health path for the health check in a non-intrusive manner. When the service prefetching is complete, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.
        /// *   false: does not check whether the service prefetching is complete.
        /// </summary>
        [NameInMap("LosslessRuleRelated")]
        [Validation(Required=false)]
        public bool? LosslessRuleRelated { get; set; }

        /// <summary>
        /// The service prefetching duration. Valid values: 0 to 86400. Unit: seconds.
        /// </summary>
        [NameInMap("LosslessRuleWarmupTime")]
        [Validation(Required=false)]
        public int? LosslessRuleWarmupTime { get; set; }

        /// <summary>
        /// The description of the NAS mounting configuration. Set this parameter to a serialized JSON string. Example: `\[{"nasPath": "/k8s","mountPath": "/mnt"},{"nasPath": "/files","mountPath": "/app/files"}\]`. The `nasPath` parameter specifies the file storage path, and the `mountPath` parameter specifies the path to mount the file system to the container where the application is running.
        /// </summary>
        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        /// <summary>
        /// The namespace of the Kubernetes cluster. This parameter specifies the Kubernetes namespace in which your application is deployed. By default, the default namespace is used.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The ID of the Network Attached Storage (NAS) file system that you want to mount to the application. If you do not specify this parameter but specify the MountDescs parameter, a NAS file system is automatically purchased and mounted to the vSwitch in the VPC.
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// The type of the deployment package. Valid values: FatJar, WAR, and Image.
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.
        /// 
        /// > The version of EDAS SDK for Java or Python must be V2.44.0 or later.
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// The version of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application. You must specify a version.
        /// 
        /// > The version of EDAS SDK for Java or Python must be V2.44.0 or later.
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// The post-start script. Example: `{"exec":{"command":\["cat","/etc/group"\]}}`.
        /// 
        /// If you want to cancel this configuration, leave this parameter empty by setting it to `""` or `{}`. If you do not specify this parameter, this configuration is ignored.
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// The pre-stop script. Example: `{"tcpSocket":{"host":"", "port":8080}}`.
        /// 
        /// If you want to cancel this configuration, leave this parameter empty by setting it to `""` or `{}`. If you do not specify this parameter, this configuration is ignored.
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// The configuration for mounting a Kubernetes PersistentVolumeClaim (PVC) volume to a directory in an elastic container instance. The following parameters are included in the configuration:
        /// 
        /// *   pvcName: the name of the PVC volume. Make sure that the PVC volume is an existing volume and is in the Bound state.
        /// 
        /// *   mountPaths: the directory to which you want to mount the PVC volume. You can configure multiple directories. You can set the following two parameters for each mount directory:
        /// 
        ///     *   mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).
        ///     *   readOnly: the mount mode. Value true indicates the read-only mode. Value false indicates the read and write mode. Default value: false.
        /// </summary>
        [NameInMap("PvcMountDescs")]
        [Validation(Required=false)]
        public string PvcMountDescs { get; set; }

        /// <summary>
        /// The configuration for the readiness check on the container. If the check fails, the traffic that passes through the Kubernetes Service is not transmitted to the container. Example: \`{"failureThreshold": 3,"initialDelaySeconds": 5,"successThreshold": 1,"timeoutSeconds": 1,"httpGet": {"path": "/consumer","port": 8080,"scheme": "HTTP","httpHeaders": \\[{"name": "test","value": "testvalue"}\\]}}\`.``
        /// 
        /// If you want to cancel this configuration, leave the parameter value empty by entering `""` or `{}`. If you do not specify this parameter, this configuration is ignored.
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// The number of application instances.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed for each application instance when the application is created. Unit: cores. Value 0 indicates that no limit is set on CPU cores. If the RequestsmCpu parameter is specified, the value of the RequestsmCpu parameter is used. You can ignore this parameter.
        /// </summary>
        [NameInMap("RequestsCpu")]
        [Validation(Required=false)]
        public int? RequestsCpu { get; set; }

        /// <summary>
        /// The minimum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// The maximum size of memory allowed for each application instance when the application is created. Unit: MB. Value 0 indicates that no limit is set on the memory size. The value of RequestsMem cannot be greater than that of LimitMem.
        /// </summary>
        [NameInMap("RequestsMem")]
        [Validation(Required=false)]
        public int? RequestsMem { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed for each application instance when the application is created. Unit: millicores.
        /// </summary>
        [NameInMap("RequestsmCpu")]
        [Validation(Required=false)]
        public int? RequestsmCpu { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the container runtime. This parameter is applicable only to clusters that use sandboxed containers.
        /// </summary>
        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// The name of the credential that is used to pull the images specified by the user. You must configure the Secret.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The configurations of services in a Kubernetes cluster.
        /// </summary>
        [NameInMap("ServiceConfigs")]
        [Validation(Required=false)]
        public string ServiceConfigs { get; set; }

        [NameInMap("Sidecars")]
        [Validation(Required=false)]
        public string Sidecars { get; set; }

        /// <summary>
        /// The Logstore configuration. To delete this configuration, leave the parameter value empty by entering `""` or `"{}"`.
        /// 
        /// *   The following parameters are included in the configuration:
        /// 
        ///     *   type: the collection type. Set this parameter to file to specify the file type. Set this parameter to stdout to specify the standard output type.
        /// 
        ///     *   logstore: the name of the Logstore. Make sure that the name of the Logstore is unique in the cluster. The name must comply with the following rules:
        /// 
        ///         *   The name can contain only lowercase letters, digits, hyphens (-), and underscores (\_).
        ///         *   The name must start and end with a lowercase letter or a digit.
        ///         *   The name must be 3 to 63 characters in length. If you leave this parameter empty, the system automatically generates a name.
        /// 
        ///     *   LogDir: If the standard output type is used, the collection path is stdout.log. If the file type is used, the collection path is the path of the collected file. Wildcards (\*) are supported. The collection path must match the following regular expression: `^/(.+)/(.*)^/$`.
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        [NameInMap("Startup")]
        [Validation(Required=false)]
        public string Startup { get; set; }

        /// <summary>
        /// The storage type of the NAS file system.
        /// 
        /// *   Valid values for General-purpose NAS file systems: Capacity and Performance.
        /// *   Valid values for Extreme NAS file systems: Standard and Advance.
        /// 
        /// You can set this parameter only to Performance.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("TerminateGracePeriod")]
        [Validation(Required=false)]
        public int? TerminateGracePeriod { get; set; }

        /// <summary>
        /// The timeout period of the change process. Valid values: 1 to 1800. Unit: seconds. If you do not specify this Unidentifiedparameter, the default value 1800 is used.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The URI encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.
        /// 
        /// > If you do not specify this parameter in the application configurations, the default URI encoding scheme in the Tomcat container is applied.
        /// </summary>
        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        /// <summary>
        /// Specifies whether to use the encoding scheme specified in the request body for URI query parameters.
        /// 
        /// > If this parameter is not specified in application configuration, the default value false is applied.
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        [NameInMap("UserBaseImageUrl")]
        [Validation(Required=false)]
        public string UserBaseImageUrl { get; set; }

        /// <summary>
        /// The version of the Tomcat container on which the deployment package of the application depends. This parameter is applicable to Spring Cloud and Dubbo applications that you deploy by using WAR packages. This parameter is unavailable if you deploy applications by using images.
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        /// <summary>
        /// The configuration of the Tomcat container. If you want to cancel this configuration, set this parameter to "" or "{}". The following parameters are included in the configuration:
        /// 
        /// *   useDefaultConfig: specifies whether to use the default configuration. Value true indicates that the default configuration is used. Value false indicates that the custom configuration is used. If the default configuration is used, the following parameters do not take effect:
        /// 
        /// *   contextInputType: the type of the access path for the application. Valid values:
        /// 
        ///     *   war: The access path is the name of the WAR package. You do not need to specify a custom path.
        ///     *   root: The access path for the application is `/`. You do not need to specify a custom path.
        ///     *   custom: If you select this option, you must specify a custom path for the contextPath parameter.
        /// 
        /// *   contextPath: the custom access path for the application. This parameter is required only when you set the contextInputType parameter to custom.
        /// 
        /// *   httpPort: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is less than 1024. Enter a value that ranges from 1024 to 65535 because the container has only the admin permissions. If you do not configure this parameter, the default port number 8080 is used.
        /// 
        /// *   maxThreads: the maximum number of connections in the connection pool. Default value: 400.
        /// 
        ///     **
        /// 
        ///     **Note**This parameter significantly affects application performance. We recommend that you consult with technical support before you set this parameter.
        /// 
        /// *   uriEncoding: the URI encoding scheme in the Tomcat container. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312. If you do not specify this parameter, the default value ISO-8859-1 is used.
        /// 
        /// *   useBodyEncoding: specifies whether to use the encoding scheme specified in the request body for URI query parameters.
        /// 
        /// *   useAdvancedServerXml: specifies whether to use advanced configurations to customize the server.xml file. If the preceding parameter types and specific parameters cannot meet your requirements, you can use advanced configurations to customize the server.xml file of Tomcat.
        /// 
        /// *   serverXml: the content of the server.xml file customized by using advanced configurations. This parameter takes effect only when you set the useAdvancedServerXml parameter to true.
        /// </summary>
        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public string WebContainerConfig { get; set; }

        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
