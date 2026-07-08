// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitEnterpriseVocAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The API key for integration access. For more information, see <a href="https://help.aliyun.com/zh/model-studio/get-api-key?spm=a2c4g.11186623.help-menu-2400256.d_2_0_0.1cbdb0a8lsT1n3">Get an API key</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-sdfs2-wewerwe-ere</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The content tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ContentTags")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestContentTags> ContentTags { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestContentTags : TeaModel {
            /// <summary>
            /// <para>The tag definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一级标签-二级标签</para>
            /// </summary>
            [NameInMap("TagDefinePrompt")]
            [Validation(Required=false)]
            public string TagDefinePrompt { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一级标签-二级标签</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The type of the tag mining task. Valid values: \<c>singleTagValue\\</c> (single tag), \<c>multiTagValues\\</c> (multiple tags), \<c>summaryAndOverview\\</c> (summarization and overview), and \<c>filter\\</c> (filtering).</para>
            /// 
            /// <b>Example:</b>
            /// <para>singleTagValue</para>
            /// </summary>
            [NameInMap("TagTaskType")]
            [Validation(Required=false)]
            public string TagTaskType { get; set; }

            /// <summary>
            /// <para>The definition of the tag value. For a tag mining task, this is a comma-separated list of enumerated values. For a summarization task, this is the summarization prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>是,否</para>
            /// </summary>
            [NameInMap("TagValueDefinePrompt")]
            [Validation(Required=false)]
            public string TagValueDefinePrompt { get; set; }

        }

        /// <summary>
        /// <para>The material content to be mined.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestContents> Contents { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestContents : TeaModel {
            /// <summary>
            /// <para>Additional information provided directly to the large language model (LLM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>额外信息</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>The material to be mined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容文本</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>The key of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://default/bucket-name/materialDocument/tenant_agent/fileName</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>The filter tags.</para>
        /// </summary>
        [NameInMap("FilterTags")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestFilterTags> FilterTags { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestFilterTags : TeaModel {
            /// <summary>
            /// <para>The tag definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一级标签-二级标签</para>
            /// </summary>
            [NameInMap("TagDefinePrompt")]
            [Validation(Required=false)]
            public string TagDefinePrompt { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一级标签-二级标签</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The type of the tag mining task. Valid values: \<c>singleTagValue\\</c> (single tag), \<c>multiTagValues\\</c> (multiple tags), \<c>summaryAndOverview\\</c> (summarization and overview), and \<c>filter\\</c> (filtering).</para>
            /// 
            /// <b>Example:</b>
            /// <para>singleTagValue</para>
            /// </summary>
            [NameInMap("TagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

            /// <summary>
            /// <para>The definition of the tag value. For a tag mining task, this is a comma-separated list of enumerated values. For a summarization task, this is the summarization prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>是,否</para>
            /// </summary>
            [NameInMap("TagValueDefinePrompt")]
            [Validation(Required=false)]
            public string TagValueDefinePrompt { get; set; }

        }

        /// <summary>
        /// <para>The material type. Valid values: \<c>shortContent\\</c> (long or short comments, or tickets) and \<c>dialogue\\</c> (dialogues).</para>
        /// 
        /// <b>Example:</b>
        /// <para>shortContent</para>
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// <para>The ID of the model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The content of the positive sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>正面样本</para>
        /// </summary>
        [NameInMap("PositiveSample")]
        [Validation(Required=false)]
        public string PositiveSample { get; set; }

        /// <summary>
        /// <para>The key of the positive sample file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://default/bucket-name/path/xxx.xlsx</para>
        /// </summary>
        [NameInMap("PositiveSampleFileKey")]
        [Validation(Required=false)]
        public string PositiveSampleFileKey { get; set; }

        /// <summary>
        /// <para>The task type. Valid values: \<c>lightAppSass\\</c> (invoked from a Software as a Service (SaaS) page) and \<c>sdkBatchTask\\</c> (SDK batch task).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lightAppSass</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
