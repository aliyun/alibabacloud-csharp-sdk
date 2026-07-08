// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingV2Request : TeaModel {
        /// <summary>
        /// <para>A list of articles to use as references. <b>Note:</b> When you provide this parameter, web search is disabled, overriding the <c>UseSearch</c> and <c>SearchSources</c> parameters.</para>
        /// </summary>
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestArticles> Articles { get; set; }
        public class RunWritingV2RequestArticles : TeaModel {
            /// <summary>
            /// <para>The content of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The publication time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-25 14:25:59</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The name of the search source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("SearchSourceName")]
            [Validation(Required=false)]
            public string SearchSourceName { get; set; }

            /// <summary>
            /// <para>The source of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新华社</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The title of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the article.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable step-by-step writing. For more information, see the <c>Step</c> parameter description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistributeWriting")]
        [Validation(Required=false)]
        public bool? DistributeWriting { get; set; }

        /// <summary>
        /// <para>The number of articles to write. If you request multiple articles, the system returns them concurrently, each with a unique session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GcNumberSize")]
        [Validation(Required=false)]
        public int? GcNumberSize { get; set; }

        /// <summary>
        /// <para>A string that specifies the desired article length. Examples: &quot;about 300 words&quot;, &quot;about 600 words&quot;, &quot;about 1,000 words&quot;, or &quot;about 2,000 words&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000字左右</para>
        /// </summary>
        [NameInMap("GcNumberSizeTag")]
        [Validation(Required=false)]
        public string GcNumberSizeTag { get; set; }

        /// <summary>
        /// <para>A list of keywords used for both search and writing.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>The output language for the article.</para>
        /// <list type="bullet">
        /// <item><description><para><c>en</c>: English</para>
        /// </description></item>
        /// <item><description><para><c>zh</c>: Chinese</para>
        /// </description></item>
        /// <item><description><para>Other languages or specific style requirements can also be specified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>A list of article snippets.</para>
        /// </summary>
        [NameInMap("MiniDocs")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestMiniDocs> MiniDocs { get; set; }
        public class RunWritingV2RequestMiniDocs : TeaModel {
            /// <summary>
            /// <para>The content of the snippet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>片段内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The index of the article snippet in the referenced article.</para>
            /// 
            /// <b>Example:</b>
            /// <para>索引</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <para>Specifies whether to prioritize this snippet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Star")]
            [Validation(Required=false)]
            public bool? Star { get; set; }

        }

        /// <summary>
        /// <para>A list of outlines for step-by-step writing.</para>
        /// </summary>
        [NameInMap("OutlineList")]
        [Validation(Required=false)]
        public List<WritingOutline> OutlineList { get; set; }

        /// <summary>
        /// <para>A list of outlines for step-by-step writing. This parameter is deprecated. Use <c>OutlineList</c> instead.</para>
        /// </summary>
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestOutlines> Outlines { get; set; }
        public class RunWritingV2RequestOutlines : TeaModel {
            /// <summary>
            /// <para>A list of articles referenced by the outline.</para>
            /// </summary>
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunWritingV2RequestOutlinesArticles> Articles { get; set; }
            public class RunWritingV2RequestOutlinesArticles : TeaModel {
                /// <summary>
                /// <para>The content of the article.</para>
                /// 
                /// <b>Example:</b>
                /// <para>正文内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The title of the article.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL of the article.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章URL</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The outline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>大纲</para>
            /// </summary>
            [NameInMap("Outline")]
            [Validation(Required=false)]
            public string Outline { get; set; }

        }

        /// <summary>
        /// <para>The writing prompt. You must provide either <c>Prompt</c> or <c>WritingParams</c>. For more information, see the description of the <c>PromptMode</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The prompt mode. Valid values: <c>Template</c> (template mode) and <c>PE</c> (advanced PE mode).</para>
        /// <ol>
        /// <item><description><para>If this parameter is omitted, you must provide the <c>Prompt</c> parameter. We recommend that the prompt includes the topic, length, requirements, and prohibitions.</para>
        /// </description></item>
        /// <item><description><para>If <c>PromptMode</c> is set to <c>Template</c>, you must provide <c>WritingParams</c>, which is a dictionary of string key-value pairs. For the required schema, see the <c>.Data.TemplateDefine[].Fields</c> field in the response of the <a href="https://help.aliyun.com/document_detail/2922609.html">ListWritingStyles</a> operation.</para>
        /// </description></item>
        /// <item><description><para>If <c>PromptMode</c> is set to <c>PE</c>, you must pass <c>WritingParams</c> with the following two fields:</para>
        /// <ol>
        /// <item><description><para><c>topic</c>: Required. The topic to write about.</para>
        /// </description></item>
        /// <item><description><para><c>prompt</c>: Optional. Any additional custom prompts or writing requirements.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Template</para>
        /// </summary>
        [NameInMap("PromptMode")]
        [Validation(Required=false)]
        public string PromptMode { get; set; }

        /// <summary>
        /// <para>A list of specified search sources to use.</para>
        /// </summary>
        [NameInMap("SearchSources")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestSearchSources> SearchSources { get; set; }
        public class RunWritingV2RequestSearchSources : TeaModel {
            /// <summary>
            /// <para>The type of search source. Valid values: <c>SystemSearch</c> (built-in system search), <c>CustomSemanticSearch</c> (search of a custom semantic index), and <c>ThirdSearch</c> (search through a third-party API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemSearch</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The unique identifier of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>The description of the search source. This parameter is deprecated and has no effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>互联网搜索</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of a single-turn conversation. This parameter is deprecated and its use is discouraged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The source tracing method. Currently, only <c>modelSourceTrace</c> is supported. If set to <c>modelSourceTrace</c>, the model adds citation markers (for example, <c>[[1]]</c>) to the end of each cited snippet in the generated text. The citation index starts at 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modelSourceTrace</para>
        /// </summary>
        [NameInMap("SourceTraceMethod")]
        [Validation(Required=false)]
        public string SourceTraceMethod { get; set; }

        /// <summary>
        /// <para>The step for step-by-step writing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>OutlineGenerate</c>: Outline generation</para>
        /// </description></item>
        /// <item><description><para><c>Writing</c>: Article writing</para>
        /// </description></item>
        /// </list>
        /// <para>When <c>DistributeWriting</c> is <c>true</c>, the default flow for step-by-step writing is to first generate an outline and then write the content based on it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Writing</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        /// <summary>
        /// <para>A list of summarization objects, used for step-by-step writing.</para>
        /// </summary>
        [NameInMap("Summarization")]
        [Validation(Required=false)]
        public List<RunWritingV2RequestSummarization> Summarization { get; set; }
        public class RunWritingV2RequestSummarization : TeaModel {
            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>事件名称</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The summary of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>事件摘编</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the task. You can reuse the same task ID for a multi-turn conversation.</para>
        /// <remarks>
        /// <para>The system automatically generates a <c>TaskId</c> if you do not specify one. Reusing the same <c>TaskId</c> for subsequent requests groups them into a single conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable web search. If <c>true</c>, the system uses its built-in web search feature. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseSearch")]
        [Validation(Required=false)]
        public bool? UseSearch { get; set; }

        /// <summary>
        /// <para>The unique ID of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The parameters for template-based writing, provided as a dictionary of string key-value pairs. You must provide either <c>Prompt</c> or <c>WritingParams</c>. For more information, see the description of the <c>PromptMode</c> parameter.</para>
        /// </summary>
        [NameInMap("WritingParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> WritingParams { get; set; }

        /// <summary>
        /// <para>The writing scene. Valid values: <c>government</c> (government affairs), <c>media</c>, <c>market</c> (marketing), <c>office</c>, and <c>custom</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>media</para>
        /// </summary>
        [NameInMap("WritingScene")]
        [Validation(Required=false)]
        public string WritingScene { get; set; }

        /// <summary>
        /// <para>The writing style. For a list of supported styles, see <a href="https://help.aliyun.com/document_detail/2922609.html">ListWritingStyles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻评论</para>
        /// </summary>
        [NameInMap("WritingStyle")]
        [Validation(Required=false)]
        public string WritingStyle { get; set; }

    }

}
