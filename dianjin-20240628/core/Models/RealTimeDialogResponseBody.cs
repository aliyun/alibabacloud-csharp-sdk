// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealTimeDialogResponseBody : TeaModel {
        [NameInMap("choices")]
        [Validation(Required=false)]
        public List<RealTimeDialogResponseBodyChoices> Choices { get; set; }
        public class RealTimeDialogResponseBodyChoices : TeaModel {
            [NameInMap("delta")]
            [Validation(Required=false)]
            public RealTimeDialogResponseBodyChoicesDelta Delta { get; set; }
            public class RealTimeDialogResponseBodyChoicesDelta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("analysisProcess")]
                [Validation(Required=false)]
                public string AnalysisProcess { get; set; }

                /// <summary>
                /// <para>time</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("callTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hangUpDialog")]
                [Validation(Required=false)]
                public bool? HangUpDialog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1853360771162058752</para>
                /// </summary>
                [NameInMap("intentionCode")]
                [Validation(Required=false)]
                public string IntentionCode { get; set; }

                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

                [NameInMap("interrupt")]
                [Validation(Required=false)]
                public bool? Interrupt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendIntention")]
                [Validation(Required=false)]
                public string RecommendIntention { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendScript")]
                [Validation(Required=false)]
                public string RecommendScript { get; set; }

                [NameInMap("selfDirectedScript")]
                [Validation(Required=false)]
                public string SelfDirectedScript { get; set; }

                [NameInMap("selfDirectedScriptFullContent")]
                [Validation(Required=false)]
                public string SelfDirectedScriptFullContent { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("finishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public RealTimeDialogResponseBodyChoicesMessage Message { get; set; }
            public class RealTimeDialogResponseBodyChoicesMessage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("analysisProcess")]
                [Validation(Required=false)]
                public string AnalysisProcess { get; set; }

                /// <summary>
                /// <para>time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735139569523</para>
                /// </summary>
                [NameInMap("callTime")]
                [Validation(Required=false)]
                public string CallTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hangUpDialog")]
                [Validation(Required=false)]
                public bool? HangUpDialog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1853360771162058752</para>
                /// </summary>
                [NameInMap("intentionCode")]
                [Validation(Required=false)]
                public string IntentionCode { get; set; }

                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

                [NameInMap("interrupt")]
                [Validation(Required=false)]
                public bool? Interrupt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendIntention")]
                [Validation(Required=false)]
                public string RecommendIntention { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("recommendScript")]
                [Validation(Required=false)]
                public string RecommendScript { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("selfDirectedScript")]
                [Validation(Required=false)]
                public string SelfDirectedScript { get; set; }

                [NameInMap("selfDirectedScriptFullContent")]
                [Validation(Required=false)]
                public string SelfDirectedScriptFullContent { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735139569523</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eb2b6139-ddf1-91a0-a47f-df7617ae9032</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5E3FBAF1-17AF-53B7-AF0A-CDCEEB6DE658</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
