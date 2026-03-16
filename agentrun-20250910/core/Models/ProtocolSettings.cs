// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ProtocolSettings : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("A2AAgentCard")]
        [Validation(Required=false)]
        [Obsolete]
        public string A2AAgentCard { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("a2aAgentCard")]
        [Validation(Required=false)]
        [Obsolete]
        public string A2aAgentCard { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("a2aAgentCardUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string A2aAgentCardUrl { get; set; }

        /// <summary>
        /// <para>协议配置的 JSON 字符串</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>请求头</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        [Obsolete]
        public string Headers { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>请求体JSON模式</para>
        /// </summary>
        [NameInMap("inputBodyJsonSchema")]
        [Validation(Required=false)]
        [Obsolete]
        public string InputBodyJsonSchema { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>HTTP方法</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        [Obsolete]
        public string Method { get; set; }

        /// <summary>
        /// <para>可选展示名/别名，不再作为协议类型标识</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>响应体JSON模式</para>
        /// </summary>
        [NameInMap("outputBodyJsonSchema")]
        [Validation(Required=false)]
        [Obsolete]
        public string OutputBodyJsonSchema { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>协议路径</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        [Obsolete]
        public string Path { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>协议路径前缀，建议使用 config</para>
        /// </summary>
        [NameInMap("pathPrefix")]
        [Validation(Required=false)]
        [Obsolete]
        public string PathPrefix { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>请求内容类型</para>
        /// </summary>
        [NameInMap("requestContentType")]
        [Validation(Required=false)]
        [Obsolete]
        public string RequestContentType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>响应内容类型</para>
        /// </summary>
        [NameInMap("responseContentType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResponseContentType { get; set; }

        /// <summary>
        /// <para>协议类型标识，用于校验与去重；合法取值由后端校验</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
