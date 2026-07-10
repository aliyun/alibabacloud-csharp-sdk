// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: success.</description></item>
        /// <item><description><b>3xx</b>: redirection.</description></item>
        /// <item><description><b>4xx</b>: request error.</description></item>
        /// <item><description><b>5xx</b>: server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationConfigResponseBodyData Data { get; set; }
        public class DescribeApplicationConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ARN of the RAM role required for pulling images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/190675.html">Pull Alibaba Cloud images across accounts</a> and <a href="https://help.aliyun.com/document_detail/223585.html">Grant cross-account permissions by using RAM roles</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/adminrole</para>
            /// </summary>
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The ACR Enterprise instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-xxxxxx</para>
            /// </summary>
            [NameInMap("AcrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// <para>The agent version.</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>The ALB gateway ReadinessGate configuration.</para>
            /// </summary>
            [NameInMap("AlbIngressReadinessGate")]
            [Validation(Required=false)]
            public string AlbIngressReadinessGate { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample application</para>
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The SAE application type.</para>
            /// <list type="bullet">
            /// <item><description><para>micro_service</para>
            /// </description></item>
            /// <item><description><para>web</para>
            /// </description></item>
            /// <item><description><para>job</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>micro_service</para>
            /// </summary>
            [NameInMap("AppSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            /// <summary>
            /// <para>Specifies whether to associate an EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Associated.</description></item>
            /// <item><description><b>false</b>: Not associated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AssociateEip")]
            [Validation(Required=false)]
            public bool? AssociateEip { get; set; }

            /// <summary>
            /// <para>The ID of the baseline application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8c573618-8d72-4407-baf4-f7b64b******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <para>The wait time between batches during a phased release, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>495fc79c-ae61-4600-866d-a09d68******</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The CloudMonitor service ID.</para>
            /// </summary>
            [NameInMap("CmsServiceId")]
            [Validation(Required=false)]
            public string CmsServiceId { get; set; }

            /// <summary>
            /// <para>The image startup command. This command must be an executable object that exists in the container. Example:</para>
            /// <pre><c>command:
            ///       - echo
            ///       - abc
            ///       - &gt;
            ///       - file0
            /// </c></pre>
            /// <para>Based on the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The arguments for the image startup command. These are the arguments required by the startup command <b>Command</b>. Format:</para>
            /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
            /// <para>In the example for the <b>Command</b> parameter, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>, where <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to the String type and the internal format is a JSON array. If this parameter is not required, leave it empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// <para>The ConfigMap information.</para>
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// <para>ConfigMap ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// <para>The ConfigMap name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConfigMapName")]
                [Validation(Required=false)]
                public string ConfigMapName { get; set; }

                /// <summary>
                /// <para>The ConfigMap key-value pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The container mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// <para>The CPU required by each instance, in millicores. This value cannot be 0. Only the following defined specifications are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>500</b></description></item>
            /// <item><description><b>1000</b></description></item>
            /// <item><description><b>2000</b></description></item>
            /// <item><description><b>4000</b></description></item>
            /// <item><description><b>8000</b></description></item>
            /// <item><description><b>16000</b></description></item>
            /// <item><description><b>32000</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The custom host mapping in the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hostName</b>: The domain name or hostname.</description></item>
            /// <item><description><b>ip</b>: The IP address.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;hostName&quot;:&quot;test.host.name&quot;,&quot;ip&quot;:&quot;0.0.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }

            /// <summary>
            /// <para>The type of the custom image. If the image is not a custom image, set this parameter to an empty string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>internet: public image</description></item>
            /// <item><description>intranet: internal image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("CustomImageNetworkType")]
            [Validation(Required=false)]
            public string CustomImageNetworkType { get; set; }

            /// <summary>
            /// <para>The instance name of the application in the ASI cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-b0cdce9b-3d1f-4168-b206-b59f348f1a8a</para>
            /// </summary>
            [NameInMap("DeploymentName")]
            [Validation(Required=false)]
            public string DeploymentName { get; set; }

            /// <summary>
            /// <para>The disk storage size, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// <para>The .NET framework version:</para>
            /// <list type="bullet">
            /// <item><description>.NET 3.1</description></item>
            /// <item><description>.NET 5.0</description></item>
            /// <item><description>.NET 6.0</description></item>
            /// <item><description>.NET 7.0</description></item>
            /// <item><description>.NET 8.0</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>.NET 8.0</para>
            /// </summary>
            [NameInMap("Dotnet")]
            [Validation(Required=false)]
            public string Dotnet { get; set; }

            /// <summary>
            /// <para>The version of the application runtime environment in the HSF framework, such as the Ali-Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The shared temporary storage.</para>
            /// </summary>
            [NameInMap("EmptyDirDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataEmptyDirDesc> EmptyDirDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataEmptyDirDesc : TeaModel {
                /// <summary>
                /// <para>The mount path.</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The temporary storage name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to connect to Application High Availability Service (AHAS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Connected to AHAS.</description></item>
            /// <item><description><b>false</b>: Not connected to AHAS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAhas")]
            [Validation(Required=false)]
            public string EnableAhas { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the CPU Burst feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCpuBurst")]
            [Validation(Required=false)]
            public string EnableCpuBurst { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the traffic canary release rule. This rule applies only to applications that use the Spring Cloud and Dubbo frameworks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableGreyTagRoute")]
            [Validation(Required=false)]
            public bool? EnableGreyTagRoute { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable idle mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// <para>Indicates whether the namespace agent version configuration is reused.</para>
            /// </summary>
            [NameInMap("EnableNamespaceAgentVersion")]
            [Validation(Required=false)]
            public bool? EnableNamespaceAgentVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the new ARMS feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableNewArms")]
            [Validation(Required=false)]
            public bool? EnableNewArms { get; set; }

            /// <summary>
            /// <para>Indicates whether Prometheus custom metric collection is enabled.</para>
            /// </summary>
            [NameInMap("EnablePrometheus")]
            [Validation(Required=false)]
            public bool? EnablePrometheus { get; set; }

            /// <summary>
            /// <para>The container environment variable parameters. Custom values or references to configuration items are supported. To reference a configuration item, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Custom configuration<list type="bullet">
            /// <item><description><b>name</b>: The environment variable name.</description></item>
            /// <item><description><b>value</b>: The environment variable value.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Reference to a configuration item<list type="bullet">
            /// <item><description><b>name</b>: The environment variable name. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, such as <c>sae-sys-configmap-all-test1</c>.</description></item>
            /// <item><description><b>valueFrom</b>: The environment variable reference. Set the value to <c>configMapRef</c>.</description></item>
            /// <item><description><b>configMapId</b>: The ConfigMap ID.</description></item>
            /// <item><description><b>key</b>: The key. If all keys are referenced, do not set this field.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
            /// </summary>
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public string Envs { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public string GpuCount { get; set; }

            /// <summary>
            /// <para>The GPU type.</para>
            /// </summary>
            [NameInMap("GpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

            [NameInMap("HeadlessPvtzDiscovery")]
            [Validation(Required=false)]
            public string HeadlessPvtzDiscovery { get; set; }

            [NameInMap("Html")]
            [Validation(Required=false)]
            public string Html { get; set; }

            [NameInMap("IdleHour")]
            [Validation(Required=false)]
            public string IdleHour { get; set; }

            /// <summary>
            /// <para>The corresponding secret ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ImagePullSecrets")]
            [Validation(Required=false)]
            public string ImagePullSecrets { get; set; }

            /// <summary>
            /// <para>The image URL. This parameter is required when <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker.io/library/nginx:1.14.2</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The init container configuration.</para>
            /// </summary>
            [NameInMap("InitContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataInitContainersConfig> InitContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataInitContainersConfig : TeaModel {
                /// <summary>
                /// <para>The image startup command. This command must be an executable object that exists in the container. Example:</para>
                /// <pre><c>command:
                ///       - echo
                ///       - abc
                ///       - &gt;
                ///       - file0
                /// </c></pre>
                /// <para>Based on the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/bin/sh</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The arguments for the image startup command. These are the arguments required by the startup command <b>Command</b>. Format:</para>
                /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
                /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>, where <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to the String type and the internal format is a JSON array. If this parameter is not required, leave it empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
                /// </summary>
                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                /// <summary>
                /// <para>The ConfigMap information.</para>
                /// </summary>
                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc : TeaModel {
                    /// <summary>
                    /// <para>ConfigMap ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    /// <summary>
                    /// <para>The ConfigMap name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    /// <summary>
                    /// <para>The ConfigMap key-value pair.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The container mount path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tmp</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                }

                /// <summary>
                /// <para>The shared temporary storage.</para>
                /// </summary>
                [NameInMap("EmptyDirDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataInitContainersConfigEmptyDirDesc> EmptyDirDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataInitContainersConfigEmptyDirDesc : TeaModel {
                    /// <summary>
                    /// <para>The mount path of the data volume in the container.</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The temporary storage name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The container environment variable parameters. You can customize environment variables or reference ConfigMap instances. To reference a ConfigMap instance, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom configuration<list type="bullet">
                /// <item><description><b>name</b>: the name of the environment variable.</description></item>
                /// <item><description><b>value</b>: the value of the environment variable. This takes priority over valueFrom.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Reference a ConfigMap instance (valueFrom)<list type="bullet">
                /// <item><description><b>name</b>: the name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, such as <c>sae-sys-configmap-all-test1</c>.</description></item>
                /// <item><description><b>valueFrom</b>: the reference of the environment variable. Set the value to <c>configMapRef</c>.</description></item>
                /// <item><description><b>configMapId</b>: the ID of the ConfigMap instance.</description></item>
                /// <item><description><b>key</b>: the key. Do not set this field if you want to reference all keys.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Reference a secret (valueFrom)<list type="bullet">
                /// <item><description><b>name</b>: the name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-secret-all-&lt;secret name&gt;</c>, such as <c>sae-sys-secret-all-test1</c>.</description></item>
                /// <item><description><b>valueFrom</b>: the reference of the environment variable. Set the value to <c>secretRef</c>.</description></item>
                /// <item><description><b>secretId</b>: the ID of the secret.</description></item>
                /// <item><description><b>key</b>: the key. Do not set this field if you want to reference all keys.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
                /// </summary>
                [NameInMap("Envs")]
                [Validation(Required=false)]
                public string Envs { get; set; }

                /// <summary>
                /// <para>The image URL used by the init container.
                /// [_single.resp.200.props.Data.InitContainersConfig.items.Env</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-shenzhen.aliyuncs.com/sae-serverless-demo/sae-demo:microservice-java-provider-v1.0</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The init container name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>init-container</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Secret mount description.</para>
                /// </summary>
                [NameInMap("SecretMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataInitContainersConfigSecretMountDesc> SecretMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataInitContainersConfigSecretMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The key.</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The mount path.</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The Secret instance ID.</para>
                    /// </summary>
                    [NameInMap("SecretId")]
                    [Validation(Required=false)]
                    public long? SecretId { get; set; }

                    /// <summary>
                    /// <para>The Secret instance name.</para>
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the application is stateful.</para>
            /// </summary>
            [NameInMap("IsStateful")]
            [Validation(Required=false)]
            public bool? IsStateful { get; set; }

            /// <summary>
            /// <para>The arguments for starting the JAR package application. The default startup command for the application: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// <para>The options for starting the JAR package application. The default startup command for the application: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>-Dtest=true</para>
            /// </summary>
            [NameInMap("JarStartOptions")]
            [Validation(Required=false)]
            public string JarStartOptions { get; set; }

            /// <summary>
            /// <para>The JDK version on which the deployment package depends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Open JDK 8</b></description></item>
            /// <item><description><b>Open JDK 7</b></description></item>
            /// <item><description><b>Dragonwell 11</b></description></item>
            /// <item><description><b>Dragonwell 8</b></description></item>
            /// <item><description><b>openjdk-8u191-jdk-alpine3.9</b></description></item>
            /// <item><description><b>openjdk-7u201-jdk-alpine3.9</b></description></item>
            /// </list>
            /// <para>This parameter is not supported when <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <para>The summary of log collection configurations for Kafka. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>kafkaEndpoint</b>: The endpoint of the Kafka API.</description></item>
            /// <item><description><b>kafkaInstanceId</b>: The Kafka instance ID.</description></item>
            /// <item><description><b>kafkaConfigs</b>: The configuration summary for one or more log entries. For example values and parameter descriptions, see the <b>kafkaConfigs</b> request parameter in this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;kafkaEndpoint&quot;:&quot;10.0.X.XXX:XXXX,10.0.X.XXX:XXXX,10.0.X.XXX:XXXX&quot;,&quot;kafkaInstanceId&quot;:&quot;alikafka_pre-cn-7pp2l8kr****&quot;,&quot;kafkaConfigs&quot;:[{&quot;logType&quot;:&quot;file_log&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;kafkaTopic&quot;:&quot;test2&quot;},{&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;kafkaTopic&quot;:&quot;test&quot;}]}</para>
            /// </summary>
            [NameInMap("KafkaConfigs")]
            [Validation(Required=false)]
            public string KafkaConfigs { get; set; }

            /// <summary>
            /// <para>The labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The container health check settings. Containers that fail the health check are shut down and recovered. The following methods are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>exec</b>: For example, <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></description></item>
            /// <item><description><b>httpGet</b>: For example, <c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
            /// <item><description><b>tcpSocket</b>: For example, <c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></description></item>
            /// </list>
            /// <remarks>
            /// <para>You can select only one method for health checks.</para>
            /// </remarks>
            /// <para>Parameter descriptions:</para>
            /// <list type="bullet">
            /// <item><description><b>exec.command</b>: The health check command.</description></item>
            /// <item><description><b>httpGet.path</b>: The access path.</description></item>
            /// <item><description><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</description></item>
            /// <item><description><b>httpGet.isContainKeyWord</b>: <b>true</b> indicates that the keyword is included. <b>false</b> indicates that the keyword is not included. If this field is missing, the advanced feature is not used.</description></item>
            /// <item><description><b>httpGet.keyWord</b>: The custom keyword. The <b>isContainKeyWord</b> field must be present when this parameter is used.</description></item>
            /// <item><description><b>tcpSocket.port</b>: The port for TCP connection detection.</description></item>
            /// <item><description><b>initialDelaySeconds</b>: The initial delay for the health check. Default value: 10. Unit: seconds.</description></item>
            /// <item><description><b>periodSeconds</b>: The health check period. Default value: 30. Unit: seconds.</description></item>
            /// <item><description><b>timeoutSeconds</b>: The health check timeout period. Default value: 1. Unit: seconds. If this parameter is set to 0 or is not set, the default timeout period is 1 second.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;curl <a href="http://localhost:8080%22%5D%7D,%22initialDelaySeconds%22:20,%22timeoutSeconds%22:3%7D">http://localhost:8080&quot;]},&quot;initialDelaySeconds&quot;:20,&quot;timeoutSeconds&quot;:3}</a></para>
            /// </summary>
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }

            /// <summary>
            /// <para>LokiConfigs</para>
            /// </summary>
            [NameInMap("LokiConfigs")]
            [Validation(Required=false)]
            public string LokiConfigs { get; set; }

            /// <summary>
            /// <para>The Peak Volume instance ratio.</para>
            /// </summary>
            [NameInMap("MaxSurgeInstanceRatio")]
            [Validation(Required=false)]
            public int? MaxSurgeInstanceRatio { get; set; }

            /// <summary>
            /// <para>The Peak Volume of instances.</para>
            /// </summary>
            [NameInMap("MaxSurgeInstances")]
            [Validation(Required=false)]
            public int? MaxSurgeInstances { get; set; }

            /// <summary>
            /// <para>The memory size required by each instance, in MB. This value cannot be 0. The memory size has a one-to-one mapping with CPU. Only the following defined specifications are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>1024</b>: Corresponds to 500 millicores and 1000 millicores of CPU.</description></item>
            /// <item><description><b>2048</b>: Corresponds to 500, 1000, and 2000 millicores of CPU.</description></item>
            /// <item><description><b>4096</b>: Corresponds to 1000, 2000, and 4000 millicores of CPU.</description></item>
            /// <item><description><b>8192</b>: Corresponds to 2000, 4000, and 8000 millicores of CPU.</description></item>
            /// <item><description><b>12288</b>: Corresponds to 12000 millicores of CPU.</description></item>
            /// <item><description><b>16384</b>: Corresponds to 4000, 8000, and 16000 millicores of CPU.</description></item>
            /// <item><description><b>24576</b>: Corresponds to 12000 millicores of CPU.</description></item>
            /// <item><description><b>32768</b>: Corresponds to 16000 millicores of CPU.</description></item>
            /// <item><description><b>65536</b>: Corresponds to 8000, 16000, and 32000 millicores of CPU.</description></item>
            /// <item><description><b>131072</b>: Corresponds to 32000 millicores of CPU.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The Nacos registry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: SAE built-in Nacos.</description></item>
            /// <item><description><b>1</b>: Self-managed Nacos.</description></item>
            /// <item><description><b>2</b>: MSE commercial edition Nacos.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;0&quot;</para>
            /// </summary>
            [NameInMap("MicroRegistration")]
            [Validation(Required=false)]
            public string MicroRegistration { get; set; }

            /// <summary>
            /// <para>The registry configuration. This parameter takes effect only when the registry type is MSE Nacos Enterprise Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-1ls43******\&quot;,\&quot;namespace\&quot;:\&quot;62ee12fb-c279-4da4-be96-21**********\&quot;}</para>
            /// </summary>
            [NameInMap("MicroRegistrationConfig")]
            [Validation(Required=false)]
            public string MicroRegistrationConfig { get; set; }

            /// <summary>
            /// <para>The microservice governance configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>Specifies whether to enable microservice governance (enable):</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled</para>
            /// </description></item>
            /// <item><description><para>false: disabled</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Lossless rolling update configuration (mseLosslessRule):</para>
            /// <list type="bullet">
            /// <item><description><para>delayTime: the delay time.</para>
            /// </description></item>
            /// <item><description><para>enable: specifies whether to enable the lossless online feature. true indicates enabled. false indicates disabled.</para>
            /// </description></item>
            /// <item><description><para>notice: specifies whether to enable the notification feature. true indicates enabled. false indicates disabled.</para>
            /// </description></item>
            /// <item><description><para>warmupTime: the warm-up duration for traffic ramping, in seconds.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Enable\&quot;:true,\&quot;MseLosslessRule\&quot;:{\&quot;enable\&quot;:true,\&quot;notice\&quot;:true,\&quot;delayTime\&quot;:10,\&quot;warmupTime\&quot;:120,\&quot;funcType\&quot;:2,\&quot;aligned\&quot;:false,\&quot;related\&quot;:false,\&quot;lossLessDetail\&quot;:false}}</para>
            /// </summary>
            [NameInMap("MicroserviceEngineConfig")]
            [Validation(Required=false)]
            public string MicroserviceEngineConfig { get; set; }

            /// <summary>
            /// <para>The minimum percentage of available instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: The default value, which indicates that the percentage is not used. If this parameter is not specified, the system uses <b>-1</b> by default.</description></item>
            /// <item><description><b>0~100</b>: The unit is percentage, rounded up. For example, if set to <b>50</b>%, and the current number of instances is 5, the minimum number of available instances is 3.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When both <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and the value of <b>MinReadyInstanceRatio</b> is not <b>-1</b>, the <b>MinReadyInstanceRatio</b> parameter takes precedence. For example, if <b>MinReadyInstances</b> is set to <b>5</b> and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the system uses <b>MinReadyInstanceRatio</b> to calculate the minimum number of available instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            /// <summary>
            /// <para>The minimum number of available instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If set to <b>0</b>, the application interrupts services during the upgrade process.</description></item>
            /// <item><description>If set to <b>-1</b>, the system-recommended value is used, which is 25% of the current number of instances. If the current number of instances is 5, 5 × 25% = 1.25, which is rounded up to 2.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Set the minimum number of available instances to ≥ 1 for each rolling deployment to avoid service interruptions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// <para>The mount description information.</para>
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataMountDesc : TeaModel {
                /// <summary>
                /// <para>The container mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The NAS relative file directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("NasPath")]
                [Validation(Required=false)]
                public string NasPath { get; set; }

            }

            /// <summary>
            /// <para>The mount point of NAS within the application VPC. If the configuration has not changed during deployment, you do not need to set this parameter (that is, the <b>MountHost</b> field does not need to be included in the request). To clear the NAS configuration, set the value of this field to an empty string in the request (that is, set the value of the <b>MountHost</b> field to &quot;&quot;).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// <para>The application ID on the Microservices Engine (MSE) side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxx@xxxxx</para>
            /// </summary>
            [NameInMap("MseApplicationId")]
            [Validation(Required=false)]
            public string MseApplicationId { get; set; }

            /// <summary>
            /// <para>The application name after the SAE service is registered with MSE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-alb-demo-5c****</para>
            /// </summary>
            [NameInMap("MseApplicationName")]
            [Validation(Required=false)]
            public string MseApplicationName { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The NAS mount configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
            /// </summary>
            [NameInMap("NasConfigs")]
            [Validation(Required=false)]
            public string NasConfigs { get; set; }

            /// <summary>
            /// <para>NAS ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKSN****</para>
            /// </summary>
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }

            /// <summary>
            /// <para>The application version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>lite: Lite Edition</description></item>
            /// <item><description>std: Standard Edition</description></item>
            /// <item><description>pro: Professional Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pro</para>
            /// </summary>
            [NameInMap("NewSaeVersion")]
            [Validation(Required=false)]
            public string NewSaeVersion { get; set; }

            /// <summary>
            /// <para>The RAM role for identity authentication.</para>
            /// <remarks>
            /// <para>Create an OIDC identity provider and an identity provider role in the same region in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2331022.html">Create an OIDC identity provider</a> and <a href="https://help.aliyun.com/document_detail/2331016.html">Create a role for SSO identity provider</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sae-test</para>
            /// </summary>
            [NameInMap("OidcRoleName")]
            [Validation(Required=false)]
            public string OidcRoleName { get; set; }

            /// <summary>
            /// <para>The AccessKey ID for OSS read/write operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }

            /// <summary>
            /// <para>The AccessKey Secret for OSS read/write operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("OssAkSecret")]
            [Validation(Required=false)]
            public string OssAkSecret { get; set; }

            /// <summary>
            /// <para>The OSS mount description.</para>
            /// </summary>
            [NameInMap("OssMountDescs")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataOssMountDescs> OssMountDescs { get; set; }
            public class DescribeApplicationConfigResponseBodyDataOssMountDescs : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The directory or OSS object that you created in OSS. If the OSS mount directory does not exist, an exception is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data/user.data</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <para>The container path in SAE. If the path already exists, it is overwritten. If the path does not exist, it is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/data/user.data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>Indicates whether the container path has read-only permission to the mounted directory resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Read-only permission.</description></item>
                /// <item><description><b>false</b>: Read and write permission.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The application package type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When you deploy with Java, <b>FatJar</b>, <b>War</b>, and <b>Image</b> are supported.</description></item>
            /// <item><description>When you deploy with PHP, the following types are supported:<list type="bullet">
            /// <item><description><b>PhpZip</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_4</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_4_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_5</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_5_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_6</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_6_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_0</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_0_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_1</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_1_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_2</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_2_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_3</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_3_ALPINE</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>War</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The deployment package URL. If your deployment package is uploaded through SAE, note the following:</para>
            /// <list type="bullet">
            /// <item><description>This URL cannot be used for direct download. Use the GetPackageVersionAccessableUrl operation to obtain a downloadable URL (valid for 10 minutes).</description></item>
            /// <item><description>SAE retains the package for a maximum of 90 days. After 90 days, the URL is no longer returned and the package is no longer available for download.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the deployment package. This parameter is required when <b>Package Type</b> is set to <b>FatJar</b> or <b>War</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// <para>The PHP version on which the PHP deployment package depends. Images are not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHP-FPM 7.0</para>
            /// </summary>
            [NameInMap("Php")]
            [Validation(Required=false)]
            public string Php { get; set; }

            /// <summary>
            /// <para>The mount path for PHP application monitoring. Make sure that the PHP server loads the configuration file from this path.</para>
            /// <para>You do not need to manage the configuration content. SAE automatically renders the correct configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/etc/php/conf.d/arms.ini</para>
            /// </summary>
            [NameInMap("PhpArmsConfigLocation")]
            [Validation(Required=false)]
            public string PhpArmsConfigLocation { get; set; }

            /// <summary>
            /// <para>The content of the PHP configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1=v1</para>
            /// </summary>
            [NameInMap("PhpConfig")]
            [Validation(Required=false)]
            public string PhpConfig { get; set; }

            /// <summary>
            /// <para>The mount path of the PHP application startup configuration. Make sure that the PHP server uses this configuration file for startup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/etc/php/php.ini</para>
            /// </summary>
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }

            /// <summary>
            /// <para>The script that is run after the container starts. A script is triggered immediately after the container is created. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The script that is run before the container stops. A script is triggered before the container is deleted. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The programming language of the technology stack used to create the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>java</b>: Java.</description></item>
            /// <item><description><b>php</b>: PHP.</description></item>
            /// <item><description><b>other</b>: Other languages, such as Python, C++, Go, .NET, and Node.js.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <para>Enables K8s Service-based service registration and discovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{     &quot;serviceName&quot;: &quot;bwm-poc-sc-gateway-cn-beijing-front&quot;,     &quot;namespaceId&quot;: &quot;cn-beijing:front&quot;,     &quot;portAndProtocol&quot;: {         &quot;18012&quot;: &quot;TCP&quot;     },     &quot;portProtocols&quot;: [         {             &quot;port&quot;: &quot;18012&quot;,             &quot;protocol&quot;: &quot;TCP&quot;         }     ],     &quot;enable&quot;: true }</para>
            /// </summary>
            [NameInMap("PvtzDiscovery")]
            [Validation(Required=false)]
            public string PvtzDiscovery { get; set; }

            /// <summary>
            /// <para>The Python environment. PYTHON 3.9.15 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON 3.9.15</para>
            /// </summary>
            [NameInMap("Python")]
            [Validation(Required=false)]
            public string Python { get; set; }

            /// <summary>
            /// <para>The custom installation module dependencies. By default, the dependencies defined in the requirements.txt file in the root directory are installed. If no dependencies are configured or custom packages are needed, you can specify the dependencies to install.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Flask==2.0</para>
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            [NameInMap("RaspConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataRaspConfig> RaspConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataRaspConfig : TeaModel {
                [NameInMap("EnableRasp")]
                [Validation(Required=false)]
                public bool? EnableRasp { get; set; }

                [NameInMap("RaspAppKey")]
                [Validation(Required=false)]
                public string RaspAppKey { get; set; }

                [NameInMap("RaspAppName")]
                [Validation(Required=false)]
                public string RaspAppName { get; set; }

            }

            /// <summary>
            /// <para>The application startup status check. Containers that fail multiple health checks are shut down and restarted. Containers that do not pass the health check do not receive SLB traffic. The <b>exec</b>, <b>httpGet</b>, and <b>tcpSocket</b> methods are supported. For specific examples, see the <b>Liveness</b> parameter.</para>
            /// <remarks>
            /// <para>You can select only one method for health checks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;curl <a href="http://localhost:8080%22%5D%7D,%22initialDelaySeconds%22:20,%22timeoutSeconds%22:5%7D">http://localhost:8080&quot;]},&quot;initialDelaySeconds&quot;:20,&quot;timeoutSeconds&quot;:5}</a></para>
            /// </summary>
            [NameInMap("Readiness")]
            [Validation(Required=false)]
            public string Readiness { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
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
            /// <para>The resource type. Only <c>application</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The Secret mount description.</para>
            /// </summary>
            [NameInMap("SecretMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSecretMountDesc> SecretMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSecretMountDesc : TeaModel {
                /// <summary>
                /// <para>The key with Base64-encoded data value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-center</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The mount path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/www/runtime/logs</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The queried Secret instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>520</para>
                /// </summary>
                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                /// <summary>
                /// <para>The Secret instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dummy-name-opaque-894</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

            }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz969ngg2e49q5i4****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The canary release tags configured for the application.</para>
            /// </summary>
            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

            /// <summary>
            /// <para>The sidecar container configuration.</para>
            /// </summary>
            [NameInMap("SidecarContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfig> SidecarContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfig : TeaModel {
                /// <summary>
                /// <para>The ACR Enterprise instance ID. This parameter is required when <b>ImageUrl</b> is from ACR Enterprise Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-fhzlneorxala66ip</para>
                /// </summary>
                [NameInMap("AcrInstanceId")]
                [Validation(Required=false)]
                public string AcrInstanceId { get; set; }

                /// <summary>
                /// <para>The image startup command. This command must be an executable object that exists in the container. Example:</para>
                /// <pre><c>command:
                ///       - echo
                ///       - abc
                ///       - &gt;
                ///       - file0
                /// </c></pre>
                /// <para>Based on the preceding example, <c>Command=&quot;echo&quot;, CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/bin/sh</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The arguments for the image startup command. These are the arguments required by the startup command <b>Command</b>. Format:</para>
                /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
                /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>, where <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to the String type and the internal format is a JSON array. If this parameter is not required, leave it empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;-c\&quot;,\&quot;echo \\\&quot;test\\\&quot; &gt; /home/nas/test.log &amp;&amp; sleep 10000000s\&quot;]</para>
                /// </summary>
                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                /// <summary>
                /// <para>The ConfigMap mount description. Use the configuration items created on the namespace configuration page to inject configuration information into the container. Parameter descriptions:</para>
                /// <list type="bullet">
                /// <item><description><b>configMapId</b>: The ConfigMap instance ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation.</description></item>
                /// <item><description><b>key</b>: The key-value pair.<remarks>
                /// <para>You can mount all keys by passing the <c>sae-sys-configmap-all</c> parameter.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description><b>mountPath</b>: The mount path.</description></item>
                /// <item><description><b>ConfigMapName</b>: The ConfigMap name.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The ConfigMap instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7361</para>
                    /// </summary>
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    /// <summary>
                    /// <para>The ConfigMap name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ConfigMap-test</para>
                    /// </summary>
                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    /// <summary>
                    /// <para>The ConfigMap key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The container mount path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt/test</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                }

                /// <summary>
                /// <para>The maximum CPU resources of the primary container that the sidecar container can use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The shared temporary storage. Sets a temporary storage directory and mounts it to the primary container and sidecar container.</para>
                /// </summary>
                [NameInMap("EmptyDirDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc> EmptyDirDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc : TeaModel {
                    /// <summary>
                    /// <para>The mount path of the data volume in the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt/cache</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The temporary storage name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sidecar-container</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The container environment variable parameters. Custom values or references to configuration items are supported. To reference a configuration item, create a ConfigMap instance first. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom configuration<list type="bullet">
                /// <item><description><b>name</b>: The environment variable name.</description></item>
                /// <item><description><b>value</b>: The environment variable value. This value takes precedence over valueFrom.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Reference to a configuration item (valueFrom)<list type="bullet">
                /// <item><description><b>name</b>: The environment variable name. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, such as <c>sae-sys-configmap-all-test1</c>.</description></item>
                /// <item><description><b>valueFrom</b>: The environment variable reference. Set the value to <c>configMapRef</c>.<list type="bullet">
                /// <item><description><b>configMapId</b>: The ConfigMap ID.</description></item>
                /// <item><description><b>key</b>: The key. If all keys are referenced, do not set this field.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;name\&quot;:\&quot;k1\&quot;,\&quot;value\&quot;:\&quot;c8e3a815-e5d3-4adf-abb3-98b106a607c4\&quot;}]</para>
                /// </summary>
                [NameInMap("Envs")]
                [Validation(Required=false)]
                public string Envs { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-beijing.aliyuncs.com/sae-dev-test/nginx:stable</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The container health check.</para>
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// <para>The maximum memory resources of the primary container that the sidecar container can use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The container name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The script that is run after the container starts.</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The script that is run before the container stops.</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The application startup status check.</para>
                /// </summary>
                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                /// <summary>
                /// <para>The Secret mount description.</para>
                /// </summary>
                [NameInMap("SecretMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigSecretMountDesc> SecretMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigSecretMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The key with Base64-encoded data value.</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The mount path.</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The Secret instance ID.</para>
                    /// </summary>
                    [NameInMap("SecretId")]
                    [Validation(Required=false)]
                    public long? SecretId { get; set; }

                    /// <summary>
                    /// <para>The Secret instance name.</para>
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

            }

            /// <summary>
            /// <para>The settings for log collection to Simple Log Service (SLS).</para>
            /// <list type="bullet">
            /// <item><description>To use SLS resources that are automatically created by Serverless App Engine (SAE): <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</description></item>
            /// <item><description>To use custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
            /// </list>
            /// <para>Parameter descriptions:</para>
            /// <list type="bullet">
            /// <item><description><b>projectName</b>: The name of the project in SLS.  </description></item>
            /// <item><description><b>logDir</b>: The log path.</description></item>
            /// <item><description><b>logType</b>: The log type. <b>stdout</b> indicates container standard output logs. You can set only one stdout entry. If this parameter is not set, file logs are collected.</description></item>
            /// <item><description><b>logstoreName</b>: The name of the Logstore in SLS.</description></item>
            /// <item><description><b>logtailName</b>: The name of the Logtail in SLS. If this parameter is not specified, a new Logtail is created through automatic creation.</description></item>
            /// </list>
            /// <para>If the SLS collection configuration has not changed during multiple deployments, you do not need to set this parameter (that is, the <b>SlsConfigs</b> field does not need to be included in the request). If you no longer need the SLS collection feature, set the value of this field to an empty string in the request (that is, set the value of the <b>SlsConfigs</b> field to &quot;&quot;).</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>sls log env tags</para>
            /// </summary>
            [NameInMap("SlsLogEnvTags")]
            [Validation(Required=false)]
            public string SlsLogEnvTags { get; set; }

            /// <summary>
            /// <para>The startup probe of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;/bin/sh\&quot;,\&quot;-c\&quot;,\&quot;#!Note: If microservice config is enabled, the application will be automatically injected with the prestop configuration for lossless offline. If you delete this prestop configuration, lossless offline will not be effective.\\n echo stop &gt; /tmp/prestop; /home/admin/.tools/curl <a href="http://127.0.0.1:54199/offline">http://127.0.0.1:54199/offline</a>; sleep 30\&quot;]}}</para>
            /// </summary>
            [NameInMap("StartupProbe")]
            [Validation(Required=false)]
            public string StartupProbe { get; set; }

            /// <summary>
            /// <para>Configures K8s Service-based service registration and discovery with end-to-end canary release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;enable\&quot;:\&quot;false\&quot;,\&quot;namespaceId\&quot;:\&quot;cn-beijing:test\&quot;,\&quot;portAndProtocol\&quot;:{\&quot;2000:TCP\&quot;:\&quot;18081\&quot;},\&quot;portProtocols\&quot;:[{\&quot;port\&quot;:2000,\&quot;protocol\&quot;:\&quot;TCP\&quot;,\&quot;targetPort\&quot;:18081}],\&quot;pvtzDiscoveryName\&quot;:\&quot;cn-beijing-1421801774382676\&quot;,\&quot;serviceId\&quot;:\&quot;3513\&quot;,\&quot;serviceName\&quot;:\&quot;demo-gray.test\&quot;}</para>
            /// </summary>
            [NameInMap("SwimlanePvtzDiscovery")]
            [Validation(Required=false)]
            public string SwimlanePvtzDiscovery { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataTags> Tags { get; set; }
            public class DescribeApplicationConfigResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The graceful shutdown timeout period. Default value: 30. Unit: seconds. Valid values: 1 to 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// <para>The time zone. Default value: <b>Asia/Shanghai</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The Tomcat configuration. Set this parameter to &quot;&quot; or &quot;{}&quot; to delete the configuration:</para>
            /// <list type="bullet">
            /// <item><description><b>port</b>: The port number. Valid values: 1024 to 65535. Ports smaller than 1024 require root permissions. Because the container is configured with admin permissions, specify a port greater than 1024. Default value: 8080.</description></item>
            /// <item><description><b>contextPath</b>: The access path. Default value: root directory &quot;/&quot;.</description></item>
            /// <item><description><b>maxThreads</b>: The maximum number of connections in the connection pool. Default value: 400.</description></item>
            /// <item><description><b>uriEncoding</b>: The encoding format of Tomcat. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. Default value: <b>ISO-8859-1</b>.</description></item>
            /// <item><description><b>useBodyEncoding</b>: Specifies whether to use <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
            /// </summary>
            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public string TomcatConfig { get; set; }

            /// <summary>
            /// <para>The deployment policy. When the minimum number of available instances is 1, the value of the <b>UpdateStrategy</b> field is &quot;&quot;. When the minimum number of available instances is greater than 1, examples are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>Canary release of 1 instance + 2 subsequent batches + automatic batching + 1-minute batch interval: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
            /// </description></item>
            /// <item><description><para>Canary release of 1 instance + 2 subsequent batches + manual batching: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
            /// </description></item>
            /// <item><description><para>2 batches + automatic batching + 0-minute batch interval: <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>Parameter descriptions:</para>
            /// <list type="bullet">
            /// <item><description><b>type</b>: The release policy type. Valid values: <b>GrayBatchUpdate</b> (grayscale batch release) and <b>BatchUpdate</b> (batch release).</description></item>
            /// <item><description><b>batchUpdate</b>: The batch release policy.<list type="bullet">
            /// <item><description><b>batch</b>: The number of release batches.</description></item>
            /// <item><description><b>releaseType</b>: The processing method between batches. Valid values: <b>auto</b> (automatic) and <b>manual</b> (manual).</description></item>
            /// <item><description><b>batchWaitTime</b>: The interval between deployments within a batch, in seconds.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>grayUpdate</b>: The remaining batches after grayscale release. This parameter is required when <b>type</b> is set to <b>GrayBatchUpdate</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</para>
            /// </summary>
            [NameInMap("UpdateStrategy")]
            [Validation(Required=false)]
            public string UpdateStrategy { get; set; }

            /// <summary>
            /// <para>vSwitch ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The startup options for the WAR package application. The default startup command for the application: <c>java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap &quot;$@&quot; start</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-option</para>
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// <para>The Tomcat version on which the deployment package depends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>apache-tomcat-7.0.91</b></description></item>
            /// <item><description><b>apache-tomcat-8.5.42</b></description></item>
            /// </list>
            /// <para>This parameter is not supported when <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apache-tomcat-7.0.91</para>
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, the <b>ErrorCode</b> field is not returned.</description></item>
        /// <item><description>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information about the call result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application configuration information is retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Retrieved.</description></item>
        /// <item><description><b>false</b>: Failed to retrieve.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID, which is used to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
