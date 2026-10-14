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
        /// <para>The session object.</para>
        /// </summary>
        [NameInMap("sessionCluster")]
        [Validation(Required=false)]
        public GetSessionClusterResponseBodySessionCluster SessionCluster { get; set; }
        public class GetSessionClusterResponseBodySessionCluster : TeaModel {
            /// <summary>
            /// <para>The list of Spark application configurations.</para>
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<GetSessionClusterResponseBodySessionClusterApplicationConfigs> ApplicationConfigs { get; set; }
            public class GetSessionClusterResponseBodySessionClusterApplicationConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-defaults.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <para>The configuration key.</para>
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
            /// <para>The auto-start configuration.</para>
            /// </summary>
            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStartConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether auto-start is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
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
            /// <para>The auto-stop configuration.</para>
            /// </summary>
            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStopConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether auto-stop is allowed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The idle timeout in minutes after which the session is automatically stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            /// <summary>
            /// <para>The token used to connect to the session cluster.</para>
            /// </summary>
            [NameInMap("connectionToken")]
            [Validation(Required=false)]
            public string ConnectionToken { get; set; }

            /// <summary>
            /// <para>The version actually displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The domain to which the session Spark UI belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your.domain.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-spark-gateway-cn-hangzhou-internal.data.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domainInner")]
            [Validation(Required=false)]
            public string DomainInner { get; set; }

            /// <summary>
            /// <para>The ID of the development job bound to the session.</para>
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
            /// <para>env-cpv569tlhtgndjl8****</para>
            /// </summary>
            [NameInMap("envId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The extra metadata of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extraInfoKey&quot;:&quot;extraInfoValue&quot;}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>Specifies whether Fusion engine acceleration is enabled.</para>
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
            /// <para>The effective job type. This parameter is required and cannot be modified after creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SQLSCRIPT: SQL job.</description></item>
            /// <item><description>JAR: JAR job.</description></item>
            /// <item><description>PYTHON: Python job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The session name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether the public network access endpoint is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("publicEndpointEnabled")]
            [Validation(Required=false)]
            public bool? PublicEndpointEnabled { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The Serverless Spark version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The interactive job session ID.</para>
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
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Starting: The job is starting.</description></item>
            /// <item><description>Running: The job is running.</description></item>
            /// <item><description>Stopping: The job is stopping.</description></item>
            /// <item><description>Stopped: The job is stopped.</description></item>
            /// <item><description>Error: The job has failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The reason for the state change.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterStateChangeReason StateChangeReason { get; set; }
            public class GetSessionClusterResponseBodySessionClusterStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The code for the state change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The message for the state change.</para>
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
            /// <para>123xxxxxxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the session creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The URL of the session Spark UI.</para>
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
