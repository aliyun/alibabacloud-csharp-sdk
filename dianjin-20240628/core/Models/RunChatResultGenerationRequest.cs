// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunChatResultGenerationRequest : TeaModel {
        [NameInMap("inferenceParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceParameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestMessages> Messages { get; set; }
        public class RunChatResultGenerationRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationRequestTools> Tools { get; set; }
        public class RunChatResultGenerationRequestTools : TeaModel {
            [NameInMap("function")]
            [Validation(Required=false)]
            public RunChatResultGenerationRequestToolsFunction Function { get; set; }
            public class RunChatResultGenerationRequestToolsFunction : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public RunChatResultGenerationRequestToolsFunctionParameters Parameters { get; set; }
                public class RunChatResultGenerationRequestToolsFunctionParameters : TeaModel {
                    [NameInMap("properties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Properties { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("required")]
                [Validation(Required=false)]
                public List<string> Required { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
