// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealTimeDialogResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of generated content. It can contain one or more choice objects.</para>
        /// </summary>
        [NameInMap("choices")]
        [Validation(Required=false)]
        public List<RealTimeDialogResponseBodyChoices> Choices { get; set; }
        public class RealTimeDialogResponseBodyChoices : TeaModel {
            /// <summary>
            /// <para>The incremental result returned for streaming responses. This is empty for non-streaming responses.</para>
            /// </summary>
            [NameInMap("delta")]
            [Validation(Required=false)]
            public RealTimeDialogResponseBodyChoicesDelta Delta { get; set; }
            public class RealTimeDialogResponseBodyChoicesDelta : TeaModel {
                /// <summary>
                /// <para>The analysis process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("analysisProcess")]
                [Validation(Required=false)]
                public string AnalysisProcess { get; set; }

                /// <summary>
                /// <para>The time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("callTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <para>Hangs up the dialog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hangUpDialog")]
                [Validation(Required=false)]
                public bool? HangUpDialog { get; set; }

                /// <summary>
                /// <para>The intent code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1853360771162058752</para>
                /// </summary>
                [NameInMap("intentionCode")]
                [Validation(Required=false)]
                public string IntentionCode { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>其他</para>
                /// </summary>
                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                /// <summary>
                /// <para>The intent script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>抱歉，我没有明白您的意思，或者您可以拨打我们的客服热线，请客服人员为您解答。</para>
                /// </summary>
                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

                /// <summary>
                /// <para>Specifies whether the conversation was interrupted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("interrupt")]
                [Validation(Required=false)]
                public bool? Interrupt { get; set; }

                /// <summary>
                /// <para>The recommended intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendIntention")]
                [Validation(Required=false)]
                public string RecommendIntention { get; set; }

                /// <summary>
                /// <para>The recommended script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendScript")]
                [Validation(Required=false)]
                public string RecommendScript { get; set; }

                /// <summary>
                /// <para>The script for the Q\&amp;A pair. This is incremental data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>话题</para>
                /// </summary>
                [NameInMap("selfDirectedScript")]
                [Validation(Required=false)]
                public string SelfDirectedScript { get; set; }

                /// <summary>
                /// <para>The script for the Q\&amp;A pair. This is the full data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>关于宇宙的大小，这是一个非常深奥的科学话题</para>
                /// </summary>
                [NameInMap("selfDirectedScriptFullContent")]
                [Validation(Required=false)]
                public string SelfDirectedScriptFullContent { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip the current recognition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipCurrentRecognize")]
                [Validation(Required=false)]
                public bool? SkipCurrentRecognize { get; set; }

            }

            /// <summary>
            /// <para>The value is \<c>stop\\</c> if the session ends. The value is \<c>null\\</c> if the session is in progress. If \<c>success\\</c> is \<c>false\\</c>, this parameter returns an error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("finishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>The sequence number in the choices list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The full result returned for non-streaming responses. This is empty for streaming responses.</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public RealTimeDialogResponseBodyChoicesMessage Message { get; set; }
            public class RealTimeDialogResponseBodyChoicesMessage : TeaModel {
                /// <summary>
                /// <para>The analysis process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("analysisProcess")]
                [Validation(Required=false)]
                public string AnalysisProcess { get; set; }

                /// <summary>
                /// <para>The time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735139569523</para>
                /// </summary>
                [NameInMap("callTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <para>Hang up the dialog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hangUpDialog")]
                [Validation(Required=false)]
                public bool? HangUpDialog { get; set; }

                /// <summary>
                /// <para>The intent code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1853360771162058752</para>
                /// </summary>
                [NameInMap("intentionCode")]
                [Validation(Required=false)]
                public string IntentionCode { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>其它</para>
                /// </summary>
                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                /// <summary>
                /// <para>The intent script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>抱歉，我没有明白您的意思，或者您可以拨打我们的客服热线，请客服人员为您解答。</para>
                /// </summary>
                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

                /// <summary>
                /// <para>Specifies whether the conversation was interrupted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("interrupt")]
                [Validation(Required=false)]
                public bool? Interrupt { get; set; }

                /// <summary>
                /// <para>The recommended intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendIntention")]
                [Validation(Required=false)]
                public string RecommendIntention { get; set; }

                /// <summary>
                /// <para>The recommended script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendScript")]
                [Validation(Required=false)]
                public string RecommendScript { get; set; }

                /// <summary>
                /// <para>The script for the Q\&amp;A pair. This is incremental data. This is empty for streaming responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("selfDirectedScript")]
                [Validation(Required=false)]
                public string SelfDirectedScript { get; set; }

                /// <summary>
                /// <para>The script for the Q\&amp;A pair. This is the full data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>关于宇宙的大小，这是一个非常深奥的科学话题</para>
                /// </summary>
                [NameInMap("selfDirectedScriptFullContent")]
                [Validation(Required=false)]
                public string SelfDirectedScriptFullContent { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip the current recognition.</para>
                /// </summary>
                [NameInMap("skipCurrentRecognize")]
                [Validation(Required=false)]
                public bool? SkipCurrentRecognize { get; set; }

            }

        }

        /// <summary>
        /// <para>The timestamp when this request was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735139569523</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The unique identifier for this call. Each chunk object has the same ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb2b6139-ddf1-91a0-a47f-df7617ae9032</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E3FBAF1-17AF-53B7-AF0A-CDCEEB6DE658</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
