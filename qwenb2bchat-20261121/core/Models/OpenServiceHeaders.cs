// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class OpenServiceHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>必填的业务网关 AK，由服务接入方签发，用于识别租户和凭据；与阿里云 API 鉴权凭据用途不同，不发送业务网关 SK。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-gateway-access</para>
        /// </summary>
        [NameInMap("X-GW-Access")]
        [Validation(Required=false)]
        public string XGWAccess { get; set; }

        /// <summary>
        /// <para>必填的一次性随机串，原值参与业务网关签名；每次请求和重试重新生成，不能重放原签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c093adf9-287a-4684-982a-1aea5a248c2e</para>
        /// </summary>
        [NameInMap("X-GW-Nonce")]
        [Validation(Required=false)]
        public string XGWNonce { get; set; }

        /// <summary>
        /// <para>必填的业务网关 HMAC-SHA256 签名，64 位小写十六进制。签名原文为方法、路径、空查询串、实际请求体字节的 SHA-256 小写摘要、时间戳、nonce 六段，以换行符连接。签名后不得改变请求体字节；阿里云 API 签名另行生成。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000000000000000000000000000000000000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("X-GW-Signature")]
        [Validation(Required=false)]
        public string XGWSignature { get; set; }

        /// <summary>
        /// <para>必填的当前 Unix 毫秒时间戳，用数字字符串表示，原值参与业务网关签名；重试时更新并重新签名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794787200000</para>
        /// </summary>
        [NameInMap("X-GW-Timestamp")]
        [Validation(Required=false)]
        public string XGWTimestamp { get; set; }

        /// <summary>
        /// <para>必填的客户请求关联号，恰好一个，匹配 [A-Za-z0-9._:-]{1,128}；不能使用 gw-ingress- 保留前缀。仅用于关联本次调用，不是订单号或幂等令牌。</para>
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
