// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateConsumerAPIKeyInput : TeaModel {
        /// <summary>
        /// <para>用户自定义的完整API密钥；为空时由服务自动生成</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>消费者API密钥的描述信息，用于说明该密钥的用途</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于生产环境的API密钥</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>关联的模型连接标识符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

    }

}
