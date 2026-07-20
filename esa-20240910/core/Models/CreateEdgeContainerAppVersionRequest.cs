// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: 1) Your account must have an ESA plan with the Edge Container feature enabled. 2) Call CreateEdgeContainerApp first to create an application and obtain the AppId. 3) Complete call chain example: CreateEdgeContainerApp → ListEdgeContainerApps → CreateEdgeContainerAppVersion.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The container group to be deployed for this version, including specific image information. The image information consists of the image address, startup command, parameters, environment variables, and probe rules. Multiple images are supported in a JSON array structure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;Name&quot;: &quot;container1&quot;,
        ///             &quot;Image&quot;: &quot;image1&quot;,
        ///             &quot;Spec&quot;: &quot;1C2G&quot;,
        ///             &quot;Command&quot;: &quot;/bin/sh&quot;,
        ///             &quot;Args&quot;: &quot;-c hello&quot;,
        ///             &quot;ProbeType&quot;: &quot;tcpSocket&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Port\&quot;:8080}&quot;
        ///       },
        ///       {
        ///             &quot;Name&quot;: &quot;container2&quot;,
        ///             &quot;Image&quot;: &quot;image2&quot;,
        ///             &quot;Spec&quot;: &quot;2C4G&quot;,
        ///             &quot;ProbeType&quot;: &quot;httpGet&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Path\&quot;:\&quot;/\&quot;,\&quot;Port\&quot;:80,\&quot;InitialDelaySeconds\&quot;:10}&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<CreateEdgeContainerAppVersionRequestContainers> Containers { get; set; }
        public class CreateEdgeContainerAppVersionRequestContainers : TeaModel {
            /// <summary>
            /// <para>The ACR image information.</para>
            /// </summary>
            [NameInMap("ACRImageInfo")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersACRImageInfo ACRImageInfo { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersACRImageInfo : TeaModel {
                /// <summary>
                /// <para>The ACR image domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500.***.net</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The ACR instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xcdn-9axbo****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Specifies whether the image is an enterprise-level image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsEnterpriseRegistry")]
                [Validation(Required=false)]
                public bool? IsEnterpriseRegistry { get; set; }

                /// <summary>
                /// <para>The region list of the ACR instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The repository ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crr-h1ghghu60ct****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The image repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_71</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The namespace of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>safeline</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The ACR image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.40.2</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The ACR image tag URL.</para>
                /// </summary>
                [NameInMap("TagUrl")]
                [Validation(Required=false)]
                public string TagUrl { get; set; }

            }

            /// <summary>
            /// <para>The startup parameters. Separate multiple parameters with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-a</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The startup command. Separate multiple commands with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The environment variables. Format: key1=val1,key2=val2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VITE_APP_TITLE=My App</para>
            /// </summary>
            [NameInMap("EnvVariables")]
            [Validation(Required=false)]
            public string EnvVariables { get; set; }

            /// <summary>
            /// <para>The image address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shenzhen.aliyuncs.com/lihe<b><b>h/ea</b></b>ts_serv**<b>am:3.</b></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>Specifies whether the image is an Alibaba Cloud Container Registry (ACR) image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsACRImage")]
            [Validation(Required=false)]
            public bool? IsACRImage { get; set; }

            /// <summary>
            /// <para>The container name. The name must be unique within the same container group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lxg-demo-er</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The command to execute before the container starts. Separate multiple commands with spaces. This command is executed before the service starts and is typically used for initialization operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh poststart.sh &quot;echo hello world&quot;</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The command to execute before the container stops. Separate multiple commands with spaces. This command is executed before the service exits and is typically used for cleanup operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh prestop.sh &quot;echo hello world&quot;</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The container health probe content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>具体字段可参照k8s官方就绪探针的定义。</para>
            /// </summary>
            [NameInMap("ProbeContent")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersProbeContent ProbeContent { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersProbeContent : TeaModel {
                /// <summary>
                /// <para>The probe command for exec-type probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo ok</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The number of consecutive failed health checks required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                /// <summary>
                /// <para>The domain name for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.rewrite.com">www.rewrite.com</a></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The HTTP request headers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;Content-Type\&quot;:\&quot;application/json\&quot;}]</para>
                /// </summary>
                [NameInMap("HttpHeaders")]
                [Validation(Required=false)]
                public string HttpHeaders { get; set; }

                /// <summary>
                /// <para>The initial delay time for the container probe, in seconds. For example, 5 indicates that the initial delay is set to 5 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The path for the container health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The interval between container health checks, in seconds. For example, 5 indicates that the health check interval is set to 5 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The port for the container health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9991</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The request protocol for the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("Scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                /// <summary>
                /// <para>The timeout period for the container health check, in seconds. For example, 5 indicates that the timeout is set to 5 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            /// <summary>
            /// <para>The probe type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>exec</b>: Command-based.</description></item>
            /// <item><description><b>tcpSocket</b>: TCP-based.</description></item>
            /// <item><description><b>httpGet</b>: HTTP-based.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec</para>
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// <para>The container specifications. Specifies the computing power specifications. Valid values: 1C2G, 2C4G, 2C8G, 4C8G, 4C16G, 8C16G, and 8C32G.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1C2G</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The storage capacity. Valid values: 0.5G, 10G, 20G, and 30G.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5G</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

        }

        /// <summary>
        /// <para>The version name. The name must be <b>6 to 128</b> characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verson1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
