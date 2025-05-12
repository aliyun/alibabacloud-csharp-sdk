// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetStyleLearningResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStyleLearningResultResponseBodyData Data { get; set; }
        public class GetStyleLearningResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AIGC 生成的内容</para>
            /// </summary>
            [NameInMap("AigcResult")]
            [Validation(Required=false)]
            public string AigcResult { get; set; }

            [NameInMap("ContentList")]
            [Validation(Required=false)]
            public List<GetStyleLearningResultResponseBodyDataContentList> ContentList { get; set; }
            public class GetStyleLearningResultResponseBodyDataContentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建时间</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建用户</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>修改时间</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>修改用户</para>
                /// </summary>
                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public string UpdateUser { get; set; }

            }

            [NameInMap("CustomTextIdList")]
            [Validation(Required=false)]
            public List<long?> CustomTextIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MaterialIdList")]
            [Validation(Required=false)]
            public List<long?> MaterialIdList { get; set; }

            [NameInMap("MaterialInfoList")]
            [Validation(Required=false)]
            public List<GetStyleLearningResultResponseBodyDataMaterialInfoList> MaterialInfoList { get; set; }
            public class GetStyleLearningResultResponseBodyDataMaterialInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>作者</para>
                /// </summary>
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建时间</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建用户ID</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建用户姓名</para>
                /// </summary>
                [NameInMap("CreateUserName")]
                [Validation(Required=false)]
                public string CreateUserName { get; set; }

                [NameInMap("DocKeywords")]
                [Validation(Required=false)]
                public List<string> DocKeywords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档类型，pdf、word、url、image</para>
                /// </summary>
                [NameInMap("DocType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>外部客户上传的URL，仅用作记录保存</para>
                /// </summary>
                [NameInMap("ExternalUrl")]
                [Validation(Required=false)]
                public string ExternalUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("FileLength")]
                [Validation(Required=false)]
                public int? FileLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>解析后的原始html内容</para>
                /// </summary>
                [NameInMap("HtmlContent")]
                [Validation(Required=false)]
                public string HtmlContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发布时间</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>临时的对外公开的URL</para>
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ShareAttr")]
                [Validation(Required=false)]
                public int? ShareAttr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档来源，user_upload、search、viewpoint</para>
                /// </summary>
                [NameInMap("SrcFrom")]
                [Validation(Required=false)]
                public string SrcFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>解析后的文本内容，对于图片来说为空</para>
                /// </summary>
                [NameInMap("TextContent")]
                [Validation(Required=false)]
                public string TextContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>图片文档类型的Base64缩略图</para>
                /// </summary>
                [NameInMap("ThumbnailInBase64")]
                [Validation(Required=false)]
                public string ThumbnailInBase64 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文档标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>修改时间</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>修改用户ID</para>
                /// </summary>
                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public string UpdateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>修改用户姓名</para>
                /// </summary>
                [NameInMap("UpdateUserName")]
                [Validation(Required=false)]
                public string UpdateUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>内部文档保存的URL，支持多协议，http://,file://,ftp://:客户上传时保存到内部存储的URL、长期保存、到期删除</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用户修订后内容</para>
            /// </summary>
            [NameInMap("RewriteResult")]
            [Validation(Required=false)]
            public string RewriteResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文体风格名称</para>
            /// </summary>
            [NameInMap("StyleName")]
            [Validation(Required=false)]
            public string StyleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
