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

        /// <summary>
        /// <b>Example:</b>
        /// <para>msg_123456_a1b2c3d4</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-xxx/table/order</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inner-resource/event-table</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>call_xxx</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Arguments")]
                [Validation(Required=false)]
                public string Arguments { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>discoverMetadata</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>call_xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
