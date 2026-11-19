// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The optional list of audio frames in the response. This list can be empty or omitted when no audio is present.</para>
        /// </summary>
        [NameInMap("audioFrames")]
        [Validation(Required=false)]
        public List<ChatResponseBodyAudioFrames> AudioFrames { get; set; }
        public class ChatResponseBodyAudioFrames : TeaModel {
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
            /// <para>SUQz</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>Indicates whether the frame is the last audio frame.</para>
            /// </summary>
            [NameInMap("last")]
            [Validation(Required=false)]
            public bool? Last { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Speech synthesis is currently unavailable</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The business request correlation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The type of the audio or error frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The information used to associate the response frame with the original business request and session.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public ChatResponseBodyCommunication Communication { get; set; }
        public class ChatResponseBodyCommunication : TeaModel {
            /// <summary>
            /// <para>The business request ID, if present.</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The identifier of the business response frame.</para>
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
            /// <para>session-example-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The business data returned in the response, including messages and optional extended information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ChatResponseBodyData Data { get; set; }
        public class ChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The optional debug information included in the business response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;intentLabel&quot;:&quot;image_search&quot;}</para>
            /// </summary>
            [NameInMap("debug")]
            [Validation(Required=false)]
            public object Debug { get; set; }

            /// <summary>
            /// <para>The business extended information, which may include inputResources.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public ChatResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class ChatResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <para>The transfer and storage results of the input resources for the current round.</para>
                /// </summary>
                [NameInMap("inputResources")]
                [Validation(Required=false)]
                public List<ChatResponseBodyDataExtraInfoInputResources> InputResources { get; set; }
                public class ChatResponseBodyDataExtraInfoInputResources : TeaModel {
                    /// <summary>
                    /// <para>The position of the original content block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("contentIndex")]
                    [Validation(Required=false)]
                    public int? ContentIndex { get; set; }

                    /// <summary>
                    /// <para>The file name of the transferred and stored resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cat.png</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The ID of the transferred and stored resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ws_example_001</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The type of the transferred and stored resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The URL of the transferred and stored resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://cdn.example.com/uploads/cat.png">https://cdn.example.com/uploads/cat.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of messages returned in the business response or the current streaming response frame.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<ChatResponseBodyDataMessages> Messages { get; set; }
            public class ChatResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>The text or content of the corresponding message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image as follows [(image_waterfall_1)]</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>The extended metadata associated with the message.</para>
                /// </summary>
                [NameInMap("metaData")]
                [Validation(Required=false)]
                public ChatResponseBodyDataMessagesMetaData MetaData { get; set; }
                public class ChatResponseBodyDataMessagesMetaData : TeaModel {
                    /// <summary>
                    /// <para>The display title of the process module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Issue analysis</para>
                    /// </summary>
                    [NameInMap("barTitle")]
                    [Validation(Required=false)]
                    public string BarTitle { get; set; }

                    /// <summary>
                    /// <para>The complete content snapshot of the process module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;body&quot;:&quot;Analyzing the issue&quot;,&quot;status&quot;:&quot;processing&quot;}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public object Content { get; set; }

                    /// <summary>
                    /// <para>The list of structured content associated with the body, such as image-text cards, returned by message type.</para>
                    /// </summary>
                    [NameInMap("multiLoad")]
                    [Validation(Required=false)]
                    public List<ChatResponseBodyDataMessagesMetaDataMultiLoad> MultiLoad { get; set; }
                    public class ChatResponseBodyDataMessagesMetaDataMultiLoad : TeaModel {
                        /// <summary>
                        /// <para>The card content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;list&quot;:[{&quot;imageUrl&quot;:&quot;<a href="https://images.example.com/cat.png%22%7D%5D%7D">https://images.example.com/cat.png&quot;}]}</a></para>
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
                    /// <para>The process module identifier within the current request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>thinking-1</para>
                    /// </summary>
                    [NameInMap("sourceSeq")]
                    [Validation(Required=false)]
                    public string SourceSeq { get; set; }

                    /// <summary>
                    /// <para>The process module type.</para>
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
        public ChatResponseBodyError Error { get; set; }
        public class ChatResponseBodyError : TeaModel {
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
            /// <para>The descriptive text of the business error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid request parameters</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The business request correlation ID of the failed call, used for troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
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
        /// <para>req-example-001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
