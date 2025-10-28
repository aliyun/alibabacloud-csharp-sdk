// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The annotation of an application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;annotation-name-1&quot;:&quot;annotation-value-1&quot;,&quot;annotation-name-2&quot;:&quot;annotation-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e83acea6-****-47e1-96ae-c0e953772cdc</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The argument array in the container start-up command. Set this parameter to a JSON array in the format of <c>[&quot;args1&quot;,&quot;args2&quot;\\]</c>, where each key is set to a string. If you want to cancel this configuration, set this parameter to an empty JSON array in the format of <c>&quot;[\\]&quot;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;args1&quot;,&quot;args2&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// <para>The timeout period for an at-a-time release. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("BatchTimeout")]
        [Validation(Required=false)]
        public int? BatchTimeout { get; set; }

        /// <summary>
        /// <para>The minimum time interval for the phased release of pods. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/controllers/deployment/#min-ready-seconds">minReadySeconds</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The build package number of EDAS Container.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to set the parameter if you do not need to change the EDAS Container version during the deployment.</description></item>
        /// <item><description>Set the parameter if you need to update the EDAS Container version of the application during the deployment.</description></item>
        /// </list>
        /// <para>You can query the build package number by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the ListBuildPack operation. For more information, see <a href="https://help.aliyun.com/document_detail/423222.html">ListBuildPack</a>.</description></item>
        /// <item><description>Obtain the value in the <b>Build package number</b> column of the <a href="https://help.aliyun.com/document_detail/92614.html">Release notes for EDAS Container</a> topic. For example, <c>59</c> indicates <c>EDAS Container 3.5.8</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public string BuildPackId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a8daf22e-****-968c7ff2ea34</para>
        /// </summary>
        [NameInMap("CanaryRuleId")]
        [Validation(Required=false)]
        public string CanaryRuleId { get; set; }

        /// <summary>
        /// <para>The description of the change process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        /// <summary>
        /// <para>The commands that you run to start the container.</para>
        /// <remarks>
        /// <para>If you want to cancel this configuration, set this parameter to an empty string in the format of <c>&quot;&quot;</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes ConfigMap or Secret to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>name: the name of the Kubernetes ConfigMap or Secret.</description></item>
        /// <item><description>type: the type of the API object that you want to mount. You can mount a Kubernetes ConfigMap or Secret.</description></item>
        /// <item><description>mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;name&quot;: &quot;nginx-config&quot;,
        ///             &quot;type&quot;: &quot;ConfigMap&quot;,
        ///             &quot;mountPath&quot;: &quot;/etc/nginx&quot;
        ///       },
        ///       {
        ///             &quot;name&quot;: &quot;tls-secret&quot;,
        ///             &quot;type&quot;: &quot;Secret&quot;,
        ///             &quot;mountPath&quot;: &quot;/etc/ssh&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public string ConfigMountDescs { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is running. Unit: cores. Value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public int? CpuLimit { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested for each application instance when the application is running. Unit: cores. We recommend that you set this parameter. Value 0 indicates that no limit is set on CPU cores.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public int? CpuRequest { get; set; }

        /// <summary>
        /// <para>The affinity configuration of the pod. This parameter takes effect only if both the DeployAcrossNodes and DeployAcrossZones parameters are set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodeAffinity&quot;:{&quot;requiredDuringSchedulingIgnoredDuringExecution&quot;:{&quot;nodeSelectorTerms&quot;:[{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;beta.kubernetes.io/arch&quot;,&quot;operator&quot;:&quot;NotIn&quot;,&quot;values&quot;:[&quot;arm64&quot;,&quot;arm32&quot;]}]}]},&quot;preferredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;weight&quot;:5,&quot;preference&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;kubernetes.io/os&quot;,&quot;operator&quot;:&quot;In&quot;,&quot;values&quot;:[&quot;linux&quot;]}]}}]},&quot;podAffinity&quot;:{&quot;requiredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;namespaces&quot;:[&quot;default&quot;],&quot;topologyKey&quot;:&quot;kubernetes.io/hostname&quot;,&quot;labelSelector&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;edas.oam.acname&quot;,&quot;operator&quot;:&quot;NotIn&quot;,&quot;values&quot;:[&quot;edas-test-app&quot;]}]}}]},&quot;podAntiAffinity&quot;:{&quot;preferredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;podAffinityTerm&quot;:{&quot;namespaces&quot;:[&quot;default&quot;],&quot;topologyKey&quot;:&quot;failure-domain.beta.kubernetes.io/zone&quot;,&quot;labelSelector&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;edas.oam.acname&quot;,&quot;operator&quot;:&quot;In&quot;,&quot;values&quot;:[&quot;edas-test-app-2&quot;]}]}},&quot;weight&quot;:15}]}}</para>
        /// </summary>
        [NameInMap("CustomAffinity")]
        [Validation(Required=false)]
        public string CustomAffinity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.1.4</para>
        /// </summary>
        [NameInMap("CustomAgentVersion")]
        [Validation(Required=false)]
        public string CustomAgentVersion { get; set; }

        /// <summary>
        /// <para>The scheduling tolerance configuration of the pod. This parameter takes effect only if both the DeployAcrossNodes and DeployAcrossZones parameters are set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;edas-taint-key2&quot;,&quot;operator&quot;:&quot;Exists&quot;,&quot;effect&quot;:&quot;NoExecute&quot;,&quot;tolerationSeconds&quot;:50},{&quot;key&quot;:&quot;edas-taint-key&quot;,&quot;operator&quot;:&quot;Equal&quot;,&quot;value&quot;:&quot;edas-taint-value&quot;,&quot;effect&quot;:&quot;PreferNoSchedule&quot;}]</para>
        /// </summary>
        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances to multiple nodes. Value true indicates that application instances are distrubuted across zones. Other values indicate that application instances are not distributed across zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances across zones. Value true indicates that application instances are distrubuted across zones. Other values indicate that application instances are not distributed across zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        /// <summary>
        /// <para>The version of EDAS Container on which the deployment package of the application depends. This parameter is applicable to High-Speed Service Framework (HSF) applications that you deploy by using WAR packages. This parameter is unavailable if you deploy applications by using images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.9</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes emptyDir volume to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>mountPath: The mount path in the container. This parameter is required.</description></item>
        /// <item><description>readOnly: (Optional) The mount mode. Value true indicates the read-only mode. Value false indicates the read and write mode. Default value: false.</description></item>
        /// <item><description>subPathExpr: (Optional) The regular expression that is used to match the subdirectory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mountPath&quot;:&quot;/app-log&quot;,&quot;subPathExpr&quot;:&quot;$(POD_IP)&quot;},{&quot;readOnly&quot;:true,&quot;mountPath&quot;:&quot;/etc/nginx&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public string EmptyDirs { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access to Application High Availability Service (AHAS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the empty list protection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the empty list protection feature.</description></item>
        /// <item><description>false: disables the empty list protection feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableEmptyPushReject")]
        [Validation(Required=false)]
        public bool? EnableEmptyPushReject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable graceful start rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables graceful start rules.</description></item>
        /// <item><description>false: disables graceful start rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLosslessRule")]
        [Validation(Required=false)]
        public bool? EnableLosslessRule { get; set; }

        /// <summary>
        /// <para>The Kubernetes environment variables that are configured in EnvFrom mode. A ConfigMap or Secret is mounted to a directory. Each key corresponds to a file in the directory, and the content of the file is the value of the key.</para>
        /// <para>This parameter contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>configMapRef: the ConfigMap that is referenced. The following parameter is contained:</para>
        /// <list type="bullet">
        /// <item><description>name: the name of the ConfigMap.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>secretRef: the Secret that is referenced. The following parameter is contained:</para>
        /// <list type="bullet">
        /// <item><description>name: the name of the Secret.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;appname&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;appconf&quot;,&quot;key&quot;:&quot;name&quot;}}}]</para>
        /// </summary>
        [NameInMap("EnvFroms")]
        [Validation(Required=false)]
        public string EnvFroms { get; set; }

        /// <summary>
        /// <para>The environment variables that are used to deploy the application. Set this parameter to a JSON array. Valid values: regular environment variables, Kubernetes ConfigMap environment variables, and Kubernetes Secret environment variables. Specify regular environment variables in the following format:</para>
        /// <para><c>{&quot;name&quot;:&quot;x&quot;, &quot;value&quot;: &quot;y&quot;}</c></para>
        /// <para>Specify Kubernetes ConfigMap environment variables in the following format to reference values from ConfigMaps:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x2&quot;, &quot;valueFrom&quot;: { &quot;configMapKeyRef&quot;: { &quot;name&quot;: &quot;my-config&quot;, &quot;key&quot;: &quot;y2&quot; } } }</c></para>
        /// <para>Specify Kubernetes Secret environment variables in the following format to reference values from Secrets:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x3&quot;, &quot;valueFrom&quot;: { &quot;secretKeyRef&quot;: { &quot;name&quot;: &quot;my-secret&quot;, &quot;key&quot;: &quot;y3&quot; } } }</c></para>
        /// <remarks>
        /// <para> If you want to cancel this configuration, set this parameter to an empty JSON array, which is in the format of &quot;[]&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;x1&quot;,&quot;value&quot;:&quot;y1&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;my-config&quot;,&quot;key&quot;:&quot;y2&quot;}}},{&quot;name&quot;:&quot;x3&quot;,&quot;valueFrom&quot;:{&quot;secretKeyRef&quot;:{&quot;name&quot;:&quot;my-secret&quot;,&quot;key&quot;:&quot;y3&quot;}}}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The absolute URL of the image. This parameter setting overwrites the setting of the ImageTag parameter.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The destination image platform. This parameter takes effect only when you deploy applications by using .war or .jar packages.</para>
        /// <list type="bullet">
        /// <item><description>If you want to specify x86_64, set the value to linux/amd64.</description></item>
        /// <item><description>If you want to specify ARM64, set the value to linux/arm64.</description></item>
        /// <item><description>If you want to specify both x86_64 and ARM64, set the value to linux/amd64,linux/arm64.</description></item>
        /// <item><description>If you leave this parameter empty, the default architecture is used.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ImagePlatforms")]
        [Validation(Required=false)]
        public string ImagePlatforms { get; set; }

        /// <summary>
        /// <para>The tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;yamlEncoded&quot;: &quot;Y29tbWFuZDoKICAtIHNsZWVwCiAgLSAnNjAnCmltYWdlOiAnYnVzeWJveDpsYXRlc3QnCm5hbWU6IGluaXQtYnVzeWJveAo=&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public string InitContainers { get; set; }

        /// <summary>
        /// <para>The version of the Java Development Kit (JDK) on which the deployment package of the application depends. Open JDK 7 and Open JDK 8 are supported. This parameter is unavailable if you deploy applications by using images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        /// <summary>
        /// <para>The configuration of Java startup parameters for a Java application. These startup parameters involve the memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom configurations. Proper parameter settings help reduce the GC overheads, shorten the server response time, and improve the throughput. Set this parameter to a JSON string. In the example, original indicates the configuration value, and startup indicates a startup parameter. The system automatically concatenates all startup values as the settings of Java startup parameters for the application. To delete this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InitialHeapSize&quot;:{&quot;original&quot;:512,&quot;startup&quot;:&quot;-Xms512m&quot;},&quot;MaxHeapSize&quot;:{&quot;original&quot;:1024,&quot;startup&quot;:&quot;-Xmx1024m&quot;}}</para>
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        /// <summary>
        /// <para>The label of an application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;label-name-1&quot;:&quot;label-value-1&quot;,&quot;label-name-2&quot;:&quot;label-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The configuration for the liveness check on the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>. If you want to cancel this configuration, set this parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The configurations that are used when the host files are mounted to the container on which the application is running. Example: <c>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}\\]</c>. The nodePath parameter specifies the host path, the mountPath parameter specifies the path within the container, and the type parameter specifies the mounting type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</para>
        /// </summary>
        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Graceful Rolling Release and configure Complete Service Registration before Readiness Probing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: If you turn on the switch, the system uses the /health path and provides port 55199 for the health check. The system does not intrude into the application. When the service is registered, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set both the LosslessRuleRelated parameter and this parameter to true, the operation checks whether the service prefetching is complete.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>false: If you turn off the switch, the system does not provide a port to check whether the service is registered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LosslessRuleAligned")]
        [Validation(Required=false)]
        public bool? LosslessRuleAligned { get; set; }

        /// <summary>
        /// <para>The delay of service registration. Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LosslessRuleDelayTime")]
        [Validation(Required=false)]
        public int? LosslessRuleDelayTime { get; set; }

        /// <summary>
        /// <para>The number of prefetching curves. Valid values: 0 to 20. The default value is 2, which is suitable for common prefetching scenarios. This value indicates that the received traffic amount of the provider during prefetching is displayed as a quadratic curve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LosslessRuleFuncType")]
        [Validation(Required=false)]
        public int? LosslessRuleFuncType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Graceful Rolling Release and configure Complete Service Prefetching before Readiness Probing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: If you turn on the switch, the system uses the /health path and provides port 55199 for the health check. The system does not intrude into the application. When service prefetching is complete, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.</description></item>
        /// <item><description>false: If you turn off the switch, the system does not provide a port to check whether service prefetching is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LosslessRuleRelated")]
        [Validation(Required=false)]
        public bool? LosslessRuleRelated { get; set; }

        /// <summary>
        /// <para>The service prefetching duration. Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("LosslessRuleWarmupTime")]
        [Validation(Required=false)]
        public int? LosslessRuleWarmupTime { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed. Unit: cores. Value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public int? McpuLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores required. Unit: cores. Value 0 indicates that no limit is set on CPU cores.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public int? McpuRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is running. Unit: MB. Value 0 indicates that no limit is set on the memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public int? MemoryLimit { get; set; }

        /// <summary>
        /// <para>The size of memory requested for each application instance when the application is running. Unit: MB. We recommend that you set this parameter. If you do not want to apply for a memory quota, set this parameter to 0.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the MemoryLimit parameter. Make sure that the value of this parameter does not exceed that of the MemoryLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public int? MemoryRequest { get; set; }

        /// <summary>
        /// <para>The description of the NAS mounting configuration. Set this parameter to a serialized JSON string. Example: <c>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}\\]</c>. The nasPath parameter specifies the file storage path, and the mountPath parameter specifies the path to mount the file system to the container in which the application is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</para>
        /// </summary>
        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        /// <summary>
        /// <para>The ID of the File Storage NAS (NAS) file system mounted to the container in which the application is running. The NAS file system must be in the same region as the cluster. The NAS file system must have an available mount target, or have a mount target on the vSwitch in the virtual private cloud (VPC) in which the application resides. If you do not specify this parameter but specify the MountDescs parameter, a NAS file system is automatically purchased and mounted to the vSwitch in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs23****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.</para>
        /// <remarks>
        /// <para>The version of EDAS SDK for Java or Python must be V2.44.0 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application. You must specify a version.</para>
        /// <remarks>
        /// <para>The version of EDAS SDK for Java or Python must be V2.44.0 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20200720</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The version ID of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2bcc********</para>
        /// </summary>
        [NameInMap("PackageVersionId")]
        [Validation(Required=false)]
        public string PackageVersionId { get; set; }

        /// <summary>
        /// <para>The post-start script. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c>. If you want to cancel this configuration, set this parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The pre-stop script. Example: <c>{&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>. If you want to cancel this configuration, set this parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes PersistentVolumeClaim (PVC) to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>pvcName: the name of the PVC. Make sure that the volume exists and is in the Bound state.</para>
        /// </description></item>
        /// <item><description><para>mountPaths: the directory to which you want to mount the PVC. You can configure multiple directories. You can set the following two parameters for each mount directory:</para>
        /// <list type="bullet">
        /// <item><description>mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).</description></item>
        /// <item><description>readOnly: the mount mode. Value true indicates the read-only mode. Value false indicates the read and write mode. Default value: false.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;pvcName&quot;:&quot;nas-pvc-1&quot;,&quot;mountPaths&quot;:[{&quot;mountPath&quot;:&quot;/usr/share/nginx/data&quot;},{&quot;mountPath&quot;:&quot;/usr/share/nginx/html&quot;,&quot;readOnly&quot;:true}]}]</para>
        /// </summary>
        [NameInMap("PvcMountDescs")]
        [Validation(Required=false)]
        public string PvcMountDescs { get; set; }

        /// <summary>
        /// <para>The configuration for the readiness check on the container. If the check fails, the traffic that passes through the Kubernetes service is not transmitted to the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}\\]}}</c>. If you want to cancel this configuration, set this parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>The number of application instances. The minimum value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The minimum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The type of the container runtime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>runc: standard container runtime</description></item>
        /// <item><description>runv: sandboxed container runtime</description></item>
        /// </list>
        /// <para>This parameter is applicable only to clusters that use sandboxed containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>runc</para>
        /// </summary>
        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;yamlEncoded&quot;: &quot;Y29tbWFuZDoKICAtIHRhaWwKICAtICctZicKICAtIC9kZXYvbnVsbAppbWFnZTogJ2J1c3lib3g6bGF0ZXN0JwpuYW1lOiBidXN5Ym94Cg==&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Sidecars")]
        [Validation(Required=false)]
        public string Sidecars { get; set; }

        /// <summary>
        /// <para>The Logstore configuration. If you want to cancel this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>type: the collection type. Set this parameter to file to specify the file type. Set this parameter to stdout to specify the standard output type.</para>
        /// </description></item>
        /// <item><description><para>logstore: the name of the Logstore. Make sure that the name of the Logstore is unique in the cluster. The name must comply with the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length. If you leave this parameter empty, the system automatically generates a name.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>logDir: If the standard output type is used, the collection path is stdout.log. If the file type is used, the collection path is the path of the collected file. Wildcards (\*) are supported. The collection path must match the following regular expression: <c>^/(.+)/(.*)^/$</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logstore&quot;:&quot;thisisanotherfilelog&quot;,&quot;type&quot;:&quot;file&quot;,&quot;logDir&quot;:&quot;/var/log/<em>&quot;},{&quot;logstore&quot;:&quot;&quot;,&quot;type&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;stdout.log&quot;},{&quot;logstore&quot;:&quot;thisisafilelog&quot;,&quot;type&quot;:&quot;file&quot;,&quot;logDir&quot;:&quot;/tmp/log/</em>&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Startup")]
        [Validation(Required=false)]
        public string Startup { get; set; }

        /// <summary>
        /// <para>The storage type of the NAS file system.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for General-purpose NAS file systems: Capacity and Performance.</description></item>
        /// <item><description>Valid values for Extreme NAS file systems: standard and advance.</description></item>
        /// </list>
        /// <para>You can set this parameter only to Performance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Performance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TerminateGracePeriod")]
        [Validation(Required=false)]
        public int? TerminateGracePeriod { get; set; }

        /// <summary>
        /// <para>The traffic adjustment policy for a canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;http&quot;:{&quot;rules&quot;:[{&quot;conditionType&quot;:&quot;percent&quot;,&quot;percent&quot;:10}]}}</para>
        /// </summary>
        [NameInMap("TrafficControlStrategy")]
        [Validation(Required=false)]
        public string TrafficControlStrategy { get; set; }

        /// <summary>
        /// <para>The phased release policy.</para>
        /// <list type="bullet">
        /// <item><description>Example 1: One instance for a canary release + Two subsequent batches + Automatic batching + 1-minute batch interval.</description></item>
        /// </list>
        /// <para><c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// <list type="bullet">
        /// <item><description>Example 2: One instance for a canary release + Two subsequent batches + Manual batching.</description></item>
        /// </list>
        /// <para><c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// <list type="bullet">
        /// <item><description>Example 3: Two batches + Automatic batching + 0-minute batch interval.</description></item>
        /// </list>
        /// <para><c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</para>
        /// </summary>
        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        /// <summary>
        /// <para>The URI encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter in the application configurations, the default URI encoding scheme in the Tomcat container is applied.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GBK</para>
        /// </summary>
        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the encoding scheme specified in the request body for URI query parameters.</para>
        /// <remarks>
        /// <para>If this parameter is not specified in application configuration, the default value false is applied.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>openjdk:8u302</para>
        /// </summary>
        [NameInMap("UserBaseImageUrl")]
        [Validation(Required=false)]
        public string UserBaseImageUrl { get; set; }

        /// <summary>
        /// <para>The data volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VolumesStr")]
        [Validation(Required=false)]
        public string VolumesStr { get; set; }

        /// <summary>
        /// <para>The version of the Tomcat container on which the deployment package of the application depends. This parameter is applicable to Spring Cloud and Dubbo applications that you deploy by using WAR packages. This parameter is unavailable if you deploy applications by using images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        /// <summary>
        /// <para>The Tomcat container configuration. If you want to cancel this configuration, set this parameter to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>useDefaultConfig: specifies whether to use the default configuration. Value true indicates to use the default configuration. Value false indicates to use the custom configuration. If the default configuration is used, the following parameters do not take effect.</para>
        /// </description></item>
        /// <item><description><para>contextInputType: the type of the access path for the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>war: The access path for the application is the name of the WAR package. You do not need to specify a custom path.</description></item>
        /// <item><description>root: The access path for the application is /. You do not need to specify a custom path.</description></item>
        /// <item><description>custom: If you select this option, you must specify a custom path for the contextPath parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>contextPath: the custom access path for the application. This parameter is required only when you set the contextInputType parameter to custom.</para>
        /// </description></item>
        /// <item><description><para>httpPort: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is less than 1024. Enter a value that ranges from 1025 to 65535 because the container has only the admin permissions. If you do not configure this parameter, the default port number 8080 is used.</para>
        /// </description></item>
        /// <item><description><para>maxThreads: the maximum number of connections in the connection pool. Default value: 400.</para>
        /// <para>**</para>
        /// <para><b>Note</b>This parameter greatly affects the application performance. We recommend that you set this parameter under professional guidance.</para>
        /// </description></item>
        /// <item><description><para>uriEncoding: the URI encoding scheme in the Tomcat container. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312. If you do not specify this parameter, the default value ISO-8859-1 is used.</para>
        /// </description></item>
        /// <item><description><para>useBodyEncoding: specifies whether to use the encoding scheme specified in the request body for URI query parameters.</para>
        /// </description></item>
        /// <item><description><para>useAdvancedServerXml: specifies whether to use advanced configurations to customize the <c>server.xml</c> file. If the preceding parameter types and specific parameters cannot meet your requirements, you can use advanced configurations to customize the <c>server.xml</c> file of Tomcat.</para>
        /// </description></item>
        /// <item><description><para>serverXml: the content of the <c>server.xml</c> file customized by using advanced configurations. This parameter takes effect only when you set the useAdvancedServerXml parameter to true.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;useDefaultConfig&quot;:false,&quot;contextInputType&quot;:&quot;custom&quot;,&quot;contextPath&quot;:&quot;hello&quot;,&quot;httpPort&quot;:8088,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;UTF-8&quot;,&quot;useBodyEncoding&quot;:true,&quot;useAdvancedServerXml&quot;:false}</para>
        /// </summary>
        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public string WebContainerConfig { get; set; }

    }

}
