// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The versions.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListEdgeContainerAppVersionsResponseBodyVersions> Versions { get; set; }
        public class ListEdgeContainerAppVersionsResponseBodyVersions : TeaModel {
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
            /// <para>The containers in the version.</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<ListEdgeContainerAppVersionsResponseBodyVersionsContainers> Containers { get; set; }
            public class ListEdgeContainerAppVersionsResponseBodyVersionsContainers : TeaModel {
                /// <summary>
                /// <para>The arguments that are passed to the container startup command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-c a=1</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <para>The command that is used to start the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openresty -g \&quot;daemon off;\&quot;</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The environment variables of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV=prod</para>
                /// </summary>
                [NameInMap("EnvVariables")]
                [Validation(Required=false)]
                public string EnvVariables { get; set; }

                /// <summary>
                /// <para>The address of the container image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The container name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>container1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The command that is run before the container is started. Format: <c>{&quot;exec&quot;:{&quot;command&quot;:[&quot;cat&quot;,&quot;/etc/group&quot;\\]}}</c>.</para>
                /// <para>If you want to cancel this configuration, set the parameter value to <c>&quot;&quot;</c> or <c>{}</c>. If you do not specify this parameter, this configuration is ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;bash\&quot;,\&quot;-c\&quot;,\&quot;cd /home/admin/</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The command that is run before the container is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sh stop.sh</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The container probe content.</para>
                /// </summary>
                [NameInMap("ProbeContent")]
                [Validation(Required=false)]
                public ListEdgeContainerAppVersionsResponseBodyVersionsContainersProbeContent ProbeContent { get; set; }
                public class ListEdgeContainerAppVersionsResponseBodyVersionsContainersProbeContent : TeaModel {
                    /// <summary>
                    /// <para>The probe command.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openresty -g  &quot;daemon off;</para>
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
                    /// <para>{\&quot;Content-Type\&quot;:\&quot;application/json\&quot;}</para>
                    /// </summary>
                    [NameInMap("HttpHeaders")]
                    [Validation(Required=false)]
                    public string HttpHeaders { get; set; }

                    /// <summary>
                    /// <para>The latency for container probe initialization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The port of the container health check.</para>
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
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// <para>The probe type of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>httpGet</para>
                /// </summary>
                [NameInMap("ProbeType")]
                [Validation(Required=false)]
                public string ProbeType { get; set; }

                /// <summary>
                /// <para>The compute specification of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1C2G</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The time when the version was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-10T02:53:16Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the version was last released. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-10T02:48:36Z</para>
            /// </summary>
            [NameInMap("LastPublishTime")]
            [Validation(Required=false)]
            public string LastPublishTime { get; set; }

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
            /// <para>The time when the version was released. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-10T02:48:36Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test version</para>
            /// </summary>
            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <para>The status of the current version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>created</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>creating</b></description></item>
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
            /// <para>2023-04-16 10:51:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
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
