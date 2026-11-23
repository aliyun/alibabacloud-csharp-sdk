// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class ChatHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>可选。完整 JSON 可传 application/json，SSE 可传 text/event-stream。客户端必须在正文中以布尔值 params.responseStreaming 指定响应格式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("Accept")]
        [Validation(Required=false)]
        public string Accept { get; set; }

        /// <summary>
        /// <para>可选。enable 表示 SSE。每次请求须在正文中显式填写布尔参数 params.responseStreaming。本头不替代 X-GW-Protocol 或 X-GW 签名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("X-DashScope-SSE")]
        [Validation(Required=false)]
        public string XDashScopeSSE { get; set; }

        /// <summary>
        /// <para>必填，服务方发放的业务网关 AK，用于识别租户和业务凭据，不是用于 POP 鉴权的阿里云 AK。每次只传一个非空值；业务 SK 只在客户端用于计算签名，不随请求发送。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-gateway-access</para>
        /// </summary>
        [NameInMap("X-GW-Access")]
        [Validation(Required=false)]
        public string XGWAccess { get; set; }

        /// <summary>
        /// <para>必填，每次尝试唯一且非空的随机串，例如 UUID；不可重放旧签名。重试重新生成 nonce、时间戳及签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c093adf9-287a-4684-982a-1aea5a248c2e</para>
        /// </summary>
        [NameInMap("X-GW-Nonce")]
        [Validation(Required=false)]
        public string XGWNonce { get; set; }

        /// <summary>
        /// <para>本文小驼峰请求与响应必须显式传 aliyun-roa，且只传一次。省略选择旧协议，不能直接照搬小驼峰正文。此头不参与业务 HMAC，不代替 POP 鉴权或 X-GW-* 业务签名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-roa</para>
        /// </summary>
        [NameInMap("X-GW-Protocol")]
        [Validation(Required=false)]
        public string XGWProtocol { get; set; }

        /// <summary>
        /// <para>必填，使用业务网关 SK 计算的 64 位小写十六进制 HMAC-SHA256。六段按 LF 连接且无末尾换行：METHOD、PATH、CANONICAL_QUERY、BODY_SHA256_HEX、TIMESTAMP、NONCE。原始 query 按 &amp; 分项去空、字典序排序，不 decode/re-encode；正文按实际发送的 UTF-8 字节摘要。具体双签名示例见接口说明。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000000000000000000000000000000000000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("X-GW-Signature")]
        [Validation(Required=false)]
        public string XGWSignature { get; set; }

        /// <summary>
        /// <para>必填，当前 Unix 毫秒时间戳的数字字符串；有效时间窗按凭据配置。签名规范串与本头使用完全相同的字符串。每次重试重新生成时间戳、nonce 和签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794787200000</para>
        /// </summary>
        [NameInMap("X-GW-Timestamp")]
        [Validation(Required=false)]
        public string XGWTimestamp { get; set; }

        /// <summary>
        /// <para>必填，恰好一个，须与 communication.requestId 完全一致。格式 [A-Za-z0-9._:-]{1,128}，不得用保留前缀 gw-ingress-。例如 chat-20261118-001；这是业务关联号，不保证重复请求只执行一次。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-example-001</para>
        /// </summary>
        [NameInMap("X-Request-Id")]
        [Validation(Required=false)]
        public string XRequestId { get; set; }

    }

}
