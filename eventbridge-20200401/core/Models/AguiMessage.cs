// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AguiMessage : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public AguiMessageMetadata Metadata { get; set; }
        public class AguiMessageMetadata : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public AguiMessageMetadataAttachments Attachments { get; set; }
            public class AguiMessageMetadataAttachments : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        [NameInMap("ToolCalls")]
        [Validation(Required=false)]
        public List<AguiMessageToolCalls> ToolCalls { get; set; }
        public class AguiMessageToolCalls : TeaModel {
            [NameInMap("Function")]
            [Validation(Required=false)]
            public AguiMessageToolCallsFunction Function { get; set; }
            public class AguiMessageToolCallsFunction : TeaModel {
                [NameInMap("Arguments")]
                [Validation(Required=false)]
                public string Arguments { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
