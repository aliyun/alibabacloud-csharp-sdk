// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeDocResponseBody : TeaModel {
        /// <summary>
        /// <para>The business code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bizcode123</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000049006</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The document parsing and chunking configuration items:</para>
        /// <para>Chunker KEY: Splitter. Valid values: paragraphSplitter - hierarchy recognition (default). treeSplitter - rule-based hierarchy.</para>
        /// <para>Document chunk size KEY: ChunkSize. VALUE: default 500. Range: [200, 800].</para>
        /// <para>Rule-based hierarchy KEY: TreePatterns. VALUE: default [].</para>
        /// <para>Document title source KEY: TitleSource. Valid values: ocrTitle - OCR-recognized title (default). docName - document name as title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;docName&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:17Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        /// <summary>
        /// <para>The name of the user who created the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <para>The document details.</para>
        /// </summary>
        [NameInMap("DocInfo")]
        [Validation(Required=false)]
        public DescribeDocResponseBodyDocInfo DocInfo { get; set; }
        public class DescribeDocResponseBodyDocInfo : TeaModel {
            /// <summary>
            /// <para>The document paragraph information.</para>
            /// </summary>
            [NameInMap("DocParas")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocInfoDocParas> DocParas { get; set; }
            public class DescribeDocResponseBodyDocInfoDocParas : TeaModel {
                /// <summary>
                /// <para>The paragraph level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParaLevel")]
                [Validation(Required=false)]
                public int? ParaLevel { get; set; }

                /// <summary>
                /// <para>The paragraph sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParaNo")]
                [Validation(Required=false)]
                public int? ParaNo { get; set; }

                /// <summary>
                /// <para>The paragraph content (plain text, OCR content for images, or Markdown representation for tables).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Content</para>
                /// </summary>
                [NameInMap("ParaText")]
                [Validation(Required=false)]
                public string ParaText { get; set; }

                /// <summary>
                /// <para>The paragraph content type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>text: Text.</description></item>
                /// <item><description>figure: Image.</description></item>
                /// <item><description>table: Table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ParaType")]
                [Validation(Required=false)]
                public string ParaType { get; set; }

            }

        }

        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocMetadata> DocMetadata { get; set; }
        public class DescribeDocResponseBodyDocMetadata : TeaModel {
            [NameInMap("BusinessViewId")]
            [Validation(Required=false)]
            public string BusinessViewId { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// </summary>
            [NameInMap("BusinessViewName")]
            [Validation(Required=false)]
            public string BusinessViewName { get; set; }

            [NameInMap("MetaCellInfoDTOList")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList> MetaCellInfoDTOList { get; set; }
            public class DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList : TeaModel {
                [NameInMap("FieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The document name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Document name</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The list of tag details.</para>
        /// </summary>
        [NameInMap("DocTags")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocTags> DocTags { get; set; }
        public class DescribeDocResponseBodyDocTags : TeaModel {
            /// <summary>
            /// <para>Indicates whether this is the default &quot;all tags&quot; label.</para>
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
            /// <para>Article</para>
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
            /// <para>Novel</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>The effective status, which is calculated based on StartDate and EndDate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>20: Effective.</description></item>
        /// <item><description>21: Expired.</description></item>
        /// <item><description>22: Pending effective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        /// <summary>
        /// <para>The expiration time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-27T06:08:54Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The knowledge ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001979424</para>
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
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-25T08:56:55Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The ID of the user who last modified the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2222222222</para>
        /// </summary>
        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public long? ModifyUserId { get; set; }

        /// <summary>
        /// <para>The name of the user who last modified the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
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
        /// <para>Task processed successfully</para>
        /// </summary>
        [NameInMap("ProcessMessage")]
        [Validation(Required=false)]
        public string ProcessMessage { get; set; }

        /// <summary>
        /// <para>The task processing status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: Queued.</description></item>
        /// <item><description>0: Succeeded.</description></item>
        /// <item><description>1: Parsing.</description></item>
        /// <item><description>2: Processing.</description></item>
        /// <item><description>3: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F132693-212A-40A9-8A81-11E7694E478B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The effective period (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1979-12-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The editing status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Unpublished.</description></item>
        /// <item><description>2: Published.</description></item>
        /// <item><description>3: Updated but not published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The document title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

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

}
