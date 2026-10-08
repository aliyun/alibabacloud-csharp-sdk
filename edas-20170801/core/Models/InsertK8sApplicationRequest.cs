// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The annotations of the application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;annotation-name-1&quot;:&quot;annotation-value-1&quot;,&quot;annotation-name-2&quot;:&quot;annotation-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>The application configuration when an application template is used. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// <para>The name of the application. The name must start with a letter and can contain digits, letters, and hyphens (-). The name can be up to 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The name of the application template that is used to create the application. If you specify an application template when you create the application, the application template and the AppConfig parameter are preferentially used to determine the application configuration. Other configurations are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-template001</para>
        /// </summary>
        [NameInMap("AppTemplateName")]
        [Validation(Required=false)]
        public string AppTemplateName { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production Environment</para>
        /// </summary>
        [NameInMap("ApplicationDescription")]
        [Validation(Required=false)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// <para>The version of EDAS Container. This parameter conflicts with <c>EdasContainerVersion</c>. Use the <c>EdasContainerVersion</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public string BuildPackId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. You can call the ListCluster operation to query the cluster ID. For more information, see <a href="https://help.aliyun.com/document_detail/154995.html">ListCluster</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9cd****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The startup command of the application. If you set this parameter, the original startup command of the image is overridden.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments for the startup command. The arguments are a JSON array of strings. Example: <c>[{&quot;argument&quot;:&quot;-c&quot;},{&quot;argument&quot;:&quot;test&quot;}]</c>. In this example, <c>-c</c> and <c>test</c> are two arguments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;argument&quot;:&quot;-lh&quot;}]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The configuration for mounting Kubernetes ConfigMaps and Secrets. You can mount ConfigMaps and Secrets to specified directories in a container. The following parameters are included in ConfigMountDescs:</para>
        /// <list type="bullet">
        /// <item><description><para>name: The name of the ConfigMap or Secret.</para>
        /// </description></item>
        /// <item><description><para>type: The configuration type. Valid values: ConfigMap and Secret.</para>
        /// </description></item>
        /// <item><description><para>mountPath: The mount path. The path must be an absolute path that starts with a forward slash (/).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;nginx-config&quot;,&quot;type&quot;:&quot;ConfigMap&quot;,&quot;mountPath&quot;:&quot;/etc/nginx&quot;},{&quot;name&quot;:&quot;tls-secret&quot;,&quot;type&quot;:&quot;secret&quot;,&quot;mountPath&quot;:&quot;/etc/ssh&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public string ConfigMountDescs { get; set; }

        /// <summary>
        /// <para>The ID of the repository that is used to build the image repository. If you leave this parameter empty, the default repository provided by EDAS is used. Currently, only the default repository provided by EDAS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>leave empty</para>
        /// </summary>
        [NameInMap("ContainerRegistryId")]
        [Validation(Required=false)]
        public string ContainerRegistryId { get; set; }

        /// <summary>
        /// <para>You must specify CsClusterId only when you create an application in a cluster that has never been imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdefg</para>
        /// </summary>
        [NameInMap("CsClusterId")]
        [Validation(Required=false)]
        public string CsClusterId { get; set; }

        /// <summary>
        /// <para>The custom affinity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("CustomAffinity")]
        [Validation(Required=false)]
        public string CustomAffinity { get; set; }

        /// <summary>
        /// <para>The version of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.8.3,3.2.10,4.3.1</para>
        /// </summary>
        [NameInMap("CustomAgentVersion")]
        [Validation(Required=false)]
        public string CustomAgentVersion { get; set; }

        /// <summary>
        /// <para>The custom tolerations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances to multiple nodes. A value of <c>true</c> means yes. Other values mean no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances to multiple zones. A value of <c>true</c> means yes. Other values mean no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        /// <summary>
        /// <para>The version of the <c>EDAS-Container</c> on which the deployment package depends.</para>
        /// <remarks>
        /// <para>This parameter is not supported for image-based deployments.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.9</para>
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes emptyDir volume. You can mount an emptyDir volume to a specified directory in a container. The following parameters are included in EmptyDirs:</para>
        /// <list type="bullet">
        /// <item><description><para>mountPath: The mount path in the container. This parameter is required.</para>
        /// </description></item>
        /// <item><description><para>readOnly: Specifies whether the volume is read-only. This parameter is optional. true specifies read-only. false specifies read and write. Default value: false.</para>
        /// </description></item>
        /// <item><description><para>subPathExpr: The subdirectory expression. This parameter is optional.</para>
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
        /// <para>Specifies whether to enable Application High Availability Service (AHAS):</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable AHAS.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable AHAS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// <para>You must set this parameter to true only when you create an application in a cluster that has never been imported and enable Service Mesh (ASM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable protection against empty pushes:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable protection against empty pushes.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable protection against empty pushes.</para>
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
        /// <item><description><para>true: Enable the graceful start rule.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable the graceful start rule.</para>
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
        /// <para>The configuration for environment variables of the Kubernetes EnvFrom type. You can mount a specified ConfigMap or Secret to a specified directory. Each key corresponds to a file in the directory. The content of the file is the value of the key.</para>
        /// <para>The following parameters are included in EnvFroms:</para>
        /// <list type="bullet">
        /// <item><description><para>configMapRef: The reference to the ConfigMap. This field includes the following parameter:</para>
        /// <list type="bullet">
        /// <item><description>name: The name of the ConfigMap.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>secretRef: The reference to the Secret. This field includes the following parameter:</para>
        /// <list type="bullet">
        /// <item><description>name: The name of the Secret.</description></item>
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
        /// <para>The environment variables for the deployment. The value must be a JSON array of objects. Three types of environment variables are supported: regular environment variables, Kubernetes ConfigMap environment variables, and Kubernetes Secret environment variables. The format of a regular environment variable is as follows:</para>
        /// <para><c>{&quot;name&quot;:&quot;x&quot;, &quot;value&quot;: &quot;y&quot;}</c></para>
        /// <para>You can use a ConfigMap to inject the value of a specific key into a container\&quot;s environment variable. The format is as follows:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x2&quot;, &quot;valueFrom&quot;: { &quot;configMapKeyRef&quot;: { &quot;name&quot;: &quot;my-config&quot;, &quot;key&quot;: &quot;y2&quot; } } }</c></para>
        /// <para>You can use a Secret to inject the value of a specific key into a container\&quot;s environment variable. The format is as follows:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x3&quot;, &quot;valueFrom&quot;: { &quot;secretKeyRef&quot;: { &quot;name&quot;: &quot;my-secret&quot;, &quot;key&quot;: &quot;y3&quot; } } }</c></para>
        /// <remarks>
        /// <para>To clear this configuration, set the value to an empty JSON array ([]).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;x1&quot;,&quot;value&quot;:&quot;y1&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;my-config&quot;,&quot;key&quot;:&quot;y2&quot;}}},{&quot;name&quot;:&quot;x3&quot;,&quot;valueFrom&quot;:{&quot;secretKeyRef&quot;:{&quot;name&quot;:&quot;my-secret&quot;,&quot;key&quot;:&quot;y3&quot;}}}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The configuration of the custom monitoring and administration solution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;features&quot;:[{&quot;name&quot;:&quot;base.combination.arms&quot;,&quot;enable&quot;:true},{&quot;name&quot;:&quot;base.combination.mse&quot;,&quot;enable&quot;:true}]}</para>
        /// </summary>
        [NameInMap("FeatureConfig")]
        [Validation(Required=false)]
        public string FeatureConfig { get; set; }

        /// <summary>
        /// <para>The architecture of the image platform. This parameter is valid when you use a WAR or JAR package for deployment. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>To specify the x86-64 architecture, enter linux/amd64.</para>
        /// </description></item>
        /// <item><description><para>To specify the ARM64 architecture, enter linux/arm64.</para>
        /// </description></item>
        /// <item><description><para>To build a dual-architecture image, enter linux/amd64,linux/arm64.</para>
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
        /// <para>The address of the image. This parameter is required when you set <c>PackageType</c> to <c>Image</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-beijing.aliyuncs.com/<b><b>_test/</b></b>-cons****:1.0</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The init containers for the application pod. You can set the container configuration in the YAML format. The value is the Base64-encoded YAML configuration of the init container.</para>
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
        /// <para>The ID of the internet-facing SLB instance. If you do not specify this parameter, EDAS automatically purchases a new SLB instance for you.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3d4********</para>
        /// </summary>
        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        /// <summary>
        /// <para>The frontend port of the internet-facing SLB instance. The value must be in the range of 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("InternetSlbPort")]
        [Validation(Required=false)]
        public int? InternetSlbPort { get; set; }

        /// <summary>
        /// <para>The protocol used by the internet-facing SLB instance. Valid values: TCP, HTTP, and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("InternetSlbProtocol")]
        [Validation(Required=false)]
        public string InternetSlbProtocol { get; set; }

        /// <summary>
        /// <para>The backend port of the internal SLB instance, which also serves as the service port for the application. The port number must be an integer from 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("InternetTargetPort")]
        [Validation(Required=false)]
        public int? InternetTargetPort { get; set; }

        /// <summary>
        /// <para>The ID of the internal-facing SLB instance. If you do not specify this parameter, EDAS automatically purchases a new SLB instance for you.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae93********</para>
        /// </summary>
        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

        /// <summary>
        /// <para>The frontend port of the internal-facing SLB instance. The value must be in the range of 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("IntranetSlbPort")]
        [Validation(Required=false)]
        public int? IntranetSlbPort { get; set; }

        /// <summary>
        /// <para>The protocol used by the internal-facing SLB instance. Valid values: TCP, HTTP, and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IntranetSlbProtocol")]
        [Validation(Required=false)]
        public string IntranetSlbProtocol { get; set; }

        /// <summary>
        /// <para>The backend port of the internal-facing SLB instance. This is also the service port of the application. The value must be in the range of 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("IntranetTargetPort")]
        [Validation(Required=false)]
        public int? IntranetTargetPort { get; set; }

        /// <summary>
        /// <para>Specifies whether the application is a multilingual application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        /// <summary>
        /// <para>The version of the Java Development Kit (JDK) on which the deployment package depends. Valid values: Open JDK 7, Open JDK 8, and Custom OpenJDK. This parameter is not supported for image-based deployments. If you select Custom OpenJDK, you must also specify the UserBaseImageUrl parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        /// <summary>
        /// <para>The Java startup parameters. You can configure startup parameters for a Java application. You can configure memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom parameters. Proper parameter configuration helps reduce GC overhead, shorten server response time, and improve throughput. The value is a JSON string. original specifies the configuration value, and startup specifies the startup parameter. The system automatically concatenates all startup values as the Java startup parameters for the application. To clear the configuration, set the value to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>. The keys in the JSON string are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>InitialHeapSize: the initial heap size.</para>
        /// </description></item>
        /// <item><description><para>MaxHeapSize: the maximum heap size.</para>
        /// </description></item>
        /// <item><description><para>CustomParams: custom content, such as JVM -D parameters.</para>
        /// </description></item>
        /// <item><description><para>Other keys: You can view the JSON structure submitted by the frontend.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InitialHeapSize&quot;:{&quot;original&quot;:512,&quot;startup&quot;:&quot;-Xms512m&quot;},&quot;MaxHeapSize&quot;:{&quot;original&quot;:1024,&quot;startup&quot;:&quot;-Xmx1024m&quot;},&quot;CustomParams&quot;:{&quot;original&quot;:&quot;-Dcustom.property.sample=false&quot;,&quot;startup&quot;:&quot;-Dcustom.property.sample=false&quot;}}</para>
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        /// <summary>
        /// <para>The labels of the application pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;label-name-1&quot;:&quot;label-value-1&quot;,&quot;label-name-2&quot;:&quot;label-value-2&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that can be used by an application instance. If you specify LimitmCpu, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public int? LimitCpu { get; set; }

        /// <summary>
        /// <para>The maximum ephemeral storage. Unit: GB. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The maximum amount of memory that can be used by an application instance. Unit: MB. The value of LimitMem must be greater than or equal to the value of RequestsMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public int? LimitMem { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that can be used by an application instance. Unit: millicores. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("LimitmCpu")]
        [Validation(Required=false)]
        public int? LimitmCpu { get; set; }

        /// <summary>
        /// <para>The liveness probe of the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>.</para>
        /// <para>To clear this configuration, set the value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, it is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a host file to a container. Example: <c>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</c>. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><para><c>nodePath</c>: the path on the host.</para>
        /// </description></item>
        /// <item><description><para><c>mountPath</c>: the path in the container.</para>
        /// </description></item>
        /// <item><description><para><c>type</c>: the mount type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</para>
        /// </summary>
        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        /// <summary>
        /// <para>The ID of the EDAS namespace. This parameter is required if you want to use a non-default namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen:beta****</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode in which service registration is complete before the readiness probe is passed:</para>
        /// <list type="bullet">
        /// <item><description><para>true: A health check URL is provided for the application on port 55199. The path is /health. The URL returns 200 after the service is registered. Otherwise, the URL returns 500.</para>
        /// <remarks>
        /// <para>If you also set <c>LosslessRuleRelated</c> to <c>true</c>, this URL is used to check whether the service warm-up is complete.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: A URL is not provided for the application to check whether the service is registered.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LosslessRuleAligned")]
        [Validation(Required=false)]
        public bool? LosslessRuleAligned { get; set; }

        /// <summary>
        /// <para>The delay of service registration. Unit: seconds. The value must be in the range of 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LosslessRuleDelayTime")]
        [Validation(Required=false)]
        public int? LosslessRuleDelayTime { get; set; }

        /// <summary>
        /// <para>The warm-up curve of the service. The value must be in the range of 0 to 20. Default value: 2. This value is suitable for normal warm-up scenarios and indicates that the traffic that the service provider receives follows a quadratic curve during the warm-up period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LosslessRuleFuncType")]
        [Validation(Required=false)]
        public int? LosslessRuleFuncType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode in which service warm-up is complete before the readiness probe is passed:</para>
        /// <list type="bullet">
        /// <item><description><para>true: A health check URL is provided for the application on port 55199. The path is /health. The URL returns 200 after the service warm-up is complete. Otherwise, the URL returns 500.</para>
        /// </description></item>
        /// <item><description><para>false: A URL is not provided for the application to check whether the service warm-up is complete.</para>
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
        /// <para>The warm-up duration of the service. Unit: seconds. The value must be in the range of 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("LosslessRuleWarmupTime")]
        [Validation(Required=false)]
        public int? LosslessRuleWarmupTime { get; set; }

        /// <summary>
        /// <para>The description of the mount configuration. The value is a serialized JSON string. Example: <c>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</c>. <c>nasPath</c> specifies the file storage path. <c>mountPath</c> specifies the path to which the file system is mounted in the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</para>
        /// </summary>
        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        /// <summary>
        /// <para>The namespace of the Kubernetes cluster. This parameter determines the Kubernetes namespace in which your application is deployed. The default value is default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system that you want to mount. If you do not specify this parameter but mountDescs is specified, a new NAS file system is automatically purchased and mounted to a vSwitch in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs23****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The type of the application package. Valid values: FatJar, WAR, and Image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAR</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The URL of the deployment package. This parameter is required for applications that are deployed using a FatJar or WAR package.</para>
        /// <remarks>
        /// <para>The version of the EDAS POP API SDK for Java or Python must be 2.44.0 or later.</para>
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
        /// <para>The version of the EDAS POP API SDK for Java or Python must be 2.44.0 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20200720</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The script that is run after the container is started. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c>.</para>
        /// <para>To clear this configuration, set the value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, it is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The script that is run before the container is stopped. Example: <c>{&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>.</para>
        /// <para>To clear this configuration, set the value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, it is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes PersistentVolumeClaim (PVC). You can mount a Kubernetes PVC volume to a specified directory in a container. The following parameters are included in PvcMountDescs:</para>
        /// <list type="bullet">
        /// <item><description><para>pvcName: The name of the PVC volume. The PVC volume must exist and be in the Bound state.</para>
        /// </description></item>
        /// <item><description><para>mountPaths: The list of mount directories. You can configure multiple mount directories. Each mount directory supports two parameters.</para>
        /// <list type="bullet">
        /// <item><description><para>mountPath: The mount path. The path must be an absolute path that starts with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>readOnly: The mount mode. true specifies the read-only mode. false specifies the read and write mode. Default value: false.</para>
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
        /// <para>The readiness probe of the container. If the check fails, traffic is not routed to the container through the Kubernetes Service. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}</c>.</para>
        /// <para>To clear this configuration, set the value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not set this parameter, it is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>The number of application instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ced********</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested for an application instance upon creation. Unit: cores. A value of 0 means no limit. If you specify RequestsmCpu, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestsCpu")]
        [Validation(Required=false)]
        public int? RequestsCpu { get; set; }

        /// <summary>
        /// <para>The minimum ephemeral storage. Unit: GB. A value of 0 means no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The amount of memory requested for an application instance upon creation. Unit: MB. A value of 0 means no limit. The value of RequestsMem cannot be greater than the value of LimitMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestsMem")]
        [Validation(Required=false)]
        public int? RequestsMem { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested for an application instance upon creation. Unit: millicores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("RequestsmCpu")]
        [Validation(Required=false)]
        public int? RequestsmCpu { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>461</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the container runtime. This parameter is applicable only to clusters that use sandboxed containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>runc</para>
        /// </summary>
        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// <para>The name of the image pull secret. You must create the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas-app-01-image-secret</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The SecurityContext attribute for the application pod container. The value is the Base64-encoded YAML configuration of the SecurityContext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;yamlEncoded&quot;:&quot;cnVuQXNVc2VyOiAwCnJ1bkFzR3JvdXA6IDA=&quot;}</para>
        /// </summary>
        [NameInMap("SecurityContext")]
        [Validation(Required=false)]
        public string SecurityContext { get; set; }

        /// <summary>
        /// <para>The configuration of the Kubernetes Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;test-svc-create&quot;,&quot;serviceType&quot;:&quot;ClusterIP&quot;,&quot;portMappings&quot;:[{&quot;servicePort&quot;: {&quot;targetPort&quot;:8080,&quot;port&quot;:80,&quot;protocol&quot;:&quot;TCP&quot;}}]}]</para>
        /// </summary>
        [NameInMap("ServiceConfigs")]
        [Validation(Required=false)]
        public string ServiceConfigs { get; set; }

        /// <summary>
        /// <para>The sidecar containers for the application pod. You can set the container configuration in the YAML format. The value is the Base64-encoded YAML configuration of the sidecar container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;yamlEncoded&quot;:&quot;Y29tbWFuZDoKICAtIHRhaWwKICAtICctZicKICAtIC9kZXYvbnVsbAppbWFnZTogJ2J1c3lib3g6bGF0ZXN0JwpuYW1lOiBidXN5Ym94Cg==&quot;}]</para>
        /// </summary>
        [NameInMap("Sidecars")]
        [Validation(Required=false)]
        public string Sidecars { get; set; }

        /// <summary>
        /// <para>The Logstore configuration. To clear the configuration, set the value to <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>Configs:</para>
        /// <list type="bullet">
        /// <item><description><para>type: The collection type. file indicates the file type. stdout indicates the standard output type.</para>
        /// </description></item>
        /// <item><description><para>Logstore: The name of the Logstore. Make sure that the Logstore name is unique in the same cluster and meets the following naming conventions:</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The name must be 3 to 63 characters in length. If you leave this parameter empty, the system automatically generates a name.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>LogDir: If the collection type is standard output, the collection path is stdout.log. If the collection type is file, the collection path is the path of the file to be collected. Wildcards are supported. The collection path must match the following regular expression: <c>^/(.+)/(.*)^/$</c>.</para>
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
        /// <para>The startup probe. You can use a startup probe to check the liveness of a slow-start container and prevent the container from being killed before it is started. Example: {&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}]}}.</para>
        /// <para>To clear this configuration, set the value to &quot;&quot; or {}. If you do not set this parameter, it is ignored.</para>
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
        /// <item><description><para>General-purpose NAS file systems: Capacity and Performance</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS file systems: Standard and Advance</para>
        /// </description></item>
        /// </list>
        /// <para>Currently, only the Performance type is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Performance</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The timeout period for a graceful stop. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TerminateGracePeriod")]
        [Validation(Required=false)]
        public int? TerminateGracePeriod { get; set; }

        /// <summary>
        /// <para>The timeout period for the change process. Unit: seconds. The value must be in the range of 1 to 1800. If you do not specify this parameter, the default value 1800 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The URI encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.</para>
        /// <remarks>
        /// <para>If you do not set this parameter for the application, the default value of Tomcat is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GBK</para>
        /// </summary>
        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable useBodyEncodingForURI.</para>
        /// <remarks>
        /// <para>If you do not set this parameter for the application, the default value false is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        /// <summary>
        /// <para>If you use a custom JDK runtime, you must configure the address of the base image. The address must be accessible over the Internet. The EDAS server pulls the image to build an application image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openjdk:8u302</para>
        /// </summary>
        [NameInMap("UserBaseImageUrl")]
        [Validation(Required=false)]
        public string UserBaseImageUrl { get; set; }

        /// <summary>
        /// <para>The version of the Tomcat container on which the deployment package depends. This parameter is applicable to Spring Cloud and Dubbo applications that are deployed using a WAR package. This parameter is not supported for image-based deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apache-tomcat-7.0.91</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        /// <summary>
        /// <para>The configuration of the Tomcat container. To clear the configuration, set the value to &quot;&quot; or &quot;{}&quot;:</para>
        /// <list type="bullet">
        /// <item><description><para>useDefaultConfig: Specifies whether to use the default configuration. If you set this parameter to true, the custom configuration is not used. If you set this parameter to false, the custom configuration is used. If you do not use the custom configuration, the following parameter settings do not take effect.</para>
        /// </description></item>
        /// <item><description><para>contextInputType: The access path of the application.</para>
        /// <list type="bullet">
        /// <item><description><para>war: You do not need to specify a custom path. The access path is the name of the WAR package.</para>
        /// </description></item>
        /// <item><description><para>root: You do not need to specify a custom path. The access path is <c>/</c>.</para>
        /// </description></item>
        /// <item><description><para>custom: You must specify a custom path in the contextPath parameter.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>contextPath: The custom path. This parameter is required only when you set contextInputType to custom.</para>
        /// </description></item>
        /// <item><description><para>httpPort: The port number. The value must be in the range of 1024 to 65535. Ports smaller than 1024 require root permissions. Because the container is configured with administrator permissions, specify a port number greater than 1024. If you do not specify this parameter, the default port 8080 is used.</para>
        /// </description></item>
        /// <item><description><para>maxThreads: The maximum number of connections in the connection pool. Default value: 400.</para>
        /// <remarks>
        /// <para>This parameter greatly affects application performance. Configure this parameter with the help of a professional.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>uriEncoding: The encoding format for Tomcat. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312. If you do not specify this parameter, the default value ISO-8859-1 is used.</para>
        /// </description></item>
        /// <item><description><para>useBodyEncoding: Specifies whether to use BodyEncoding for URLs.</para>
        /// </description></item>
        /// <item><description><para>useAdvancedServerXml: Specifies whether to use advanced settings to customize the server.xml file. If the preceding parameter types and specific parameters cannot meet your requirements, you can use advanced settings to directly edit the server.xml file of Tomcat.</para>
        /// </description></item>
        /// <item><description><para>serverXml: The content of the server.xml file that is customized in the advanced settings. This parameter takes effect only when useAdvancedServerXml is set to true.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;useDefaultConfig&quot;:false,&quot;contextInputType&quot;:&quot;custom&quot;,&quot;contextPath&quot;:&quot;hello&quot;,&quot;httpPort&quot;:8088,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;UTF-8&quot;,&quot;useBodyEncoding&quot;:true,&quot;useAdvancedServerXml&quot;:false}</para>
        /// </summary>
        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public string WebContainerConfig { get; set; }

        /// <summary>
        /// <para>The type of the workload. Currently, only deployments are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployment</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
