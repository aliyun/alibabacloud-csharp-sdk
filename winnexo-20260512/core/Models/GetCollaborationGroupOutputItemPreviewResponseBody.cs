// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetCollaborationGroupOutputItemPreviewResponseBody : TeaModel {
        /// <summary>
        /// <para>公共业务状态码，由后端Code字段映射；错误时用于识别失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERR.Robject.Auth.TenantAccessDenied</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>可直接展示的文本正文或预览提示；不提供正文的文件类型可为空。</para>
        /// 
        /// <b>Example:</b>
        /// <h1>技术方案</h1>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>是否降级为下载。true时应展示下载入口，不要按在线文档预览器处理。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("degraded")]
        [Validation(Required=false)]
        public bool? Degraded { get; set; }

        /// <summary>
        /// <para>短期签名下载地址；普通文件有效期3600秒，邮件正文可为空。过期后重新调用本接口。示例仅展示URL格式，不包含真实签名。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/download/document.md">https://example.com/download/document.md</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>文件扩展名，不含点；无扩展名时可为空。</para>
        /// 
        /// <b>Example:</b>
        /// <para>md</para>
        /// </summary>
        [NameInMap("fileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>文件名，包含扩展名；无文件名时可为空。</para>
        /// 
        /// <b>Example:</b>
        /// <para>codex-r2-a-baseline.md</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>对话生成文件的产出明细ID。取GetNodeDetail返回的artifacts中ref.kind为USER_OUTPUT_ITEM的ref.id；不是artifactId。</para>
        /// 
        /// <b>Example:</b>
        /// <para>51469466</para>
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>公共错误说明，由后端Message字段映射；错误时描述失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>无权访问租户 2147483647，用户不属于该租户</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>预览方式，例如CONTENT为文本正文，HTML为网页，IMAGE为图片，AUDIO为音频，VIDEO为视频，OSS_IMM为文档预览。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTENT</para>
        /// </summary>
        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        /// <summary>
        /// <para>短期预览地址；正文可直接展示时可为空。地址过期后重新调用本接口。示例仅展示URL格式，不是可访问凭证。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/preview/document">https://example.com/preview/document</a></para>
        /// </summary>
        [NameInMap("previewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>请求追踪ID，由后端RequestId字段映射，用于排查调用失败。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9cf6cb3-3f5c-4994-a8a1-c93379a6f5cf</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
