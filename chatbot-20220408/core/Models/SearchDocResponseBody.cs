// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchDocResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of matching documents.</para>
        /// </summary>
        [NameInMap("DocHits")]
        [Validation(Required=false)]
        public List<SearchDocResponseBodyDocHits> DocHits { get; set; }
        public class SearchDocResponseBodyDocHits : TeaModel {
            /// <summary>
            /// <para>The business code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_dytns</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000135654</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The splitter for the document. Key: <c>Splitter</c>. Valid values:<br>• <c>paragraphSplitter</c> (default): Splits the document by paragraph.<br>• <c>treeSplitter</c>: Splits the document based on a rule-based hierarchy.<br><br></para>
            /// <para>The size of each document chunk. Key: <c>ChunkSize</c>. Default value: 500. Value range: [200, 800].</para>
            /// <para>The patterns for the rule-based hierarchy. Key: <c>TreePatterns</c>. Default value: <c>[]</c>.</para>
            /// <para>The source of the document title. Key: <c>TitleSource</c>. Valid values:<br>• <c>ocrTitle</c> (default): Uses the OCR-identified title.<br>• <c>docName</c>: Uses the document name as the title.<br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;docName&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The time the document was created (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-22T03:53:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The document name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档名称</para>
            /// </summary>
            [NameInMap("DocName")]
            [Validation(Required=false)]
            public string DocName { get; set; }

            /// <summary>
            /// <para>A list of the document\&quot;s tags.</para>
            /// </summary>
            [NameInMap("DocTags")]
            [Validation(Required=false)]
            public List<SearchDocResponseBodyDocHitsDocTags> DocTags { get; set; }
            public class SearchDocResponseBodyDocHitsDocTags : TeaModel {
                /// <summary>
                /// <para>Indicates whether this is a default tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultTag")]
                [Validation(Required=false)]
                public bool? DefaultTag { get; set; }

                /// <summary>
                /// <para>The tag group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3610</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The tag group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1201</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小说</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The knowledge\&quot;s effective status, calculated based on <c>StartDate</c> and <c>EndDate</c>. Valid values:<br>• 20: Active<br>• 21: Expired<br>• 22: Pending<br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public int? EffectStatus { get; set; }

            /// <summary>
            /// <para>The time the knowledge expires (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-31T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The knowledge ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30002692007</para>
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            /// <summary>
            /// <para>The document metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>The time the document was last modified (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-25T02:27:42Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The modifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222222222</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            /// <summary>
            /// <para>The name of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>Indicates whether the task can be retried.<br>• <c>true</c>: The task can be retried.<br>• <c>false</c>: The task cannot be retried.<br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProcessCanRetry")]
            [Validation(Required=false)]
            public bool? ProcessCanRetry { get; set; }

            /// <summary>
            /// <para>The processing message for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务处理成功</para>
            /// </summary>
            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            /// <summary>
            /// <para>The task\&quot;s processing status. Valid values:<br>• -1: Queued<br>• 0: Succeeded<br>• 1: Parsing<br>• 2: Processing<br>• 3: Failed<br><br><br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <para>The time the knowledge takes effect (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-28T11:40:18Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The editing status of the document. Valid values:<br>• 1: Unpublished<br>• 2: Published<br>• 3: Updated but not published<br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The OSS URL of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/%E6%96%87%E6%A1%A3%E9%97%AE%E7%AD%94%E8%AF%B4%E6%98%8E%E4%B9%A6_V1.pdf">https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/文档问答说明书_V1.pdf</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
        /// <para>E3E5C779-A630-45AC-B0F2-A4506A4212F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
