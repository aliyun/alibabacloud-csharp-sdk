// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDeepWritingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDeepWritingResponseBodyHeader Header { get; set; }
        public class RunDeepWritingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>response.output_item.done</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c2e2e991-f96a-4fcc-9ff7-d0df46c6d232</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b84d31a5-44b2-4a35-9c6d-878d459c93d0</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FAB10D42-F081-557B-8DCB-D6FB7AAF100B</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunDeepWritingResponseBodyPayload Payload { get; set; }
        public class RunDeepWritingResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDeepWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunDeepWritingResponseBodyPayloadOutput : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public RunDeepWritingResponseBodyPayloadOutputItem Item { get; set; }
                public class RunDeepWritingResponseBodyPayloadOutputItem : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ProjectManager</para>
                    /// </summary>
                    [NameInMap("Agent")]
                    [Validation(Required=false)]
                    public string Agent { get; set; }

                    [NameInMap("Arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public List<RunDeepWritingResponseBodyPayloadOutputItemContent> Content { get; set; }
                    public class RunDeepWritingResponseBodyPayloadOutputItemContent : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <TASK_DONE>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>output_text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>88f6ed9e85c4f9377378da23e6a370d1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>completed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>function_call</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputIndex")]
                [Validation(Required=false)]
                public int? OutputIndex { get; set; }

                [NameInMap("Response")]
                [Validation(Required=false)]
                public RunDeepWritingResponseBodyPayloadOutputResponse Response { get; set; }
                public class RunDeepWritingResponseBodyPayloadOutputResponse : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>b2dc224b38694e0b668020159a7c5732</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>in_progress</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SequenceNumber")]
                [Validation(Required=false)]
                public string SequenceNumber { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31AC01F1-88FB-5C4D-B6F5-E8BB136CD5A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
