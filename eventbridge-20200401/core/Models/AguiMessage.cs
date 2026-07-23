// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AguiMessage : TeaModel {
        /// <summary>
        /// <para>The text content of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>根据您的问题，我将查询过去7天的事件量...</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The unique identifier of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_123456_a1b2c3d4</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The extension metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public AguiMessageMetadata Metadata { get; set; }
        public class AguiMessageMetadata : TeaModel {
            /// <summary>
            /// <para>The extension data.</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public AguiMessageMetadataAttachments Attachments { get; set; }
            public class AguiMessageMetadataAttachments : TeaModel {
                /// <summary>
                /// <para>The name of the extension data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-xxx/table/order</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the extension data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inner-resource/event-table</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Reasoning")]
        [Validation(Required=false)]
        public string Reasoning { get; set; }

        /// <summary>
        /// <para>The role of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The associated tool invocation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call_xxx</para>
        /// </summary>
        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <para>The tool invocation list.</para>
        /// </summary>
        [NameInMap("ToolCalls")]
        [Validation(Required=false)]
        public List<AguiMessageToolCalls> ToolCalls { get; set; }
        public class AguiMessageToolCalls : TeaModel {
            /// <summary>
            /// <para>The tool calling function.</para>
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public AguiMessageToolCallsFunction Function { get; set; }
            public class AguiMessageToolCallsFunction : TeaModel {
                /// <summary>
                /// <para>The arguments of the tool calling function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Arguments")]
                [Validation(Required=false)]
                public string Arguments { get; set; }

                /// <summary>
                /// <para>The name of the tool calling function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>discoverMetadata</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The tool calling ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The tool calling type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
