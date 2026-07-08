// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDeepWritingResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDeepWritingResponseBodyHeader Header { get; set; }
        public class RunDeepWritingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误消息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The Server-Sent Event (SSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>response.output_item.done</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2e2e991-f96a-4fcc-9ff7-d0df46c6d232</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b84d31a5-44b2-4a35-9c6d-878d459c93d0</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAB10D42-F081-557B-8DCB-D6FB7AAF100B</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunDeepWritingResponseBodyPayload Payload { get; set; }
        public class RunDeepWritingResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDeepWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunDeepWritingResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The new output item for this event.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public RunDeepWritingResponseBodyPayloadOutputItem Item { get; set; }
                public class RunDeepWritingResponseBodyPayloadOutputItem : TeaModel {
                    /// <summary>
                    /// <para>The name of the agent that generated this item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ProjectManager</para>
                    /// </summary>
                    [NameInMap("Agent")]
                    [Validation(Required=false)]
                    public string Agent { get; set; }

                    /// <summary>
                    /// <para>Parameter</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>item类型为function_call时，此字段有值，为调用函数的入参</para>
                    /// </summary>
                    [NameInMap("Arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    /// <summary>
                    /// <para>This field has a value when the item type is \<c>message\\</c>. The value is a list of output content.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public List<RunDeepWritingResponseBodyPayloadOutputItemContent> Content { get; set; }
                    public class RunDeepWritingResponseBodyPayloadOutputItemContent : TeaModel {
                        /// <summary>
                        /// <para>The text content that is output when the item type is \<c>message\\</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <TASK_DONE>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>When the item type is \<c>message\\</c>, the value of this field is \<c>output_text\\</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>output_text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The unique ID of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>88f6ed9e85c4f9377378da23e6a370d1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>item类型为function_call时，此字段有值，为调用的函数名字</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The item\&quot;s result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>item类型为function_call时，此字段有值，为调用的函数的输出</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>The status of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>completed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The type of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>function_call</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ordinal number of the new output item in this event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputIndex")]
                [Validation(Required=false)]
                public int? OutputIndex { get; set; }

                /// <summary>
                /// <para>The response body.</para>
                /// </summary>
                [NameInMap("Response")]
                [Validation(Required=false)]
                public RunDeepWritingResponseBodyPayloadOutputResponse Response { get; set; }
                public class RunDeepWritingResponseBodyPayloadOutputResponse : TeaModel {
                    /// <summary>
                    /// <para>The unique ID of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b2dc224b38694e0b668020159a7c5732</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The execution status of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>in_progress</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ordinal number of the streaming event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SequenceNumber")]
                [Validation(Required=false)]
                public string SequenceNumber { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同上级Event</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31AC01F1-88FB-5C4D-B6F5-E8BB136CD5A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
