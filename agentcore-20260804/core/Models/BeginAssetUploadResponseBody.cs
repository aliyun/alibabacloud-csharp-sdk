// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class BeginAssetUploadResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>包含 assetId、uploadId、实际 status、contentType，以及有效 UPLOADING 会话的 uploadUrl、headers 和 expiresAt。携带 sourceETag 的 Begin 复用当前上传目标时，可返回 PENDING、PROCESSING 或 COMPLETED，此时不返回上传地址，无需再次上传或确认；应依据 status 判断是否完成。显式提供相同 clientToken 且未传 sourceETag 的 PENDING 重放仍须通过 CompleteAssetUpload 补交调度。完成 PUT 上传后，CompleteAssetUpload 必须传回此 uploadId。uploadUrl 统一使用 OSS 公网地址；不返回固定上传方法或固定大小上限。签名到期不代表上传意图失效。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BeginAssetUploadResponseBodyData Data { get; set; }
        public class BeginAssetUploadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>本次上传所属资产的稳定 ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>平台校验或推导后的原件 MIME 类型；返回上传签名时与 headers 中的 Content-Type 一致，上传必须原样携带。</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/pdf</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>ISO 8601 UTC 时间，仅随有效 UPLOADING 会话的 uploadUrl 返回；客户端 token 幂等重放（须显式提供并命中最近一次 Begin 保存的 token）或来源版本去重命中有效上传会话时可获取刷新后的签名。签名过期不等于上传意图过期。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:15:00Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>仅随有效 UPLOADING 会话的 uploadUrl 返回。上传必须原样带入的签名请求头，包括 Content-Type 及不可覆盖写入约束所需的头；不得自行增加、更改或省略参与签名的头。旧上传地址也不得改写已存在的原件对象。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Content-Type&quot;:&quot;application/pdf&quot;}</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>新登记上传为 UPLOADING；客户端 token 幂等重放（须显式提供并命中最近一次 Begin 保存的 token）或来源版本去重均返回实际状态，仅 UPLOADING 且上传意图有效时可签发 URL。携带 sourceETag 的 Begin 复用当前上传目标时，可返回 PENDING、PROCESSING 或 COMPLETED，无需再次上传或确认；PENDING 按相同 taskKey 补交调度，不递增加工代次。显式提供相同 clientToken 且未传 sourceETag 的 PENDING 重放仍须通过 CompleteAssetUpload 补交调度。版本相同不表示处理完成。客户端 token 幂等命中 FAILED 时返回失败状态；新的上传意图遇到 FAILED 或上传意图过期时按规则创建新会话。</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>本次上传会话的稳定标识，完成 PUT 上传后调用 CompleteAssetUpload 时必传。客户端提供的 clientToken 命中最近一次 Begin 保存的 token 且规范化请求相同，或指定稳定 assetId、overwrite=true 并满足 sourceETag 去重条件时复用当前 uploadId 和加工代次；来源版本去重不要求提供 clientToken。其他合法的新上传意图生成新的 uploadId 和内部原件路径，未提供 clientToken 不保证跨请求重试幂等。</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload-001</para>
            /// </summary>
            [NameInMap("uploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>仅限该资产原件对象的短期预签名 PUT URL，统一使用 OSS 公网地址；仅 UPLOADING 且上传意图有效时返回。客户端 token 幂等重放（须显式提供并命中最近一次 Begin 保存的 token）或来源版本去重命中有效上传会话时刷新同一对象路径的签名，不用于覆盖已确认上传的原件；PENDING、PROCESSING、COMPLETED 或 FAILED 均不返回。不得记录到普通日志。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/tenants/1234567890123456/workspaces/ws-001/kb/kb-001/assets/asset-001/original/upload-001/source?signature=REDACTED">https://example.com/tenants/1234567890123456/workspaces/ws-001/kb/kb-001/assets/asset-001/original/upload-001/source?signature=REDACTED</a></para>
            /// </summary>
            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
