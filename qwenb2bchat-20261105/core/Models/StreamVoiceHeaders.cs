// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class StreamVoiceHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>业务网关 Access Key ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-gateway-access</para>
        /// </summary>
        [NameInMap("X-GW-Access")]
        [Validation(Required=false)]
        public string XGWAccess { get; set; }

        /// <summary>
        /// <para>每次调用使用的随机串</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c093adf9-287a-4684-982a-1aea5a248c2e</para>
        /// </summary>
        [NameInMap("X-GW-Nonce")]
        [Validation(Required=false)]
        public string XGWNonce { get; set; }

        /// <summary>
        /// <para>小驼峰回源协议固定传 aliyun-roa，省略时为旧协议；不参与 HMAC 签名</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-roa</para>
        /// </summary>
        [NameInMap("X-GW-Protocol")]
        [Validation(Required=false)]
        public string XGWProtocol { get; set; }

        /// <summary>
        /// <para>按实际请求字节计算的 HMAC-SHA256 小写十六进制签名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000000000000000000000000000000000000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("X-GW-Signature")]
        [Validation(Required=false)]
        public string XGWSignature { get; set; }

        /// <summary>
        /// <para>当前 Unix 毫秒时间戳</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794787200000</para>
        /// </summary>
        [NameInMap("X-GW-Timestamp")]
        [Validation(Required=false)]
        public string XGWTimestamp { get; set; }

        /// <summary>
        /// <para>可选的 WebSocket 握手关联号，每轮业务 ID 使用 run-task 帧中的 communication.requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-example-001</para>
        /// </summary>
        [NameInMap("X-Request-Id")]
        [Validation(Required=false)]
        public string XRequestId { get; set; }

    }

}
