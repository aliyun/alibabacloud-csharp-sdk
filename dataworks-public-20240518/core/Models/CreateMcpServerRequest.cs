// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateMcpServerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public CreateMcpServerRequestConfig Config { get; set; }
        public class CreateMcpServerRequestConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomHeaders { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SSE</para>
            /// </summary>
            [NameInMap("Transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-server</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateMcpServerRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateMcpServerRequestVisibilityScope : TeaModel {
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
