// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSessionClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The sessions.</para>
        /// </summary>
        [NameInMap("sessionClusters")]
        [Validation(Required=false)]
        public List<ListSessionClustersResponseBodySessionClusters> SessionClusters { get; set; }
        public class ListSessionClustersResponseBodySessionClusters : TeaModel {
            /// <summary>
            /// <para>The session configurations, which are equivalent to the configurations of the Spark job.</para>
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<ListSessionClustersResponseBodySessionClustersApplicationConfigs> ApplicationConfigs { get; set; }
            public class ListSessionClustersResponseBodySessionClustersApplicationConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark-default.conf</para>
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
                /// <para>test_application</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            /// <summary>
            /// <para>The automatic startup configurations.</para>
            /// </summary>
            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStartConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic startup is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>The configurations of automatic termination.</para>
            /// </summary>
            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStopConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic termination is enabled.</para>
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
                /// <para>45</para>
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            [NameInMap("connectionToken")]
            [Validation(Required=false)]
            public string ConnectionToken { get; set; }

            /// <summary>
            /// <para>The version of the Spark engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The public endpoint of the Thrift server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-spark-gateway-cn-hangzhou.data.aliyun.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the Thrift server.</para>
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
            /// <para>TSK-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("draftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

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
            /// <para>1732267598000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOTEBOOK</description></item>
            /// <item><description>THRIFT</description></item>
            /// <item><description>SQL</description></item>
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
            /// <para>adhoc_query</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("publicEndpointEnabled")]
            [Validation(Required=false)]
            public bool? PublicEndpointEnabled { get; set; }

            /// <summary>
            /// <para>The name of the queue that is used to run the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The version of EMR Serverless Spark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-2.1</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-123131</para>
            /// </summary>
            [NameInMap("sessionClusterId")]
            [Validation(Required=false)]
            public string SessionClusterId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1732267598000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the session.</para>
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
            /// <para>The details of the most recent status change of the session.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersStateChangeReason StateChangeReason { get; set; }
            public class ListSessionClustersResponseBodySessionClustersStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The status change code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
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
            /// <para>123131</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The Spark UI of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://spark-ui-xxxx">http://spark-ui-xxxx</a></para>
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

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
