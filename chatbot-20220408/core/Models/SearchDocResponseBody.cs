// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchDocResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of documents.</para>
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
            /// <para>The document parsing and chunking configuration.</para>
            /// <para>Configuration item: Splitter
            /// KEY: Splitter
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>paragraphSplitter: hierarchy recognition (default)</description></item>
            /// <item><description>treeSplitter: rule-based hierarchy</description></item>
            /// </list>
            /// <para>Configuration item: Document chunk size
            /// KEY: ChunkSize
            /// VALUE: Default value: 500. Value range: [200, 800].</para>
            /// <para>Configuration item: Rule-based hierarchy
            /// KEY: TreePatterns
            /// VALUE: Default value: [].</para>
            /// <para>Configuration item: Document title source
            /// KEY: TitleSource
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ocrTitle: OCR-recognized title (default)</description></item>
            /// <item><description>docName: document name as title</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;docName&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-22T03:53:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
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
            /// <para>John</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The document name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DocumentName</para>
            /// </summary>
            [NameInMap("DocName")]
            [Validation(Required=false)]
            public string DocName { get; set; }

            /// <summary>
            /// <para>The list of label details.</para>
            /// </summary>
            [NameInMap("DocTags")]
            [Validation(Required=false)]
            public List<SearchDocResponseBodyDocHitsDocTags> DocTags { get; set; }
            public class SearchDocResponseBodyDocHitsDocTags : TeaModel {
                /// <summary>
                /// <para>Indicates whether this is the default label that represents all labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultTag")]
                [Validation(Required=false)]
                public bool? DefaultTag { get; set; }

                /// <summary>
                /// <para>The label group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3610</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The label group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Article</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The label ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1201</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                /// <summary>
                /// <para>The label name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Novel</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The knowledge effective status, calculated based on StartDate and EndDate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>20: effective</description></item>
            /// <item><description>21: expired</description></item>
            /// <item><description>22: pending effective</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public int? EffectStatus { get; set; }

            /// <summary>
            /// <para>The expiration time in UTC.</para>
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
            /// <para>The metadata associated with the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-25T02:27:42Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222222222</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            /// <summary>
            /// <para>The name of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jane</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>Indicates whether the task can be retried. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The task can be retried.</description></item>
            /// <item><description>false: The task cannot be retried.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProcessCanRetry")]
            [Validation(Required=false)]
            public bool? ProcessCanRetry { get; set; }

            /// <summary>
            /// <para>The task processing message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task processing succeeded</para>
            /// </summary>
            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            /// <summary>
            /// <para>The task processing status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: queued</description></item>
            /// <item><description>0: succeeded</description></item>
            /// <item><description>1: parsing</description></item>
            /// <item><description>2: processing</description></item>
            /// <item><description>3: processing failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <para>The effective period in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-28T11:40:18Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The editing status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: unpublished</description></item>
            /// <item><description>2: published</description></item>
            /// <item><description>3: updated but not published</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The OSS URL where the document is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/%E6%96%87%E6%A1%A3%E9%97%AE%E7%AD%94%E8%AF%B4%E6%98%8E%E4%B9%A6_V1.pdf">https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/文档问答说明书_V1.pdf</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3E5C779-A630-45AC-B0F2-A4506A4212F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
