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
        /// <para>The configuration for document parsing and splitting. Key: <c>Splitter</c>. Valid values: <c>paragraphSplitter</c> (splits by recognition level, default) and <c>treeSplitter</c> (splits by rule level).</para>
        /// <para>Key: <c>ChunkSize</c>. The size of each document chunk, which must be between 200 and 800. The default value is 500.</para>
        /// <para>Key: <c>TreePatterns</c>. The patterns for the rule-based hierarchy. The default value is [].</para>
        /// <para>Key: <c>TitleSource</c>. The source of the document title. Valid values: <c>ocrTitle</c> (OCR-recognized title, default) and <c>docName</c> (document name).</para>
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
        /// <para>The creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        /// <summary>
        /// <para>The creator name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
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
            /// <para>The paragraphs of the document.</para>
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
                /// <para>The paragraph number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParaNo")]
                [Validation(Required=false)]
                public int? ParaNo { get; set; }

                /// <summary>
                /// <para>The paragraph content. The content can be plain text, text extracted from an image using optical character recognition (OCR), or a table in Markdown format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("ParaText")]
                [Validation(Required=false)]
                public string ParaText { get; set; }

                /// <summary>
                /// <para>The paragraph type.<br>text: Text<br>figure: Image<br>table: Table<br><br><br></para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ParaType")]
                [Validation(Required=false)]
                public string ParaType { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of metadata sets, where each set corresponds to a business view.</para>
        /// </summary>
        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocMetadata> DocMetadata { get; set; }
        public class DescribeDocResponseBodyDocMetadata : TeaModel {
            /// <summary>
            /// <para>The ID of the business view.</para>
            /// </summary>
            [NameInMap("BusinessViewId")]
            [Validation(Required=false)]
            public string BusinessViewId { get; set; }

            /// <summary>
            /// <para>The business view name.</para>
            /// </summary>
            [NameInMap("BusinessViewName")]
            [Validation(Required=false)]
            public string BusinessViewName { get; set; }

            /// <summary>
            /// <para>A list of metadata cells.</para>
            /// </summary>
            [NameInMap("MetaCellInfoDTOList")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList> MetaCellInfoDTOList { get; set; }
            public class DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList : TeaModel {
                /// <summary>
                /// <para>The code of the field.</para>
                /// </summary>
                [NameInMap("FieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                /// <summary>
                /// <para>The field name.</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The value of the field.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

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
        /// <para>A list of document tags.</para>
        /// </summary>
        [NameInMap("DocTags")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocTags> DocTags { get; set; }
        public class DescribeDocResponseBodyDocTags : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tag represents all items by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DefaultTag")]
            [Validation(Required=false)]
            public bool? DefaultTag { get; set; }

            /// <summary>
            /// <para>The tag\&quot;s group ID.</para>
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
        /// <para>The effective status, calculated from <c>StartDate</c> and <c>EndDate</c>.<br>20: Active<br>21: Expired<br>22: Pending<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        /// <summary>
        /// <para>The end time in UTC format.</para>
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
        /// <para>The document\&quot;s metadata.</para>
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
        /// <para>The modifier ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2222222222</para>
        /// </summary>
        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public long? ModifyUserId { get; set; }

        /// <summary>
        /// <para>The modifier name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>Indicates whether a failed task can be retried.<br><c>true</c>: The task can be retried.<br><c>false</c>: The task cannot be retried.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ProcessCanRetry")]
        [Validation(Required=false)]
        public bool? ProcessCanRetry { get; set; }

        /// <summary>
        /// <para>The processing message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务处理成功</para>
        /// </summary>
        [NameInMap("ProcessMessage")]
        [Validation(Required=false)]
        public string ProcessMessage { get; set; }

        /// <summary>
        /// <para>The processing status of the task.<br>-1: Queued<br>0: Succeeded<br>1: Parsing<br>2: Processing<br>3: Failed<br><br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F132693-212A-40A9-8A81-11E7694E478B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1979-12-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The edit status.<br>1: Unpublished<br>2: Published<br>3: Updated but not published<br><br><br></para>
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
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The OSS address of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/%E6%96%87%E6%A1%A3%E9%97%AE%E7%AD%94%E8%AF%B4%E6%98%8E%E4%B9%A6_V1.pdf">https://doc2bot-bucket-cloud.oss-cn-shanghai.aliyuncs.com/doc2bot/input/文档问答说明书_V1.pdf</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
