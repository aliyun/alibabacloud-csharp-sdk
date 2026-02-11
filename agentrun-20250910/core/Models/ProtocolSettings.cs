// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ProtocolSettings : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>A2A Agent Card</para>
        /// </summary>
        [NameInMap("A2AAgentCard")]
        [Validation(Required=false)]
        [Obsolete]
        public string A2AAgentCard { get; set; }

        [NameInMap("a2aAgentCard")]
        [Validation(Required=false)]
        public string A2aAgentCard { get; set; }

        [NameInMap("a2aAgentCardUrl")]
        [Validation(Required=false)]
        public string A2aAgentCardUrl { get; set; }

        /// <summary>
        /// <para>请求头</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>请求体JSON模式</para>
        /// </summary>
        [NameInMap("inputBodyJsonSchema")]
        [Validation(Required=false)]
        public string InputBodyJsonSchema { get; set; }

        /// <summary>
        /// <para>HTTP方法</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>协议名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>响应体JSON模式</para>
        /// </summary>
        [NameInMap("outputBodyJsonSchema")]
        [Validation(Required=false)]
        public string OutputBodyJsonSchema { get; set; }

        /// <summary>
        /// <para>协议路径</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>协议路径前缀</para>
        /// </summary>
        [NameInMap("pathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>请求内容类型</para>
        /// </summary>
        [NameInMap("requestContentType")]
        [Validation(Required=false)]
        public string RequestContentType { get; set; }

        /// <summary>
        /// <para>响应内容类型</para>
        /// </summary>
        [NameInMap("responseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

    }

}
