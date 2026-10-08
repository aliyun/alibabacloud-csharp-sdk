// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The annotations for the application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;annotation-name-1&quot;:&quot;annotation-value-1&quot;,&quot;annotation-name-2&quot;:&quot;annotation-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>The application ID. Obtain the ID by calling the ListApplication operation. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e83acea6-****-47e1-96ae-c0e953772cdc</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The arguments for the container startup command. The value must be a JSON array of strings, such as <c>[&quot;Argument 1&quot;, &quot;Argument 2&quot;]</c>. To clear the arguments, set the parameter to an empty JSON array <c>&quot;[]&quot;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;args1&quot;,&quot;args2&quot;]</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// <para>The timeout period for a single batch release. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("BatchTimeout")]
        [Validation(Required=false)]
        public int? BatchTimeout { get; set; }

        /// <summary>
        /// <para>The minimum interval for a phased release of pods. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/controllers/deployment/#min-ready-seconds">minReadySeconds</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The build package number for EDAS Container:</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not need to change the EDAS Container version during deployment, you can leave this parameter unset.</para>
        /// </description></item>
        /// <item><description><para>To update the EDAS Container version of the target application during this deployment, you must set this parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>You can obtain the number in two ways:</para>
        /// <list type="bullet">
        /// <item><description><para>Call the ListBuildPack operation to query the list of container versions. For more information, see <a href="https://help.aliyun.com/document_detail/423222.html">ListBuildPack</a>.</para>
        /// </description></item>
        /// <item><description><para>Obtain it from the <b>Build Package Number</b> column in the <a href="https://help.aliyun.com/document_detail/92614.html">Version guide</a> table. For example, <c>59</c> indicates <c>EDAS Container 3.5.8</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public string BuildPackId { get; set; }

        /// <summary>
        /// <para>The ID of the canary release rule policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8daf22e-****-968c7ff2ea34</para>
        /// </summary>
        [NameInMap("CanaryRuleId")]
        [Validation(Required=false)]
        public string CanaryRuleId { get; set; }

        /// <summary>
        /// <para>The description of the change record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        /// <summary>
        /// <para>The container startup command.</para>
        /// <remarks>
        /// <para>To clear this configuration, set the parameter to an empty string <c>&quot;&quot;</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>Configures Kubernetes ConfigMap and Secret mounts. This lets you mount a ConfigMap or Secret to a specified container directory. The parameters for \<c>ConfigMountDescs\\</c> are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>name\\</c>: The name of the ConfigMap or Secret.</para>
        /// </description></item>
        /// <item><description><para>\<c>type\\</c>: The configuration type. \<c>ConfigMap\\</c> and \<c>Secret\\</c> are supported.</para>
        /// </description></item>
        /// <item><description><para>\<c>mountPath\\</c>: The mount path. An absolute path in the container that starts with a forward slash (/).</para>
        /// </description></item>
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
        /// <para>The CPU limit for the application instance during runtime. Unit: cores. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public int? CpuLimit { get; set; }

        /// <summary>
        /// <para>The CPU quota to request for the application instance during runtime. Setting this parameter is recommended.
        /// Unit: cores. A value of 0 means no limit.</para>
        /// <remarks>
        /// <para>If you set this parameter, also set the CpuLimit parameter. The value of CpuRequest must be less than or equal to the value of CpuLimit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public int? CpuRequest { get; set; }

        /// <summary>
        /// <para>The pod affinity configuration. This takes effect only when both \<c>DeployAcrossNodes\\</c> and \<c>DeployAcrossZones\\</c> are \<c>false\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodeAffinity&quot;:{&quot;requiredDuringSchedulingIgnoredDuringExecution&quot;:{&quot;nodeSelectorTerms&quot;:[{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;beta.kubernetes.io/arch&quot;,&quot;operator&quot;:&quot;NotIn&quot;,&quot;values&quot;:[&quot;arm64&quot;,&quot;arm32&quot;]}]}]},&quot;preferredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;weight&quot;:5,&quot;preference&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;kubernetes.io/os&quot;,&quot;operator&quot;:&quot;In&quot;,&quot;values&quot;:[&quot;linux&quot;]}]}}]},&quot;podAffinity&quot;:{&quot;requiredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;namespaces&quot;:[&quot;default&quot;],&quot;topologyKey&quot;:&quot;kubernetes.io/hostname&quot;,&quot;labelSelector&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;edas.oam.acname&quot;,&quot;operator&quot;:&quot;NotIn&quot;,&quot;values&quot;:[&quot;edas-test-app&quot;]}]}}]},&quot;podAntiAffinity&quot;:{&quot;preferredDuringSchedulingIgnoredDuringExecution&quot;:[{&quot;podAffinityTerm&quot;:{&quot;namespaces&quot;:[&quot;default&quot;],&quot;topologyKey&quot;:&quot;failure-domain.beta.kubernetes.io/zone&quot;,&quot;labelSelector&quot;:{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;edas.oam.acname&quot;,&quot;operator&quot;:&quot;In&quot;,&quot;values&quot;:[&quot;edas-test-app-2&quot;]}]}},&quot;weight&quot;:15}]}}</para>
        /// </summary>
        [NameInMap("CustomAffinity")]
        [Validation(Required=false)]
        public string CustomAffinity { get; set; }

        /// <summary>
        /// <para>Sets the version of the custom Application Real-Time Monitoring Service (ARMS) agent to mount to the application.</para>
        /// <remarks>
        /// <para>This feature is available only to whitelisted users. To use this feature, submit a ticket to be added to the whitelist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.1.4</para>
        /// </summary>
        [NameInMap("CustomAgentVersion")]
        [Validation(Required=false)]
        public string CustomAgentVersion { get; set; }

        /// <summary>
        /// <para>The pod scheduling toleration configuration. This takes effect only when both \<c>DeployAcrossNodes\\</c> and \<c>DeployAcrossZones\\</c> are \<c>false\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;edas-taint-key2&quot;,&quot;operator&quot;:&quot;Exists&quot;,&quot;effect&quot;:&quot;NoExecute&quot;,&quot;tolerationSeconds&quot;:50},{&quot;key&quot;:&quot;edas-taint-key&quot;,&quot;operator&quot;:&quot;Equal&quot;,&quot;value&quot;:&quot;edas-taint-value&quot;,&quot;effect&quot;:&quot;PreferNoSchedule&quot;}]</para>
        /// </summary>
        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances across multiple nodes. \<c>true\\</c> indicates yes, and other values indicate no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances across multiple zones. \<c>true\\</c> indicates yes, and other values indicate no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        /// <summary>
        /// <para>The EDAS Container version on which the deployment package depends. This parameter applies to HSF applications deployed using WAR packages. It is not supported for image-based deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.9</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>Configures Kubernetes \<c>emptyDir\\</c> mounts. This lets you mount an \<c>emptyDir\\</c> volume to a specified container directory. The parameters for \<c>EmptyDirs\\</c> are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>mountPath\\</c>: The container mount path. This is required.</para>
        /// </description></item>
        /// <item><description><para>\<c>readOnly\\</c>: Specifies whether the volume is read-only. Optional. \<c>true\\</c> for read-only, \<c>false\\</c> for read-write. The default is \<c>false\\</c>.</para>
        /// </description></item>
        /// <item><description><para>\<c>subPathExpr\\</c>: The subdirectory expression. Optional.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mountPath&quot;:&quot;/app-log&quot;,&quot;subPathExpr&quot;:&quot;$(POD_IP)&quot;},{&quot;readOnly&quot;:true,&quot;mountPath&quot;:&quot;/etc/nginx&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public string EmptyDirs { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect to Application High Availability Service (AHAS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable empty push protection:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>true\\</c>: Enable empty push protection.</para>
        /// </description></item>
        /// <item><description><para>\<c>false\\</c>: Do not enable empty push protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableEmptyPushReject")]
        [Validation(Required=false)]
        public bool? EnableEmptyPushReject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful start rule:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>true\\</c>: Enable the graceful start rule.</para>
        /// </description></item>
        /// <item><description><para>\<c>false\\</c>: Do not enable the graceful start rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLosslessRule")]
        [Validation(Required=false)]
        public bool? EnableLosslessRule { get; set; }

        /// <summary>
        /// <para>Configures environment variables of the Kubernetes \<c>EnvFrom\\</c> type. This mounts a specified ConfigMap or Secret to a directory. Each key corresponds to a file in the directory, and the file content is the value of the key.</para>
        /// <para>The parameters for \<c>EnvFroms\\</c> are as follows.</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>configMapRef\\</c>: A reference to a ConfigMap. This field includes the following parameter:</para>
        /// <list type="bullet">
        /// <item><description>\<c>name\\</c>: The name of the ConfigMap.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>\<c>secretRef\\</c>: A reference to a Secret. This field includes the following parameter:</para>
        /// <list type="bullet">
        /// <item><description>\<c>name\\</c>: The name of the Secret.</description></item>
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
        /// <para>The environment variables for the deployment. The value must be a JSON array of objects. Three types of environment variables are supported: regular, Kubernetes ConfigMap, and Kubernetes Secret. The format for a regular environment variable is as follows:</para>
        /// <para><c>{&quot;name&quot;:&quot;x&quot;, &quot;value&quot;: &quot;y&quot;}</c></para>
        /// <para>A ConfigMap environment variable injects the value of a specified key from a ConfigMap into the container\&quot;s environment variables. The format is as follows:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x2&quot;, &quot;valueFrom&quot;: { &quot;configMapKeyRef&quot;: { &quot;name&quot;: &quot;my-config&quot;, &quot;key&quot;: &quot;y2&quot; } } }</c></para>
        /// <para>A Secret environment variable injects the value of a specified key from a Secret into the container\&quot;s environment variables. The format is as follows:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x3&quot;, &quot;valueFrom&quot;: { &quot;secretKeyRef&quot;: { &quot;name&quot;: &quot;my-secret&quot;, &quot;key&quot;: &quot;y3&quot; } } }</c></para>
        /// <remarks>
        /// <para>To clear this configuration, set the parameter to an empty JSON array \<c>[]\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;x1&quot;,&quot;value&quot;:&quot;y1&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;my-config&quot;,&quot;key&quot;:&quot;y2&quot;}}},{&quot;name&quot;:&quot;x3&quot;,&quot;valueFrom&quot;:{&quot;secretKeyRef&quot;:{&quot;name&quot;:&quot;my-secret&quot;,&quot;key&quot;:&quot;y3&quot;}}}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The full URL of the image. This parameter overwrites the ImageTag parameter.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The target platform architecture for the image. This is valid when deploying with a WAR or JAR file. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>To specify the x86-64 architecture: \<c>linux/amd64\\</c></para>
        /// </description></item>
        /// <item><description><para>To specify the ARM 64 architecture: \<c>linux/arm64\\</c></para>
        /// </description></item>
        /// <item><description><para>To build a dual-architecture image: \<c>linux/amd64,linux/arm64\\</c></para>
        /// </description></item>
        /// <item><description><para>If you do not enter a value, the default architecture is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux/arm64,linux/amd64</para>
        /// </summary>
        [NameInMap("ImagePlatforms")]
        [Validation(Required=false)]
        public string ImagePlatforms { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>Sets an init container for the application pod. The container configuration is in YAML format. The value is the base64-encoded YAML configuration of the init container.</para>
        /// 
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
        /// <para>The JDK version on which the deployment package depends. Valid values: Open JDK 7, Open JDK 8, or Custom OpenJDK. This parameter is not supported for image-based deployments. If you use Custom OpenJDK, you must also configure the \<c>UserBaseImageUrl\\</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        /// <summary>
        /// <para>The Java startup parameters. You can configure memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom settings. Correctly configuring these parameters helps reduce GC overhead, shorten server response time, and improve throughput. The parameter is a JSON string. \<c>original\\</c> is the configuration value, and \<c>startup\\</c> is the startup parameter. The system automatically concatenates all \<c>startup\\</c> values as the Java startup parameters for the application. Set to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c> to delete the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InitialHeapSize&quot;:{&quot;original&quot;:512,&quot;startup&quot;:&quot;-Xms512m&quot;},&quot;MaxHeapSize&quot;:{&quot;original&quot;:1024,&quot;startup&quot;:&quot;-Xmx1024m&quot;}}</para>
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        /// <summary>
        /// <para>The labels for the application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;label-name-1&quot;:&quot;label-value-1&quot;,&quot;label-name-2&quot;:&quot;label-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The upper limit of the temporary storage resource requirement. Unit: GB. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The liveness probe for the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>. To delete this configuration, set the parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, the configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a host file to a container. Example: <c>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</c>. In this example, \<c>nodePath\\</c> is the host path, \<c>mountPath\\</c> is the path in the container, and \<c>type\\</c> is the mount type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</para>
        /// </summary>
        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode to complete service registration before the readiness probe succeeds:</para>
        /// <list type="bullet">
        /// <item><description>\<c>true\\</c>: This switch provides a health check for the application on port 55199 and the \<c>/health\\</c> path without intrusion. When service registration is complete, the interface returns 200. Otherwise, it returns 500.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If \<c>LosslessRuleRelated\\</c> is also set to \<c>true\\</c>, this interface checks whether service prefetch is complete.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>\<c>false\\</c>: Does not provide an interface for the application to check if service registration is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LosslessRuleAligned")]
        [Validation(Required=false)]
        public bool? LosslessRuleAligned { get; set; }

        /// <summary>
        /// <para>The service registration latency. Unit: seconds. The value ranges from 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LosslessRuleDelayTime")]
        [Validation(Required=false)]
        public int? LosslessRuleDelayTime { get; set; }

        /// <summary>
        /// <para>The service prefetch curve. The value ranges from 0 to 20. The default is 2, which is suitable for general prefetch scenarios. This indicates that the traffic receiving curve of the service provider follows a quadratic curve during the prefetch period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LosslessRuleFuncType")]
        [Validation(Required=false)]
        public int? LosslessRuleFuncType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode to complete service prefetch before the readiness probe succeeds:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>true\\</c>: This switch provides a health check for the application on port 55199 and the \<c>/health\\</c> path without intrusion. When service prefetch is complete, the interface returns 200. Otherwise, it returns 500.</para>
        /// </description></item>
        /// <item><description><para>\<c>false\\</c>: Does not provide an interface for the application to check if service prefetch is complete.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LosslessRuleRelated")]
        [Validation(Required=false)]
        public bool? LosslessRuleRelated { get; set; }

        /// <summary>
        /// <para>The service prefetch duration. Unit: seconds. The value ranges from 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("LosslessRuleWarmupTime")]
        [Validation(Required=false)]
        public int? LosslessRuleWarmupTime { get; set; }

        /// <summary>
        /// <para>The maximum CPU that can be used. Unit: cores. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public int? McpuLimit { get; set; }

        /// <summary>
        /// <para>The minimum CPU resource requirement. Unit: cores. A value of 0 means no limit.</para>
        /// <remarks>
        /// <para>If you set this parameter, you must also set the \<c>CpuLimit\\</c> parameter. The value must be less than or equal to the value of \<c>CpuLimit\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public int? McpuRequest { get; set; }

        /// <summary>
        /// <para>The memory limit for the application instance during runtime. Unit: MB. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public int? MemoryLimit { get; set; }

        /// <summary>
        /// <para>The memory quota to request for the application instance during runtime. Setting this parameter is recommended. Unit: MB. A value of 0 means no request.</para>
        /// <remarks>
        /// <para>If you set this parameter, also set the MemoryLimit parameter. The value of MemoryRequest must be less than or equal to the value of MemoryLimit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public int? MemoryRequest { get; set; }

        /// <summary>
        /// <para>The mount configurations, which are a serialized JSON string. Example: <c>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</c>. In this example, \<c>nasPath\\</c> is the file storage path and \<c>mountPath\\</c> is the path in the container to which the file system is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</para>
        /// </summary>
        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        /// <summary>
        /// <para>The ID of the Apsara File Storage NAS (NAS) file system to mount. The NAS file system must be in the same region as the cluster. It must have an available mount target quota, or its mount target must be on a vSwitch in the VPC. If you do not set this parameter but the \<c>mountDescs\\</c> field exists, a NAS file system is automatically purchased and mounted to a vSwitch in the VPC by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs23****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The URL of the deployment package. Configure this parameter for applications deployed using a FatJar or WAR package.</para>
        /// <remarks>
        /// <para>The Java or Python SDK for EDAS POP API must be version 2.44.0 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The version number of the deployment package. This parameter is required for WAR and FatJar packages. You can define the meaning of the version number.</para>
        /// <remarks>
        /// <para>The Java or Python SDK for EDAS POP API must be version 2.44.0 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20200720</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The ID of the deployment package version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2bcc********</para>
        /// </summary>
        [NameInMap("PackageVersionId")]
        [Validation(Required=false)]
        public string PackageVersionId { get; set; }

        /// <summary>
        /// <para>The script to execute after the container starts. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c>. To delete this configuration, set the parameter to <c>{}</c>. If you do not set this parameter, the configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;exec&quot;:{
        ///         &quot;command&quot;:[
        ///             &quot;ls&quot;,
        ///             &quot;/&quot;
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script to execute before stopping the container. Example: <c>{&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>.
        /// To delete this configuration, set the parameter to <c>{}</c>. If you do not set this parameter, the configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;exec&quot;:{
        ///         &quot;command&quot;:[
        ///             &quot;ls&quot;,
        ///             &quot;/&quot;
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>Configures Kubernetes PersistentVolumeClaim (PVC) mounts. This lets you mount a Kubernetes PVC volume to a specified container directory. The parameters for \<c>PvcMountDescs\\</c> are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>pvcName\\</c>: The name of the PVC volume. The PVC volume must already exist and be in the Bound state.</para>
        /// </description></item>
        /// <item><description><para>\<c>mountPaths\\</c>: A list of mount directories. You can configure multiple mount directories. Each mount directory supports the following two parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>mountPath\\</c>: The mount path. An absolute path in the container that starts with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>\<c>readOnly\\</c>: The mount mode. \<c>true\\</c> for read-only, \<c>false\\</c> for read-write. The default is \<c>false\\</c>.</para>
        /// </description></item>
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
        /// <para>The readiness probe for the container. If the probe fails, traffic from the Kubernetes service is not routed to the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}</c>. To delete this configuration, set the parameter to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, the configuration is ignored.</para>
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
        /// <para>The minimum temporary storage resource requirement. Unit: GB. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The container runtime type:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>runc\\</c>: regular container runtime.</para>
        /// </description></item>
        /// <item><description><para>\<c>runv\\</c>: sandboxed container.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter applies only to clusters that use sandboxed containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>runc</para>
        /// </summary>
        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// <para>Sets the \<c>SecurityContext\\</c> property for the application pod container. The value is the base64-encoded YAML configuration of the \<c>SecurityContext\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;yamlEncoded&quot;:&quot;cnVuQXNVc2VyOiAwCnJ1bkFzR3JvdXA6IDA=&quot;}</para>
        /// </summary>
        [NameInMap("SecurityContext")]
        [Validation(Required=false)]
        public string SecurityContext { get; set; }

        /// <summary>
        /// <para>Sets a sidecar container for the application pod. The container configuration is in YAML format. The value is the base64-encoded YAML configuration of the sidecar container.</para>
        /// 
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
        /// <para>The Logstore configuration. Set to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c> to delete the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>Configs\\</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>type\\</c>: The collection type. \<c>file\\</c> for file type, \<c>stdout\\</c> for standard output type.</para>
        /// </description></item>
        /// <item><description><para>\<c>Logstore\\</c>: The name of the Logstore. Make sure the Logstore name is unique within the same cluster. The name must follow these rules:</para>
        /// <list type="bullet">
        /// <item><description><para>It can only contain lowercase letters, numbers, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start and end with a lowercase letter or a number.</para>
        /// </description></item>
        /// <item><description><para>The name must be 3 to 63 characters long. If left empty, the system generates a name automatically.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>\<c>LogDir\\</c>: If the type is standard output, the collection path is \<c>stdout.log\\</c>. If the type is file, this is the path of the file to collect. Wildcards are supported. The collection path must match the regular expression: <c>^/(.+)/(.*)^/$</c>.</para>
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
        /// <para>The startup probe can be used to perform liveness checks on slow-starting containers to prevent them from being killed before they are up and running. Example: {&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}.</para>
        /// <para>To delete this configuration, set the parameter to &quot;&quot; or {}. If you do not set this parameter, the configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Startup")]
        [Validation(Required=false)]
        public string Startup { get; set; }

        /// <summary>
        /// <para>The storage type of the NAS file system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose NAS: \<c>Capacity\\</c> and \<c>Performance\\</c></para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: \<c>standard\\</c> and \<c>advance\\</c></para>
        /// </description></item>
        /// </list>
        /// <para>Currently, only the \<c>Performance\\</c> type is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Performance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The graceful stop timeout period for the application. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TerminateGracePeriod")]
        [Validation(Required=false)]
        public int? TerminateGracePeriod { get; set; }

        /// <summary>
        /// <para>The traffic control policy for phased release.</para>
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
        /// <item><description><para>Example 1: Phased release with one canary instance, followed by two batches, automatic batching, and a 1-minute interval.
        /// <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Example 2: Phased release with one canary instance, followed by two batches and manual batching.
        /// <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
        /// </description></item>
        /// <item><description><para>Example 3: Phased release in two batches, with automatic batching and a 0-minute interval.
        /// <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</para>
        /// </summary>
        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        /// <summary>
        /// <para>The URI encoding format. Supported formats: ISO-8859-1, GBK, GB2312, and UTF-8.</para>
        /// <remarks>
        /// <para>If you do not set this parameter in the application configuration, the default Tomcat value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GBK</para>
        /// </summary>
        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable \<c>useBodyEncodingForURI\\</c>.</para>
        /// <remarks>
        /// <para>If you do not set this parameter in the application configuration, the default value \<c>false\\</c> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        /// <summary>
        /// <para>When using a custom JDK runtime, you must configure the base image address. This address must be publicly accessible. The EDAS server pulls this image to build the application image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openjdk:8u302</para>
        /// </summary>
        [NameInMap("UserBaseImageUrl")]
        [Validation(Required=false)]
        public string UserBaseImageUrl { get; set; }

        /// <summary>
        /// <para>The data volumes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VolumesStr")]
        [Validation(Required=false)]
        public string VolumesStr { get; set; }

        /// <summary>
        /// <para>The Tomcat version on which the deployment package depends. This parameter applies to Spring Cloud and Dubbo applications deployed using WAR packages. It is not supported for image-based deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        /// <summary>
        /// <para>The Tomcat container configuration. Set to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c> to delete the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>useDefaultConfig\\</c>: Specifies whether to use a custom configuration. If \<c>true\\</c>, the custom configuration is not used. If \<c>false\\</c>, the custom configuration is used. If you do not use a custom configuration, the following parameter settings do not take effect.</para>
        /// </description></item>
        /// <item><description><para>\<c>contextInputType\\</c>: The access path of the application.</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>war\\</c>: You do not need to enter a custom path. The access path is the name of the WAR package.</para>
        /// </description></item>
        /// <item><description><para>\<c>root\\</c>: You do not need to enter a custom path. The access path is \<c>/\\</c>.</para>
        /// </description></item>
        /// <item><description><para>\<c>custom\\</c>: You need to enter a custom path in the \<c>contextPath\\</c> parameter below.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>\<c>contextPath\\</c>: The custom path. This parameter is required only when \<c>contextInputType\\</c> is set to \<c>custom\\</c>.</para>
        /// </description></item>
        /// <item><description><para>\<c>httpPort\\</c>: The port number. The valid range is 1024 to 65535. Ports smaller than 1024 require root permissions. Because the container is configured with administrator permissions, specify a port number greater than 1024. If you do not configure this, the default port is 8080.</para>
        /// </description></item>
        /// <item><description><para>\<c>maxThreads\\</c>: The size of the connection pool. The default value is 400.</para>
        /// <remarks>
        /// <para>This configuration greatly affects application performance. Configure it under professional guidance.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>\<c>uriEncoding\\</c>: The encoding format for Tomcat. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312. If you do not set this, the default is ISO-8859-1.</para>
        /// </description></item>
        /// <item><description><para>\<c>useBodyEncoding\\</c>: Specifies whether to use BodyEncoding for URLs.</para>
        /// </description></item>
        /// <item><description><para>\<c>useAdvancedServerXml\\</c>: Specifies whether to use advanced configuration to customize the \<c>server.xml\\</c> file. If the preceding parameter types and values do not meet your needs, you can use the advanced settings to directly edit the Tomcat \<c>Server.xml\\</c> file.</para>
        /// </description></item>
        /// <item><description><para>\<c>serverXml\\</c>: The content of the custom \<c>server.xml\\</c> text file in the advanced configuration. This takes effect when \<c>useAdvancedServerXml\\</c> is \<c>true\\</c>.</para>
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
