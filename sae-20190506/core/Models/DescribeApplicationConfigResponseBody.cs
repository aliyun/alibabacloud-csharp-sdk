// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationConfigResponseBodyData Data { get; set; }
        public class DescribeApplicationConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is required to pull images across accounts. For more information, see <a href="https://help.aliyun.com/document_detail/190675.html">Pull images across Alibaba Cloud accounts</a> and <a href="https://help.aliyun.com/document_detail/223585.html">Use a RAM role to grant permissions across Alibaba Cloud accounts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/adminrole</para>
            /// </summary>
            [NameInMap("AcrAssumeRoleArn")]
            [Validation(Required=false)]
            public string AcrAssumeRoleArn { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
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
            /// <para>The configuration of the Application Load Balancer (ALB) gateway readiness gate.</para>
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
            /// <para>The type of the SAE application.</para>
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
            /// <para>Specifies whether to bind an elastic IP address (EIP). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Bind an EIP.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Do not bind an EIP.</para>
            /// </description></item>
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
            /// <para>The interval between batches in a phased release. Unit: seconds.</para>
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
            /// <para>The Cloud Monitor service ID.</para>
            /// </summary>
            [NameInMap("CmsServiceId")]
            [Validation(Required=false)]
            public string CmsServiceId { get; set; }

            /// <summary>
            /// <para>The startup command of the image. The command must be an executable object that exists in the container. Example:</para>
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
            /// <para>The arguments of the image startup command. The arguments are required by the <b>Command</b> parameter. Format:</para>
            /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
            /// <para>In the example of the <b>Command</b> parameter, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The value <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted into a string in the JSON array format. If this parameter is not required, you do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
            /// </summary>
            [NameInMap("CommandArgs")]
            [Validation(Required=false)]
            public string CommandArgs { get; set; }

            /// <summary>
            /// <para>The configurations of the ConfigMap.</para>
            /// </summary>
            [NameInMap("ConfigMapMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataConfigMapMountDesc> ConfigMapMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataConfigMapMountDesc : TeaModel {
                /// <summary>
                /// <para>The ID of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// <para>The name of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConfigMapName")]
                [Validation(Required=false)]
                public string ConfigMapName { get; set; }

                /// <summary>
                /// <para>The key of the key-value pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The mount path of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// <para>The CPU required by each instance. Unit: millicores. The value cannot be 0. The following specifications are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>500</b></para>
            /// </description></item>
            /// <item><description><para><b>1000</b></para>
            /// </description></item>
            /// <item><description><para><b>2000</b></para>
            /// </description></item>
            /// <item><description><para><b>4000</b></para>
            /// </description></item>
            /// <item><description><para><b>8000</b></para>
            /// </description></item>
            /// <item><description><para><b>16000</b></para>
            /// </description></item>
            /// <item><description><para><b>32000</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The custom mapping between a domain name and an IP address in the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>hostName</b>: The domain name or hostname.</para>
            /// </description></item>
            /// <item><description><para><b>ip</b>: The IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;hostName&quot;:&quot;test.host.name&quot;,&quot;ip&quot;:&quot;0.0.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("CustomHostAlias")]
            [Validation(Required=false)]
            public string CustomHostAlias { get; set; }

            /// <summary>
            /// <para>The type of the custom image. If you do not use a custom image, set this parameter to an empty string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>internet: a public image</para>
            /// </description></item>
            /// <item><description><para>intranet: a private image</para>
            /// </description></item>
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
            /// <para>The disk storage size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// <para>The version of the .NET framework:</para>
            /// <list type="bullet">
            /// <item><description><para>.NET 3.1</para>
            /// </description></item>
            /// <item><description><para>.NET 5.0</para>
            /// </description></item>
            /// <item><description><para>.NET 6.0</para>
            /// </description></item>
            /// <item><description><para>.NET 7.0</para>
            /// </description></item>
            /// <item><description><para>.NET 8.0</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>.NET 8.0</para>
            /// </summary>
            [NameInMap("Dotnet")]
            [Validation(Required=false)]
            public string Dotnet { get; set; }

            /// <summary>
            /// <para>The version of the application runtime environment in the High-Speed Service Framework (HSF), such as an Ali-Tomcat container.</para>
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
                /// <para>The name of the temporary storage.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable Application High Availability Service (AHAS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable AHAS.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disable AHAS.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAhas")]
            [Validation(Required=false)]
            public string EnableAhas { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the CPU burst feature:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCpuBurst")]
            [Validation(Required=false)]
            public string EnableCpuBurst { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the canary release rule. This rule is applicable only to applications that use the Spring Cloud and Dubbo frameworks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable the canary release rule.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disable the canary release rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableGreyTagRoute")]
            [Validation(Required=false)]
            public bool? EnableGreyTagRoute { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the idle mode:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// <para>Specifies whether to reuse the agent version configuration of the namespace.</para>
            /// </summary>
            [NameInMap("EnableNamespaceAgentVersion")]
            [Validation(Required=false)]
            public bool? EnableNamespaceAgentVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the new ARMS feature:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableNewArms")]
            [Validation(Required=false)]
            public bool? EnableNewArms { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable custom metric collection for Prometheus.</para>
            /// </summary>
            [NameInMap("EnablePrometheus")]
            [Validation(Required=false)]
            public bool? EnablePrometheus { get; set; }

            /// <summary>
            /// <para>The environment variables for the container. You can customize environment variables or reference a ConfigMap. To reference a ConfigMap, you must first create a ConfigMap. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Custom configuration</para>
            /// <list type="bullet">
            /// <item><description><para><b>name</b>: The name of the environment variable.</para>
            /// </description></item>
            /// <item><description><para><b>value</b>: The value of the environment variable.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Reference a configuration item</para>
            /// <list type="bullet">
            /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, for example, <c>sae-sys-configmap-all-test1</c>.</para>
            /// </description></item>
            /// <item><description><para><b>valueFrom</b>: The reference of the environment variable. Set the value to <c>configMapRef</c>.</para>
            /// </description></item>
            /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
            /// </description></item>
            /// <item><description><para><b>key</b>: The key. If you want to reference all keys, do not specify this parameter.</para>
            /// </description></item>
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
            /// <para>The GPU card type.</para>
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
            /// <para>The ID of the secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ImagePullSecrets")]
            [Validation(Required=false)]
            public string ImagePullSecrets { get; set; }

            /// <summary>
            /// <para>The URL of the image. This parameter is required when <b>Package Type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker.io/library/nginx:1.14.2</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The configurations of the init container.</para>
            /// </summary>
            [NameInMap("InitContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataInitContainersConfig> InitContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataInitContainersConfig : TeaModel {
                /// <summary>
                /// <para>The startup command of the image. The command must be an executable object that exists in the container. Example:</para>
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
                /// <para>The arguments of the image startup command. The arguments are required by the preceding startup command <b>Command</b>. Format:</para>
                /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
                /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The value <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted into a string in the JSON array format. If this parameter is not required, you do not need to specify it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
                /// </summary>
                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                /// <summary>
                /// <para>The configurations of the ConfigMap.</para>
                /// </summary>
                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataInitContainersConfigConfigMapMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The ID of the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    /// <summary>
                    /// <para>The name of the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    /// <summary>
                    /// <para>The key of the key-value pair.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The mount path of the container.</para>
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
                    /// <para>The path on which the volume is mounted in the container.</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The name of the temporary storage.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The environment variables of the container. You can customize environment variables or reference a ConfigMap. To reference a ConfigMap, you must first create a ConfigMap instance. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Custom configuration</para>
                /// <list type="bullet">
                /// <item><description><para><b>name</b>: The name of the environment variable.</para>
                /// </description></item>
                /// <item><description><para><b>value</b>: The value of the environment variable. This parameter takes precedence over valueFrom.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Reference a configuration item (valueFrom)</para>
                /// <list type="bullet">
                /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, for example, <c>sae-sys-configmap-all-test1</c>.</para>
                /// </description></item>
                /// <item><description><para><b>valueFrom</b>: The reference of the environment variable. Set the value to <c>configMapRef</c>.</para>
                /// </description></item>
                /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
                /// </description></item>
                /// <item><description><para><b>key</b>: The key. If you want to reference all keys, do not specify this parameter.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Reference a secret (valueFrom)</para>
                /// <list type="bullet">
                /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-secret-all-&lt;Secret name&gt;</c>, for example, <c>sae-sys-secret-all-test1</c>.</para>
                /// </description></item>
                /// <item><description><para><b>valueFrom</b>: The reference of the environment variable. Set the value to <c>secretRef</c>.</para>
                /// </description></item>
                /// <item><description><para><b>secretId</b>: The ID of the secret.</para>
                /// </description></item>
                /// <item><description><para><b>key</b>: The key. If you want to reference all keys, do not specify this parameter.</para>
                /// </description></item>
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
                /// <para>The URL of the image that is used by the init container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-shenzhen.aliyuncs.com/sae-serverless-demo/sae-demo:microservice-java-provider-v1.0</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The name of the init container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>init-container</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The description of the secret that you want to mount.</para>
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
                    /// <para>The ID of the secret instance.</para>
                    /// </summary>
                    [NameInMap("SecretId")]
                    [Validation(Required=false)]
                    public long? SecretId { get; set; }

                    /// <summary>
                    /// <para>The name of the secret instance.</para>
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether the application is a stateful application.</para>
            /// </summary>
            [NameInMap("IsStateful")]
            [Validation(Required=false)]
            public bool? IsStateful { get; set; }

            /// <summary>
            /// <para>The arguments for starting the JAR package. The default startup command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("JarStartArgs")]
            [Validation(Required=false)]
            public string JarStartArgs { get; set; }

            /// <summary>
            /// <para>The options for starting the JAR package. The default startup command is: <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>-Dtest=true</para>
            /// </summary>
            [NameInMap("JarStartOptions")]
            [Validation(Required=false)]
            public string JarStartOptions { get; set; }

            /// <summary>
            /// <para>The version of the Java Development Kit (JDK) that the deployment package requires. The following versions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Open JDK 8</b></para>
            /// </description></item>
            /// <item><description><para><b>Open JDK 7</b></para>
            /// </description></item>
            /// <item><description><para><b>Dragonwell 11</b></para>
            /// </description></item>
            /// <item><description><para><b>Dragonwell 8</b></para>
            /// </description></item>
            /// <item><description><para><b>openjdk-8u191-jdk-alpine3.9</b></para>
            /// </description></item>
            /// <item><description><para><b>openjdk-7u201-jdk-alpine3.9</b></para>
            /// </description></item>
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
            /// <para>The configurations for collecting logs to Kafka. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>kafkaEndpoint</b>: The endpoint of the Kafka API.</para>
            /// </description></item>
            /// <item><description><para><b>kafkaInstanceId</b>: The ID of the Kafka instance.</para>
            /// </description></item>
            /// <item><description><para><b>kafkaConfigs</b>: The configurations of one or more logs. For more information about the example and parameters, see the <b>kafkaConfigs</b> request parameter in this topic.</para>
            /// </description></item>
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
            /// <para>The liveness probe of the container. A container that fails the health check is shut down and restored. The following methods are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>exec</b>: example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;sh&quot;,&quot;-c&quot;,&quot;cat/home/admin/start.sh&quot;]},&quot;initialDelaySeconds&quot;:30,&quot;periodSeconds&quot;:30,&quot;timeoutSeconds&quot;:2}</c></para>
            /// </description></item>
            /// <item><description><para><b>httpGet</b>: example:<c>{&quot;httpGet&quot;:{&quot;path&quot;:&quot;/&quot;,&quot;port&quot;:18091,&quot;scheme&quot;:&quot;HTTP&quot;,&quot;isContainKeyWord&quot;:true,&quot;keyWord&quot;:&quot;SAE&quot;},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
            /// </description></item>
            /// <item><description><para><b>tcpSocket</b>: example:<c>{&quot;tcpSocket&quot;:{&quot;port&quot;:18091},&quot;initialDelaySeconds&quot;:11,&quot;periodSeconds&quot;:10,&quot;timeoutSeconds&quot;:1}</c></para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You can use only one method for a health check.</para>
            /// </remarks>
            /// <para>The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>exec.command</b>: The command that is used for the health check.</para>
            /// </description></item>
            /// <item><description><para><b>httpGet.path</b>: The request path.</para>
            /// </description></item>
            /// <item><description><para><b>httpGet.scheme</b>: <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>httpGet.isContainKeyWord</b>: Specifies whether the response must contain a keyword. A value of <b>true</b> indicates that the response must contain the keyword. A value of <b>false</b> indicates that the response does not need to contain the keyword. If you do not specify this parameter, this advanced feature is not used.</para>
            /// </description></item>
            /// <item><description><para><b>httpGet.keyWord</b>: The custom keyword. This parameter is required if you set the <b>isContainKeyWord</b> parameter.</para>
            /// </description></item>
            /// <item><description><para><b>tcpSocket.port</b>: The port that is used for the TCP connection check.</para>
            /// </description></item>
            /// <item><description><para><b>initialDelaySeconds</b>: The delay for the health check. Default value: 10. Unit: seconds.</para>
            /// </description></item>
            /// <item><description><para><b>periodSeconds</b>: The interval for the health check. Default value: 30. Unit: seconds.</para>
            /// </description></item>
            /// <item><description><para><b>timeoutSeconds</b>: The timeout period for the health check. Default value: 1. Unit: seconds. If you set this parameter to 0 or do not specify this parameter, the default value is used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;curl <a href="http://localhost:8080%22%5D%7D,%22initialDelaySeconds%22:20,%22timeoutSeconds%22:3%7D">http://localhost:8080&quot;]},&quot;initialDelaySeconds&quot;:20,&quot;timeoutSeconds&quot;:3}</a></para>
            /// </summary>
            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public string Liveness { get; set; }

            /// <summary>
            /// <para>The Loki configurations.</para>
            /// </summary>
            [NameInMap("LokiConfigs")]
            [Validation(Required=false)]
            public string LokiConfigs { get; set; }

            /// <summary>
            /// <para>The maximum surge instance ratio.</para>
            /// </summary>
            [NameInMap("MaxSurgeInstanceRatio")]
            [Validation(Required=false)]
            public int? MaxSurgeInstanceRatio { get; set; }

            /// <summary>
            /// <para>The maximum number of surge instances.</para>
            /// </summary>
            [NameInMap("MaxSurgeInstances")]
            [Validation(Required=false)]
            public int? MaxSurgeInstances { get; set; }

            /// <summary>
            /// <para>The memory required by each instance. Unit: MB. The value cannot be 0. This parameter corresponds to the \<c>Cpu\\</c> parameter. The following specifications are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1024</b>: corresponds to 500 millicores and 1,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>2048</b>: corresponds to 500, 1,000, and 2,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>4096</b>: corresponds to 1,000, 2,000, and 4,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>8192</b>: corresponds to 2,000, 4,000, and 8,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>12288</b>: corresponds to 12,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>16384</b>: corresponds to 4,000, 8,000, and 16,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>24576</b>: corresponds to 12,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>32768</b>: corresponds to 16,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>65536</b>: corresponds to 8,000, 16,000, and 32,000 millicores.</para>
            /// </description></item>
            /// <item><description><para><b>131072</b>: corresponds to 32,000 millicores.</para>
            /// </description></item>
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
            /// <item><description><para><b>0</b>: SAE built-in Nacos.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: User-created Nacos.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: MSE Nacos.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;0&quot;</para>
            /// </summary>
            [NameInMap("MicroRegistration")]
            [Validation(Required=false)]
            public string MicroRegistration { get; set; }

            /// <summary>
            /// <para>The configuration of the registry. This parameter takes effect only when the registry is MSE Nacos Enterprise Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;instanceId\&quot;:\&quot;mse-cn-1ls43******\&quot;,\&quot;namespace\&quot;:\&quot;62ee12fb-c279-4da4-be96-21**********\&quot;}</para>
            /// </summary>
            [NameInMap("MicroRegistrationConfig")]
            [Validation(Required=false)]
            public string MicroRegistrationConfig { get; set; }

            /// <summary>
            /// <para>The configurations of microservice governance.</para>
            /// <list type="bullet">
            /// <item><description><para>Specifies whether to enable microservice governance (enable):</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>The configuration of graceful start and shutdown (mseLosslessRule):</para>
            /// <list type="bullet">
            /// <item><description><para>delayTime: The delay time.</para>
            /// </description></item>
            /// <item><description><para>enable: Specifies whether to enable graceful start. true indicates that graceful start is enabled. false indicates that graceful start is not enabled.</para>
            /// </description></item>
            /// <item><description><para>notice: Specifies whether to enable notifications. true indicates that notifications are enabled. false indicates that notifications are not enabled.</para>
            /// </description></item>
            /// <item><description><para>warmupTime: The warm-up duration for a small amount of traffic. Unit: seconds.</para>
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
            /// <para>The percentage of the minimum number of ready instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>-1: The default value. This value indicates that the percentage is not used. If you do not specify this parameter, the system uses the default value <b>-1</b>.</para>
            /// </description></item>
            /// <item><description><para><b>0 to 100</b>: The percentage of the minimum number of ready instances. The value is rounded up. For example, if you set this parameter to <b>50</b>%, and you have five instances, the minimum number of ready instances is 3.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify both \<c>MinReadyInstances\\</c> and <b>MinReadyInstanceRatio</b>, and the value of <b>MinReadyInstanceRatio</b> is not <b>-1</b>, the value of <b>MinReadyInstanceRatio</b> takes precedence. For example, if <b>MinReadyInstances</b> is set to <b>5</b> and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the minimum number of ready instances is calculated based on the value of <b>MinReadyInstanceRatio</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            /// <summary>
            /// <para>The minimum number of ready instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set this parameter to <b>0</b>, the application may be interrupted during an upgrade.</para>
            /// </description></item>
            /// <item><description><para>If you set this parameter to -1, the system uses a recommended value, which is 25% of the total number of instances. For example, if you have five instances, the minimum number of ready instances is 2 after the value is rounded up.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>We recommend that you set the minimum number of ready instances to a value of 1 or greater to ensure that the application is not interrupted during a rolling update.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// <para>The mount description.</para>
            /// </summary>
            [NameInMap("MountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataMountDesc> MountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataMountDesc : TeaModel {
                /// <summary>
                /// <para>The mount path of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The path of the NAS file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("NasPath")]
                [Validation(Required=false)]
                public string NasPath { get; set; }

            }

            /// <summary>
            /// <para>The mount target of the Apsara File Storage NAS file system in the application VPC. If you do not change the NAS configuration during a deployment, you do not need to specify this parameter. If you want to clear the NAS configuration, set this parameter to an empty string (&quot;&quot;).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("MountHost")]
            [Validation(Required=false)]
            public string MountHost { get; set; }

            /// <summary>
            /// <para>The ID of the application in Microservices Engine (MSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxx@xxxxx</para>
            /// </summary>
            [NameInMap("MseApplicationId")]
            [Validation(Required=false)]
            public string MseApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the application after the SAE service is registered with MSE.</para>
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
            /// <para>The configurations for mounting a NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;mountPath&quot;:&quot;/test1&quot;,&quot;readOnly&quot;:false,&quot;nasId&quot;:&quot;nasId1&quot;,&quot;mountDomain&quot;:&quot;nasId1.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;nasPath&quot;:&quot;/test1&quot;},{&quot;nasId&quot;:&quot;nasId2&quot;,&quot;mountDomain&quot;:&quot;nasId2.cn-shenzhen.nas.aliyuncs.com&quot;,&quot;readOnly&quot;:false,&quot;nasPath&quot;:&quot;/test2&quot;,&quot;mountPath&quot;:&quot;/test2&quot;}]</para>
            /// </summary>
            [NameInMap("NasConfigs")]
            [Validation(Required=false)]
            public string NasConfigs { get; set; }

            /// <summary>
            /// <para>The ID of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKSN****</para>
            /// </summary>
            [NameInMap("NasId")]
            [Validation(Required=false)]
            public string NasId { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// <list type="bullet">
            /// <item><description><para>lite: Lightweight Edition</para>
            /// </description></item>
            /// <item><description><para>std: Standard Edition</para>
            /// </description></item>
            /// <item><description><para>pro: Professional Edition</para>
            /// </description></item>
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
            /// <para>You must create an OpenID Connect (OIDC) identity provider (IdP) and a RAM role for the IdP in the same region beforehand. For more information, see <a href="https://help.aliyun.com/document_detail/2331022.html">Create an OIDC IdP</a> and <a href="https://help.aliyun.com/document_detail/2331016.html">Create a RAM role for a trusted IdP</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sae-test</para>
            /// </summary>
            [NameInMap("OidcRoleName")]
            [Validation(Required=false)]
            public string OidcRoleName { get; set; }

            /// <summary>
            /// <para>The AccessKey ID that is used to read data from and write data to Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("OssAkId")]
            [Validation(Required=false)]
            public string OssAkId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret that is used to read data from and write data to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("OssAkSecret")]
            [Validation(Required=false)]
            public string OssAkSecret { get; set; }

            /// <summary>
            /// <para>The description of the OSS mount.</para>
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
                /// <para>The directory or object that you created in OSS. An error occurs if the mount directory does not exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data/user.data</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <para>The path of the container in SAE. If the path exists, the path is overwritten. If the path does not exist, a new path is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/data/user.data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>Specifies whether the container has the read-only permission on the mount directory resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The read-only permission.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The read and write permissions.</para>
                /// </description></item>
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
            /// <para>The type of the application package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you deploy the application using Java, valid values are <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>If you deploy the application using PHP, the following values are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PhpZip</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_4</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_4_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_5</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_5_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_6</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_6_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_0</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_0_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_1</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_1_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_2</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_2_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_3</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_3_ALPINE</b></para>
            /// </description></item>
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
            /// <para>The URL of the deployment package. If you upload the deployment package using SAE, note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>You cannot download the package from this URL. Call the \<c>GetPackageVersionAccessableUrl\\</c> operation to obtain a download URL that is valid for 10 minutes.</para>
            /// </description></item>
            /// <item><description><para>SAE stores the package for a maximum of 90 days. After 90 days, the URL is not returned and you cannot download the package.</para>
            /// </description></item>
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
            /// <para>The PHP version required for the deployment package. This parameter is not supported for images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHP-FPM 7.0</para>
            /// </summary>
            [NameInMap("Php")]
            [Validation(Required=false)]
            public string Php { get; set; }

            /// <summary>
            /// <para>The mount path of the Application Real-Time Monitoring Service (ARMS) configuration file for a PHP application. Make sure that the PHP server loads the configuration file from this path.</para>
            /// <para>SAE automatically renders the correct configuration file. You do not need to manage the content of the configuration file.</para>
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
            /// <para>The mount path of the PHP application startup configuration file. Make sure that the PHP server uses this configuration file to start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/etc/php/php.ini</para>
            /// </summary>
            [NameInMap("PhpConfigLocation")]
            [Validation(Required=false)]
            public string PhpConfigLocation { get; set; }

            /// <summary>
            /// <para>The script that runs after the container starts. The script runs immediately after the container is created. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The script that runs before the container is stopped. The script runs before the container is deleted. Example: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;]}}</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The programming language of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>java</b>: Java</para>
            /// </description></item>
            /// <item><description><para><b>php</b>: PHP</para>
            /// </description></item>
            /// <item><description><para><b>other</b>: other languages, such as Python, C++, Go, .NET, and Node.js.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <para>Enables service registration and discovery for a Kubernetes Service.</para>
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
            /// <para>The dependencies for custom installation modules. By default, the dependencies that are defined in the requirements.txt file in the root directory are installed. If no software package is configured or a custom software package is used, you can specify the dependencies to be installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Flask==2.0</para>
            /// </summary>
            [NameInMap("PythonModules")]
            [Validation(Required=false)]
            public string PythonModules { get; set; }

            /// <summary>
            /// <para>The readiness probe of the application. A container that fails the health check multiple times is shut down and restarted. A container that fails the health check does not receive traffic from a Server Load Balancer (SLB) instance. You can perform the health check using the <b>exec</b>, <b>httpGet</b>, or <b>tcpSocket</b> method. For more information, see the <b>Liveness</b> parameter.</para>
            /// <remarks>
            /// <para>You can use only one method for a health check.</para>
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
            /// <para>The description of the secret that you want to mount.</para>
            /// </summary>
            [NameInMap("SecretMountDesc")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSecretMountDesc> SecretMountDesc { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSecretMountDesc : TeaModel {
                /// <summary>
                /// <para>The key of the data value that is encoded in Base64.</para>
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
                /// <para>The ID of the queried secret instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>520</para>
                /// </summary>
                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                /// <summary>
                /// <para>The name of the secret instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dummy-name-opaque-894</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz969ngg2e49q5i4****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The canary release tags of the application configuration.</para>
            /// </summary>
            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

            /// <summary>
            /// <para>The configurations of the sidecar container.</para>
            /// </summary>
            [NameInMap("SidecarContainersConfig")]
            [Validation(Required=false)]
            public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfig> SidecarContainersConfig { get; set; }
            public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the Container Registry Enterprise Edition instance. This parameter is required if <b>ImageUrl</b> is set to an image in Container Registry Enterprise Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-fhzlneorxala66ip</para>
                /// </summary>
                [NameInMap("AcrInstanceId")]
                [Validation(Required=false)]
                public string AcrInstanceId { get; set; }

                /// <summary>
                /// <para>The startup command of the image. The command must be an executable object that exists in the container. Example:</para>
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
                /// <para>The arguments of the image startup command. The arguments are required by the preceding startup command <b>Command</b>. Format:</para>
                /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
                /// <para>In the preceding example, <c>CommandArgs=[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The value <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted into a string in the JSON array format. If this parameter is not required, you do not need to specify it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;-c\&quot;,\&quot;echo \\\&quot;test\\\&quot; &gt; /home/nas/test.log &amp;&amp; sleep 10000000s\&quot;]</para>
                /// </summary>
                [NameInMap("CommandArgs")]
                [Validation(Required=false)]
                public string CommandArgs { get; set; }

                /// <summary>
                /// <para>The description of the ConfigMap that you want to mount. Use the configuration item that you created on the Namespace Configuration Items page to inject configuration information into the container. The parameters are described as follows:</para>
                /// <list type="bullet">
                /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap instance. You can call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation to obtain the ID.</para>
                /// </description></item>
                /// <item><description><para><b>key</b>: The key.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>You can pass the <c>sae-sys-configmap-all</c> parameter to mount all keys.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para><b>mountPath</b>: The mount path.</para>
                /// </description></item>
                /// <item><description><para><b>ConfigMapName</b>: The name of the ConfigMap.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("ConfigMapMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc> ConfigMapMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigConfigMapMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The ID of the ConfigMap instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7361</para>
                    /// </summary>
                    [NameInMap("ConfigMapId")]
                    [Validation(Required=false)]
                    public long? ConfigMapId { get; set; }

                    /// <summary>
                    /// <para>The name of the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ConfigMap-test</para>
                    /// </summary>
                    [NameInMap("ConfigMapName")]
                    [Validation(Required=false)]
                    public string ConfigMapName { get; set; }

                    /// <summary>
                    /// <para>The key of the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The mount path of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt/test</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                }

                /// <summary>
                /// <para>The maximum CPU resources that the sidecar container can use from the main container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The shared temporary storage. Set a temporary storage directory and mount it to the main container and the sidecar container.</para>
                /// </summary>
                [NameInMap("EmptyDirDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc> EmptyDirDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigEmptyDirDesc : TeaModel {
                    /// <summary>
                    /// <para>The path on which the volume is mounted in the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt/cache</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The name of the temporary storage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sidecar-container</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The environment variables of the container. You can customize environment variables or reference a ConfigMap. To reference a ConfigMap, you must first create a ConfigMap instance. For more information, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Custom configuration</para>
                /// <list type="bullet">
                /// <item><description><para><b>name</b>: The name of the environment variable.</para>
                /// </description></item>
                /// <item><description><para><b>value</b>: The value of the environment variable. This parameter takes precedence over valueFrom.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Reference a configuration item (valueFrom)</para>
                /// <list type="bullet">
                /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, enter <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c>, for example, <c>sae-sys-configmap-all-test1</c>.</para>
                /// </description></item>
                /// <item><description><para><b>valueFrom</b>: The reference of the environment variable. Set the value to <c>configMapRef</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
                /// </description></item>
                /// <item><description><para><b>key</b>: The key. If you want to reference all keys, do not specify this parameter.</para>
                /// </description></item>
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
                /// <para>The health check on the container.</para>
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// <para>The maximum memory resources that the sidecar container can use from the main container.</para>
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

                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The check on the application startup status.</para>
                /// </summary>
                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                /// <summary>
                /// <para>The description of the secret that you want to mount.</para>
                /// </summary>
                [NameInMap("SecretMountDesc")]
                [Validation(Required=false)]
                public List<DescribeApplicationConfigResponseBodyDataSidecarContainersConfigSecretMountDesc> SecretMountDesc { get; set; }
                public class DescribeApplicationConfigResponseBodyDataSidecarContainersConfigSecretMountDesc : TeaModel {
                    /// <summary>
                    /// <para>The key of the data value that is encoded in Base64.</para>
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
                    /// <para>The ID of the secret instance.</para>
                    /// </summary>
                    [NameInMap("SecretId")]
                    [Validation(Required=false)]
                    public long? SecretId { get; set; }

                    /// <summary>
                    /// <para>The name of the secret instance.</para>
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

            }

            /// <summary>
            /// <para>The configurations for collecting logs to Simple Log Service (SLS).</para>
            /// <list type="bullet">
            /// <item><description><para>To use an SLS resource that is automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
            /// </description></item>
            /// <item><description><para>To use a custom SLS resource: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>projectName</b>: The name of the SLS project.</para>
            /// </description></item>
            /// <item><description><para><b>logDir</b>: The log path.</para>
            /// </description></item>
            /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> indicates the standard output log of the container. You can specify only one log of this type. If you do not specify this parameter, file logs are collected.</para>
            /// </description></item>
            /// <item><description><para><b>logstoreName</b>: The name of the Logstore in SLS.</para>
            /// </description></item>
            /// <item><description><para><b>logtailName</b>: The name of the Logtail configuration in SLS. If you do not specify this parameter, a new Logtail configuration is created.</para>
            /// </description></item>
            /// </list>
            /// <para>If you do not change the log collection configuration during a deployment, you do not need to specify this parameter. If you no longer need to use the log collection feature, set this parameter to an empty string (&quot;&quot;) in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>The environment tags for SLS logs.</para>
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
            /// <para>The configuration for service registration and discovery based on a Kubernetes Service and for end-to-end canary release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;enable\&quot;:\&quot;false\&quot;,\&quot;namespaceId\&quot;:\&quot;cn-beijing:test\&quot;,\&quot;portAndProtocol\&quot;:{\&quot;2000:TCP\&quot;:\&quot;18081\&quot;},\&quot;portProtocols\&quot;:[{\&quot;port\&quot;:2000,\&quot;protocol\&quot;:\&quot;TCP\&quot;,\&quot;targetPort\&quot;:18081}],\&quot;pvtzDiscoveryName\&quot;:\&quot;cn-beijing-1421801774382676\&quot;,\&quot;serviceId\&quot;:\&quot;3513\&quot;,\&quot;serviceName\&quot;:\&quot;demo-gray.test\&quot;}</para>
            /// </summary>
            [NameInMap("SwimlanePvtzDiscovery")]
            [Validation(Required=false)]
            public string SwimlanePvtzDiscovery { get; set; }

            /// <summary>
            /// <para>The tags.</para>
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
            /// <para>The timeout period for a graceful shutdown. Default value: 30. Unit: seconds. The value can range from 1 to 300.</para>
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
            /// <para>The Tomcat configuration. To delete the configuration, set this parameter to &quot;&quot; or &quot;{}&quot;.</para>
            /// <list type="bullet">
            /// <item><description><para><b>port</b>: The port number. The port number can range from 1024 to 65535. A port number smaller than 1024 requires the root permission to be operated. Because the container is configured with the administrator permission, specify a port number that is greater than 1024. If you do not configure this parameter, the default port 8080 is used.</para>
            /// </description></item>
            /// <item><description><para><b>contextPath</b>: The access path. The default value is the root directory &quot;/&quot;.</para>
            /// </description></item>
            /// <item><description><para><b>maxThreads</b>: The maximum number of connections in the connection pool. Default value: 400.</para>
            /// </description></item>
            /// <item><description><para><b>uriEncoding</b>: The URI encoding scheme of Tomcat. Valid values: <b>UTF-8</b>, <b>ISO-8859-1</b>, <b>GBK</b>, and <b>GB2312</b>. If you do not set this parameter, the default value <b>ISO-8859-1</b> is used.</para>
            /// </description></item>
            /// <item><description><para><b>useBodyEncoding</b>: Specifies whether to use <b>BodyEncoding for URL</b>. Default value: <b>true</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;port&quot;:8080,&quot;contextPath&quot;:&quot;/&quot;,&quot;maxThreads&quot;:400,&quot;uriEncoding&quot;:&quot;ISO-8859-1&quot;,&quot;useBodyEncodingForUri&quot;:true}</para>
            /// </summary>
            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public string TomcatConfig { get; set; }

            /// <summary>
            /// <para>The deployment policy. If the minimum number of ready instances is 1, the value of the <b>UpdateStrategy</b> parameter is &quot;&quot;. If the minimum number of ready instances is greater than 1, see the following examples:</para>
            /// <list type="bullet">
            /// <item><description><para>Canary release of one instance, phased release in two batches, automatic batching, and a 1-minute interval between batches: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:1},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
            /// </description></item>
            /// <item><description><para>Canary release of one instance and phased release in two batches with manual batching: <c>{&quot;type&quot;:&quot;GrayBatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;manual&quot;},&quot;grayUpdate&quot;:{&quot;gray&quot;:1}}</c></para>
            /// </description></item>
            /// <item><description><para>Phased release in two batches, automatic batching, and a 0-minute interval between batches: <c>{&quot;type&quot;:&quot;BatchUpdate&quot;,&quot;batchUpdate&quot;:{&quot;batch&quot;:2,&quot;releaseType&quot;:&quot;auto&quot;,&quot;batchWaitTime&quot;:0}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>type</b>: The type of the release policy. Valid values: <b>GrayBatchUpdate</b> (canary release) and <b>BatchUpdate</b> (phased release).</para>
            /// </description></item>
            /// <item><description><para><b>batchUpdate</b>: The phased release policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>batch</b>: The number of release batches.</para>
            /// </description></item>
            /// <item><description><para><b>releaseType</b>: The processing method for batches. Valid values: <b>auto</b> and <b>manual</b>.</para>
            /// </description></item>
            /// <item><description><para><b>batchWaitTime</b>: The interval between batches. Unit: seconds.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>grayUpdate</b>: The number of batches for the remaining instances after the canary release. This parameter is required when <b>type</b> is set to <b>GrayBatchUpdate</b>.</para>
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
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The options for starting the WAR package. The default startup command is: <c>java $JAVA_OPTS $CATALINA_OPTS -Options org.apache.catalina.startup.Bootstrap &quot;$@&quot; start</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-option</para>
            /// </summary>
            [NameInMap("WarStartOptions")]
            [Validation(Required=false)]
            public string WarStartOptions { get; set; }

            /// <summary>
            /// <para>The Tomcat version that the deployment package requires. The following versions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>apache-tomcat-7.0.91</b></para>
            /// </description></item>
            /// <item><description><para><b>apache-tomcat-8.5.42</b></para>
            /// </description></item>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, this parameter is returned. For more information, see the &quot;Error codes&quot; section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
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
        /// <para>Indicates whether the application configuration was retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The configuration was retrieved.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The configuration failed to be retrieved.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
