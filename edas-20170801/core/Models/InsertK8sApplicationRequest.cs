// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertK8sApplicationRequest : TeaModel {
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
        /// <para>The application configuration when the application template is used. Set this parameter to a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// <para>The name of the application. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The name of the template used to create the application. If you specify an application template when you create an application, the application template and the AppConfig parameter are used to configure the application. Other configurations are ignored.</para>
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
        /// <para>Application in the production environment</para>
        /// </summary>
        [NameInMap("ApplicationDescription")]
        [Validation(Required=false)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// <para>The version of <c>EDAS Container</c>. The value of this parameter conflicts with that of the <c>EdasContainerVersion</c> parameter. We recommend that you use the <c>EdasContainerVersion</c> parameter.</para>
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
        /// <para>The application startup command. If you specify this parameter, the value of this parameter will replace the startup command in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments in the command. The parameter value is a JSON array of strings. An example is <c>[{&quot;argument&quot;:&quot;-c&quot;},{&quot;argument&quot;:&quot;test&quot;}]</c>, where <c>-c</c> and <c>test</c> are two arguments that can be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;argument&quot;:&quot;-lh&quot;}]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes ConfigMap or Secret to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>name: the name of the Kubernetes ConfigMap or Secret.</description></item>
        /// <item><description>type: the type of the API object that you want to mount. You can mount a Kubernetes ConfigMap or Secret.</description></item>
        /// <item><description>mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;nginx-config&quot;,&quot;type&quot;:&quot;ConfigMap&quot;,&quot;mountPath&quot;:&quot;/etc/nginx&quot;},{&quot;name&quot;:&quot;tls-secret&quot;,&quot;type&quot;:&quot;secret&quot;,&quot;mountPath&quot;:&quot;/etc/ssh&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public string ConfigMountDescs { get; set; }

        /// <summary>
        /// <para>The ID of the repository used to build the image repository. If this parameter is left empty, the default repository provided by EDAS is used. Only the default repository provided by EDAS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Leave empty</para>
        /// </summary>
        [NameInMap("ContainerRegistryId")]
        [Validation(Required=false)]
        public string ContainerRegistryId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. This parameter is required only when you create the application in a cluster that has not been imported.</para>
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

        [NameInMap("CustomAgentVersion")]
        [Validation(Required=false)]
        public string CustomAgentVersion { get; set; }

        /// <summary>
        /// <para>The custom tolerances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances across nodes. Value <c>true</c> indicates that application instances are distributed across nodes. Other values indicate that application instances are not distributed across nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to distribute application instances across zones. Value <c>true</c> indicates that application instances are distributed across zones. Other values indicate that application instances are not distributed across zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        /// <summary>
        /// <para>The version of <c>EDAS Container</c> on which the deployment package of the application depends.</para>
        /// <remarks>
        /// <para>This parameter is unavailable if you deploy applications by using images.</para>
        /// </remarks>
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
        /// <para>Specifies whether to enable access to Application High Availability Service (AHAS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables access to AHAS.</description></item>
        /// <item><description>false: does not enable access to AHAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// <para>Specifies whether to activate Alibaba Cloud Service Mesh (ASM). Set this parameter to true only when you create the application in a cluster that has not been imported and you need to use ASM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

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
        /// <para>The following parameters are included in the configuration:</para>
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
        /// <para>The environment variables that are used to deploy the application. The value must be a JSON array. Valid values: regular environment variables, Kubernetes ConfigMap environment variables, or Kubernetes Secret environment variables. Specify regular environment variables in the following format:</para>
        /// <para><c>{&quot;name&quot;:&quot;x&quot;, &quot;value&quot;: &quot;y&quot;}</c></para>
        /// <para>Specify Kubernetes ConfigMap environment variables in the following format to reference values from ConfigMaps:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x2&quot;, &quot;valueFrom&quot;: { &quot;configMapKeyRef&quot;: { &quot;name&quot;: &quot;my-config&quot;, &quot;key&quot;: &quot;y2&quot; } } }</c></para>
        /// <para>Specify Kubernetes Secret environment variables in the following format to reference values from Secrets:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x3&quot;, &quot;valueFrom&quot;: { &quot;secretKeyRef&quot;: { &quot;name&quot;: &quot;my-secret&quot;, &quot;key&quot;: &quot;y3&quot; } } }</c></para>
        /// <remarks>
        /// <para> If you want to cancel this configuration, set this parameter to an empty JSON array in the format of &quot;[]&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;x1&quot;,&quot;value&quot;:&quot;y1&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;my-config&quot;,&quot;key&quot;:&quot;y2&quot;}}},{&quot;name&quot;:&quot;x3&quot;,&quot;valueFrom&quot;:{&quot;secretKeyRef&quot;:{&quot;name&quot;:&quot;my-secret&quot;,&quot;key&quot;:&quot;y3&quot;}}}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("FeatureConfig")]
        [Validation(Required=false)]
        public string FeatureConfig { get; set; }

        /// <summary>
        /// <para>Mirror the target platform architecture, which is effective when deployed using war or jar. Enter an example:</para>
        /// <list type="bullet">
        /// <item><description>Specify x86 64 architecture: Linux/amd64</description></item>
        /// <item><description>Specify ARM 64 architecture: Linux/arm64</description></item>
        /// <item><description>Specify the construction of dual architecture images: Linux/amd64, Linux/arm64</description></item>
        /// <item><description>Do not input: default schema</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ImagePlatforms")]
        [Validation(Required=false)]
        public string ImagePlatforms { get; set; }

        /// <summary>
        /// <para>The URL of the image. This parameter is required if you set the <c>PackageType</c> parameter to <c>Image</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-beijing.aliyuncs.com/<b><b>_test/</b></b>-cons****:1.0</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Set the initialization container for the application Pod. Support setting the format YAML for container configuration, which is the value of Init container YAML configured with base64 encoding.</para>
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
        /// <para>The ID of the Internet-facing SLB instance. If you do not specify this parameter, EDAS automatically purchases a new SLB instance for you.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3d4********</para>
        /// </summary>
        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        /// <summary>
        /// <para>The frontend port of the Internet-facing SLB instance. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("InternetSlbPort")]
        [Validation(Required=false)]
        public int? InternetSlbPort { get; set; }

        /// <summary>
        /// <para>The protocol used by the Internet-facing SLB instance. Valid values: TCP, HTTP, and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("InternetSlbProtocol")]
        [Validation(Required=false)]
        public string InternetSlbProtocol { get; set; }

        /// <summary>
        /// <para>The backend port of the internal-facing SLB instance. This port also serves as the service port of the application. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("InternetTargetPort")]
        [Validation(Required=false)]
        public int? InternetTargetPort { get; set; }

        /// <summary>
        /// <para>The ID of the internal-facing SLB instance. If you do not specify this parameter, Enterprise Distributed Application Service (EDAS) automatically purchases a new SLB instance for you.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae93********</para>
        /// </summary>
        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

        /// <summary>
        /// <para>The frontend port of the internal-facing SLB instance. Valid values: 1 to 65535.</para>
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
        /// <para>The backend port of the internal-facing Server Load Balancer (SLB) instance. This port also serves as the service port of the application. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("IntranetTargetPort")]
        [Validation(Required=false)]
        public int? IntranetTargetPort { get; set; }

        /// <summary>
        /// <para>Specifies whether the application is a multi-language application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        /// <summary>
        /// <para>The version of the Java Development Kit (JDK) on which the deployment package of the application depends. Valid values: Open JDK 7 and Open JDK 8. This parameter is unavailable if you deploy applications by using images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open JDK 8</para>
        /// </summary>
        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        /// <summary>
        /// <para>The configuration of Java startup parameters for a Java application. These startup parameters involve the memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom configurations. Appropriate parameter settings help reduce the GC overheads, shorten the server response time, and improve the throughput. Set this parameter to a JSON string. In the example, original indicates the configuration value, and startup indicates a startup parameter. The system automatically concatenates all startup values as the settings of Java startup parameters for the application. To delete this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>InitialHeapSize: the initial size of the heap memory.</description></item>
        /// <item><description>MaxHeapSize: the maximum size of the heap memory.</description></item>
        /// <item><description>CustomParams: the custom parameters, such as JVM -D parameters.</description></item>
        /// <item><description>Other parameters: You can view the JSON structure submitted by the frontend.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InitialHeapSize&quot;:{&quot;original&quot;:512,&quot;startup&quot;:&quot;-Xms512m&quot;},&quot;MaxHeapSize&quot;:{&quot;original&quot;:1024,&quot;startup&quot;:&quot;-Xmx1024m&quot;},&quot;CustomParams&quot;:{&quot;original&quot;:&quot;-Dcustom.property.sample=false&quot;,&quot;startup&quot;:&quot;-Dcustom.property.sample=false&quot;}}</para>
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
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is running. Unit: cores. If the LimitmCpu parameter is specified, you can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public int? LimitCpu { get; set; }

        /// <summary>
        /// <para>The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is running. Unit: MB. The value of LimitMem must be greater than that of RequestsMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public int? LimitMem { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is running. Unit: millicores. Value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("LimitmCpu")]
        [Validation(Required=false)]
        public int? LimitmCpu { get; set; }

        /// <summary>
        /// <para>The configuration for the liveness check on the container. Example: <c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>.</para>
        /// <para>If you want to cancel this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The configurations that are used when the host files are mounted to the container on which the application is running. Example: <c>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}\\]</c>. Description:</para>
        /// <list type="bullet">
        /// <item><description><c>nodePath</c>: the host path.</description></item>
        /// <item><description><c>mountPath</c>: the path in the container.</description></item>
        /// <item><description><c>type</c>: the mounting type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/localfiles&quot;,&quot;mountPath&quot;:&quot;/app/files&quot;},{&quot;type&quot;:&quot;Directory&quot;,&quot;nodePath&quot;:&quot;/mnt&quot;,&quot;mountPath&quot;:&quot;/app/storage&quot;}]</para>
        /// </summary>
        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        /// <summary>
        /// <para>The ID of the EDAS namespace. This parameter is required for a non-default namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen:beta****</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode and ensure that the service is registered before the readiness check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: provides port 55199 and the /health path for the health check in a non-intrusive manner. When the service is registered, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.</para>
        /// <para>**</para>
        /// <para><b>Note</b>If you set both the <c>LosslessRuleRelated</c> parameter and this parameter to <c>true</c>, the operation checks whether the service prefetching is complete.</para>
        /// </description></item>
        /// <item><description><para>false: does not check whether the service is registered.</para>
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
        /// <para>The delay of service registration. Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LosslessRuleDelayTime")]
        [Validation(Required=false)]
        public int? LosslessRuleDelayTime { get; set; }

        /// <summary>
        /// <para>The number of prefetching curves. Valid values: 0 to 20. The default value is 2, which is suitable for common prefetching scenarios. This value indicates that the received traffic of the provider during prefetching is displayed as a quadratic curve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LosslessRuleFuncType")]
        [Validation(Required=false)]
        public int? LosslessRuleFuncType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the graceful rolling deployment mode and ensure that the service prefetching is complete before the readiness check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: provides port 55199 and the /health path for the health check in a non-intrusive manner. When the service prefetching is complete, the system returns HTTP 200 status code. Otherwise, the system returns HTTP 500 status code.</description></item>
        /// <item><description>false: does not check whether the service prefetching is complete.</description></item>
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
        /// <para>The description of the NAS mounting configuration. Set this parameter to a serialized JSON string. Example: <c>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}\\]</c>. The <c>nasPath</c> parameter specifies the file storage path, and the <c>mountPath</c> parameter specifies the path to mount the file system to the container where the application is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;nasPath&quot;: &quot;/k8s&quot;,&quot;mountPath&quot;: &quot;/mnt&quot;},{&quot;nasPath&quot;: &quot;/files&quot;,&quot;mountPath&quot;: &quot;/app/files&quot;}]</para>
        /// </summary>
        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        /// <summary>
        /// <para>The namespace of the Kubernetes cluster. This parameter specifies the Kubernetes namespace in which your application is deployed. By default, the default namespace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the Network Attached Storage (NAS) file system that you want to mount to the application. If you do not specify this parameter but specify the MountDescs parameter, a NAS file system is automatically purchased and mounted to the vSwitch in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs23****</para>
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// <para>The type of the deployment package. Valid values: FatJar, WAR, and Image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAR</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

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
        /// <para>The post-start script. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c>.</para>
        /// <para>If you want to cancel this configuration, leave this parameter empty by setting it to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The pre-stop script. Example: <c>{&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</c>.</para>
        /// <para>If you want to cancel this configuration, leave this parameter empty by setting it to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes PersistentVolumeClaim (PVC) volume to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>pvcName: the name of the PVC volume. Make sure that the PVC volume is an existing volume and is in the Bound state.</para>
        /// </description></item>
        /// <item><description><para>mountPaths: the directory to which you want to mount the PVC volume. You can configure multiple directories. You can set the following two parameters for each mount directory:</para>
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
        /// <para>The configuration for the readiness check on the container. If the check fails, the traffic that passes through the Kubernetes Service is not transmitted to the container. Example: \<c>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: \[{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}\\\\]}}\\</c>.``</para>
        /// <para>If you want to cancel this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
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
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is created. Unit: cores. Value 0 indicates that no limit is set on CPU cores. If the RequestsmCpu parameter is specified, the value of the RequestsmCpu parameter is used. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestsCpu")]
        [Validation(Required=false)]
        public int? RequestsCpu { get; set; }

        /// <summary>
        /// <para>The minimum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is created. Unit: MB. Value 0 indicates that no limit is set on the memory size. The value of RequestsMem cannot be greater than that of LimitMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestsMem")]
        [Validation(Required=false)]
        public int? RequestsMem { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is created. Unit: millicores.</para>
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
        /// <para>The name of the credential that is used to pull the images specified by the user. You must configure the Secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas-app-01-image-secret</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The configurations of services in a Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;test-svc-create&quot;,&quot;serviceType&quot;:&quot;ClusterIP&quot;,&quot;portMappings&quot;:[{&quot;servicePort&quot;: {&quot;targetPort&quot;:8080,&quot;port&quot;:80,&quot;protocol&quot;:&quot;TCP&quot;}}]}]</para>
        /// </summary>
        [NameInMap("ServiceConfigs")]
        [Validation(Required=false)]
        public string ServiceConfigs { get; set; }

        /// <summary>
        /// <para>Set up a Sidecar container for the application Pod. Support setting the format YAML for container configuration, which is the value of Sidecar container YAML configured with base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;yamlEncoded&quot;:&quot;Y29tbWFuZDoKICAtIHRhaWwKICAtICctZicKICAtIC9kZXYvbnVsbAppbWFnZTogJ2J1c3lib3g6bGF0ZXN0JwpuYW1lOiBidXN5Ym94Cg==&quot;}]</para>
        /// </summary>
        [NameInMap("Sidecars")]
        [Validation(Required=false)]
        public string Sidecars { get; set; }

        /// <summary>
        /// <para>The Logstore configuration. To delete this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>.</para>
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
        /// <item><description><para>LogDir: If the standard output type is used, the collection path is stdout.log. If the file type is used, the collection path is the path of the collected file. Wildcards (\*) are supported. The collection path must match the following regular expression: <c>^/(.+)/(.*)^/$</c>.</para>
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
        /// <para>The startup probe can be used to detect the viability of slow start containers, avoiding them from being killed before startup. The format is as follows: {&quot;FailureThreshold&quot;: 3, &quot;initialDelaySeconds&quot;: 5, &quot;SuccessThreshold&quot;: 1, &quot;timeoutSeconds&quot;: 1, &quot;https Get&quot;: {&quot;path&quot;: &quot;/consumer&quot;, &quot;port&quot;: 8080, &quot;scheme&quot;: &quot;HTTP&quot;, &quot;https Headers&quot;: [{&quot;name&quot;: &quot;test&quot;, &quot;value&quot;: &quot;testvalue&quot;}]}.</para>
        /// <para>If set to &quot;&quot; or {}, it means delete, and if not set, it means ignore.</para>
        /// 
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
        /// <item><description>Valid values for Extreme NAS file systems: Standard and Advance.</description></item>
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
        /// <para>Set the grace stop timeout for the application. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TerminateGracePeriod")]
        [Validation(Required=false)]
        public int? TerminateGracePeriod { get; set; }

        /// <summary>
        /// <para>The timeout period of the change process. Valid values: 1 to 1800. Unit: seconds. If you do not specify this Unidentifiedparameter, the default value 1800 is used.</para>
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
        /// <para>When using custom JDK runtime, it is necessary to configure the basic image address. The address needs to be publicly accessible, and the EDAS server will pull the image to build the application image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openjdk:8u302</para>
        /// </summary>
        [NameInMap("UserBaseImageUrl")]
        [Validation(Required=false)]
        public string UserBaseImageUrl { get; set; }

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
        /// <para>The configuration of the Tomcat container. If you want to cancel this configuration, set this parameter to &quot;&quot; or &quot;{}&quot;. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>useDefaultConfig: specifies whether to use the default configuration. Value true indicates that the default configuration is used. Value false indicates that the custom configuration is used. If the default configuration is used, the following parameters do not take effect:</para>
        /// </description></item>
        /// <item><description><para>contextInputType: the type of the access path for the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>war: The access path is the name of the WAR package. You do not need to specify a custom path.</description></item>
        /// <item><description>root: The access path for the application is <c>/</c>. You do not need to specify a custom path.</description></item>
        /// <item><description>custom: If you select this option, you must specify a custom path for the contextPath parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>contextPath: the custom access path for the application. This parameter is required only when you set the contextInputType parameter to custom.</para>
        /// </description></item>
        /// <item><description><para>httpPort: the port number. The port number ranges from 1024 to 65535. Though the admin permissions are configured for the container, the root permissions are required to perform operations on ports whose number is less than 1024. Enter a value that ranges from 1024 to 65535 because the container has only the admin permissions. If you do not configure this parameter, the default port number 8080 is used.</para>
        /// </description></item>
        /// <item><description><para>maxThreads: the maximum number of connections in the connection pool. Default value: 400.</para>
        /// <para>**</para>
        /// <para><b>Note</b>This parameter significantly affects application performance. We recommend that you consult with technical support before you set this parameter.</para>
        /// </description></item>
        /// <item><description><para>uriEncoding: the URI encoding scheme in the Tomcat container. Valid values: UTF-8, ISO-8859-1, GBK, and GB2312. If you do not specify this parameter, the default value ISO-8859-1 is used.</para>
        /// </description></item>
        /// <item><description><para>useBodyEncoding: specifies whether to use the encoding scheme specified in the request body for URI query parameters.</para>
        /// </description></item>
        /// <item><description><para>useAdvancedServerXml: specifies whether to use advanced configurations to customize the server.xml file. If the preceding parameter types and specific parameters cannot meet your requirements, you can use advanced configurations to customize the server.xml file of Tomcat.</para>
        /// </description></item>
        /// <item><description><para>serverXml: the content of the server.xml file customized by using advanced configurations. This parameter takes effect only when you set the useAdvancedServerXml parameter to true.</para>
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
        /// <para>The type of Workload when creating an application is currently only supported for the Deployment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployment</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
