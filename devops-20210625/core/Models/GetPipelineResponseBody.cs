// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 流水线
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }
            [NameInMap("envId")]
            [Validation(Required=false)]
            public int? EnvId { get; set; }
            [NameInMap("envName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("pipelineConfig")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyPipelinePipelineConfig PipelineConfig { get; set; }
            public class GetPipelineResponseBodyPipelinePipelineConfig : TeaModel {
                /// <summary>
                /// 流水线配置信息
                /// </summary>
                [NameInMap("flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// 流水线环境变量等
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// 代码源
                /// </summary>
                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<GetPipelineResponseBodyPipelinePipelineConfigSources> Sources { get; set; }
                public class GetPipelineResponseBodyPipelinePipelineConfigSources : TeaModel {
                    /// <summary>
                    /// 代码数据
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodyPipelinePipelineConfigSourcesData Data { get; set; }
                    public class GetPipelineResponseBodyPipelinePipelineConfigSourcesData : TeaModel {
                        [NameInMap("branch")]
                        [Validation(Required=false)]
                        public string Branch { get; set; }
                        [NameInMap("cloneDepth")]
                        [Validation(Required=false)]
                        public long? CloneDepth { get; set; }
                        [NameInMap("credentialId")]
                        [Validation(Required=false)]
                        public long? CredentialId { get; set; }
                        [NameInMap("credentialLabel")]
                        [Validation(Required=false)]
                        public string CredentialLabel { get; set; }
                        [NameInMap("credentialType")]
                        [Validation(Required=false)]
                        public string CredentialType { get; set; }
                        [NameInMap("events")]
                        [Validation(Required=false)]
                        public List<string> Events { get; set; }
                        [NameInMap("isBranchMode")]
                        [Validation(Required=false)]
                        public bool? IsBranchMode { get; set; }
                        [NameInMap("isCloneDepth")]
                        [Validation(Required=false)]
                        public bool? IsCloneDepth { get; set; }
                        [NameInMap("isSubmodule")]
                        [Validation(Required=false)]
                        public bool? IsSubmodule { get; set; }
                        [NameInMap("isTrigger")]
                        [Validation(Required=false)]
                        public bool? IsTrigger { get; set; }
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }
                        [NameInMap("namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }
                        [NameInMap("repo")]
                        [Validation(Required=false)]
                        public string Repo { get; set; }
                        [NameInMap("serviceConnectionId")]
                        [Validation(Required=false)]
                        public long? ServiceConnectionId { get; set; }
                        [NameInMap("triggerFilter")]
                        [Validation(Required=false)]
                        public string TriggerFilter { get; set; }
                        [NameInMap("webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }
                    };

                    /// <summary>
                    /// 代码源唯一标识
                    /// </summary>
                    [NameInMap("sign")]
                    [Validation(Required=false)]
                    public string Sign { get; set; }

                    /// <summary>
                    /// 代码源类型aliyunGit 阿里云代码库 customGitlab  自建git giteeGit 码云 codeup Codeup git 通用git gitlab gitlab bitbucket bitbucket githubOAuth github
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("tagList")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineTagList> TagList { get; set; }
            public class GetPipelineResponseBodyPipelineTagList : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
