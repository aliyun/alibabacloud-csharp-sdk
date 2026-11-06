// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>保存版本的请求体。</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>客户端生成的幂等令牌，当前为预留参数，后端暂不提供持久化幂等保证。</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2d8a6f0-3b1e-4a7d-9f25-6e4b0c1a8d37</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
