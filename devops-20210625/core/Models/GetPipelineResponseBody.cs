// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>112222122</para>
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("envId")]
            [Validation(Required=false)]
            public int? EnvId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>日常环境</para>
            /// </summary>
            [NameInMap("envName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>112222122</para>
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>流水线</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pipelineConfig")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyPipelinePipelineConfig PipelineConfig { get; set; }
            public class GetPipelineResponseBodyPipelinePipelineConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>schema: tb pipeline:   - name: 执行命令     stages:       - driven: AUTO         jobs:           - displayName: 执行命令             task: execution-component-production@10             identifier: &quot;10_1626147407245&quot;             templateType: task             templateSign: &quot;&quot;             templateBatchUpdate: &quot;N&quot;             extraInfo: &quot;&quot;             params:               version1: pre-jdk1.62               steps:                 - name: 执行命令                   stepType: exec-shell                   stepIdentifier: &quot;10_1626147407245__11_1626147407249&quot;                   command: |                     # input your command here                     echo hello,world!                   ARTIFACTS: &quot;&quot;                   JSONEncoding: true                   freeInTaskGroupModeFields:                     - ARTIFACTS                   source: 132504-sss_ddd_3mvJ               ENGINE_PIPELINE_NAME: &quot;${INPUTS.ENGINE_PIPELINE_NAME}&quot;               ENGINE_PIPELINE_ID: &quot;${INPUTS.ENGINE_PIPELINE_ID}&quot;               ENGINE_PIPELINE_INST_ID: &quot;${INPUTS.ENGINE_PIPELINE_INST_ID}&quot;               ENGINE_PIPELINE_INST_NUMBER: &quot;${INPUTS.ENGINE_PIPELINE_INST_NUMBER}&quot;               buildNodeGroup: K8S-4             plugins: []             output: []             freeInTaskGroupModeFields: []</para>
                /// </summary>
                [NameInMap("flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<GetPipelineResponseBodyPipelinePipelineConfigSources> Sources { get; set; }
                public class GetPipelineResponseBodyPipelinePipelineConfigSources : TeaModel {
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodyPipelinePipelineConfigSourcesData Data { get; set; }
                    public class GetPipelineResponseBodyPipelinePipelineConfigSourcesData : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>master</para>
                        /// </summary>
                        [NameInMap("branch")]
                        [Validation(Required=false)]
                        public string Branch { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("cloneDepth")]
                        [Validation(Required=false)]
                        public long? CloneDepth { get; set; }

                        /// <summary>
                        /// <para>Credential Id</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>222</para>
                        /// </summary>
                        [NameInMap("credentialId")]
                        [Validation(Required=false)]
                        public long? CredentialId { get; set; }

                        /// <summary>
                        /// <para>Credential Label</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>企业公钥</para>
                        /// </summary>
                        [NameInMap("credentialLabel")]
                        [Validation(Required=false)]
                        public string CredentialLabel { get; set; }

                        /// <summary>
                        /// <para>Credential Type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>region-ssh</para>
                        /// </summary>
                        [NameInMap("credentialType")]
                        [Validation(Required=false)]
                        public string CredentialType { get; set; }

                        [NameInMap("events")]
                        [Validation(Required=false)]
                        public List<string> Events { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("isBranchMode")]
                        [Validation(Required=false)]
                        public bool? IsBranchMode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("isCloneDepth")]
                        [Validation(Required=false)]
                        public bool? IsCloneDepth { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("isSubmodule")]
                        [Validation(Required=false)]
                        public bool? IsSubmodule { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("isTrigger")]
                        [Validation(Required=false)]
                        public bool? IsTrigger { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cdup/ss</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>asasasas</para>
                        /// </summary>
                        [NameInMap("namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://codeup.aliyun.com/test.git">https://codeup.aliyun.com/test.git</a></para>
                        /// </summary>
                        [NameInMap("repo")]
                        [Validation(Required=false)]
                        public string Repo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("serviceConnectionId")]
                        [Validation(Required=false)]
                        public long? ServiceConnectionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>.*</para>
                        /// </summary>
                        [NameInMap("triggerFilter")]
                        [Validation(Required=false)]
                        public string TriggerFilter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://flow.aliyun/webhook/asassasa">https://flow.aliyun/webhook/asassasa</a></para>
                        /// </summary>
                        [NameInMap("webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxsxsxs</para>
                    /// </summary>
                    [NameInMap("sign")]
                    [Validation(Required=false)]
                    public string Sign { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Codeup</para>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>标签1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
