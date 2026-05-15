// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelConnectionProviderSettings : TeaModel {
        /// <summary>
        /// <para>模型提供商的默认API基础地址</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://api.openai.com/v1">https://api.openai.com/v1</a></para>
        /// </summary>
        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>该连接支持的模型名称列表</para>
        /// </summary>
        [NameInMap("modelNames")]
        [Validation(Required=false)]
        public List<string> ModelNames { get; set; }

    }

}
