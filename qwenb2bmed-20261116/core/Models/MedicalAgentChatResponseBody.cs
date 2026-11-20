// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261116.Models
{
    public class MedicalAgentChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The optional list of audio frames in the response. This list can be empty or omitted when no audio is present.</para>
        /// </summary>
        [NameInMap("audioFrames")]
        [Validation(Required=false)]
        public List<MedicalAgentChatResponseBodyAudioFrames> AudioFrames { get; set; }
        public class MedicalAgentChatResponseBodyAudioFrames : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOWNSTREAM_ERROR</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The encoded audio data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAEC</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the last audio frame.</para>
            /// </summary>
            [NameInMap("last")]
            [Validation(Required=false)]
            public bool? Last { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Audio generation failed</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The business request correlation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The audio or error frame type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The information used to correlate response frames with the original business request and session.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public MedicalAgentChatResponseBodyCommunication Communication { get; set; }
        public class MedicalAgentChatResponseBodyCommunication : TeaModel {
            /// <summary>
            /// <para>The business request ID, which is identical to the original request ID when present.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The business response frame ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("responseId")]
            [Validation(Required=false)]
            public long? ResponseId { get; set; }

            /// <summary>
            /// <para>The customer session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-session-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The business data returned in this response, including messages and optional extended information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MedicalAgentChatResponseBodyData Data { get; set; }
        public class MedicalAgentChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The optional debug information included in the business response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("debug")]
            [Validation(Required=false)]
            public object Debug { get; set; }

            /// <summary>
            /// <para>The business extended information, which may include inputResources.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public MedicalAgentChatResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class MedicalAgentChatResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <para>The transfer results of the input resources for this round.</para>
                /// </summary>
                [NameInMap("inputResources")]
                [Validation(Required=false)]
                public List<MedicalAgentChatResponseBodyDataExtraInfoInputResources> InputResources { get; set; }
                public class MedicalAgentChatResponseBodyDataExtraInfoInputResources : TeaModel {
                    /// <summary>
                    /// <para>The index of the original content block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("contentIndex")]
                    [Validation(Required=false)]
                    public int? ContentIndex { get; set; }

                    /// <summary>
                    /// <para>The resource file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>report.png</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The ID of the transferred resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ws_123</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The input resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The URL of the transferred resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/report.png">https://example.com/report.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of messages returned in this business response or the current streaming response frame.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<MedicalAgentChatResponseBodyDataMessages> Messages { get; set; }
            public class MedicalAgentChatResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>The text or content corresponding to the message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hemoglobin carries oxygen. Refer to the reference ranges on the report for interpretation</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>The extended metadata associated with this message.</para>
                /// </summary>
                [NameInMap("metaData")]
                [Validation(Required=false)]
                public MedicalAgentChatResponseBodyDataMessagesMetaData MetaData { get; set; }
                public class MedicalAgentChatResponseBodyDataMessagesMetaData : TeaModel {
                    /// <summary>
                    /// <para>The status bar title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Analyzing the issue</para>
                    /// </summary>
                    [NameInMap("barTitle")]
                    [Validation(Required=false)]
                    public string BarTitle { get; set; }

                    /// <summary>
                    /// <para>The metadata content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;body&quot;:&quot;Analyzing the user\&quot;s issue.&quot;,&quot;status&quot;:&quot;processing&quot;}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public object Content { get; set; }

                    /// <summary>
                    /// <para>The list of structured content associated with the body, such as image-text cards, returned by message type.</para>
                    /// </summary>
                    [NameInMap("multiLoad")]
                    [Validation(Required=false)]
                    public List<MedicalAgentChatResponseBodyDataMessagesMetaDataMultiLoad> MultiLoad { get; set; }
                    public class MedicalAgentChatResponseBodyDataMessagesMetaDataMultiLoad : TeaModel {
                        /// <summary>
                        /// <para>The card content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;list&quot;:[{&quot;image_url&quot;:&quot;<a href="https://example.com/image.jpg%22,%22image_width%22:%22800%22,%22image_height%22:%22600%22%7D%5D%7D">https://example.com/image.jpg&quot;,&quot;image_width&quot;:&quot;800&quot;,&quot;image_height&quot;:&quot;600&quot;}]}</a></para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public object Content { get; set; }

                        /// <summary>
                        /// <para>The card reference identifier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall_1</para>
                        /// </summary>
                        [NameInMap("sourceSeq")]
                        [Validation(Required=false)]
                        public string SourceSeq { get; set; }

                        /// <summary>
                        /// <para>The card type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The source identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bar_thinking_1</para>
                    /// </summary>
                    [NameInMap("sourceSeq")]
                    [Validation(Required=false)]
                    public string SourceSeq { get; set; }

                    /// <summary>
                    /// <para>The metadata type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bar_thinking</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>multi_load/iframe</para>
                /// </summary>
                [NameInMap("mimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The business message status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>complete</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The error details returned when a business call fails.</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public MedicalAgentChatResponseBodyError Error { get; set; }
        public class MedicalAgentChatResponseBodyError : TeaModel {
            /// <summary>
            /// <para>The business error code used by the client to identify the failure type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_REQUEST</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public object Code { get; set; }

            /// <summary>
            /// <para>The descriptive text for the business error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid request parameters</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The business request correlation ID for the failed call, used to troubleshoot the issue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public object ErrorCode { get; set; }

        /// <summary>
        /// <para>The business status description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The optional business request correlation ID. For the POP request ID, see x-acs-request-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>med-req-001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
