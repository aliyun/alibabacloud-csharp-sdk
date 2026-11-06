// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentVersionRequest : TeaModel {
        /// <summary>
        /// <para>保存版本的请求体。</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentVersionRequestBody Body { get; set; }
        public class CreateAgentVersionRequestBody : TeaModel {
            /// <summary>
            /// <para>版本描述，最多 1024 个字符，保存后不可修改。</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产环境稳定版本</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>用户自定义的展示名称，去除首尾空白后为 1 至 128 个字符，可包含中文、大小写字母、空格和标点，不能包含控制字符。同一 Agent 下未删除的版本名称唯一，区分大小写，保存后不可修改。版本号 agentVersion 由系统生成，不由此字段决定。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产稳定版 V1.0</para>
            /// </summary>
            [NameInMap("versionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

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
