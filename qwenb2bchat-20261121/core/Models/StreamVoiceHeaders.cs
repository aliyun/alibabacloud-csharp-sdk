// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class StreamVoiceHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>握手必填的业务网关 AK，用于识别租户和凭据；与阿里云 API AK 用途不同。业务网关 SK 仅在客户端用于计算签名，不发送。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-gateway-access</para>
        /// </summary>
        [NameInMap("X-GW-Access")]
        [Validation(Required=false)]
        public string XGWAccess { get; set; }

        /// <summary>
        /// <para>握手必填，一次性随机串，原值参与业务签名；每次重新连接重新生成，不能重放原握手签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c093adf9-287a-4684-982a-1aea5a248c2e</para>
        /// </summary>
        [NameInMap("X-GW-Nonce")]
        [Validation(Required=false)]
        public string XGWNonce { get; set; }

        /// <summary>
        /// <para>可选，当前公开小驼峰字段协议应传 aliyun-roa；省略时采用兼容旧协议，其字段命名不同。握手时选择后作用于本连接，不能在后续帧中切换。本头不参与 X-GW 签名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-roa</para>
        /// </summary>
        [NameInMap("X-GW-Protocol")]
        [Validation(Required=false)]
        public string XGWProtocol { get; set; }

        /// <summary>
        /// <para>握手必填，64 位小写十六进制 HMAC-SHA256。签名原文为 GET、实际路径、规范化实际 query、空请求体的 SHA-256 小写摘要、时间戳和 nonce，以换行符连接。对原文 UTF-8 字节使用业务网关 SK 签名；阿里云 API 签名另行生成。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000000000000000000000000000000000000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("X-GW-Signature")]
        [Validation(Required=false)]
        public string XGWSignature { get; set; }

        /// <summary>
        /// <para>握手必填，当前 Unix 毫秒时间戳的数字字符串，原值参与业务签名；每次重新连接更新后重新签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794787200000</para>
        /// </summary>
        [NameInMap("X-GW-Timestamp")]
        [Validation(Required=false)]
        public string XGWTimestamp { get; set; }

        /// <summary>
        /// <para>可选连接级关联号。省略时生成服务端诊断号。显式提供时只允许一个 1–128 位的 [A-Za-z0-9._:-] 字符串，gw-ingress- 前缀保留给服务。格式非法或提供多个值时返回 HTTP 400。每轮业务请求号使用 run-task.communication.requestId。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-example-001</para>
        /// </summary>
        [NameInMap("X-Request-Id")]
        [Validation(Required=false)]
        public string XRequestId { get; set; }

    }

}
