// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class PreviewKnowledgeBaseSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>文本内容（CONTENT类型使用）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>文件扩展名（OSS_IMM类型使用）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("fileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>文件名（OSS_IMM类型使用）</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>预览类型：OSS_IMM / IMAGE / AUDIO / VIDEO / HTML / DING_TALK / VOICE_MEETING / CONTENT</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS_IMM</para>
        /// </summary>
        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        /// <summary>
        /// <para>预览URL（OSS_IMM、DING_TALK、VOICE_MEETING使用）</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("previewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>公开下载URL（可供下载的文件URL）</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("publicUrl")]
        [Validation(Required=false)]
        public string PublicUrl { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
