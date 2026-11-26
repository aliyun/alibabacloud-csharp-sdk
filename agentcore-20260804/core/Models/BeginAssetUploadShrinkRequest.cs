// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class BeginAssetUploadShrinkRequest : TeaModel {
        /// <summary>
        /// <para>登记新资产，或为指定资产创建、复用上传会话。覆盖授权、最近 token 幂等检查、来源版本去重与加工代次分配由管控层原子完成。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>可选。提供时须为非空白字符串，最长 128 个字符；仅对该资产最近一次 Begin 保存的 token 幂等，后续 Begin（包括省略 clientToken 的请求）会替换最近请求标识。命中时必须使用相同规范化请求，包括 sourceETag，否则返回幂等冲突。未提供时按新的上传意图处理，不保证跨请求重试幂等；同时未指定 assetId 时每次请求创建新资产。与来源版本去重独立：被后续 Begin 替换的旧 token 再次到来时按新意图处理；覆盖已有资产仍须 overwrite=true，并可在指定稳定 assetId 时按 sourceETag 规则复用当前会话。</para>
        /// 
        /// <b>Example:</b>
        /// <para>asset-upload-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
