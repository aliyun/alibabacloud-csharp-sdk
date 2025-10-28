// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class StartK8sAppPrecheckRequest : TeaModel {
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
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af58edcf-f7eb-<b><b>-</b></b>-db4e425f****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 36 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testapp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c37aec2a-bcca-4ec1-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the application component. You can call the ListComponents operation to query application components. This parameter must be specified when the application runs in Apache Tomcat or in a standard Java application runtime environment. The Apache Tomcat application runtime environment is applicable to Dubbo applications that are deployed by using WAR packages. A standard Java application runtime environment is applicable to Spring Boot or Spring Cloud applications that are deployed by using JAR packages.</para>
        /// <para>Valid values for regular application component IDs:</para>
        /// <list type="bullet">
        /// <item><description>4: Apache Tomcat 7.0.91</description></item>
        /// <item><description>5: OpenJDK 1.8.x</description></item>
        /// <item><description>6: OpenJDK 1.7.x</description></item>
        /// <item><description>7: Apache Tomcat 8.5.42</description></item>
        /// </list>
        /// <para>This parameter is available only for Java SDK 2.57.3 or later, or Python SDK 2.57.3 or later. Assume that you use an SDK that is not provided by Enterprise Distributed Application Service (EDAS), such as aliyun-python-sdk-core, aliyun-java-sdk-core, and Alibaba Cloud CLI. In this case, you can directly specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

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
        /// <para>The configuration for mounting a Kubernetes emptyDir volume to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>mountPath: The mount path in the container. This parameter is required.</description></item>
        /// <item><description>readOnly: (Optional) The mount mode. The value true indicates the read-only mode. The value false indicates the read and write mode. Default value: false.</description></item>
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
        /// <para>The Kubernetes environment variables that are configured in EnvFrom mode. A ConfigMap or Secret is mounted to a directory. Each key corresponds to a file in the directory, and the content of the file is the value of the key.</para>
        /// <para>The following parameters are included in the configuration of the EnvFroms parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>configMapRef: the ConfigMap that is referenced. The following parameter is included:</para>
        /// <para>name: the name of the ConfigMap.</para>
        /// </description></item>
        /// <item><description><para>secretRef: the Secret that is referenced. The following parameter is included:</para>
        /// <para>name: the name of the Secret.</para>
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
        /// <para>The environment variables that are used to deploy the application. The value must be a JSON array. Valid values: regular environment variables, Kubernetes ConfigMap environment variables, and Kubernetes Secret environment variables. Specify regular environment variables in the following format:</para>
        /// <para><c>{&quot;name&quot;:&quot;x&quot;, &quot;value&quot;: &quot;y&quot;}</c></para>
        /// <para>Specify Kubernetes ConfigMap environment variables in the following format to reference values from ConfigMaps:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x2&quot;, &quot;valueFrom&quot;: { &quot;configMapKeyRef&quot;: { &quot;name&quot;: &quot;my-config&quot;, &quot;key&quot;: &quot;y2&quot; } } }</c></para>
        /// <para>Specify Kubernetes Secret environment variables in the following format to reference values from Secrets:</para>
        /// <para><c>{ &quot;name&quot;: &quot;x3&quot;, &quot;valueFrom&quot;: { &quot;secretKeyRef&quot;: { &quot;name&quot;: &quot;my-secret&quot;, &quot;key&quot;: &quot;y3&quot; } } }</c></para>
        /// <remarks>
        /// <para>If you want to cancel this configuration, set this parameter to an empty JSON array, which is in the format of &quot;[]&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;x1&quot;,&quot;value&quot;:&quot;y1&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;valueFrom&quot;:{&quot;configMapKeyRef&quot;:{&quot;name&quot;:&quot;my-config&quot;,&quot;key&quot;:&quot;y2&quot;}}},{&quot;name&quot;:&quot;x3&quot;,&quot;valueFrom&quot;:{&quot;secretKeyRef&quot;:{&quot;name&quot;:&quot;my-secret&quot;,&quot;key&quot;:&quot;y3&quot;}}}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/mw/testapp:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The configuration of Java startup parameters for a Java application. These startup parameters involve the memory, application, garbage collection (GC) policy, tools, service registration and discovery, and custom configurations. Proper parameter settings help reduce the GC overheads, shorten the server response time, and improve the throughput. Set this parameter to a JSON string. In the example, original indicates the configuration value, and startup indicates a startup parameter. The system automatically concatenates all startup values as the settings of Java startup parameters for the application. To delete this configuration, leave the parameter value empty by entering <c>&quot;&quot;</c> or <c>&quot;{}&quot;</c>. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description>InitialHeapSize: the initial size of the heap memory.</description></item>
        /// <item><description>MaxHeapSize: the maximum size of the heap memory.</description></item>
        /// <item><description>CustomParams: the custom parameters, such as JVM -D parameters.</description></item>
        /// <item><description>Other parameters: You can view the JSON structure submitted by the frontend.</description></item>
        /// </list>
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
        /// <para>The maximum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitEphemeralStorage")]
        [Validation(Required=false)]
        public int? LimitEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is running. Unit: MB. The value of LimitMem must be greater than or equal to that of RequestsMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public int? LimitMem { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is running. Unit: millicores. The value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("LimitmCpu")]
        [Validation(Required=false)]
        public int? LimitmCpu { get; set; }

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
        /// <para>The namespace of the Kubernetes cluster. This parameter specifies the Kubernetes namespace in which your application is deployed. By default, the default namespace is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The URL of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a Kubernetes PersistentVolumeClaim (PVC) to a directory in an elastic container instance. The following parameters are included in the configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>pvcName: the name of the PVC. Make sure that the volume exists and is in the Bound state.</para>
        /// </description></item>
        /// <item><description><para>mountPaths: the directory to which you want to mount the PVC. You can configure multiple directories. You can set the following two parameters for each mount directory:</para>
        /// <list type="bullet">
        /// <item><description>mountPath: the mount path. The mount path must be an absolute path that starts with a forward slash (/).</description></item>
        /// <item><description>readOnly: the mount mode. The value true indicates the read-only mode. The value false indicates the read and write mode. Default value: false.</description></item>
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
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of application instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The minimum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RequestsEphemeralStorage")]
        [Validation(Required=false)]
        public int? RequestsEphemeralStorage { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is created. Unit: MB. The value 0 indicates that no limit is set on the memory size. The value of RequestsMem cannot be greater than that of LimitMem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
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

    }

}
