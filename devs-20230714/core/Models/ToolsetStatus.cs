// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ToolsetStatus : TeaModel {
        [NameInMap("observedGeneration")]
        [Validation(Required=false)]
        public long? ObservedGeneration { get; set; }

        [NameInMap("observedTime")]
        [Validation(Required=false)]
        public string ObservedTime { get; set; }

        [NameInMap("outputs")]
        [Validation(Required=false)]
        public ToolsetStatusOutputs Outputs { get; set; }
        public class ToolsetStatusOutputs : TeaModel {
            [NameInMap("functionArn")]
            [Validation(Required=false)]
            public string FunctionArn { get; set; }

            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public ToolsetStatusOutputsMcpServerConfig McpServerConfig { get; set; }
            public class ToolsetStatusOutputsMcpServerConfig : TeaModel {
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("transportType")]
                [Validation(Required=false)]
                public string TransportType { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("openApiTools")]
            [Validation(Required=false)]
            public List<OpenAPIToolMeta> OpenApiTools { get; set; }

            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<MCPToolMeta> Tools { get; set; }

            [NameInMap("urls")]
            [Validation(Required=false)]
            public ToolsetStatusOutputsUrls Urls { get; set; }
            public class ToolsetStatusOutputsUrls : TeaModel {
                [NameInMap("internetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                [NameInMap("intranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Installed</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

    }

}
