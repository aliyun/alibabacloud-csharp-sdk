// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetSessionClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sessionCluster")]
        [Validation(Required=false)]
        public GetSessionClusterResponseBodySessionCluster SessionCluster { get; set; }
        public class GetSessionClusterResponseBodySessionCluster : TeaModel {
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<GetSessionClusterResponseBodySessionClusterApplicationConfigs> ApplicationConfigs { get; set; }
            public class GetSessionClusterResponseBodySessionClusterApplicationConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>spark-defaults.conf</para>
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spark.app.name</para>
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStartConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class GetSessionClusterResponseBodySessionClusterAutoStopConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esr-2.2(Java Runtime)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>your.domain.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TSK-xxxxxxxx</para>
            /// </summary>
            [NameInMap("draftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-cpv569tlhtgndjl86t40</para>
            /// </summary>
            [NameInMap("envId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>作业实例名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esr-2.2（Java Runtime）</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>交互式作业会话id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234abcd-12ab-34cd-56ef-1234567890ab</para>
            /// </summary>
            [NameInMap("sessionClusterId")]
            [Validation(Required=false)]
            public string SessionClusterId { get; set; }

            /// <summary>
            /// <para>作业状态。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public GetSessionClusterResponseBodySessionClusterStateChangeReason StateChangeReason { get; set; }
            public class GetSessionClusterResponseBodySessionClusterStateChangeReason : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>任务实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-231231</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://spark-ui/link">https://spark-ui/link</a></para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

            /// <summary>
            /// <para>工作空间id。</para>
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
