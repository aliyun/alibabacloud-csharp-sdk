// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the version.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public GetEdgeContainerAppVersionResponseBodyVersion Version { get; set; }
        public class GetEdgeContainerAppVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-88068867578379****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The container images deployed for this version.</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<GetEdgeContainerAppVersionResponseBodyVersionContainers> Containers { get; set; }
            public class GetEdgeContainerAppVersionResponseBodyVersionContainers : TeaModel {
                /// <summary>
                /// <para>The information about the Container Registry image.</para>
                /// </summary>
                [NameInMap("ACRImageInfo")]
                [Validation(Required=false)]
                public GetEdgeContainerAppVersionResponseBodyVersionContainersACRImageInfo ACRImageInfo { get; set; }
                public class GetEdgeContainerAppVersionResponseBodyVersionContainersACRImageInfo : TeaModel {
                    /// <summary>
                    /// <para>The domain name of the Container Registry image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>*.mooc.seewo.com</para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>The ID of the Container Registry instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xcdn-9ak2thl14z5s</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the image is an enterprise-level image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsEnterpriseRegistry")]
                    [Validation(Required=false)]
                    public bool? IsEnterpriseRegistry { get; set; }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The ID of the image repository.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>crr-zeu0xyk28alyxozh</para>
                    /// </summary>
                    [NameInMap("RepoId")]
                    [Validation(Required=false)]
                    public string RepoId { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_1</para>
                    /// </summary>
                    [NameInMap("RepoName")]
                    [Validation(Required=false)]
                    public string RepoName { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the image repository belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wpy1</para>
                    /// </summary>
                    [NameInMap("RepoNamespace")]
                    [Validation(Required=false)]
                    public string RepoNamespace { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-healthy-100-soa-1710987653</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The URL of the Container Registry image tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-shenzhen.aliyuncs.com/lihetech/easywits_server_exam:3.40.2</para>
                    /// </summary>
                    [NameInMap("TagUrl")]
                    [Validation(Required=false)]
                    public string TagUrl { get; set; }

                }

                /// <summary>
                /// <para>The arguments that are passed to the container startup command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-c /path/config.toml</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <para>The command that is used to start the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sh abc.sh 1 2 3</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The environment variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV=prod</para>
                /// </summary>
                [NameInMap("EnvVariables")]
                [Validation(Required=false)]
                public string EnvVariables { get; set; }

                /// <summary>
                /// <para>The image address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx:1.14.0</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is a Container Registry image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsACRImage")]
                [Validation(Required=false)]
                public bool? IsACRImage { get; set; }

                /// <summary>
                /// <para>The version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>version01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The command that is run before the container is started. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c>. If you want to cancel this configuration, set the parameter value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;touch\&quot;,\&quot;/home/admin/checkpoststartV1\&quot;]}}</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The command that is run before the container is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sh prestop.sh &quot;echo hello world&quot;</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The probe content.</para>
                /// </summary>
                [NameInMap("ProbeContent")]
                [Validation(Required=false)]
                public GetEdgeContainerAppVersionResponseBodyVersionContainersProbeContent ProbeContent { get; set; }
                public class GetEdgeContainerAppVersionResponseBodyVersionContainersProbeContent : TeaModel {
                    /// <summary>
                    /// <para>The probe command.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sh test.sh</para>
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
                    /// <para>test.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The request headers that are included in the container health check request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{\&quot;Content-Type\&quot;:\&quot;application/json</para>
                    /// </summary>
                    [NameInMap("HttpHeaders")]
                    [Validation(Required=false)]
                    public string HttpHeaders { get; set; }

                    /// <summary>
                    /// <para>The latency for container probe initialization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// <para>The path of the container health check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/health_check</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The interval between container health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// <para>The port of the container health check. Valid values: <b>1</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
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
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// <para>The probe type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>httpGet</para>
                /// </summary>
                [NameInMap("ProbeType")]
                [Validation(Required=false)]
                public string ProbeType { get; set; }

                /// <summary>
                /// <para>The compute specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C2G</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The storage capacity of the container. Valid values: 0.5G, 10G, 20G, and 30G.</para>
                /// </summary>
                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

            }

            /// <summary>
            /// <para>The time when the version was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-01T09:32:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the version was last released. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T04:58:05Z</para>
            /// </summary>
            [NameInMap("LastPublishTime")]
            [Validation(Required=false)]
            public string LastPublishTime { get; set; }

            /// <summary>
            /// <para>The version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the version was released. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-14T02:04:03Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <para>The status of the current version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>created: The version is created.</description></item>
            /// <item><description>failed: The version failed to be created.</description></item>
            /// <item><description>creating: The version is being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the version was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-03T10:52:52Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the created version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-87962637161651****</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
