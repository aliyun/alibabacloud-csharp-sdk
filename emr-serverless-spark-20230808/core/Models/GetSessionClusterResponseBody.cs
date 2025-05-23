// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetSessionClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session.</para>
        /// </summary>
        [NameInMap("sessionCluster")]
        [Validation(Required=false)]
        public GetSessionClusterResponseBodySessionCluster SessionCluster { get; set; }
        public class GetSessionClusterResponseBodySessionCluster : TeaModel {
            /// <summary>
            /// <para>The Spark configurations.</para>
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<GetSessionClusterResponseBodySessionClusterApplicationConfigs> ApplicationConfigs { get; set; }
            public class GetSessionClusterResponseBodySessionClusterApplicationConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-defaults.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <para>The key of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark.app.name</para>
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// <para>The configuration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether automatic startup is enabled.</para>
            /// </summary>
            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStartConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic startup is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether automatic termination is enabled.</para>
            /// </summary>
            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStopConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic termination is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The idle timeout period. The session is automatically terminated when the idle timeout period is exceeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            /// <summary>
            /// <para>The version of the Spark engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-2.2(Java Runtime)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The domain name to which the Spark UI of the session belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your.domain.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The internal endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-spark-gateway-cn-hangzhou-internal.data.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domainInner")]
            [Validation(Required=false)]
            public string DomainInner { get; set; }

            /// <summary>
            /// <para>The ID of the job that is associated with the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TSK-xxxxxxxx</para>
            /// </summary>
            [NameInMap("draftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            /// <summary>
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cpv569tlhtgndjl86t40</para>
            /// </summary>
            [NameInMap("envId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The additional metadata of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extraInfoKey&quot;:&quot;extraInfoValue&quot;}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>Indicates whether the Fusion engine is used for acceleration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-01 06:23:01</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The type of the job. This parameter is required and cannot be modified after the deployment is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SQLSCRIPT</description></item>
            /// <item><description>JAR</description></item>
            /// <item><description>PYTHON</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The name of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("publicEndpointEnabled")]
            [Validation(Required=false)]
            public bool? PublicEndpointEnabled { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The version of Serverless Spark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-2.2(Java Runtime)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234abcd-12ab-34cd-56ef-1234567890ab</para>
            /// </summary>
            [NameInMap("sessionClusterId")]
            [Validation(Required=false)]
            public string SessionClusterId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-01 06:23:01</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The job status.</para>
            /// <list type="bullet">
            /// <item><description>Starting</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Stopping</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Error</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The reason of the job status change.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterStateChangeReason StateChangeReason { get; set; }
            public class GetSessionClusterResponseBodySessionClusterStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The status change code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The status change message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-231231</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the account that is used to create the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The Spark UI of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://spark-ui/link">https://spark-ui/link</a></para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-1234abcd</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
