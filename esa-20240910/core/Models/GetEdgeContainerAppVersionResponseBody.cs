// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppVersionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public GetEdgeContainerAppVersionResponseBodyVersion Version { get; set; }
        public class GetEdgeContainerAppVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app-88068867578379****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<GetEdgeContainerAppVersionResponseBodyVersionContainers> Containers { get; set; }
            public class GetEdgeContainerAppVersionResponseBodyVersionContainers : TeaModel {
                [NameInMap("ACRImageInfo")]
                [Validation(Required=false)]
                public GetEdgeContainerAppVersionResponseBodyVersionContainersACRImageInfo ACRImageInfo { get; set; }
                public class GetEdgeContainerAppVersionResponseBodyVersionContainersACRImageInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>*.mooc.seewo.com</para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xcdn-9ak2thl14z5s</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsEnterpriseRegistry")]
                    [Validation(Required=false)]
                    public bool? IsEnterpriseRegistry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>crr-zeu0xyk28alyxozh</para>
                    /// </summary>
                    [NameInMap("RepoId")]
                    [Validation(Required=false)]
                    public string RepoId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_1</para>
                    /// </summary>
                    [NameInMap("RepoName")]
                    [Validation(Required=false)]
                    public string RepoName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>wpy1</para>
                    /// </summary>
                    [NameInMap("RepoNamespace")]
                    [Validation(Required=false)]
                    public string RepoNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-healthy-100-soa-1710987653</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-shenzhen.aliyuncs.com/lihetech/easywits_server_exam:3.40.2</para>
                    /// </summary>
                    [NameInMap("TagUrl")]
                    [Validation(Required=false)]
                    public string TagUrl { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-c /path/config.toml</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sh abc.sh 1 2 3</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENV=prod</para>
                /// </summary>
                [NameInMap("EnvVariables")]
                [Validation(Required=false)]
                public string EnvVariables { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nginx:1.14.0</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsACRImage")]
                [Validation(Required=false)]
                public bool? IsACRImage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>version01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;touch\&quot;,\&quot;/home/admin/checkpoststartV1\&quot;]}}</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sh prestop.sh &quot;echo hello world&quot;</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                [NameInMap("ProbeContent")]
                [Validation(Required=false)]
                public GetEdgeContainerAppVersionResponseBodyVersionContainersProbeContent ProbeContent { get; set; }
                public class GetEdgeContainerAppVersionResponseBodyVersionContainersProbeContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sh test.sh</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[{\&quot;Content-Type\&quot;:\&quot;application/json</para>
                    /// </summary>
                    [NameInMap("HttpHeaders")]
                    [Validation(Required=false)]
                    public string HttpHeaders { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/health_check</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>http</para>
                    /// </summary>
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>httpGet</para>
                /// </summary>
                [NameInMap("ProbeType")]
                [Validation(Required=false)]
                public string ProbeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1C2G</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-01T09:32:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-25T04:58:05Z</para>
            /// </summary>
            [NameInMap("LastPublishTime")]
            [Validation(Required=false)]
            public string LastPublishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-14T02:04:03Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-03T10:52:52Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ver-87962637161651****</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
