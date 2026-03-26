// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BoundTool : TeaModel {
        /// <summary>
        /// <para>绑定的 HTTP 请求方法，支持：GET、PUT、POST、PATCH、DELETE、OPTIONS</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>绑定的 URL 路径，用于路由匹配</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/v1/tools</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>要绑定的工具名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-tool</para>
        /// </summary>
        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

    }

}
