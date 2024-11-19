// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The container group to be deployed for this version, which contains information about images.\
        /// The image data contains the image address, startup command, parameters, environment variables, and probe rules. You can specify one or more images. The parameter value is a JSON string.</para>
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
            /// <para>The information about the Container Registry image.</para>
            /// </summary>
            [NameInMap("ACRImageInfo")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersACRImageInfo ACRImageInfo { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersACRImageInfo : TeaModel {
                /// <summary>
                /// <para>The domain name of the Container Registry image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500.***.net</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The ID of the Container Registry instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xcdn-9axbo****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Specifies whether the image is an enterprise-level Container Registry image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsEnterpriseRegistry")]
                [Validation(Required=false)]
                public bool? IsEnterpriseRegistry { get; set; }

                /// <summary>
                /// <para>The regions in which the Container Registry instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crr-h1ghghu60ct****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The name of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_71</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The namespace to which the image repository belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>safeline</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The tag of the Container Registry image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.40.2</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The URL of the Container Registry image tag.</para>
                /// </summary>
                [NameInMap("TagUrl")]
                [Validation(Required=false)]
                public string TagUrl { get; set; }

            }

            /// <summary>
            /// <para>The arguments that are passed to the container startup command. Separate the parameters with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-a</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The command that is used to start the container. Separate the arguments with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The environment variables. Separate the environment variables with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>VITE_APP_TITLE=My App</para>
            /// </summary>
            [NameInMap("EnvVariables")]
            [Validation(Required=false)]
            public string EnvVariables { get; set; }

            /// <summary>
            /// <para>The address of the image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shenzhen.aliyuncs.com/lihe<b><b>h/ea</b></b>ts_serv**<b>am:3.</b></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>Specifies whether the image is a Container Registry image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsACRImage")]
            [Validation(Required=false)]
            public bool? IsACRImage { get; set; }

            /// <summary>
            /// <para>The name of the container. The name must be unique in the same container group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lxg-demo-er</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The command that is run before the container is started. Separate the arguments with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh poststart.sh &quot;echo hello world&quot;</para>
            /// </summary>
            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            /// <summary>
            /// <para>The command that is run before the container is stopped. Separate the arguments with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh prestop.sh &quot;echo hello world&quot;</para>
            /// </summary>
            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>The content of the container health probe.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProbeContent")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersProbeContent ProbeContent { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersProbeContent : TeaModel {
                /// <summary>
                /// <para>The command of the exec type probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo ok</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The number of consecutive failed health checks required for a container to be considered as unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.rewrite.com">www.rewrite.com</a></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The request headers that are included in the container health check request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;Content-Type\&quot;:\&quot;application/json\&quot;}]</para>
                /// </summary>
                [NameInMap("HttpHeaders")]
                [Validation(Required=false)]
                public string HttpHeaders { get; set; }

                /// <summary>
                /// <para>The latency for container probe initialization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The health check path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The interval between container health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The health check port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9991</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol that the container health check request uses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("Scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required for a container to be considered as healthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                /// <summary>
                /// <para>The timeout period of the container health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            /// <summary>
            /// <para>The type of the probe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>exec: the command type.</description></item>
            /// <item><description>tcpSocket: the TCP probe type.</description></item>
            /// <item><description>httpGet: the HTTP access type.</description></item>
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
            /// <para>The compute specification of the container. Valid values: 1C2G, 2C4G, 2C8G, 4C8G, 4C16G, 8C16G, and 8C32G.</para>
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
        /// <para>The version name, which must be 6 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verson1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The description of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
